namespace Plunge.Newtonsoft.ProfileVersions
{
    public class LibraryData
    {
        public Dictionary<string, LibraryArtifact> Downloads = new();

        public ExtractData Extract = new();

        public string Name = "";

        public Dictionary<string, string> Natives = new();

        public LibraryRule[] Rules = Array.Empty<LibraryRule>();
    }
}