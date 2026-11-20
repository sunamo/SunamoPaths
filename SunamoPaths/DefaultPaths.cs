namespace SunamoPaths;

/// <summary>
/// Represents the default paths type.
/// </summary>
public partial class DefaultPaths
{
    /// <summary>
    /// Is ignored.
    /// </summary>
    /// <param name="path">The path.</param>
    /// <returns>The is ignored result.</returns>
    public static bool IsIgnored(string path) => path.StartsWith(BitBucketBasePath);
}
