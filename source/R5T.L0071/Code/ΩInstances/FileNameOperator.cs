using System;


namespace R5T.L0071
{
    public class FileNameOperator : IFileNameOperator
    {
        #region Infrastructure

        public static IFileNameOperator Instance { get; } = new FileNameOperator();


        private FileNameOperator()
        {
        }

        #endregion
    }
}
