using System.ComponentModel;

namespace SpecFlowProject.Helpers
{
    public static class ObjectToDictionaryHelper
    {
        public static Dictionary<string, object> ToDictionary(this object source)
        {
            if (source == null)
            {
                ThrowExceptionWhenSourceArgumentIsNull();
            }

            var dictionary = new Dictionary<string, object>();
            foreach (PropertyDescriptor property in TypeDescriptor.GetProperties(source))
            {
                AddPropertyToDictionary(property, source, dictionary);
            }
            return dictionary;
        }

        private static void AddPropertyToDictionary(PropertyDescriptor property, object source, Dictionary<string, object> dictionary)
        {
            object value = property.GetValue(source);
            if (value is not null)
            {
                dictionary.Add(property.Name, value);
            }
        }

        private static void ThrowExceptionWhenSourceArgumentIsNull()
        {
            throw new ArgumentNullException("source", "Unable to convert object to a dictionary. The source object is null.");
        }
    }
}