namespace Course_Work2
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.listView1 = new System.Windows.Forms.ListView();
            this.Number = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Amount_of_persons = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Amount_of_rooms = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Type = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Price = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.DateIN = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.DateOUT = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.RoomType = new System.Windows.Forms.ComboBox();
            this.RoomNumber = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.AmountOfRooms = new System.Windows.Forms.ComboBox();
            this.Name1 = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.radioButtonFamily = new System.Windows.Forms.RadioButton();
            this.radioButtonFemale = new System.Windows.Forms.RadioButton();
            this.radioButtonMale = new System.Windows.Forms.RadioButton();
            this.label10 = new System.Windows.Forms.Label();
            this.AmountOfPersons = new System.Windows.Forms.ComboBox();
            this.button_WOC_Search = new ePOSOne.btnProduct.Button_WOC();
            this.label8 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.label9 = new System.Windows.Forms.Label();
            this.DateBox = new System.Windows.Forms.RichTextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.contextMenuStrip2 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.contextMenuStrip3 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.contextMenuStrip4 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.contextMenuStrip5 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.label11 = new System.Windows.Forms.Label();
            this.PriseBox = new System.Windows.Forms.RichTextBox();
            this.button_WOCCatalog = new ePOSOne.btnProduct.Button_WOC();
            this.button_WOCRemove = new ePOSOne.btnProduct.Button_WOC();
            this.button_WOC_Add = new ePOSOne.btnProduct.Button_WOC();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Khaki;
            this.label1.Location = new System.Drawing.Point(48, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(511, 51);
            this.label1.TabIndex = 0;
            this.label1.Text = "Manage Reservations";
            // 
            // listView1
            // 
            this.listView1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listView1.BackColor = System.Drawing.SystemColors.Info;
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Number,
            this.Amount_of_persons,
            this.Amount_of_rooms,
            this.Type,
            this.Price});
            this.listView1.Font = new System.Drawing.Font("Britannic Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listView1.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.listView1.FullRowSelect = true;
            this.listView1.GridLines = true;
            this.listView1.HideSelection = false;
            this.listView1.LabelEdit = true;
            this.listView1.Location = new System.Drawing.Point(625, 31);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(636, 539);
            this.listView1.TabIndex = 1;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.listView1_ItemSelectionChanged);
            // 
            // Number
            // 
            this.Number.Text = "Number";
            this.Number.Width = 71;
            // 
            // Amount_of_persons
            // 
            this.Amount_of_persons.Text = "Amount of persons";
            this.Amount_of_persons.Width = 144;
            // 
            // Amount_of_rooms
            // 
            this.Amount_of_rooms.Text = "Amount of rooms";
            this.Amount_of_rooms.Width = 146;
            // 
            // Type
            // 
            this.Type.Text = "Type";
            this.Type.Width = 146;
            // 
            // Price
            // 
            this.Price.Text = "Price for 1 day";
            this.Price.Width = 172;
            // 
            // DateIN
            // 
            this.DateIN.CustomFormat = "";
            this.DateIN.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DateIN.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DateIN.Location = new System.Drawing.Point(212, 232);
            this.DateIN.MinDate = new System.DateTime(2019, 11, 15, 0, 0, 0, 0);
            this.DateIN.Name = "DateIN";
            this.DateIN.Size = new System.Drawing.Size(200, 26);
            this.DateIN.TabIndex = 2;
            this.DateIN.Value = new System.DateTime(2019, 11, 15, 0, 0, 0, 0);
            this.DateIN.ValueChanged += new System.EventHandler(this.DateIN_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Khaki;
            this.label2.Location = new System.Drawing.Point(57, 238);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 23);
            this.label2.TabIndex = 3;
            this.label2.Text = "Date IN: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Khaki;
            this.label3.Location = new System.Drawing.Point(44, 274);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 23);
            this.label3.TabIndex = 4;
            this.label3.Text = "Date OUT:";
            // 
            // DateOUT
            // 
            this.DateOUT.CalendarMonthBackground = System.Drawing.Color.Gold;
            this.DateOUT.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DateOUT.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DateOUT.Location = new System.Drawing.Point(212, 264);
            this.DateOUT.MinDate = new System.DateTime(2019, 11, 15, 0, 0, 0, 0);
            this.DateOUT.Name = "DateOUT";
            this.DateOUT.Size = new System.Drawing.Size(200, 26);
            this.DateOUT.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Khaki;
            this.label4.Location = new System.Drawing.Point(44, 120);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(126, 23);
            this.label4.TabIndex = 6;
            this.label4.Text = "Room Type:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Khaki;
            this.label5.Location = new System.Drawing.Point(30, 444);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(160, 23);
            this.label5.TabIndex = 7;
            this.label5.Text = "Room Number:";
            // 
            // RoomType
            // 
            this.RoomType.BackColor = System.Drawing.Color.NavajoWhite;
            this.RoomType.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RoomType.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.RoomType.Location = new System.Drawing.Point(212, 112);
            this.RoomType.Name = "RoomType";
            this.RoomType.Size = new System.Drawing.Size(200, 31);
            this.RoomType.TabIndex = 11;
            this.RoomType.Click += new System.EventHandler(this.RoomType_Click);
            // 
            // RoomNumber
            // 
            this.RoomNumber.BackColor = System.Drawing.SystemColors.Info;
            this.RoomNumber.Font = new System.Drawing.Font("Gill Sans Ultra Bold Condensed", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RoomNumber.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.RoomNumber.FormattingEnabled = true;
            this.RoomNumber.Location = new System.Drawing.Point(211, 440);
            this.RoomNumber.Name = "RoomNumber";
            this.RoomNumber.Size = new System.Drawing.Size(200, 28);
            this.RoomNumber.TabIndex = 12;
            this.RoomNumber.SelectedIndexChanged += new System.EventHandler(this.RoomNumber_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Khaki;
            this.label6.Location = new System.Drawing.Point(66, 509);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 23);
            this.label6.TabIndex = 13;
            this.label6.Text = "Name:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Khaki;
            this.label7.Location = new System.Drawing.Point(12, 197);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(194, 23);
            this.label7.TabIndex = 14;
            this.label7.Text = "Amount of rooms:";
            // 
            // AmountOfRooms
            // 
            this.AmountOfRooms.BackColor = System.Drawing.Color.NavajoWhite;
            this.AmountOfRooms.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AmountOfRooms.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.AmountOfRooms.Location = new System.Drawing.Point(212, 197);
            this.AmountOfRooms.Name = "AmountOfRooms";
            this.AmountOfRooms.Size = new System.Drawing.Size(200, 31);
            this.AmountOfRooms.TabIndex = 15;
            this.AmountOfRooms.Click += new System.EventHandler(this.AmountOfRooms_Click);
            // 
            // Name1
            // 
            this.Name1.BackColor = System.Drawing.SystemColors.Info;
            this.Name1.Font = new System.Drawing.Font("Gill Sans Ultra Bold Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name1.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.Name1.Location = new System.Drawing.Point(211, 509);
            this.Name1.Name = "Name1";
            this.Name1.Size = new System.Drawing.Size(200, 27);
            this.Name1.TabIndex = 16;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.radioButtonFamily);
            this.panel1.Controls.Add(this.radioButtonFemale);
            this.panel1.Controls.Add(this.radioButtonMale);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.AmountOfPersons);
            this.panel1.Controls.Add(this.button_WOC_Search);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.RoomType);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.AmountOfRooms);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.DateIN);
            this.panel1.Controls.Add(this.DateOUT);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Location = new System.Drawing.Point(7, 73);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(587, 311);
            this.panel1.TabIndex = 18;
            // 
            // radioButtonFamily
            // 
            this.radioButtonFamily.AutoSize = true;
            this.radioButtonFamily.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonFamily.ForeColor = System.Drawing.Color.Khaki;
            this.radioButtonFamily.Location = new System.Drawing.Point(274, 72);
            this.radioButtonFamily.Name = "radioButtonFamily";
            this.radioButtonFamily.Size = new System.Drawing.Size(93, 27);
            this.radioButtonFamily.TabIndex = 24;
            this.radioButtonFamily.TabStop = true;
            this.radioButtonFamily.Text = "Family";
            this.radioButtonFamily.UseVisualStyleBackColor = true;
            this.radioButtonFamily.CheckedChanged += new System.EventHandler(this.radioButtonFamily_CheckedChanged);
            // 
            // radioButtonFemale
            // 
            this.radioButtonFemale.AutoSize = true;
            this.radioButtonFemale.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonFemale.ForeColor = System.Drawing.Color.Khaki;
            this.radioButtonFemale.Location = new System.Drawing.Point(127, 72);
            this.radioButtonFemale.Name = "radioButtonFemale";
            this.radioButtonFemale.Size = new System.Drawing.Size(97, 27);
            this.radioButtonFemale.TabIndex = 22;
            this.radioButtonFemale.TabStop = true;
            this.radioButtonFemale.Text = "Female";
            this.radioButtonFemale.UseVisualStyleBackColor = true;
            // 
            // radioButtonMale
            // 
            this.radioButtonMale.AutoSize = true;
            this.radioButtonMale.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonMale.ForeColor = System.Drawing.Color.Khaki;
            this.radioButtonMale.Location = new System.Drawing.Point(25, 72);
            this.radioButtonMale.Name = "radioButtonMale";
            this.radioButtonMale.Size = new System.Drawing.Size(73, 27);
            this.radioButtonMale.TabIndex = 20;
            this.radioButtonMale.TabStop = true;
            this.radioButtonMale.Text = "Male";
            this.radioButtonMale.UseVisualStyleBackColor = true;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Khaki;
            this.label10.Location = new System.Drawing.Point(21, 35);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(89, 23);
            this.label10.TabIndex = 18;
            this.label10.Text = "Gender:";
            // 
            // AmountOfPersons
            // 
            this.AmountOfPersons.BackColor = System.Drawing.Color.NavajoWhite;
            this.AmountOfPersons.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AmountOfPersons.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.AmountOfPersons.Location = new System.Drawing.Point(212, 156);
            this.AmountOfPersons.Name = "AmountOfPersons";
            this.AmountOfPersons.Size = new System.Drawing.Size(200, 31);
            this.AmountOfPersons.TabIndex = 17;
            this.AmountOfPersons.Click += new System.EventHandler(this.AmountOfPersons_Click);
            // 
            // button_WOC_Search
            // 
            this.button_WOC_Search.BackColor = System.Drawing.Color.Transparent;
            this.button_WOC_Search.BorderColor = System.Drawing.Color.Gold;
            this.button_WOC_Search.ButtonColor = System.Drawing.Color.Blue;
            this.button_WOC_Search.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_WOC_Search.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_WOC_Search.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button_WOC_Search.Location = new System.Drawing.Point(429, 232);
            this.button_WOC_Search.Name = "button_WOC_Search";
            this.button_WOC_Search.OnHoverBorderColor = System.Drawing.Color.DarkKhaki;
            this.button_WOC_Search.OnHoverButtonColor = System.Drawing.Color.Yellow;
            this.button_WOC_Search.OnHoverTextColor = System.Drawing.Color.Black;
            this.button_WOC_Search.Size = new System.Drawing.Size(137, 62);
            this.button_WOC_Search.TabIndex = 23;
            this.button_WOC_Search.Text = "Search";
            this.button_WOC_Search.TextColor = System.Drawing.Color.White;
            this.button_WOC_Search.UseVisualStyleBackColor = false;
            this.button_WOC_Search.Click += new System.EventHandler(this.button_WOC_Search_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Khaki;
            this.label8.Location = new System.Drawing.Point(3, 161);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(210, 23);
            this.label8.TabIndex = 16;
            this.label8.Text = "Amount of persons:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Khaki;
            this.label9.Location = new System.Drawing.Point(621, 593);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(170, 26);
            this.label9.TabIndex = 21;
            this.label9.Text = "Number info:";
            // 
            // DateBox
            // 
            this.DateBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DateBox.BackColor = System.Drawing.SystemColors.Info;
            this.DateBox.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DateBox.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.DateBox.Location = new System.Drawing.Point(625, 626);
            this.DateBox.Name = "DateBox";
            this.DateBox.Size = new System.Drawing.Size(636, 96);
            this.DateBox.TabIndex = 22;
            this.DateBox.Text = "";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // contextMenuStrip2
            // 
            this.contextMenuStrip2.Name = "contextMenuStrip2";
            this.contextMenuStrip2.Size = new System.Drawing.Size(61, 4);
            // 
            // contextMenuStrip3
            // 
            this.contextMenuStrip3.Name = "contextMenuStrip3";
            this.contextMenuStrip3.Size = new System.Drawing.Size(61, 4);
            // 
            // contextMenuStrip4
            // 
            this.contextMenuStrip4.Name = "contextMenuStrip4";
            this.contextMenuStrip4.Size = new System.Drawing.Size(61, 4);
            // 
            // contextMenuStrip5
            // 
            this.contextMenuStrip5.Name = "contextMenuStrip5";
            this.contextMenuStrip5.Size = new System.Drawing.Size(61, 4);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Khaki;
            this.label11.Location = new System.Drawing.Point(485, 445);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(66, 23);
            this.label11.TabIndex = 24;
            this.label11.Text = "Total:";
            // 
            // PriseBox
            // 
            this.PriseBox.BackColor = System.Drawing.SystemColors.Info;
            this.PriseBox.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PriseBox.ForeColor = System.Drawing.Color.LimeGreen;
            this.PriseBox.Location = new System.Drawing.Point(461, 472);
            this.PriseBox.Name = "PriseBox";
            this.PriseBox.ReadOnly = true;
            this.PriseBox.Size = new System.Drawing.Size(114, 64);
            this.PriseBox.TabIndex = 25;
            this.PriseBox.Text = "";
            // 
            // button_WOCCatalog
            // 
            this.button_WOCCatalog.BorderColor = System.Drawing.Color.Yellow;
            this.button_WOCCatalog.ButtonColor = System.Drawing.Color.DarkRed;
            this.button_WOCCatalog.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_WOCCatalog.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_WOCCatalog.Location = new System.Drawing.Point(403, 626);
            this.button_WOCCatalog.Name = "button_WOCCatalog";
            this.button_WOCCatalog.OnHoverBorderColor = System.Drawing.Color.DarkKhaki;
            this.button_WOCCatalog.OnHoverButtonColor = System.Drawing.Color.Yellow;
            this.button_WOCCatalog.OnHoverTextColor = System.Drawing.Color.Black;
            this.button_WOCCatalog.Size = new System.Drawing.Size(172, 60);
            this.button_WOCCatalog.TabIndex = 27;
            this.button_WOCCatalog.Text = "Show Catalog";
            this.button_WOCCatalog.TextColor = System.Drawing.Color.White;
            this.button_WOCCatalog.UseVisualStyleBackColor = true;
            this.button_WOCCatalog.Click += new System.EventHandler(this.button_WOCShowCatalog_Click);
            // 
            // button_WOCRemove
            // 
            this.button_WOCRemove.BorderColor = System.Drawing.Color.Yellow;
            this.button_WOCRemove.ButtonColor = System.Drawing.Color.DodgerBlue;
            this.button_WOCRemove.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_WOCRemove.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_WOCRemove.Location = new System.Drawing.Point(204, 626);
            this.button_WOCRemove.Name = "button_WOCRemove";
            this.button_WOCRemove.OnHoverBorderColor = System.Drawing.Color.DarkKhaki;
            this.button_WOCRemove.OnHoverButtonColor = System.Drawing.Color.Yellow;
            this.button_WOCRemove.OnHoverTextColor = System.Drawing.Color.Black;
            this.button_WOCRemove.Size = new System.Drawing.Size(172, 60);
            this.button_WOCRemove.TabIndex = 26;
            this.button_WOCRemove.Text = "Remove";
            this.button_WOCRemove.TextColor = System.Drawing.Color.White;
            this.button_WOCRemove.UseVisualStyleBackColor = true;
            this.button_WOCRemove.Click += new System.EventHandler(this.button_WOCRemove_Click);
            // 
            // button_WOC_Add
            // 
            this.button_WOC_Add.BorderColor = System.Drawing.Color.Yellow;
            this.button_WOC_Add.ButtonColor = System.Drawing.Color.Red;
            this.button_WOC_Add.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_WOC_Add.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_WOC_Add.Location = new System.Drawing.Point(7, 626);
            this.button_WOC_Add.Name = "button_WOC_Add";
            this.button_WOC_Add.OnHoverBorderColor = System.Drawing.Color.DarkKhaki;
            this.button_WOC_Add.OnHoverButtonColor = System.Drawing.Color.Yellow;
            this.button_WOC_Add.OnHoverTextColor = System.Drawing.Color.Black;
            this.button_WOC_Add.Size = new System.Drawing.Size(172, 60);
            this.button_WOC_Add.TabIndex = 23;
            this.button_WOC_Add.Text = "Add";
            this.button_WOC_Add.TextColor = System.Drawing.Color.White;
            this.button_WOC_Add.UseVisualStyleBackColor = true;
            this.button_WOC_Add.Click += new System.EventHandler(this.button_WOC_Add_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.WindowText;
            this.BackgroundImage = global::Course_Work2.Properties.Resources.hotel1_1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1297, 733);
            this.Controls.Add(this.button_WOCCatalog);
            this.Controls.Add(this.button_WOCRemove);
            this.Controls.Add(this.PriseBox);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.button_WOC_Add);
            this.Controls.Add(this.DateBox);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Name1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.RoomNumber);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.label1);
            this.Name = "Form2";
            this.Text = "Manage Reservations";
            this.Load += new System.EventHandler(this.Form1_Load_1);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader Number;
        private System.Windows.Forms.ColumnHeader Amount_of_persons;
        private System.Windows.Forms.ColumnHeader Amount_of_rooms;
        private System.Windows.Forms.ColumnHeader Type;
        private System.Windows.Forms.ColumnHeader Price;
        private System.Windows.Forms.DateTimePicker DateIN;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker DateOUT;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox RoomNumber;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox RoomType;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox AmountOfRooms;
        private System.Windows.Forms.TextBox Name1;
        private System.Windows.Forms.Panel panel1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.ComboBox AmountOfPersons;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.RichTextBox DateBox;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip2;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip3;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip4;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip5;
        private System.Windows.Forms.RadioButton radioButtonFemale;
        private System.Windows.Forms.RadioButton radioButtonMale;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.RadioButton radioButtonFamily;
        private ePOSOne.btnProduct.Button_WOC button_WOC_Search;
        private ePOSOne.btnProduct.Button_WOC button_WOC_Add;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.RichTextBox PriseBox;
        private ePOSOne.btnProduct.Button_WOC button_WOCRemove;
        private ePOSOne.btnProduct.Button_WOC button_WOCCatalog;
    }
}

