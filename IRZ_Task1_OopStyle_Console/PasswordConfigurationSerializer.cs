using System;
using System.IO;
using System.Xml.Serialization;


namespace IRZ_Task1_OopStyle_Classes
{
    public static class PasswordConfigurationSerializer
    {
        private static XmlSerializer xmlSerializer;

        static PasswordConfigurationSerializer()
        {
            var type = typeof(PasswordValidateConfiguration);
            xmlSerializer = new XmlSerializer(type);
        }

        public static void Writer(PasswordValidateConfiguration configuration, string path)
        {
            try
            {
                using (var fileStream = new FileStream(path, FileMode.Create))
                {
                    xmlSerializer.Serialize(fileStream, configuration);
                }
            }
            catch (Exception e)
            {
                throw new Exception("Error while writing and serialize configuration. ", e);
            }
        }

        public static PasswordValidateConfiguration Read(string path)
        {
            try
            {
                using (var fileStream = new FileStream(path, FileMode.Open))
                {
                    return (PasswordValidateConfiguration)xmlSerializer.Deserialize(fileStream);
                }
            }
            catch (Exception e)
            {
                throw new Exception("Error while reading and deserialize configuration. ", e);
            }
        }
    }
}
