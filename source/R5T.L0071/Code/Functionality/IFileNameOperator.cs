using System;

using R5T.T0132;


namespace R5T.L0071
{
    [FunctionalityMarker]
    public partial interface IFileNameOperator : IFunctionalityMarker,
        L0066.IFileNameOperator
    {
        public string Get_BackupCopyFileNameStem(string fileNameStem)
        {
            var output = $"{fileNameStem}-{Instances.FileNameAffixes._Raw.BAK}";
            return output;
        }

        public string Get_BackupCopyFileName(string fileName)
        {
            var fileNameStem = this.Get_FileNameStem(fileName);
            var fileExtension = this.Get_FileExtension(fileName);

            var backupCopyFileNameStem = this.Get_BackupCopyFileNameStem(fileNameStem);

            var backupCopyFileName = this.Get_FileName(backupCopyFileNameStem, fileExtension);
            return backupCopyFileName;
        }
    }
}
