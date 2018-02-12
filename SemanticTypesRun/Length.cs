namespace SemanticTypesRun
{
    public partial struct Length
    {
        public static Length operator +(Length a, Length b)
        {
            return (a.Value + b.Value).AsLength();
        }

        public static Length operator -(Length a, Length b)
        {
            return (a.Value - b.Value).AsLength();
        }

        public static double operator /(Length a, Length b)
        {
            return a.Value / b.Value;
        }

        public static Area operator *(Length a, Length b)
        {
            return (a.Value * b.Value).AsArea();
        }
    }
}
