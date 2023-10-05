using System;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

public class NullToEmptyStringConverter : JsonConverter
{
    public override bool CanConvert(Type objectType)
    {
        return objectType == typeof(string);
    }

    public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
    {
        throw new NotImplementedException();
    }

    public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
    {
        if (value == null)
        {
            writer.WriteValue("");
        }
        else
        {
            writer.WriteValue(value);
        }
    }
}

public class MyClass
{
    [JsonConverter(typeof(NullToEmptyStringConverter))]
    public string MyString { get; set; }
}

