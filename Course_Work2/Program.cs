using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;
using System.Xml;
using System.IO;
using System.Text;

namespace Course_Work2
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {        /*   
            List<Room> rooms = new List<Room>();
            var room = new Room();
            rooms.Add(room);
            rooms[0].Amount_of_persons = "3";
            rooms[0].Amount_of_rooms = "3";
            rooms[0].Number = "999";
            rooms[0].Type = "Vip";
            rooms[0].Price = "500";

            var record = new Record();
            //rooms[0].Records.Add(record);
            //rooms[0].Records[0].Date_IN = "01.01.2019";
           //rooms[0].Records[0].Date_OUT = "02.01.2019";
            //rooms[0].Records[0].Gender = "male";
            //rooms[0].Records[0].Name = "Alexander";
           // rooms[0].Records[0].Amount_of_persons_reserved = "3";

            XmlSerializer serializer = new XmlSerializer(typeof(List<Room>));
            Stream fs = new FileStream("Rooms_data.xml", FileMode.Create);
            XmlTextWriter writer = new XmlTextWriter(fs, Encoding.Unicode);
            writer.Formatting = Formatting.Indented;
            writer.Indentation = 4;
            serializer.Serialize(writer, rooms);
            writer.Close();
           */
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            Application.Run(new Form2());
            //Form
     
        }
    }
}
