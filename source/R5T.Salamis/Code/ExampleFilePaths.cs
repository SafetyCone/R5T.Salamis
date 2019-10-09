using System;


namespace R5T.Salamis
{
    public static class ExampleFilePaths
    {
        // Windows.
        public const string WindowsFile01Path = @"C:\Directory01\File01.txt";
        public const string WindowsFile02Path = @"C:\Directory01\File02.txt";
        public const string WindowsFile03Path = @"C:\Directory01\Directory02\File03.txt";
        public const string WindowsFile04Path = @"C:\Directory01\Directory02\Directory03\File04.txt";
        public const string WindowsFile05Path = @"C:\Directory01\Directory04\File05.txt";
        public const string WindowsFile06Path = @"C:\File06.txt";

        public const string WindowsFile01FromRootRelativePath = @"Directory01/File01.txt";

        public const string WindowsFile01DirectoryIndicatedPath = @"C:\Directory01\File01.txt\";

        public const string WindowsFile01FromWindowsDirectory02PathUnresolved = @"C:\Directory02\..\Directory01\File01.txt";

        public static readonly string[] WindowsFile04PathParts = new string[]
        {
            ExampleRootPaths.WindowsCDrive,
            ExampleDirectoryNames.Directory01,
            ExampleDirectoryNames.Directory02,
            ExampleDirectoryNames.Directory03,
            ExampleFileNames.File04Name
        };

        // Non-Windows.
        public const string NonWindowsFile01Path = @"/mnt/Directory01/File01.txt";

        public const string NonWindowsFile01FromNonWindowsDirectory02PathUnresolved = @"/mnt/Directory02/../Directory01/File01.txt";

        public static readonly string[] NonWindowsFile01PathParts = new string[]
        {
            ExampleRootPaths.NonWindowsMnt,
            ExampleDirectoryNames.Directory01,
            ExampleFileNames.File01Name,
        };

        // Mixed.
        public const string MixedWindowsDominantFile01Path = @"C:\Directory01/File01.txt";

        public const string MixedNonWindowsDominantFile01Path = @"/mnt\Directory01\File01.txt";
    }
}
