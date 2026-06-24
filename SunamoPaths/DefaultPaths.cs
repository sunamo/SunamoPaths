namespace SunamoPaths;

public partial class DefaultPaths
{
    public static bool IsIgnored(string path) => path.StartsWith(BitBucketBasePath);
}
