<Query Kind="Program" />

void Main()
{
	/* CHANGE THE FOLLOWING STRINGS TO MATCH THE LOCATION OF YOUR FILES.
	   THEN HIT F5 TO EXECUTE. */
	const string SolutionPath = @"C:\Source\HC\PopulationBuilder";
	string FirstFileName = Path.Combine(SolutionPath, @".editorconfig");
	string SecondFileName = Path.Combine(SolutionPath, @"PopulationBuilder.UnitTests\.editorconfig");

	var first = GetDiagnosticSeverities(FirstFileName);
	var second = GetDiagnosticSeverities(SecondFileName);
	var allKeys = new HashSet<string>(first.Keys.Concat(second.Keys));
	allKeys.Select(key => new
	{
		key,
		firstValue = first.ContainsKey(key) ? first[key] : null,
		secondValue = second.ContainsKey(key) ? second[key] : null
	})
    .Dump();
}

#region Helper Methods and Classes

IDictionary<string, string> GetDiagnosticSeverities(string filename){
	var dict = new Dictionary<string, string>();
	foreach (var line in File.ReadAllLines(filename)
		.Select(l => l.ToLowerInvariant()))
	{
		if(line.StartsWith("dotnet_diagnostic")){
			var pieces = line.Split('=', 2).Select(s => s.Trim()).ToArray();
			var (key, value) = (pieces[0], pieces[1]);
			if (!dict.TryAdd(key, value))
			{
				Console.WriteLine($"{filename} has multiple entries for {key}");
				dict[key] = value;
			}
		}
	}
	return dict;
}

#endregion