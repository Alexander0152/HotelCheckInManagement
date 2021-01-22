using System;
using System.Collections.Generic;
using System.Windows.Forms;



namespace Course_Work2
{
    public class Record : IRecord
    {
        public string Gender { get; set; }
        public string Date_IN { get; set; }
        public string Date_OUT { get; set; }
        public string Name { get; set; }
        public string Amount_of_persons_reserved { get; set; }
    }
    public class Room : IRoom
    {
        //public List<Data> Rooms { get; set; }
        private List<Record> records = new List<Record>();
        private string number;
        private string amount_of_persons;
        private string amount_of_rooms;
        private string type;
        private string price;

        public string Number
        {
            get
            {
                return number;
            }
            set
            {
                if (int.Parse(value) <= 0)
                {
                    MessageBox.Show("The wrong number", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                number = value;
            }
        }
        public string Amount_of_persons
        {
            get
            {
                return amount_of_persons;
            }
            set
            {
                if (int.Parse(value) <= 0 || int.Parse(value) > 3)
                {
                    MessageBox.Show(" The wrong amount of persons", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                amount_of_persons = value;
            }
        }
        public string Amount_of_rooms
        {
            get
            {
                return amount_of_rooms;
            }
            set
            {
                if (int.Parse(value) <= 0 || int.Parse(value) > 3)
                {
                    MessageBox.Show(" The wrong amount of rooms", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                amount_of_rooms = value;
            }
        }
        public string Type
        {
            get
            {
                return type;
            }
            set
            {
                if (value != "Economy" && value != "Lux" && value != "Vip" && value != "President")
                {
                    MessageBox.Show(" The wrong type of room", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                type = value;
            }
        }
        public string Price
        {
            get
            {
                return price;
            }
            set
            {
                if (int.Parse(value) <= 0 || int.Parse(value) > 5000)
                {
                    MessageBox.Show("The wrong price", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                price = value;
            }
        }
        public List<Record> Records
        {
            get
            {
                return records;
            }
        }

        public string GetInfo()
        {
            var result_basic = String.Empty;
            var result = String.Empty;
            if (records == null) return result;
            int index = 0;
            result_basic = String.Format("{0} Number: {1}\n", result, Number);
            foreach (Record record in records)
            {
                result = String.Format("{0} {1} - {2}    {3} ({4}, {5} persons)\n", result, record.Date_IN, record.Date_OUT, record.Name,
                    record.Gender, record.Amount_of_persons_reserved);
                index++;
            }
            result_basic += result;
            return result_basic;
        }
    }
}
