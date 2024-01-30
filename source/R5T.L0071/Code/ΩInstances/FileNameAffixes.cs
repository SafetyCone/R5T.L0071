using System;


namespace R5T.L0071
{
    public class FileNameAffixes : IFileNameAffixes
    {
        #region Infrastructure

        public static IFileNameAffixes Instance { get; } = new FileNameAffixes();


        private FileNameAffixes()
        {
        }

        #endregion
    }
}


namespace R5T.L0071.Raw
{
    public class FileNameAffixes : IFileNameAffixes
    {
        #region Infrastructure

        public static IFileNameAffixes Instance { get; } = new FileNameAffixes();


        private FileNameAffixes()
        {
        }

        #endregion
    }
}
