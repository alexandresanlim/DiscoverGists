﻿using DiscoverGists.DataBase;
using DiscoverGists.Extentions;
using DiscoverGists.Models;
using DiscoverGists.Services;
using DiscoverGists.Services.Interfaces;
using DiscoverGists.Views;
using Newtonsoft.Json;
using Prism.Commands;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace DiscoverGists.ViewModels
{
    public class MainPageViewModel : ViewModelBase
    {
        private IGitHubService _gitHubService { get; }

        public MainPageViewModel(INavigationService navigationService, IGitHubService gitHubService)
            : base(navigationService)
        {
            _gitHubService = gitHubService;
        }

        public override async void OnNavigatedTo(INavigationParameters parameters)
        {
            if (parameters.GetNavigationMode() == NavigationMode.Back)
                return;

            try
            {
                SetIsLoading(true);

                await Task.Delay(1000);

                LoadDataCommand.Execute(null);
            }
            catch (Exception e)
            {
                ShowDefaultErrorMsg();
            }
            finally
            {
                SetIsLoading(false);
            }
        }

        public ICommand LoadDataCommand => new DelegateCommand(async () =>
        {
            await LoadData();
        });

        private async Task LoadData()
        {
            try
            {
                IsBusy = true;

                await GetGistListFromService();
            }
            catch (Exception e)
            {
                ShowDefaultErrorMsg();
            }
            finally
            {
                IsBusy = false;
            }
        }

        private async Task GetGistListFromService()
        {
            var gistList = await _gitHubService.GetGistList(LastPage);

            var languageColors = LanguageColors.GetList();

            foreach (var item in gistList)
            {
                item.FirstFile.ColorFromLanguage = languageColors?.FirstOrDefault(x => x.Language?.ToLower() == item?.FirstFile?.Language?.ToLower())?.Color ?? "#2980b9";
            }

            if (LastPage == 1)
                GistList = gistList.ToObservableCollection();

            else
            {
                foreach (var item in gistList)
                {
                    GistList.Add(item);
                }
            }
        }

        public ICommand LoadMoreCommand => new DelegateCommand(async () =>
        {
            try
            {
                if (IsLoad)
                    return;

                IsLoad = true;

                LastPage += 1;

                await GetGistListFromService();
            }
            catch (Exception e)
            {
                ShowDefaultErrorMsg();
            }
            finally
            {
                IsLoad = false;
            }
        });

        public ICommand NavigateToFavoriteCommand => new DelegateCommand(async () =>
        {
            await NavigationService.NavigateAsync(nameof(FavoritePage));
        });

        public ICommand SettingsCommand => new Command(async () =>
        {
            var preferences = new List<Acr.UserDialogs.ActionSheetOption>
            {
                new Acr.UserDialogs.ActionSheetOption(PreferenceService.Theme == "light" ? "Dark Mode" : "Light Mode", () =>
                {
                    PreferenceService.Theme = PreferenceService.Theme == "light" ? "dark" : "light";
                    App.SetThemeColorsByPreference();
                })
            };

            DialogService.ActionSheet(new Acr.UserDialogs.ActionSheetConfig
            {
                Title = "Preferências",
                Options = preferences,
                Cancel = new Acr.UserDialogs.ActionSheetOption("Cancelar", () =>
                {
                    return;
                })
            });
        });

        public DelegateCommand<Gist> NavigateToDetailCommand => new DelegateCommand<Gist>(async (gist) =>
        {
            var navigationParams = new NavigationParameters
            {
                { "gist", gist }
            };

            await NavigationService.NavigateAsync(nameof(DetailPage), navigationParams);
        });

        public DelegateCommand<Gist> AddFavoriteCommand => new DelegateCommand<Gist>((gist) =>
        {
            GistDataBase.UpInsert(gist);

            DialogService.Toast("Adicionado aos favoritos com sucesso!");
        });

        private ObservableCollection<Gist> _gistList;
        public ObservableCollection<Gist> GistList
        {
            set => SetProperty(ref _gistList, value);
            get => _gistList;
        }

        private bool _isLoad;
        public bool IsLoad
        {
            set => SetProperty(ref _isLoad, value);
            get => _isLoad;
        }

        public int LastPage { get; set; } = 1;
    }
}
