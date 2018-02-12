


namespace SemanticTypesRun
{
    public struct Length
    {
        public double Value { get; }

        public Length(double value)
        {
            Value = value;
        }

        public Length(Length other)
        {
            Value = other.Value;
        }

        public override int GetHashCode()
        {
            return Value.GetHashCode();
        }

        public override bool Equals(object obj)
        {
            if (obj is Length)
            {
                var other = (Length) obj;
                return Equals(Value, other.Value);
            }
            else
            {
                return false;
            }
        }

        public static bool operator ==(Length x, Length y)
        {
            return Equals(x.Value,y.Value);
        }

        public static bool operator !=(Length x, Length y)
        {
            return !Equals(x.Value, y.Value);
        }
    }

    public static partial class SemanticExtensions
    {
        public static Length AsLength(this double value)
        {
            return new Length(value);
        }
    }
}
namespace SemanticTypesRun
{
    public struct Weight
    {
        public double Value { get; }

        public Weight(double value)
        {
            Value = value;
        }

        public Weight(Weight other)
        {
            Value = other.Value;
        }

        public override int GetHashCode()
        {
            return Value.GetHashCode();
        }

        public override bool Equals(object obj)
        {
            if (obj is Weight)
            {
                var other = (Weight) obj;
                return Equals(Value, other.Value);
            }
            else
            {
                return false;
            }
        }

        public static bool operator ==(Weight x, Weight y)
        {
            return Equals(x.Value,y.Value);
        }

        public static bool operator !=(Weight x, Weight y)
        {
            return !Equals(x.Value, y.Value);
        }
    }

    public static partial class SemanticExtensions
    {
        public static Weight AsWeight(this double value)
        {
            return new Weight(value);
        }
    }
}
namespace SemanticTypesRun
{
    public struct Email
    {
        public string Value { get; }

        public Email(string value)
        {
            Value = value;
        }

        public Email(Email other)
        {
            Value = other.Value;
        }

        public override int GetHashCode()
        {
            return Value != null ? Value.GetHashCode() : 0;
        }

        public override bool Equals(object obj)
        {
            if (obj is Email)
            {
                var other = (Email) obj;
                return Equals(Value, other.Value);
            }
            else
            {
                return false;
            }
        }

        public static bool operator ==(Email x, Email y)
        {
            return Equals(x.Value,y.Value);
        }

        public static bool operator !=(Email x, Email y)
        {
            return !Equals(x.Value, y.Value);
        }
    }

    public static partial class SemanticExtensions
    {
        public static Email AsEmail(this string value)
        {
            return new Email(value);
        }
    }
}

