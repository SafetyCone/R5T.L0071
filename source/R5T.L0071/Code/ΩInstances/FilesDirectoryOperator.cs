using System;


namespace R5T.L0071
{
    public class FilesDirectoryOperator : IFilesDirectoryOperator
    {
        #region Infrastructure

        public static IFilesDirectoryOperator Instance { get; } = new FilesDirectoryOperator();


        private FilesDirectoryOperator()
        {
        }

        #endregion
    }
}
