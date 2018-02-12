namespace SemanticTypes
{
    public struct SemanticType<TTag, TValue>
    {
        public TValue Value { get; }

        public SemanticType(TValue value)
        {
            Value = value;
        }

        public SemanticType(SemanticType<TTag, TValue> other)
        {
            Value = other.Value;
        }

        public override int GetHashCode()
        {
            return Value != null ? Value.GetHashCode() : 0;
        }

        public override bool Equals(object obj)
        {
            if (obj is SemanticType<TTag, TValue>)
            {
                var other = (SemanticType<TTag, TValue>) obj;
                return Equals(Value, other.Value);
            }
            else
            {
                return false;
            }
        }

        public static bool operator ==(SemanticType<TTag, TValue> x, SemanticType<TTag, TValue> y)
        {
            return Equals(x.Value,y.Value);
        }

        public static bool operator !=(SemanticType<TTag, TValue> x, SemanticType<TTag, TValue> y)
        {
            return !Equals(x.Value, y.Value);
        }
    }

    public static partial class SemanticExtensions
    {
        public static SemanticType<TTag, TValue> As<TTag,TValue>(this TValue value)
        {
            return new SemanticType<TTag, TValue>(value);
        }
    }
}
