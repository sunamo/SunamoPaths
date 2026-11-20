namespace SunamoPaths;

/// <summary>
/// Represents the compare files paths type.
/// </summary>
public class CompareFilesPaths
{
    /// <summary>
    /// Get file.
    /// </summary>
    /// <param name="compareExt">The compare ext.</param>
    /// <param name="index">The index.</param>
    /// <returns>The get file result.</returns>
    public static string GetFile(CompareExt compareExt, int index)
    {
        return DefaultPaths.VsRoot + @"_tests\CompareTwoFiles\CompareTwoFiles\" + compareExt + @"\" + index + "." + compareExt;
    }
}

/// <summary>
/// Represents the compare two files helper type.
/// </summary>
public class CompareTwoFilesHelper
{
    static readonly string basePath = DefaultPaths.VsRoot + @"Projects\_tests\CompareTwoFiles\CompareTwoFiles\";

    /// <summary>
    /// Txt.
    /// </summary>
    /// <param name="index">The index.</param>
    /// <returns>The txt result.</returns>
    public static string Txt(int index)
    {
        return basePath + @"txt\" + index + ".txt";
    }

    /// <summary>
    /// Html.
    /// </summary>
    /// <param name="index">The index.</param>
    /// <returns>The html result.</returns>
    public static string Html(int index)
    {
        return basePath + @"html\" + index + ".txt";
    }
}

/// <summary>
/// Represents the compare ext type.
/// </summary>
public enum CompareExt
{
    /// <summary>
    /// The cpp value.
    /// </summary>
    cpp,
    /// <summary>
    /// The aspx value.
    /// </summary>
    aspx,
    /// <summary>
    /// The cs value.
    /// </summary>
    cs,
    /// <summary>
    /// The docs value.
    /// </summary>
    docs,
    /// <summary>
    /// The html value.
    /// </summary>
    html,
    /// <summary>
    /// The js value.
    /// </summary>
    js,
    /// <summary>
    /// The json value.
    /// </summary>
    json,
    /// <summary>
    /// The txt value.
    /// </summary>
    txt
}
