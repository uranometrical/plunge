namespace Plunge.Newtonsoft.ProfileVersions
{
    public class LibraryArtifact
    {
        public class OperatingSystemArtifact
        {
            public string Path = "";

            public string Sha1 = "";

            public int Size;

            public string Url = "";
        }

        public string Path = "";

        public string Sha1 = "";

        public int Size;

        public string Url = "";

        public OperatingSystemArtifact NativesLinux = new();

        public OperatingSystemArtifact NativesOsx = new();

        public OperatingSystemArtifact NativesWindows = new();
    }
}