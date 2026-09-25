namespace SunamoPaths;

public partial class DefaultPaths
{
    public const string VsSecondaryRoot = @"E:\vs2\";

    public const string VsRoot = @"E:\vs\";

    public static string ActualPlatform => VsRoot;

    public static readonly string SunamoCzRootPath = Path.Combine(VsRoot, @"Projects\sunamo.cz\");

    public const string BitBucketBasePath = @"D:\Documents\BitBucket\";

    public static readonly string SunamoCzProjectPath =
        Path.Combine(VsRoot, @"Projects\sunamo.cz\sunamo.cz\");

    public static readonly string SunamoCzOldPath =
        Path.Combine(VsRoot, @"Projects\sunamo.cz\sunamo.cz-old\");

    public static readonly string SunamoCzNsnPath =
        Path.Combine(VsRoot, @"Projects\sunamo.cz\sunamo.cz-nsn\");

    public static readonly string VsDocuments = Path.Combine(EDocuments, @"vs\");

    public static readonly string NormalizePathToFolder = Path.Combine(VsRoot, @"Projects\");

    public static readonly string TestMoveClassElementIntoSharedFileUC =
        "D:\\_Test\\AllProjectsSearch\\AllProjectsSearch\\MoveClassElementIntoSharedFileUC\\";

    public const string SyncArchived = @"E:\SyncArchived\";

    public const string SyncArchivedText = @"E:\SyncArchived\Text\";

    public const string SyncArchivedDrive = @"E:\SyncArchived\Drive\";

    public static readonly string Documents = @"D:\Documents\";

    public const string EDocuments = @"E:\Documents\";

    public static readonly string Docs = @"D:\Docs\";

    public static readonly string Downloads = @"D:\Downloads\";

    public static readonly string Music2 = @"D:\Music2\";

    public static readonly List<string> All = [Documents, Docs, Downloads, Music2];

    public static readonly string XnConvert = @"D:\Pictures\XnConvert\";

    public const string PhotosSunamoCz = @"D:\Pictures\photos.sunamo.cz\";

    public static readonly string VsProjects = @"E:\vs\Projects\";

    public const string VsProjectsPlatformIndependent = @"E:\vs\Projects\PlatformIndependentNuGetPackages\";

    public const string BackupSunamosAppData = @"E:\Sync\Develop of Future\Backups\";

    public const string PaBasePath = @"D:\pa\";

    public const string PaSyncPath = @"D:\paSync\";

    public static readonly string Backup = @"D:\Documents\Backup\";

    public static readonly string Streamline = @"D:\Pictures\Streamline_All_Icons_PNG\PNG Icons\";
}
