namespace LearningHub.Nhs.Models.Search
{
    using System;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    /// <summary>
    /// Method to determine type for JSON element.
    /// </summary>
    /// <typeparam name="T">The type.</typeparam>
    public class SingleOrArrayConverter<T> : JsonConverter
    {
        /// <summary>
        /// Gets a value indicating whether JSON object can be written.
        /// </summary>
        public override bool CanWrite
        {
            get { return true; }
        }

        /// <summary>
        /// Method to determine if Type can be converted.
        /// </summary>
        /// <param name="objectType">
        /// The objectType.
        /// </param>
        /// <returns>
        /// Indicates whether can convert.
        /// </returns>
        public override bool CanConvert(Type objectType)
        {
            return objectType == typeof(List<T>);
        }

        /// <summary>
        /// Method to read the JSON object.
        /// </summary>
        /// <param name="reader">
        /// The reader.
        /// </param>
        /// <param name="objectType">
        /// The objectType.
        /// </param>
        /// <param name="existingValue">
        /// The existingValue.
        /// </param>
        /// <param name="serializer">
        /// The serializer.
        /// </param>
        /// <returns>
        /// Output object.
        /// </returns>
        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            JToken token = JToken.Load(reader);
            if (token.Type == JTokenType.Array)
            {
                return token.ToObject<List<T>>();
            }

            return new List<T> { token.ToObject<T>() };
        }

        /// <summary>
        /// Method to write the JSON object.
        /// </summary>
        /// <param name="writer">
        /// The writer.
        /// </param>
        /// <param name="value">
        /// The value.
        /// </param>
        /// <param name="serializer">
        /// The serializer.
        /// </param>
        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            List<T> list = (List<T>)value;
            if (list.Count == 1)
            {
                value = list[0];
            }

            serializer.Serialize(writer, value);
        }
    }
}
