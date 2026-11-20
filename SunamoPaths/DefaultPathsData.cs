namespace SunamoPaths;

public partial class DefaultPaths
{
    /// <summary>
    /// The vs secondary root constant.
    /// </summary>
    public const string VsSecondaryRoot = @"E:\vs2\";

    /// <summary>
    /// The vs root constant.
    /// </summary>
    public const string VsRoot = @"E:\vs\";

    /// <summary>
    /// Gets the actual platform.
    /// </summary>
    public static string ActualPlatform => VsRoot;

    /// <summary>
    /// The sunamo cz root path.
    /// </summary>
    public static readonly string SunamoCzRootPath = Path.Combine(VsRoot, @"Projects\sunamo.cz\");

    /// <summary>
    /// The bit bucket base path constant.
    /// </summary>
    public const string BitBucketBasePath = @"D:\Documents\BitBucket\";

    /// <summary>
    /// The sunamo cz project path.
    /// </summary>
    public static readonly string SunamoCzProjectPath =
        Path.Combine(VsRoot, @"Projects\sunamo.cz\sunamo.cz\");

    /// <summary>
    /// The sunamo cz old path.
    /// </summary>
    public static readonly string SunamoCzOldPath =
        Path.Combine(VsRoot, @"Projects\sunamo.cz\sunamo.cz-old\");

    /// <summary>
    /// The sunamo cz nsn path.
    /// </summary>
    public static readonly string SunamoCzNsnPath =
        Path.Combine(VsRoot, @"Projects\sunamo.cz\sunamo.cz-nsn\");

    /// <summary>
    /// The vs documents.
    /// </summary>
    public static readonly string VsDocuments = Path.Combine(EDocuments, @"vs\");

    /// <summary>
    /// The normalize path to folder.
    /// </summary>
    public static readonly string NormalizePathToFolder = Path.Combine(VsRoot, @"Projects\");

    /// <summary>
    /// The test move class element into shared file UC.
    /// </summary>
    public static readonly string TestMoveClassElementIntoSharedFileUC =
        "D:\\_Test\\AllProjectsSearch\\AllProjectsSearch\\MoveClassElementIntoSharedFileUC\\";

    /// <summary>
    /// The sync archived constant.
    /// </summary>
    public const string SyncArchived = @"E:\SyncArchived\";

    /// <summary>
    /// The sync archived text constant.
    /// </summary>
    public const string SyncArchivedText = @"E:\SyncArchived\Text\";

    /// <summary>
    /// The sync archived drive constant.
    /// </summary>
    public const string SyncArchivedDrive = @"E:\SyncArchived\Drive\";

    /// <summary>
    /// The documents.
    /// </summary>
    public static readonly string Documents = @"D:\Documents\";

    /// <summary>
    /// The e documents constant.
    /// </summary>
    public const string EDocuments = @"E:\Documents\";

    /// <summary>
    /// The docs.
    /// </summary>
    public static readonly string Docs = @"D:\Docs\";

    /// <summary>
    /// The downloads.
    /// </summary>
    public static readonly string Downloads = @"D:\Downloads\";

    /// <summary>
    /// The music 2.
    /// </summary>
    public static readonly string Music2 = @"D:\Music2\";

    /// <summary>
    /// The all.
    /// </summary>
    public static readonly List<string> All = [Documents, Docs, Downloads, Music2];

    /// <summary>
    /// The xn convert.
    /// </summary>
    public static readonly string XnConvert = @"D:\Pictures\XnConvert\";

    /// <summary>
    /// The photos sunamo cz constant.
    /// </summary>
    public const string PhotosSunamoCz = @"D:\Pictures\photos.sunamo.cz\";

    /// <summary>
    /// The vs projects.
    /// </summary>
    public static readonly string VsProjects = @"E:\vs\Projects\";

    /// <summary>
    /// The vs projects platform independent constant.
    /// </summary>
    public const string VsProjectsPlatformIndependent = @"E:\vs\Projects\PlatformIndependentNuGetPackages\";

    /// <summary>
    /// The backup sunamos app data constant.
    /// </summary>
    public const string BackupSunamosAppData = @"E:\Sync\Develop of Future\Backups\";

    /// <summary>
    /// The pa base path constant.
    /// </summary>
    public const string PaBasePath = @"D:\pa\";

    /// <summary>
    /// The pa sync path constant.
    /// </summary>
    public const string PaSyncPath = @"D:\paSync\";

    /// <summary>
    /// The backup.
    /// </summary>
    public static readonly string Backup = @"D:\Documents\Backup\";

    /// <summary>
    /// The streamline.
    /// </summary>
    public static readonly string Streamline = @"D:\Pictures\Streamline_All_Icons_PNG\PNG Icons\";
}
