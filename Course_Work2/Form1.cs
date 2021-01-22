using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Course_Work2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void button_WOC_Search_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            var newImage = pictureBox1.Image;
            var newForm = new Form();

            newForm.StartPosition = FormStartPosition.CenterScreen;
            newForm.BackgroundImageLayout = ImageLayout.Stretch;
            newForm.Size = new Size(1405, 830);
            newForm.BackgroundImage = newImage;
            newForm.Show();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            var newImage = pictureBox2.Image;
            var newForm = new Form();

            newForm.StartPosition = FormStartPosition.CenterScreen;
            newForm.BackgroundImageLayout = ImageLayout.Stretch;
            newForm.Size = new Size(1405, 830);
            newForm.BackgroundImage = newImage;
            newForm.Show();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            var newImage = pictureBox3.Image;
            var newForm = new Form();

            newForm.StartPosition = FormStartPosition.CenterScreen;
            newForm.BackgroundImageLayout = ImageLayout.Stretch;
            newForm.Size = new Size(1405, 830);
            newForm.BackgroundImage = newImage;
            newForm.Show();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            var newImage = pictureBox4.Image;
            var newForm = new Form();

            newForm.StartPosition = FormStartPosition.CenterScreen;
            newForm.BackgroundImageLayout = ImageLayout.Stretch;
            newForm.Size = new Size(1405, 830);
            newForm.BackgroundImage = newImage;
            newForm.Show();
        }
    }
}
