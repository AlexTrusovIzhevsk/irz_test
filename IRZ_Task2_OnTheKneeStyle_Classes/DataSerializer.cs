using System.IO;
using System.Xml.Serialization;

namespace IRZ_Task2_OnTheKneeStyle_Classes
{
    public static class DataSerializer
    {
        private static XmlSerializer xmlSerializer;

        static DataSerializer()
        {
            xmlSerializer = new XmlSerializer(typeof(Data));
        }

        public static void Writer(Data data, string path)
        {
            using (var fileStream = new FileStream(path, FileMode.Create))
            {
                xmlSerializer.Serialize(fileStream, data);
            }
        }

        public static Data Read(string path)
        {
            using (var fileStream = new FileStream(path, FileMode.Open))
            {
                return (Data) xmlSerializer.Deserialize(fileStream);
            }
        }
    }
}