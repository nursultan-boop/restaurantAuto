using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace restaurantAuto
{
    public partial class addToMenu : Form
    {
        public addToMenu()
        {
            InitializeComponent();
            Region = colors.region(Width, Height);
        }
        public string itemName { get; set; }
        public int itemValue { get; set; }
        public string pic { get; set; }
        public string ingrs { get; set; }
        private void addToMenu_Load(object sender, EventArgs e)
        {
            panel1.BackColor = colors.green;
            panel1.Location = new Point(0, 0);
            panel1.Size = Size;
            okButton.BorderColor = cancelButton.BorderColor = colors.darkPink;
            okButton.ButtonColor = okButton.OnHoverBorderColor = cancelButton.ButtonColor = cancelButton.OnHoverBorderColor = colors.pink;
            okButton.OnHoverButtonColor = cancelButton.OnHoverButtonColor = colors.lightPink;
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            itemValue = (int)numericUpDown1.Value;
            if (checkName(textBox1.Text) && checkName(textBox2.Text) && pictureBox1.Image!=null)
            {

                ingrs = textBox2.Text;
                DialogResult = DialogResult.OK;
                Close();
            } else 
            {
                MessageBox.Show("Необходимо заполнить все поля и загрузить изображение");
            }
        }

        private bool checkName(string text)
        {
            
            if(!String.IsNullOrEmpty(text) && !String.IsNullOrWhiteSpace(text)) 
            {
                itemName = textBox1.Text;
                return true;
            }
            return false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            using (OpenFileDialog dlg = new OpenFileDialog())
            {
                dlg.Title = "Open Image";
                dlg.Filter = "jpg files (*.jpg)|*.jpg";

                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    pic = $"{textBox1.Text}.jpg";
                    pictureBox1.Image = new Bitmap(dlg.FileName);
                    System.IO.File.Copy(dlg.FileName,$"menu/{textBox1.Text}.jpg", true);
                }
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
