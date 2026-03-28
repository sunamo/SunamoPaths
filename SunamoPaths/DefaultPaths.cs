namespace SunamoPaths;

/// <summary>
/// Provides methods for working with default paths in the sunamo project infrastructure.
/// </summary>
public partial class DefaultPaths
{
    /// <summary>
    /// Determines whether the specified path should be ignored based on known ignore patterns.
    /// </summary>
    /// <param name="path">The path to check.</param>
    /// <returns>True if the path starts with the BitBucket base path; otherwise, false.</returns>
    public static bool IsIgnored(string path)
    {
        if (path.StartsWith(BitBucketBasePath)) return true;
        return false;
    }
}
