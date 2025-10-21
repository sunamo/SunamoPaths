// EN: Variable names have been checked and replaced with self-descriptive names
// CZ: Názvy proměnných byly zkontrolovány a nahrazeny samopopisnými názvy
namespace SunamoPaths;

public class CompareFilesPaths
{
    public static string GetFile(CompareExt c, int i)
    {
        return DefaultPaths.eVs + @"_tests\CompareTwoFiles\CompareTwoFiles\" + c + @"\" + i + "." + c;
    }
}
public class CompareTwoFilesHelper
{
    static readonly string basePath = DefaultPaths.eVs + @"Projects\_tests\CompareTwoFiles\CompareTwoFiles\";
    public static string Txt(int n)
    {
        return basePath + @"txt\" + n + ".txt";
    }
    public static string Html(int n)
    {
        return basePath + @"html\" + n + ".txt";
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