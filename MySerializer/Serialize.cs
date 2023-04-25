using System.Text.Json;
using System.IO;

//openxmlsdk

namespace MySerializer
{
    public static class Serialize
    {
        public static string DoSerializationToString<T>(this T Info) where T : class
        {
            var SerializedInfo = JsonSerializer.Serialize(Info);

            return SerializedInfo;
        }
        public static void DoSerialization<T>(this T Info, string path) where T : class
        {
            FileStream fs = new FileStream(path, FileMode.OpenOrCreate);
            JsonSerializer.SerializeAsync(fs, Info);
            fs.Close();
        }

        public static T DoDeserializationFromString<T>(this T DeserializedInfo, string Info) where T : class
        {
                DeserializedInfo = JsonSerializer.Deserialize<T>(Info);

                return DeserializedInfo;
        }
        public static T DoDeserialization<T>(this T DeserializedInfo, string path) where T : class
        {
            using (StreamReader sr = new StreamReader(path))
            {
                string InfoFromJson = sr.ReadToEnd();
                sr.Close();

                DeserializedInfo = JsonSerializer.Deserialize<T>(InfoFromJson);

                return DeserializedInfo;
            }
        }
    }
}
