using Newtonsoft.Json;
using Plunge.Newtonsoft.ProfileVersions;

string json = File.ReadAllText(Console.ReadLine() ?? "");

LauncherProfileVersion? version = JsonConvert.DeserializeObject<LauncherProfileVersion>(json);

if (version is null)
    throw new Exception("null");

Console.WriteLine();
Console.WriteLine();
Console.WriteLine();
Console.WriteLine();
Console.WriteLine();
Console.WriteLine(JsonConvert.SerializeObject(version, Formatting.Indented));

Console.ReadLine();
