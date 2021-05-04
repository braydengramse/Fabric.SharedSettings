# Fabric.SharedSettings

Code style and analysis settings that we can share across the HealthCatalyst organization.
These include general editor settings, Microsoft/C#-specific settings, ReSharper settings, Code Analysis/StyleCop severity settings, and Prettier/eslint settings for javascript applications.

**Check out the [Wiki](https://github.com/HealthCatalyst/Fabric.SharedSettings/wiki) for suggestions on dealing with common error messages.**

## Getting Started ##

Copy the `SharedSettings/.editorconfig` file from this repository into your solution's root folder. This is a good baseline for health catalyst's preferred styles.

### For .NET Applications
1. For .NET applications, append the contents of `SharedSettings/Catalyst.MostRules.Error.ruleset.editorconfig` to the `.editorconfig` file. This will cause many common programming mistakes to cause compile-time errors instead of just warnings. Also ensure you have analyzers enabled/installed. We recommend:
    1. [Microsoft.CodeAnalysis.NetAnalyzers](https://github.com/dotnet/roslyn-analyzers#microsoftcodeanalysisnetanalyzers)
    2. [StyleCop.Analyzers](https://www.nuget.org/packages/StyleCop.Analyzers/)
2. If you have projects that represent libraries for external use (for example, they get published as Nuget packages), add the contents of `SharedSettings/Catalyst.ClassLibrary.ruleset.editorconfig` to the `.editorconfig` file for those projects. These will make some rules stricter, for things like adding `.ConfigureAwait(false)` to Tasks, and enforcing good documentation practices.
3. If you have automated test projects, add the contents of `SharedSettings/Catalyst.TestRules.ruleset.editorconfig` to the `.editorconfig` file for those projects. This will loosen some rules around things like having multiple classes in the same file, which tend to be more acceptable in test libraries.
4. Make sure you're not unintentionally overriding these settings via Resharper DotSettings files or Code Analysis Rulesets.

### For TypeScript/Javascript applications

For web applications (TypeScript/Javascript/Angular):
1. Put the `SharedSettings/.prettierrc` and `SharedSettings/.eslintrc.js` files in the root of your application folder.
2. Incorporate the elements from the `SharedSettings/package.json` file into your `package.json` file. This file contains versions of the required packages (as of 2021-3-4), along with an npm command to run the linter.

## More on EditorConfig

The `.editorconfig` file allows a development team to share consistent coding style rules between different editors and IDEs independent of platform.

To apply the shared `.editorconfig` settings to your project, move the `.editorconfig` file from the `SharedSettings` folder into the root folder of your repository. You can create other `.editorconfig` files in individual project folders to override these settings.

For more details, see https://editorconfig.org/

**Useful Resources:**

* [Visual Studio Extension](https://marketplace.visualstudio.com/items?itemName=MadsKristensen.EditorConfig) for easier editing of `.editorconfig` files
* [Create portable, custom editor settings with EditorConfig](https://docs.microsoft.com/en-us/visualstudio/ide/create-portable-custom-editor-options)
* [.NET coding convention settings for EditorConfig](https://docs.microsoft.com/en-us/visualstudio/ide/editorconfig-code-style-settings-reference)
* This repository also has an `EditorConfigFileComparisonTool.linq` file, which is a LINQPad script to help compare the code analysis rules found in `.editorconfig` files.

## More on TypeScript/Javascript settings ##

For styling and linting purposes, we use a combination of ESLint and Prettier, along with minimal configuration files.  The bulk of the linting rules use the built-in recommended lists, along with rules for using eslint with Prettier. 

Recommended extensions:
* [VsCode Prettier extension](https://marketplace.visualstudio.com/items?itemName=esbenp.prettier-vscode)
* [VsCode ESLint extension](https://marketplace.visualstudio.com/items?itemName=dbaeumer.vscode-eslint)


## Contributing ##

Please use [the GitHub repository](https://github.com/HealthCatalyst/Fabric.SharedSettings) to suggest and make changes to these baseline settings file. Log an issue, create a pull request, comment on proposed changes with other developers, etc.
