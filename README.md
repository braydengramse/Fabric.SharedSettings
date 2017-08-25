# Fabric.ReSharper

Resharper settings that we can share across the HealthCatalyst organization.

## Getting Started ##

To use these settings:

1. Copy the `Settings\HealthCatalyst.Fabric.ReSharper.DotSettings` file in this repository to your solution folder
2. In Visual Studio, open your solution. Go to `Resharper > Manage Options`. Right-click the team-shared Solution settings layer (the middle one) and click `Add Layer > Open Settings File`. Select the file you copied to the solution folder. If you have multiple solutions, remember to do this for all of them.
3. Commit changes to your repository. This should include both the new DotSettings file you copied, and some lines added to your team-shared solution DotSettings file that causes this new DotSettings file to be injected. Consider removing the AbsolutePath entry in the team-shared solution file, because you'll be relying on the path that's relative to your solution.

Now anybody who uses your solution will have this HealthCatalyst standard layer of style settings applied. Auto-formatting actions like `Ctrl-E, F` and `Ctrl-E, C` will apply these settings to your code styles.


## Contributing ##

Please use [the GitHub repository](https://github.com/HealthCatalyst/Fabric.ReSharper) to suggest and make changes to this baseline file. Log an issue, create a pull request, comment on proposed changes with other developers, etc.

## Where did these settings come from? ##

These settings are largely based on StyleCop/FxCop suggestions. They began with Ryan Orbaker's personal settings, merged into the solution-wide settings in the Precise Registry Builder project, then trimmed down for use in the Fabric.Terminology project. 

Realizing that it would be beneficial to have a source of truth for a good baseline set of settings, James Jensen hosted some Open Space sessions, and this project/repository was born. You can see more about the thought process and possible future of the project by reading the notes from those sessions:
- [Session 1](https://healthcarequalitycatalyst.sharepoint.com/productdev/_layouts/OneNote.aspx?id=%2Fproductdev%2FSiteAssets%2FOpen%20Space&wd=target%28OS%2025%20%288-2-17%5C%29.one%7C8FF73F6F-DDD5-463A-BD87-AB243F8D5C41%2FShared%20Resharper%20Settings%7C8376F343-C3EC-41A4-8F93-8E2FDF7415B2%2F%29
onenote:https://healthcarequalitycatalyst.sharepoint.com/productdev/SiteAssets/Open%20Space/OS%2025%20(8-2-17).one#Shared%20Resharper%20Settings&section-id={8FF73F6F-DDD5-463A-BD87-AB243F8D5C41}&page-id={8376F343-C3EC-41A4-8F93-8E2FDF7415B2}&end)
- [Session 2](https://healthcarequalitycatalyst.sharepoint.com/productdev/_layouts/OneNote.aspx?id=%2Fproductdev%2FSiteAssets%2FOpen%20Space&wd=target%28OS%2026%20%288-23-17%5C%29.one%7C433BF617-4A41-4170-B453-8D1E7D4ACC2C%2FShared%20ReSharper%20Settings%2C%20Part%202%7C5576F75C-4119-4325-9A3B-54CAA341FCC7%2F%29
onenote:https://healthcarequalitycatalyst.sharepoint.com/productdev/SiteAssets/Open%20Space/OS%2026%20(8-23-17).one#Shared%20ReSharper%20Settings,%20Part%202&section-id={433BF617-4A41-4170-B453-8D1E7D4ACC2C}&page-id={5576F75C-4119-4325-9A3B-54CAA341FCC7}&end)
