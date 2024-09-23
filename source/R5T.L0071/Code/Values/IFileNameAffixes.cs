using System;

using R5T.T0131;
using R5T.T0143;


namespace R5T.L0071
{
    /// <summary>
    /// Refined file name affixes (both prefixes and suffixes).
    /// Refined allows for value instances to be named in a more verbally decorated way, making easier to find.
    /// </summary>
    [ValuesMarker]
    public partial interface IFileNameAffixes : IValuesMarker
    {
#pragma warning disable IDE1006 // Naming Styles

        [Ignore]
        Raw.IFileNameAffixes _Raw => Raw.FileNameAffixes.Instance;

#pragma warning restore IDE1006 // Naming Styles


        /// <inheritdoc cref="Raw.IFileNameAffixes.BAK"/>
        public string Backup => _Raw.BAK;
    }
}
