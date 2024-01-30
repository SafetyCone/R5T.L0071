using System;

using R5T.T0132;


namespace R5T.L0071
{
    [FunctionalityMarker]
    public partial interface IFilePathOperator : IFunctionalityMarker
    {
        public string GetBackupCopyFilePath(string filePath)
        {
            var parentDirectoryPath = Instances.PathOperator.Get_ParentDirectoryPath_ForFile(filePath);
            var fileName = Instances.PathOperator.Get_FileName(filePath);

            var backupCopyFileName = Instances.FileNameOperator.Get_BackupCopyFileName(fileName);

            var backupCopyFilePath = Instances.PathOperator.Get_FilePath(
                parentDirectoryPath,
                backupCopyFileName);

            return backupCopyFilePath;
        }
    }
}
