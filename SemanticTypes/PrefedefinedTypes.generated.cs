
namespace SemanticTypes
{
    public struct SString<TTag>
    {
        public string Value { get; }

        public SString(string value)
        {
            Value = value;
        }

        public SString(SString<TTag> other)
        {
            Value = other.Value;
        }

        public override int GetHashCode()
        {
            return Value != null ? Value.GetHashCode() : 0;
        }

        public override bool Equals(object obj)
        {
            if (obj is SString<TTag>)
            {
                var other = (SString<TTag>) obj;
                return Equals(Value, other.Value);
            }
            else
            {
                return false;
            }
        }

        public static bool operator ==(SString<TTag> x, SString<TTag> y)
        {
            return Equals(x.Value,y.Value);
        }

        public static bool operator !=(SString<TTag> x, SString<TTag> y)
        {
            return !Equals(x.Value, y.Value);
        }

        public override string ToString()
        {
            if (Value == null) return "";
            return Value.ToString();
        }
    }

    public static partial class SemanticExtensions
    {
        public static SString<TTag> As<TTag>(this string value)
        {
            return new SString<TTag>(value);
        }
    }
}
namespace SemanticTypes
{
    public struct SInt<TTag>
    {
        public int Value { get; }

        public SInt(int value)
        {
            Value = value;
        }

        public SInt(SInt<TTag> other)
        {
            Value = other.Value;
        }

        public override int GetHashCode()
        {
            return Value.GetHashCode();
        }

        public override bool Equals(object obj)
        {
            if (obj is SInt<TTag>)
            {
                var other = (SInt<TTag>) obj;
                return Equals(Value, other.Value);
            }
            else
            {
                return false;
            }
        }

        public static bool operator ==(SInt<TTag> x, SInt<TTag> y)
        {
            return Equals(x.Value,y.Value);
        }

        public static bool operator !=(SInt<TTag> x, SInt<TTag> y)
        {
            return !Equals(x.Value, y.Value);
        }

        public override string ToString()
        {
            if (Value == null) return "";
            return Value.ToString();
        }
    }

    public static partial class SemanticExtensions
    {
        public static SInt<TTag> As<TTag>(this int value)
        {
            return new SInt<TTag>(value);
        }
    }
}
namespace SemanticTypes
{
    public struct SDouble<TTag>
    {
        public double Value { get; }

        public SDouble(double value)
        {
            Value = value;
        }

        public SDouble(SDouble<TTag> other)
        {
            Value = other.Value;
        }

        public override int GetHashCode()
        {
            return Value.GetHashCode();
        }

        public override bool Equals(object obj)
        {
            if (obj is SDouble<TTag>)
            {
                var other = (SDouble<TTag>) obj;
                return Equals(Value, other.Value);
            }
            else
            {
                return false;
            }
        }

        public static bool operator ==(SDouble<TTag> x, SDouble<TTag> y)
        {
            return Equals(x.Value,y.Value);
        }

        public static bool operator !=(SDouble<TTag> x, SDouble<TTag> y)
        {
            return !Equals(x.Value, y.Value);
        }

        public override string ToString()
        {
            if (Value == null) return "";
            return Value.ToString();
        }
    }

    public static partial class SemanticExtensions
    {
        public static SDouble<TTag> As<TTag>(this double value)
        {
            return new SDouble<TTag>(value);
        }
    }
}

