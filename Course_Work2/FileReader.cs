using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Xml;
using System.Xml.Serialization;

namespace Course_Work2
{
    class FileReader
    {
        public static List<Room> ReadListFromFile(string filename)
        {
            List<Room> list = new List<Room>();
            XmlSerializer serializer = new XmlSerializer(typeof(List<Room>));
            using (Stream reader = new FileStream(filename, FileMode.Open))
            {
                list = (List<Room>)serializer.Deserialize(reader);
            }
            return list;
        }

        public static void WriteListToFile(List<Room> rooms, string filename)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(List<Room>));
            Stream fs = new FileStream(filename, FileMode.Create);
            XmlTextWriter writer = new XmlTextWriter(fs, Encoding.Unicode);
            writer.Formatting = Formatting.Indented;
            writer.Indentation = 4;
            serializer.Serialize(writer, rooms);
            writer.Close();
        }
    }
}
