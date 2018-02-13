namespace SemanticTypes
{
    public interface ISemanticType
    {
        object Value { get; }
    }

    public interface ISemanticType<T>
    {
        T Value { get; }
    }
}
