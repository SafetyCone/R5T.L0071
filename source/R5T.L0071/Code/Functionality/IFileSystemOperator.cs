using System;

using R5T.T0132;


namespace R5T.L0071
{
    [FunctionalityMarker]
    public partial interface IFileSystemOperator : IFunctionalityMarker,
        L0066.IFileSystemOperator
    {
        public void Create_BackupFile(string filePath)
        {
            var backupFilePath = FilePathOperator.Instance.GetBackupCopyFilePath(filePath);

            this.Copy_File(
                filePath,
                backupFilePath);
        }
    }
}
