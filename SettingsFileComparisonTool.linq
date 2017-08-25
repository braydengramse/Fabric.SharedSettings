<Query Kind="Program" />

void Main()
{
	/* CHANGE THE FOLLOWING STRINGS TO MATCH THE LOCATION OF YOUR FILES.
	   THEN HIT F5 TO EXECUTE. */
	const string SolutionPath = @"C:\Source\HC\PreciseRegistryBuilder";
	string HCSharedFileName = Path.Combine(SolutionPath, @"HealthCatalyst.Fabric.ReSharper.DotSettings");
	string SolutionFileName = Path.Combine(SolutionPath, @"PrecisePatientRegistry.sln.DotSettings");
	RemoveExtraneousSettingsFromSolutionFile(HCSharedFileName, SolutionFileName);
}

#region Helper Methods and Classes

void RemoveExtraneousSettingsFromSolutionFile(string baseFilePath, string solutionFilePath)
{
	var baseFileXml = XElement.Load(baseFilePath);
	var solutionFileXml = XElement.Load(solutionFilePath);
	var allElements = GetSettingsElements(baseFileXml, baseFilePath)
		.Concat(GetSettingsElements(solutionFileXml, solutionFilePath));
	var elementsWeCareAbout = allElements
		.Where(e => !e.Key.StartsWith("/Default/Environment/SettingsMigration/IsMigratorApplied"));
	var similarSettings = elementsWeCareAbout.GroupBy(e => e.Key)
		.Select(g => new
		{
			g.Key,
			Base = g.Where(e => e.Source == baseFilePath).Select(e => new { e.Value, e.Element }).FirstOrDefault(),
			Solution = g.Where(e => e.Source == solutionFilePath).Select(e => new { e.Value, e.Element }).FirstOrDefault()
		})
		.Where(g => g.Base?.Value == g.Solution?.Value)
		.ToList();
	Console.WriteLine($"Removing {similarSettings.Count()} duplicate settings from solution settings.");
	foreach (var setting in similarSettings)
	{
		var element = setting.Solution.Element;
		if (element.ElementsBeforeSelf().Any())
		{
			var emptyNodesBefore = element.NodesBeforeSelf()
			   .Reverse()
			   .TakeWhile(node => node.NodeType == XmlNodeType.Text)
			   .Cast<XText>()
			   .Where(n => string.IsNullOrWhiteSpace(n.Value))
			   .ToList();
			emptyNodesBefore.ForEach(n => n.Remove());
		}
		setting.Solution.Element.Remove();
	}
	solutionFileXml.Save(solutionFilePath);	
}

IReadOnlyCollection<SettingsElement> GetSettingsElements(XElement element, string source)
{
	var xaml = (XNamespace)"http://schemas.microsoft.com/winfx/2006/xaml";
	return element.Descendants()
		.Select(e => new SettingsElement{ Source = source, Key = e.Attribute(xaml + "Key")?.Value, Element = e, Value = e.Value })
		.Where(e => !string.IsNullOrEmpty(e.Key))
		.ToList();
}

class SettingsElement
{
	public string Key { get; set; }
	public XElement Element { get; set; }
	public string Value { get; set; }
	public string Source { get; set;}
}

#endregion