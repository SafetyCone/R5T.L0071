using System;

using R5T.T0131;


namespace R5T.L0071
{
    [ValuesMarker]
    public partial interface IDirectoryNames : IValuesMarker
    {
        /// <summary>
        /// <para><value>Files</value></para>
        /// </summary>
        public string Files => "Files";
    }
}
