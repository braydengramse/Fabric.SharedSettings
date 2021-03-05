# Fabric.SharedSettings

`.editorconfig` settings that we can share across the HealthCatalyst organization.
These include general editor settings, Microsoft/C#-specific settings, ReSharper settings, and Code Analysis/StyleCop severity settings.

**Check out the [Wiki](https://github.com/HealthCatalyst/Fabric.SharedSettings/wiki) for suggestions on dealing with common error messages.**

## Getting Started ##

1. Copy the `SharedSettings/.editorconfig` file from this repository into your solution's root folder. This is a good baseline for health catalyst's preferred styles.
2. For .NET applications, append the contents of `SharedSettings.MostRules.Error.ruleset.editorconfig` to the `.editorconfig` file. This will cause many common programming mistakes to cause compile-time errors instead of just warnings. Also ensure you have analyzers enabled/installed. We recommend:
    1. [Microsoft.CodeAnalysis.NetAnalyzers](https://github.com/dotnet/roslyn-analyzers#microsoftcodeanalysisnetanalyzers)
    2. [StyleCop.Analyzers](https://www.nuget.org/packages/StyleCop.Analyzers/)
4. If you have projects that represent libraries for external use (for example, they get published as Nuget packages), add the contents of `SharedSettings.ClassLibrary.ruleset.editorconfig` to the `.editorconfig` file for those projects. These will make some rules stricter, for things like adding `.ConfigureAwait(false)` to Tasks, and enforcing good documentation practices.
5. If you have automated test projects, add the contents of `SharedSettings.TestRules.ruleset.editorconfig` to the `.editorconfig` file for those projects. This will loosen some rules around things like having multiple classes in the same file, which tend to be more acceptable in test libraries.
6. Make sure you're not unintentionally overriding these settings via Resharper DotSettings files or Code Analysis Rulesets.

### EditorConfig

The `.editorconfig` file allows a development team to share consistent coding style rules between different editors and IDEs independent of platform.

To apply the shared `.editorconfig` settings to your project, move the `.editorconfig` file from the `SharedSettings` folder into the root folder of your repository. You can create other `.editorconfig` files in individual project folders to override these settings.

For more details, see https://editorconfig.org/

**Useful Resources:**

* [Visual Studio Extension](https://marketplace.visualstudio.com/items?itemName=MadsKristensen.EditorConfig) for easier editing of `.editorconfig` files
* [Create portable, custom editor settings with EditorConfig](https://docs.microsoft.com/en-us/visualstudio/ide/create-portable-custom-editor-options)
* [.NET coding convention settings for EditorConfig](https://docs.microsoft.com/en-us/visualstudio/ide/editorconfig-code-style-settings-reference)
* This repository also has an `EditorConfigFileComparisonTool.linq` file, which is a LINQPad script to help compare the code analysis rules found in `.editorconfig` files.

## Contributing ##

Please use [the GitHub repository](https://github.com/HealthCatalyst/Fabric.SharedSettings) to suggest and make changes to these baseline settings file. Log an issue, create a pull request, comment on proposed changes with other developers, etc.
