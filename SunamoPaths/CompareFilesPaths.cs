namespace SunamoPaths;

/// <summary>
/// Provides helper methods for constructing file paths used in file comparison operations.
/// </summary>
public class CompareFilesPaths
{
    /// <summary>
    /// Gets the file path for a comparison file based on extension type and index.
    /// </summary>
    /// <param name="compareExt">The file extension type for comparison.</param>
    /// <param name="index">The file index number.</param>
    /// <returns>The full file path to the comparison file.</returns>
    public static string GetFile(CompareExt compareExt, int index)
    {
        return DefaultPaths.VsRoot + @"_tests\CompareTwoFiles\CompareTwoFiles\" + compareExt + @"\" + index + "." + compareExt;
    }
}

/// <summary>
/// Provides helper methods for constructing paths to text and HTML comparison test files.
/// </summary>
public class CompareTwoFilesHelper
{
    static readonly string basePath = DefaultPaths.VsRoot + @"Projects\_tests\CompareTwoFiles\CompareTwoFiles\";

    /// <summary>
    /// Gets the file path for a text comparison file by index.
    /// </summary>
    /// <param name="index">The file index number.</param>
    /// <returns>The full file path to the text comparison file.</returns>
    public static string Txt(int index)
    {
        return basePath + @"txt\" + index + ".txt";
    }

    /// <summary>
    /// Gets the file path for an HTML comparison file by index.
    /// </summary>
    /// <param name="index">The file index number.</param>
    /// <returns>The full file path to the HTML comparison file.</returns>
    public static string Html(int index)
    {
        return basePath + @"html\" + index + ".txt";
    }
}

/// <summary>
/// Supported file extension types for file comparison operations.
/// </summary>
public enum CompareExt
{
    /// <summary>
    /// C++ source files.
    /// </summary>
    cpp,

    /// <summary>
    /// ASP.NET Web Forms files.
    /// </summary>
    aspx,

    /// <summary>
    /// C# source files.
    /// </summary>
    cs,

    /// <summary>
    /// Document files.
    /// </summary>
    docs,

    /// <summary>
    /// HTML files.
    /// </summary>
    html,

    /// <summary>
    /// JavaScript files.
    /// </summary>
    js,

    /// <summary>
    /// JSON files.
    /// </summary>
    json,

    /// <summary>
    /// Plain text files.
    /// </summary>
    txt
}
