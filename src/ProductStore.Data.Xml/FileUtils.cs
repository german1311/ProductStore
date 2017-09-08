using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Xml.Serialization;

namespace ProductStore.Data.Xml
{
    //todo: Should me part of Common/util proj
    public static class FileUtils<T>
    {
        static readonly IFormatter _formatter = new BinaryFormatter();

        public static T DeserializedFromBinary(string fileName)
        {
            if (File.Exists(fileName))
            {
                using (Stream inStream = new FileStream(fileName, FileMode.Open, FileAccess.Read, FileShare.Read))
                {
                    T obj = (T)_formatter.Deserialize(inStream);

                    return obj;
                }
            }

            return default(T);
        }

        //override if it exists
        public static void SerializedAsBinary(T obj, string fileName)
        {
            using (Stream outStream = new FileStream(fileName, FileMode.Create, FileAccess.Write, FileShare.None))
            {
                _formatter.Serialize(outStream, obj);
            }
        }

        public static void SerializeToXML(T obj, string filename)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(T));
            using (TextWriter writer = new StreamWriter(filename))
            {
                serializer.Serialize(writer, obj);
            }
        }
        
        //override if it exists
        public static T DeserializeFromXML(string fileName)
        {
            if (File.Exists(fileName))
            {
                var deserializer = new XmlSerializer(typeof(T));
                using (var reader = new StreamReader(fileName))
                {
                    var obj = deserializer.Deserialize(reader);
                    var xmlData = (T) obj;
                    reader.Close();
                    return xmlData;
                }
            }

            return default(T);
        }
    }
}
