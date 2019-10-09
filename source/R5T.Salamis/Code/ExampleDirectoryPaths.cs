using System;


namespace R5T.Salamis
{
    public static class ExampleDirectoryPaths
    {
        // Windows.
        public const string WindowsDirectory01PathUnindicated = @"C:\Directory01";
        public const string WindowsDirectory01Path = @"C:\Directory01\";
        public const string WindowsDirectory02PathUnindicated = @"C:\Directory01\Directory02";
        public const string WindowsDirectory02Path = @"C:\Directory01\Directory02\";
        public const string WindowsDirectory03PathUnindicated = @"C:\Directory01\Directory02\Directory03";
        public const string WindowsDirectory03Path = @"C:\Directory01\Directory02\Directory03\";
        public const string WindowsDirectory04PathUnindicated = @"C:\Directory01\Directory04";
        public const string WindowsDirectory04Path = @"C:\Directory01\Directory04";

        public const string WindowsRootDirectoryPathUnindicated = @"C:"; // Also the same as the Windows volume path.
        public const string WindowsRootDirectoryPath = @"C:\";

        public const string WindowsDirectory01FromWindowsDirectory04PathUnresolved = @"C:\Directory4\..\..\Directory1\";

        // Non-Windows.
        public const string NonWindowsDirectory01PathUnindicated = @"/mnt/Directory01";
        public const string NonWindowsDirectory01Path = @"/mnt/Directory01/";
        public const string NonWindowsDirectory02PathUnindicated = @"/mnt/Directory02";
        public const string NonWindowsDirectory02Path = @"/mnt/Directory02/";

        // Mixed.


    }
}
