namespace HashTable;

public class KeyValuePair<TKey, TValue>
{
    public TKey Key { get; set; }
    
    public TValue Value { get; set; }

    public KeyValuePair(TKey key, TValue value)
    {
        Key = key;
        Value = value;
    }
}