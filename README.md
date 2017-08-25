# Fabric.ReSharper

Resharper settings that we can share across the HealthCatalyst organization.

## Getting Started ##

To use these settings:

1. Copy the `Settings\HealthCatalyst.Fabric.ReSharper.DotSettings` file in this repository to your solution folder
2. In Visual Studio, open your solution. Go to `Resharper > Manage Options`. Right-click the team-shared Solution settings layer (the middle one) and click `Add Layer > Open Settings File`. Select the file you copied to the solution folder. 
    > Note: If you have multiple solutions, consider picking one DotSettings file as the source of truth and having the rest of your solution DotSettings files inject that one as an extra layer. That way you don't have to work as hard to keep your various DotSettings files synchronized.
3. Commit changes to your repository. This should include both the new DotSettings file you copied, and some lines added to your team-shared solution DotSettings file that causes this new DotSettings file to be injected. It is safe to remove the AbsolutePath entry in the team-shared solution settings file, because you'll be relying on the path that's relative to your solution.
4. Open the SettingsFileComparisonTool.linq file in LINQPad. Change the paths in that file and run it to remove lines from your solution settings file that don't need to be there anymore.
5. Look at the remaining settings in your solution's team-shared settings file. If any of those settings are not specific to your code base, consider either dropping them to adopt the HealthCatalyst default, or submitting an issue and/or pull request to change the HealthCatalyst default to match your preference.

Now anybody who uses your solution will have this HealthCatalyst standard layer of style settings applied. Auto-formatting actions like `Ctrl-E, F` and `Ctrl-E, C` will apply these settings to your code styles.

## Contributing ##

Please use [the GitHub repository](https://github.com/HealthCatalyst/Fabric.ReSharper) to suggest and make changes to this baseline file. Log an issue, create a pull request, comment on proposed changes with other developers, etc.

## Where did these settings come from? ##

These settings are largely based on StyleCop/FxCop suggestions. They began with Ryan Orbaker's personal settings, merged into the solution-wide settings in the Precise Registry Builder project, then trimmed down for use in the Fabric.Terminology project. 

Realizing that it would be beneficial to have a source of truth for a good baseline set of settings, James Jensen hosted some Open Space sessions, and this project/repository was born. You can see more about the thought process and possible future of the project by reading the notes from those sessions:
- [Session 1](https://healthcarequalitycatalyst.sharepoint.com/productdev/_layouts/OneNote.aspx?id=%2Fproductdev%2FSiteAssets%2FOpen%20Space&wd=target%28OS%2025%20%288-2-17%5C%29.one%7C8FF73F6F-DDD5-463A-BD87-AB243F8D5C41%2FShared%20Resharper%20Settings%7C8376F343-C3EC-41A4-8F93-8E2FDF7415B2%2F%29)
- [Session 2](https://healthcarequalitycatalyst.sharepoint.com/productdev/_layouts/OneNote.aspx?id=%2Fproductdev%2FSiteAssets%2FOpen%20Space&wd=target%28OS%2026%20%288-23-17%5C%29.one%7C433BF617-4A41-4170-B453-8D1E7D4ACC2C%2FShared%20ReSharper%20Settings%2C%20Part%202%7C5576F75C-4119-4325-9A3B-54CAA341FCC7%2F%29)
