using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

public static class DictionaryExtensionMethods
{
    public static void Add<TKey, TValue>(this Dictionary<TKey, TValue> dic, KeyValuePair<TKey, TValue> entry)
    {
        dic.Add(entry.Key,entry.Value);
    }
    public static void Add<TKey, TValue>(this Dictionary<TKey, TValue> dic, IEnumerable<KeyValuePair<TKey, TValue>> entry)
    {
        entry.ForEach(e => dic.Add(e));
    }
    public static void AddRangeOverride<TKey, TValue>(this Dictionary<TKey, TValue> dic, Dictionary<TKey, TValue> dicToAdd)
    {
        dicToAdd.ForEach(x => dic[x.Key] = x.Value);
    }

    public static void AddRangeNewOnly<TKey, TValue>(this Dictionary<TKey, TValue> dic, Dictionary<TKey, TValue> dicToAdd)
    {
        dicToAdd.ForEach(x => { if (!dic.ContainsKey(x.Key)) dic.Add(x.Key, x.Value); });
    }
    public static void AddRangeNewOnly<TKey, TValue>(this Dictionary<TKey, TValue> dic, KeyValuePair<TKey, TValue> entry)
    {
        if (!dic.ContainsKey(entry.Key))
            dic.Add(entry.Key, entry.Value);
    }

    public static void AddRangeNewOnly<TKey, TValue>(this Dictionary<TKey, TValue> dic, IEnumerable<KeyValuePair<TKey, TValue>> dicToAdd)
    {
        dicToAdd.ForEach(x => { if (!dic.ContainsKey(x.Key)) dic.Add(x.Key, x.Value); });
    }
    public static void AddRange<TKey, TValue>(this Dictionary<TKey, TValue> dic, Dictionary<TKey, TValue> dicToAdd)
    {
        dicToAdd.ForEach(x => dic.Add(x.Key, x.Value));
    }

    public static bool ContainsKeys<TKey, TValue>(this Dictionary<TKey, TValue> dic, IEnumerable<TKey> keys)
    {
        bool result = false;
        keys.ForEachOrBreak((x) => { result = dic.ContainsKey(x); return result; });
        return result;
    }

    public static void ForEach<T>(this IEnumerable<T> source, Action<T> action)
    {
        foreach (var item in source)
            action(item);
    }

    public static void ForEachOrBreak<T>(this IEnumerable<T> source, Func<T, bool> func)
    {
        foreach (var item in source)
        {
            bool result = func(item);
            if (result) break;
        }
    }
    /// <summary>
    ///  ref types like like list compare by reference and will always fail.
    ///  An IEqualityComparer must be made later on
    /// </summary>
    /// <typeparam name="TKey"></typeparam>
    /// <typeparam name="TValue"></typeparam>
    /// <param name="dictionary"></param>
    /// <param name="otherDictionary"></param>
    /// <returns></returns>
    public static bool ContentEquals<TKey, TValue>(this Dictionary<TKey, TValue> dictionary, Dictionary<TKey, TValue> otherDictionary)
    {
        return (otherDictionary ?? new Dictionary<TKey, TValue>())
            .OrderBy(kvp => kvp.Key)
            .SequenceEqual((dictionary ?? new Dictionary<TKey, TValue>())
                               .OrderBy(kvp => kvp.Key));
    }
}