using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

namespace ProductStore.Data.Xml
{
    //todo: Should me part of Common/util proj
    public static class FileUtils<T>
    {
        static readonly IFormatter iformatter = new BinaryFormatter();

        public static T DeserializedFromBinary(string filename)
        {
            if (File.Exists(filename))
            {
                using (Stream inStream = new FileStream(filename, FileMode.Open, FileAccess.Read, FileShare.Read))
                {
                    T obj = (T)iformatter.Deserialize(inStream);

                    return obj;
                }
            }

            return default(T);
        }

        //override if it exists
        public static void SerializedAsBinary(T obj, string filename)
        {
            using (Stream outStream = new FileStream(filename, FileMode.Create, FileAccess.Write, FileShare.None))
            {
                iformatter.Serialize(outStream, obj);
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
            var deserializer = new XmlSerializer(typeof(T));
            using (var reader = new StreamReader(fileName))
            {
                var obj = deserializer.Deserialize(reader);
                var xmlData = (T)obj;
                reader.Close();
                return xmlData;
            }
        }
    }
}
