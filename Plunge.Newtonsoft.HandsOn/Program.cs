using Newtonsoft.Json;
using Plunge.Newtonsoft.ProfileVersions;
using System;
using System.IO;

string json = File.ReadAllText(args.Length == 1 ? args[0] : Console.ReadLine() ?? "");

LauncherProfileVersion? version = JsonConvert.DeserializeObject<LauncherProfileVersion>(json);

if (version is null)
    throw new Exception("null");

Console.WriteLine();
Console.WriteLine();
Console.WriteLine();
Console.WriteLine();
Console.WriteLine();
Console.WriteLine(JsonConvert.SerializeObject(version, new JsonSerializerSettings
{
    Formatting = Formatting.Indented,
    NullValueHandling = NullValueHandling.Ignore
}));

Console.ReadLine();
