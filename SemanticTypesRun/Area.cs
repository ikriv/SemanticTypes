using System;

namespace SemanticTypesRun
{
    public partial struct Area
    {
        public Length Sqrt()
        {
            return Math.Sqrt(Value).AsLength();
        }
    }
}
