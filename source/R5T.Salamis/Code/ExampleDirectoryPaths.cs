﻿using System;


namespace R5T.Salamis
{
    /// <summary>
    /// OBSOLETE - See R5T.Z0066.
    /// </summary>
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
        public const string WindowsDirectory04Path = @"C:\Directory01\Directory04\";

        public const string WindowsRootDirectoryPathUnindicated = @"C:"; // Also the same as the Windows volume path.
        public const string WindowsRootDirectoryPath = @"C:\";

        public const string WindowsDirectory01FromWindowsDirectory04PathUnresolved = @"C:\Directory04\..\Directory01\";

        // Non-Windows.
        public const string NonWindowsDirectory01PathUnindicated = @"/mnt/Directory01";
        public const string NonWindowsDirectory01Path = @"/mnt/Directory01/";
        public const string NonWindowsDirectory02PathUnindicated = @"/mnt/Directory01/Directory02";
        public const string NonWindowsDirectory02Path = @"/mnt/Directory01/Directory02/";
        public const string NonWindowsDirectory03PathUnindicated = @"/mnt/Directory01/Directory02/Directory03";
        public const string NonWindowsDirectory03Path = @"/mnt/Directory01/Directory02/Directory03/";

        public const string NonWindowsDirectory04PathUnindicated = @"/mnt/Directory01/Directory04";
        public const string NonWindowsDirectory04Path = @"/mnt/Directory01/Directory04/";

        public const string NonWindowsDirectory01FromNonWindowsDirectory04PathUnresolved = @"/mnt/Directory04/../Directory01/";

        // Mixed.


    }
}
