using System;


namespace R5T.L0071
{
    public class FilePathOperator : IFilePathOperator
    {
        #region Infrastructure

        public static IFilePathOperator Instance { get; } = new FilePathOperator();


        private FilePathOperator()
        {
        }

        #endregion
    }
}
