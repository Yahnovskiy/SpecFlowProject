using System.ComponentModel;

namespace SpecFlowProject.Helpers;

public static class ObjectToDictionaryHelper
{
    public static Dictionary<string, int> ToDictionary(this object source)
    {
        if (source == null)
            ThrowExceptionWhenSourceArgumentIsNull();

        var dictionary = new Dictionary<string, int>();
        foreach (PropertyDescriptor property in TypeDescriptor.GetProperties(source))
            AddPropertyToDictionary<int>(property, source, dictionary);
        return dictionary;
    }

    private static void AddPropertyToDictionary<T>(PropertyDescriptor property, object source, Dictionary<string, T> dictionary)
    {
        object value = property.GetValue(source);
        if (IsOfType<T>(value))
            dictionary.Add(property.Name, (T)value);
    }

    private static bool IsOfType<T>(object value)
    {
        return value is T;
    }

    private static void ThrowExceptionWhenSourceArgumentIsNull()
    {
        throw new ArgumentNullException("source", "Unable to convert object to a dictionary. The source object is null.");
    }
}