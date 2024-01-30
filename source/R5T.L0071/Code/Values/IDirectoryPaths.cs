using System;

using R5T.T0131;


namespace R5T.L0071
{
    [ValuesMarker]
    public partial interface IDirectoryPaths : IValuesMarker
    {
        private static readonly Lazy<string> zFilesDirectoryPath = new Lazy<string>(
            Instances.FilesDirectoryOperator.Get_FilesDirectoryPath);

        public string FilesDirectoryPath => IDirectoryPaths.zFilesDirectoryPath.Value;
    }
}
