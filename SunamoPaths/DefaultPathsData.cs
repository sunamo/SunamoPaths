namespace SunamoPaths;

/// <summary>
/// Provides default path constants and static fields for sunamo project infrastructure.
/// </summary>
public partial class DefaultPaths
{
    /// <summary>
    /// Secondary Visual Studio root path (E:\vs2\).
    /// </summary>
    public const string VsSecondaryRoot = @"E:\vs2\";

    /// <summary>
    /// Visual Studio root path (E:\vs\).
    /// </summary>
    public const string VsRoot = @"E:\vs\";

    /// <summary>
    /// Gets the current platform root path.
    /// </summary>
    public static string ActualPlatform => VsRoot;

    /// <summary>
    /// Root path for the sunamo.cz project, ending with backslash.
    /// </summary>
    public static readonly string SunamoCzRootPath = Path.Combine(VsRoot, @"Projects\sunamo.cz\");

    /// <summary>
    /// Base path for BitBucket documents.
    /// </summary>
    public const string BitBucketBasePath = @"D:\Documents\BitBucket\";

    /// <summary>
    /// Path to the sunamo.cz project folder, ending with backslash.
    /// </summary>
    public static readonly string SunamoCzProjectPath =
        Path.Combine(VsRoot, @"Projects\sunamo.cz\sunamo.cz\");

    /// <summary>
    /// Path to the old sunamo.cz project folder.
    /// </summary>
    public static readonly string SunamoCzOldPath =
        Path.Combine(VsRoot, @"Projects\sunamo.cz\sunamo.cz-old\");

    /// <summary>
    /// Path to the sunamo.cz NSN project folder.
    /// </summary>
    public static readonly string SunamoCzNsnPath =
        Path.Combine(VsRoot, @"Projects\sunamo.cz\sunamo.cz-nsn\");

    /// <summary>
    /// Path to the Visual Studio documents folder.
    /// </summary>
    public static readonly string VsDocuments = Path.Combine(EDocuments, @"vs\");

    /// <summary>
    /// Normalized path to the projects folder.
    /// </summary>
    public static readonly string NormalizePathToFolder = Path.Combine(VsRoot, @"Projects\");

    /// <summary>
    /// Test path for MoveClassElementIntoSharedFileUC operations.
    /// </summary>
    public static readonly string TestMoveClassElementIntoSharedFileUC =
        "D:\\_Test\\AllProjectsSearch\\AllProjectsSearch\\MoveClassElementIntoSharedFileUC\\";

    /// <summary>
    /// Root path for sync archived content.
    /// </summary>
    public const string SyncArchived = @"E:\SyncArchived\";

    /// <summary>
    /// Path for archived text content.
    /// </summary>
    public const string SyncArchivedText = @"E:\SyncArchived\Text\";

    /// <summary>
    /// Path for archived drive content.
    /// </summary>
    public const string SyncArchivedDrive = @"E:\SyncArchived\Drive\";

    /// <summary>
    /// Documents folder path on D: drive.
    /// </summary>
    public static readonly string Documents = @"D:\Documents\";

    /// <summary>
    /// Documents folder path on E: drive.
    /// </summary>
    public const string EDocuments = @"E:\Documents\";

    /// <summary>
    /// Docs folder path on D: drive.
    /// </summary>
    public static readonly string Docs = @"D:\Docs\";

    /// <summary>
    /// Downloads folder path on D: drive.
    /// </summary>
    public static readonly string Downloads = @"D:\Downloads\";

    /// <summary>
    /// Secondary music folder path.
    /// </summary>
    public static readonly string Music2 = @"D:\Music2\";

    /// <summary>
    /// Collection of all document-related paths.
    /// </summary>
    public static readonly List<string> All = [Documents, Docs, Downloads, Music2];

    /// <summary>
    /// Path to the XnConvert output folder.
    /// </summary>
    public static readonly string XnConvert = @"D:\Pictures\XnConvert\";

    /// <summary>
    /// Path to the photos.sunamo.cz pictures folder.
    /// </summary>
    public const string PhotosSunamoCz = @"D:\Pictures\photos.sunamo.cz\";

    /// <summary>
    /// Visual Studio projects folder path.
    /// </summary>
    public static readonly string VsProjects = @"E:\vs\Projects\";

    /// <summary>
    /// Path to the platform-independent NuGet packages folder.
    /// </summary>
    public const string VsProjectsPlatformIndependent = @"E:\vs\Projects\PlatformIndependentNuGetPackages\";

    /// <summary>
    /// Backup path for sunamo application data.
    /// </summary>
    public const string BackupSunamosAppData = @"E:\Sync\Develop of Future\Backups\";

    /// <summary>
    /// Base path for PA directory.
    /// </summary>
    public const string PaBasePath = @"D:\pa\";

    /// <summary>
    /// Sync path for PA directory.
    /// </summary>
    public const string PaSyncPath = @"D:\paSync\";

    /// <summary>
    /// Backup folder path.
    /// </summary>
    public static readonly string Backup = @"D:\Documents\Backup\";

    /// <summary>
    /// Path to the Streamline icons folder.
    /// </summary>
    public static readonly string Streamline = @"D:\Pictures\Streamline_All_Icons_PNG\PNG Icons\";
}
