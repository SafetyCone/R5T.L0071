using System;


namespace R5T.L0071
{
    public static class Instances
    {
        public static L0066.IDateTimeOperator DateTimeOperator => L0066.DateTimeOperator.Instance;
        public static L0066.INowOperator NowOperator => L0066.NowOperator.Instance;
        public static L0066.IStrings Strings => L0066.Strings.Instance;
    }
}