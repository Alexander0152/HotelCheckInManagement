using System;
using System.Collections.Generic;
using System.Globalization;
using System.Windows.Forms;

namespace Course_Work2
{
    public partial class Form2 : Form
    {
        private List<Room> rooms;
        public const string Filename = "Rooms_data.xml";

        public Form2()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            RoomType.DropDownStyle = ComboBoxStyle.DropDownList;
            AmountOfPersons.DropDownStyle = ComboBoxStyle.DropDownList;
            AmountOfRooms.DropDownStyle = ComboBoxStyle.DropDownList;
            RoomNumber.DropDownStyle = ComboBoxStyle.DropDownList;
            DateIN.MinDate = DateTime.Now;
            DateOUT.MinDate = DateTime.Now.AddDays(1);
        }

        List<string> Check_Amount_Of_Rooms = new List<string>();
        List<string> Check_Room_Type = new List<string>();
        List<string> Check_Amount_Of_Persons = new List<string>();
        private void Form1_Load_1(object sender, EventArgs e)
        {
            rooms = FileReader.ReadListFromFile(Filename);

            foreach (Room current_room in rooms)
            {
                var row = new string[] { current_room.Number, current_room.Amount_of_persons, current_room.Amount_of_rooms,
                current_room.Type, current_room.Price};
                var lvi = new ListViewItem(row);
                lvi.Tag = current_room;
                listView1.Items.Add(lvi);
                //RoomNumber.Items.Add(current_room.Number);

                if (!(Check_Amount_Of_Rooms.Contains(current_room.Amount_of_rooms)))
                {
                    AmountOfRooms.Items.Add(current_room.Amount_of_rooms);
                    Check_Amount_Of_Rooms.Add(current_room.Amount_of_rooms);
                }

                if (!(Check_Room_Type.Contains(current_room.Type)))
                {
                    RoomType.Items.Add(current_room.Type);
                    Check_Room_Type.Add(current_room.Type);
                }

                if (!(Check_Amount_Of_Persons.Contains(current_room.Amount_of_persons)))
                {
                    AmountOfPersons.Items.Add(current_room.Amount_of_persons);
                    Check_Amount_Of_Persons.Add(current_room.Amount_of_persons);
                }
            }
        }

        private void button_WOC_Search_Click(object sender, EventArgs e)
        {
            bool check_fields = Utility.Check_fields(Get_Temp());
            if ((!radioButtonMale.Checked && !radioButtonFemale.Checked && !radioButtonFamily.Checked) || !check_fields)
            {
                MessageBox.Show("Not all options selected", "Error",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            listView1.Items.Clear();
            RoomNumber.Items.Clear();
            foreach (Room current_room in rooms)
            {
                bool check = Utility.Check_for_RoomNumber_only_by_date(current_room, Get_Gender(), Get_Temp());
                if (RoomType.SelectedItem == null && AmountOfRooms.SelectedItem == null && check)
                {
                    RoomNumber.Items.Add(current_room.Number);
                    var row = new string[] { current_room.Number, current_room.Amount_of_persons, current_room.Amount_of_rooms,
                            current_room.Type, current_room.Price};
                    var lvi = new ListViewItem(row);
                    lvi.Tag = current_room;
                    listView1.Items.Add(lvi);
                    return;
                }
                if (Utility.Check_for_RoomNumber(current_room, Get_Temp()))
                {
                    bool DateCompare = Utility.Date_Compare(current_room, DateIN.Value.Date, DateOUT.Value.Date);

                    if (current_room.Type == "Vip" || current_room.Type == "President")
                    {
                        if (DateCompare)
                        {
                            RoomNumber.Items.Add(current_room.Number);
                            var row = new string[] { current_room.Number, current_room.Amount_of_persons, current_room.Amount_of_rooms,
                            current_room.Type, current_room.Price};
                            var lvi = new ListViewItem(row);
                            lvi.Tag = current_room;
                            listView1.Items.Add(lvi);
                        }
                    }
                    else if (Utility.Check_for_RoomNumber_with_gender(current_room, Get_Temp(), Get_Gender()))
                    {
                        RoomNumber.Items.Add(current_room.Number);
                        var row = new string[] { current_room.Number, current_room.Amount_of_persons, current_room.Amount_of_rooms,
                            current_room.Type, current_room.Price};
                        var lvi = new ListViewItem(row);
                        lvi.Tag = current_room;
                        listView1.Items.Add(lvi);
                    }
                }
            }
        }

        private void button_WOC_Add_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(Name1.Text) || RoomNumber.SelectedItem == null)
            {
                MessageBox.Show("Enter the name and number!", "Error",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (RoomType.SelectedItem == null || AmountOfPersons.SelectedItem == null || AmountOfRooms.SelectedItem == null)
            {
                MessageBox.Show("Select room options!", "Error",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                foreach (ListViewItem item in listView1.Items)
                {
                    if (String.Compare(((Room)item.Tag).Number, (RoomNumber.SelectedItem).ToString(), true) == 0)
                    {
                        var current_record = new Record();
                        var current_room = (Room)item.Tag;

                        current_record.Date_IN = DateIN.Value.ToString("dd/MM/yyyy");
                        current_record.Date_OUT = DateOUT.Value.ToString("dd/MM/yyyy");
                        current_record.Gender = Get_Gender();
                        current_record.Name = Name1.Text;
                        current_record.Amount_of_persons_reserved = (AmountOfPersons.SelectedItem).ToString();
                        current_room.Records.Add(current_record);
                        break;
                    }
                }

                Clear_Comboboxes();

                listView1.Items.Clear();
                foreach (Room current_room in rooms)
                {
                    var row = new string[] { current_room.Number, current_room.Amount_of_persons, current_room.Amount_of_rooms,
                        current_room.Type, current_room.Price};
                    var lvi = new ListViewItem(row);
                    lvi.Tag = current_room;
                    listView1.Items.Add(lvi);
                }
                listView1.Items[int.Parse(RoomNumber.SelectedItem.ToString()) - 1].Selected = true;
                listView1.Select();


                FileReader.WriteListToFile(rooms, Filename);
                RoomNumber.Items.Clear();
            }
        }

        private void button_WOCRemove_Click(object sender, EventArgs e)
        {
            bool check = false;
            if (String.IsNullOrEmpty(Name1.Text))
            {
                MessageBox.Show("Enter the name!", "Error",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {//////////////////////////
                Clear_Comboboxes();

                listView1.Items.Clear();
                foreach (Room current_room in rooms)
                {
                    var row = new string[] { current_room.Number, current_room.Amount_of_persons, current_room.Amount_of_rooms,
                        current_room.Type, current_room.Price};
                    var lvi = new ListViewItem(row);
                    lvi.Tag = current_room;
                    listView1.Items.Add(lvi);
                }//////////////////
                foreach (ListViewItem item in listView1.Items)
                {
                    var current_room = (Room)item.Tag;
                    foreach (Record record in current_room.Records)
                    {
                        if (Utility.Date_Are_Equal(record, Get_Temp(), Name1.Text))
                        {
                            check = true;
                            current_room.Records.Remove(record);
                            break;
                        }
                    }
                }
                if (!check)
                {
                    MessageBox.Show("There are no such client in the list!", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                Clear_Comboboxes();
                listView1.Items.Clear();
                foreach (Room current_room in rooms)
                {
                    var row = new string[] { current_room.Number, current_room.Amount_of_persons, current_room.Amount_of_rooms,
                        current_room.Type, current_room.Price};
                    var lvi = new ListViewItem(row);
                    lvi.Tag = current_room;
                    listView1.Items.Add(lvi);
                }

                if (RoomNumber.SelectedItem != null)
                {
                    listView1.Items[int.Parse(RoomNumber.SelectedItem.ToString()) - 1].Selected = true;
                    listView1.Select();
                }

                FileReader.WriteListToFile(rooms, Filename);

                MessageBox.Show("The client was removed successfully", "Removed",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        public Temp Get_Temp()
        {
            var temp = new Temp();
            temp.DateIN = DateIN.Value;
            temp.DateOUT = DateOUT.Value;
            temp.AmountOfRooms = AmountOfRooms.SelectedItem;
            temp.RoomType = RoomType.SelectedItem;
            temp.RoomType = RoomType.SelectedItem;
            temp.AmountOfPersons = AmountOfPersons.SelectedItem;
            temp.RoomNumber = RoomNumber.SelectedItem;

            return temp;
        }

        private string Get_Gender()
        {
            string gender;
            if (radioButtonFemale.Checked == true)
            {
                gender = "female";
            }
            else if (radioButtonMale.Checked == true)
            {
                gender = "male";
            }
            else gender = "family";

            return gender;
        }

        private void listView1_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            if (listView1.SelectedItems.Count == 0) return;
            Room room = (Room)listView1.SelectedItems[0].Tag;

            DateBox.Text = rooms[rooms.IndexOf(room)].GetInfo();
        }

        private void radioButtonFamily_CheckedChanged(object sender, EventArgs e)
        {
            string number = "1";
            if (radioButtonFamily.Checked == true)
            {
                if (Check_Amount_Of_Persons.Contains(number))
                {
                    AmountOfPersons.Items.Remove(number);
                }
            }
            else if (Check_Amount_Of_Persons.Contains(number))
            {
                AmountOfPersons.Items.Insert(0, number);
            }
        }
        private void Clear_Comboboxes()
        {
            RoomType.SelectedIndex = -1;
            AmountOfPersons.SelectedIndex = -1;
            AmountOfRooms.SelectedIndex = -1;
        }

        private void RoomNumber_SelectedIndexChanged(object sender, EventArgs e)
        {
            int period = Utility.Get_Period(Get_Temp());
            string cost_result = Utility.Get_Prise(Get_Temp(), Get_Gender(), rooms).ToString();
            PriseBox.Text = String.Format("{0} days\n{1}$", period, cost_result);
        }

        private void RoomType_Click(object sender, EventArgs e)
        {
            RoomNumber.Items.Clear();
            Name1.Clear();
        }

        private void AmountOfPersons_Click(object sender, EventArgs e)
        {
            RoomNumber.Items.Clear();
            Name1.Clear();
        }

        private void AmountOfRooms_Click(object sender, EventArgs e)
        {
            RoomNumber.Items.Clear();
            Name1.Clear();
        }

        private void DateIN_ValueChanged(object sender, EventArgs e)
        {
            DateOUT.MinDate = DateIN.Value.AddDays(1);
        }

        private void button_WOCShowCatalog_Click(object sender, EventArgs e)
        {
            Form myForm = new Form1();
            myForm.ShowDialog();
        }
    }
}
