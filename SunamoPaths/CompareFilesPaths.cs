namespace SunamoPaths;

public class CompareFilesPaths
{
    public static string GetFile(CompareExt compareExt, int index)
    {
        return DefaultPaths.VsRoot + @"_tests\CompareTwoFiles\CompareTwoFiles\" + compareExt + @"\" + index + "." + compareExt;
    }
}

public class CompareTwoFilesHelper
{
    static readonly string basePath = DefaultPaths.VsRoot + @"Projects\_tests\CompareTwoFiles\CompareTwoFiles\";

    public static string Txt(int index)
    {
        return basePath + @"txt\" + index + ".txt";
    }

    public static string Html(int index)
    {
        return basePath + @"html\" + index + ".txt";
    }
}

public enum CompareExt
{
    cpp,
    aspx,
    cs,
    docs,
    html,
    js,
    json,
    txt
}
