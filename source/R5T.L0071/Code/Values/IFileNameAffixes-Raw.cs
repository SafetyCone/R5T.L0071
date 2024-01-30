using System;

using R5T.T0131;


namespace R5T.L0071.Raw
{
    /// <summary>
    /// Raw file name affixes (both suffixes and prefixes).
    /// Raw means that the value instancse are named after their value contents.
    /// </summary>
    [ValuesMarker]
    public partial interface IFileNameAffixes : IValuesMarker
    {
        /// <summary>
        /// <para><value>BAK</value></para>
        /// </summary>
        public string BAK => "BAK";
    }
}
