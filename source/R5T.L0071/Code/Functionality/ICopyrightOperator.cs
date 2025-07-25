using System;

using R5T.T0132;


namespace R5T.L0071
{
    /// <summary>
    /// 
    /// </summary>
    /// <remarks>
    /// Deprecated. See F10Y.L0004.
    /// </remarks>
    [FunctionalityMarker]
    public partial interface ICopyrightOperator : IFunctionalityMarker
    {
        public string Get_CopyrightText(
            string copyrightHolder,
            int copyrightYear)
        {
            var output = $"Copyright {Instances.Strings.Copyright} {copyrightHolder} {copyrightYear}";
            return output;
        }

        public string Get_CopyrightText(
            string copyrightHolder,
            DateTime copyrightDate)
        {
            var copyrightYear = Instances.DateTimeOperator.Get_Year(copyrightDate);

            var output = this.Get_CopyrightText(
                copyrightHolder,
                copyrightYear);

            return output;
        }

        public string Get_CopyrightText(string copyrightHolder)
        {
            var copyrightYear = Instances.NowOperator.Get_CurrentYear();

            var output = this.Get_CopyrightText(
                copyrightHolder,
                copyrightYear);

            return output;
        }
    }
}
