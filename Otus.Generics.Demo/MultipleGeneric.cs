namespace Otus.Generics.Demo
{
    // Два обобщенных типа TKey и TValue
public class MyKeyValue<TKey, TValue>
{
    public MyKeyValue(TKey key, TValue value)
    {
        Key = key;
        Value = value;
    }
    public TKey Key { get; set; }
    public TValue Value { get; set; }

    public override string ToString()
    => $"Key={Key}, Value={Value}";
}
}