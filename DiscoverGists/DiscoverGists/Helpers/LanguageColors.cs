﻿using Newtonsoft.Json;
using System.Collections.Generic;

public class LanguageColors
{
    [JsonProperty("language")]
    public string Language { get; set; }

    [JsonProperty("color")]
    public string Color { get; set; }

    public static List<LanguageColors> GetList()
    {
        var json =
            @"[
              {language: 'Mercury', color: '#ff2b2b'},
              {language:'TypeScript', color: '#2b7489'},
              {language:'PureBasic', color: '#5a6986'},
              {language:'Objective-C++', color:'#6866fb'},
              {language:'Self', color: '#0579aa'},
              {language:'edn', color: '#db5855'},
              {language:'NewLisp', color: '#87AED7'},
              {language:'Jupyter Notebook', color: '#DA5B0B'},
              {language:'Rebol', color: '#358a5b'},
              {language:'Frege', color: '#00cafe'},
              {language:'Dart', color: '#00B4AB'},
              {language:'AspectJ', color: '#a957b0'},
              {language:'Shell', color: '#89e051'},
              {language:'Web Ontology language', color: '#9cc9dd'},
              {language:'xBase', color: '#403a40'},
              {language:'Eiffel', color: '#946d57'},
              {language:'Nix', color: '#7e7eff'},
              {language:'RAML', color: '#77d9fb'},
              {language:'MTML', color: '#b7e1f4'},
              {language:'Racket', color: '#22228f'},
              {language:'Elixir', color: '#6e4a7e'},
              {language:'SAS', color: '#B34936'},
              {language:'Agda', color: '#315665'},
              {language:'wisp', color: '#7582D1'},
              {language:'D', color: '#ba595e'},
              {language:'Kotlin', color: '#F18E33'},
              {language:'Opal', color: '#f7ede0'},
              {language:'Crystal', color: '#776791'},
              {language:'Objective-C', color: '#438eff'},
              {language:'ColdFusion CFC', color: '#ed2cd6'},
              {language:'Oz', color: '#fab738'},
              {language:'Mirah', color: '#c7a938'},
              {language:'Objective-J', color: '#ff0c5a'},
              {language:'Gosu', color: '#82937f'},
              {language:'FreeMarker', color: '#0050b2'},
              {language:'Ruby', color: '#701516'},
              {language:'Component Pascal', color: '#b0ce4e'},
              {language:'Arc', color: '#aa2afe'},
              {language:'Brainfuck', color: '#2F2530'},
              {language:'Nit', color: '#009917'},
              {language:'APL', color: '#5A8164'},
              {language:'Go', color: '#375eab'},
              {language:'Visual Basic', color: '#945db7'},
              {language:'PHP', color: '#4F5D95'},
              {language:'Cirru', color: '#ccccff'},
              {language:'SQF', color: '#3F3F3F'},
              {language:'Glyph', color: '#e4cc98'},
              {language:'Java', color: '#b07219'},
              {language:'MAXScript', color: '#00a6a6'},
              {language:'Scala', color: '#DC322F'},
              {language:'Makefile', color: '#427819'},
              {language:'ColdFusion', color: '#ed2cd6'},
              {language:'Perl', color: '#0298c3'},
              {language:'Lua', color: '#000080'},
              {language:'Vue', color: '#2c3e50'},
              {language:'Verilog', color: '#b2b7f8'},
              {language:'Factor', color: '#636746'},
              {language:'Haxe', color: '#df7900'},
              {language:'Pure Data', color: '#91de79'},
              {language:'Forth', color: '#341708'},
              {language:'Red', color: '#ee0000'},
              {language:'Hy', color: '#7790B2'},
              {language:'Volt', color: '#1F1F1F'},
              {language:'LSL', color: '#3d9970'},
              {language:'eC', color: '#913960'},
              {language:'CoffeeScript', color: '#244776'},
              {language:'HTML', color: '#e44b23'},
              {language:'Lex', color: '#DBCA00'},
              {language:'API Blueprint', color: '#2ACCA8'},
              {language:'Swift', color: '#ffac45'},
              {language:'C', color: '#555555'},
              {language:'AutoHotkey', color: '#6594b9'},
              {language:'Isabelle', color: '#FEFE00'},
              {language:'Metal', color: '#8f14e9'},
              {language:'Clarion', color: '#db901e'},
              {language:'JSONiq', color: '#40d47e'},
              {language:'Boo', color: '#d4bec1'},
              {language:'AutoIt', color: '#1C3552'},
              {language:'Clojure', color: '#db5855'},
              {language:'Rust', color: '#dea584'},
              {language:'Prolog', color: '#74283c'},
              {language:'SourcePawn', color: '#5c7611'},
              {language:'AMPL', color: '#E6EFBB'},
              {language:'FORTRAN', color: '#4d41b1'},
              {language:'ANTLR', color: '#9DC3FF'},
              {language:'Harbour', color: '#0e60e3'},
              {language:'Tcl', color: '#e4cc98'},
              {language:'BlitzMax', color: '#cd6400'},
              {language:'PigLatin', color: '#fcd7de'},
              {language:'Lasso', color: '#999999'},
              {language:'ECL', color: '#8a1267'},
              {language:'VHDL', color: '#adb2cb'},
              {language:'Elm', color: '#60B5CC'},
              {language:'Propeller Spin', color: '#7fa2a7'},
              {language:'X10', color: '#4B6BEF'},
              {language:'IDL', color: '#a3522f'},
              {language:'ATS', color: '#1ac620'},
              {language:'Ada', color: '#02f88c'},
              {language:'Unity3D Asset', color: '#ab69a1'},
              {language:'Nu', color: '#c9df40'},
              {language:'LFE', color: '#004200'},
              {language:'SuperCollider', color: '#46390b'},
              {language:'Oxygene', color: '#cdd0e3'},
              {language:'ASP', color: '#6a40fd'},
              {language:'Assembly', color: '#6E4C13'},
              {language:'Gnuplot', color: '#f0a9f0'},
              {language:'JFlex', color: '#DBCA00'},
              {language:'NetLinx', color: '#0aa0ff'},
              {language:'Turing', color: '#45f715'},
              {language:'Vala', color: '#fbe5cd'},
              {language:'Processing', color: '#0096D8'},
              {language:'Arduino', color: '#bd79d1'},
              {language:'FLUX', color: '#88ccff'},
              {language:'NetLogo', color: '#ff6375'},
              {language:'C Sharp', color: '#178600'},
              {language:'CSS', color: '#563d7c'},
              {language:'Emacs Lisp', color: '#c065db'},
              {language:'Stan', color: '#b2011d'},
              {language:'SaltStack', color: '#646464'},
              {language:'QML', color: '#44a51c'},
              {language:'Pike', color: '#005390'},
              {language:'LOLCODE', color: '#cc9900'},
              {language:'ooc', color: '#b0b77e'},
              {language:'Handlebars', color: '#01a9d6'},
              {language:'J', color: '#9EEDFF'},
              {language:'Mask', color: '#f97732'},
              {language:'EmberScript', color: '#FFF4F3'},
              {language:'TeX', color: '#3D6117'},
              {language:'Nemerle', color: '#3d3c6e'},
              {language:'KRL', color: '#28431f'},
              {language:'RenPy', color: '#ff7f7f'},
              {language:'Unified Parallel C', color: '#4e3617'},
              {language:'Golo', color: '#88562A'},
              {language:'Fancy', color: '#7b9db4'},
              {language:'OCaml', color: '#3be133'},
              {language:'Shen', color: '#120F14'},
              {language:'Pascal', color: '#b0ce4e'},
              {language:'F#', color: '#b845fc'},
              {language:'Puppet', color: '#302B6D'},
              {language:'ActionScript', color: '#882B0F'},
              {language:'Diff', color: '#88dddd'},
              {language:'Ragel in Ruby Host', color: '#9d5200'},
              {language:'Fantom', color: '#dbded5'},
              {language:'Zephir', color: '#118f9e'},
              {language:'Click', color: '#E4E6F3'},
              {language:'Smalltalk', color: '#596706'},
              {language:'DM', color: '#447265'},
              {language:'Ioke', color: '#078193'},
              {language:'PogoScript', color: '#d80074'},
              {language:'LiveScript', color: '#499886'},
              {language:'JavaScript', color: '#f1e05a'},
              {language:'VimL', color: '#199f4b'},
              {language:'PureScript', color: '#1D222D'},
              {language:'ABAP', color: '#E8274B'},
              {language:'Matlab', color: '#bb92ac'},
              {language:'Slash', color: '#007eff'},
              {language:'R', color: '#198ce7'},
              {language:'Erlang', color: '#B83998'},
              {language:'Pan', color: '#cc0000'},
              {language:'LookML', color: '#652B81'},
              {language:'Eagle', color: '#814C05'},
              {language:'Scheme', color: '#1e4aec'},
              {language:'PLSQL', color: '#dad8d8'},
              {language:'Python', color: '#3572A5'},
              {language:'Max', color: '#c4a79c'},
              {language:'Common Lisp', color: '#3fb68b'},
              {language:'Latte', color: '#A8FF97'},
              {language:'XQuery', color: '#5232e7'},
              {language:'Omgrofl', color: '#cabbff'},
              {language:'XC', color: '#99DA07'},
              {language:'Nimrod', color: '#37775b'},
              {language:'SystemVerilog', color: '#DAE1C2'},
              {language:'Chapel', color: '#8dc63f'},
              {language:'Groovy', color: '#e69f56'},
              {language:'Dylan', color: '#6c616e'},
              {language:'E', color: '#ccce35'},
              {language:'Parrot', color: '#f3ca0a'},
              {language:'Grammatical Framework', color: '#79aa7a'},
              {language:'Game Maker language', color: '#8fb200'},
              {language:'Papyrus', color: '#6600cc'},
              {language:'NetLinx+ERB', color: '#747faa'},
              {language:'Clean', color: '#3F85AF'},
              {language:'Alloy', color: '#64C800'},
              {language:'Squirrel', color: '#800000'},
              {language:'PAWN', color: '#dbb284'},
              {language:'UnrealScript', color: '#a54c4d'},
              {language:'Standard ML', color: '#dc566d'},
              {language:'Slim', color: '#ff8f77'},
              {language:'Perl6', color: '#0000fb'},
              {language:'Julia', color: '#a270ba'},
              {language:'Haskell', color: '#29b544'},
              {language:'NCL', color: '#28431f'},
              {language:'Io', color: '#a9188d'},
              {language:'Rouge', color: '#cc0088'},
              {language:'cpp', color: '#f34b7d'},
              {language:'AGS Script', color: '#B9D9FF'},
              {language:'Dogescript', color: '#cca760'},
              {language:'nesC', color: '#94B0C7'},{language:'Text', color: '#8e44ad'},{language:'Markdown', color: '#2c3e50'},{language:'XML', color: '#d35400'},{language:'Json', color: '#f39c12'},{language:'C#', color: '#178600'}
            ]";

        var gists = JsonConvert.DeserializeObject<List<LanguageColors>>(json);

        return gists;
    }
}

