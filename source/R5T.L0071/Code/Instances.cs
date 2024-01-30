using System;


namespace R5T.L0071
{
    public static class Instances
    {
        public static L0066.IActionOperator ActionOperator => L0066.ActionOperator.Instance;
        public static L0066.IDateTimeOperator DateTimeOperator => L0066.DateTimeOperator.Instance;
        public static L0066.IDirectoryNameOperator DirectoryNameOperator => L0066.DirectoryNameOperator.Instance;
        public static IDirectoryNames DirectoryNames => L0071.DirectoryNames.Instance;
        public static L0066.IExecutablePathOperator ExecutablePathOperator => L0066.ExecutablePathOperator.Instance;
        public static IFilesDirectoryOperator FilesDirectoryOperator => L0071.FilesDirectoryOperator.Instance;
        public static IFileNameAffixes FileNameAffixes => L0071.FileNameAffixes.Instance;
        public static IFileNameOperator FileNameOperator => L0071.FileNameOperator.Instance;
        public static L0066.INowOperator NowOperator => L0066.NowOperator.Instance;
        public static L0066.IPathOperator PathOperator => L0066.PathOperator.Instance;
        public static L0066.IStrings Strings => L0066.Strings.Instance;
    }
}