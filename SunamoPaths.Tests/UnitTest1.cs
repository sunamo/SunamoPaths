namespace SunamoPaths.Tests;

/// <summary>
/// Unit tests for the SunamoPaths library.
/// </summary>
public class UnitTest1
{
    /// <summary>
    /// Tests that GetFile returns a path containing the expected extension and index.
    /// </summary>
    [Fact]
    public static void GetFile_ReturnsPathWithExtensionAndIndex()
    {
        string result = CompareFilesPaths.GetFile(CompareExt.txt, 1);

        Assert.Contains("txt", result);
        Assert.EndsWith("1.txt", result);
    }

    /// <summary>
    /// Tests that GetFile returns a path containing the correct subdirectory for given extension.
    /// </summary>
    [Fact]
    public static void GetFile_ReturnsPathWithCorrectSubdirectory()
    {
        string result = CompareFilesPaths.GetFile(CompareExt.cs, 3);

        Assert.Contains(@"cs\3.cs", result);
    }

    /// <summary>
    /// Tests that Txt returns a path ending with the expected txt subdirectory and index.
    /// </summary>
    [Fact]
    public static void Txt_ReturnsPathWithIndex()
    {
        string result = CompareTwoFilesHelper.Txt(1);

        Assert.EndsWith(@"txt\1.txt", result);
    }

    /// <summary>
    /// Tests that Html returns a path ending with the expected html subdirectory and index.
    /// </summary>
    [Fact]
    public static void Html_ReturnsPathWithIndex()
    {
        string result = CompareTwoFilesHelper.Html(1);

        Assert.EndsWith(@"html\1.txt", result);
    }

    /// <summary>
    /// Tests that IsIgnored returns true for paths starting with BitBucket base path.
    /// </summary>
    [Fact]
    public static void IsIgnored_ReturnsTrueForBitBucketPath()
    {
        bool result = DefaultPaths.IsIgnored(DefaultPaths.BitBucketBasePath + @"some\project\");

        Assert.True(result);
    }

    /// <summary>
    /// Tests that IsIgnored returns false for paths not matching any ignore pattern.
    /// </summary>
    [Fact]
    public static void IsIgnored_ReturnsFalseForNonIgnoredPath()
    {
        bool result = DefaultPaths.IsIgnored(@"C:\SomeOtherPath\");

        Assert.False(result);
    }

    /// <summary>
    /// Tests that VsRoot constant has the expected value.
    /// </summary>
    [Fact]
    public static void VsRoot_HasExpectedValue()
    {
        Assert.Equal(@"E:\vs\", DefaultPaths.VsRoot);
    }

    /// <summary>
    /// Tests that ActualPlatform returns the same value as VsRoot.
    /// </summary>
    [Fact]
    public static void ActualPlatform_ReturnsVsRoot()
    {
        Assert.Equal(DefaultPaths.VsRoot, DefaultPaths.ActualPlatform);
    }

    /// <summary>
    /// Tests that VsProjects path starts with VsRoot.
    /// </summary>
    [Fact]
    public static void VsProjects_StartsWithVsRoot()
    {
        Assert.StartsWith(DefaultPaths.VsRoot, DefaultPaths.VsProjects);
    }

    /// <summary>
    /// Tests that SunamoCzRootPath starts with VsRoot.
    /// </summary>
    [Fact]
    public static void SunamoCzRootPath_StartsWithVsRoot()
    {
        Assert.StartsWith(DefaultPaths.VsRoot, DefaultPaths.SunamoCzRootPath);
    }
}
