using System.Collections.Concurrent;

namespace DigitSymbolRecogniser.Helpers
{
    public static class ConcurentDictionaryHelper
    {
        public static void AddOrUpdate<TK, TV>(this ConcurrentDictionary<TK, TV> dictionary, TK key, TV value)
        {
            dictionary.AddOrUpdate(key, value, (oldkey, oldvalue) => value);
        }
    }
}
