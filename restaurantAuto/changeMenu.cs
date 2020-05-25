using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace restaurantAuto
{
    public partial class changeMenu : template
    {
        static OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=menu.mdb");
        int chosen;
        DataTable fullData = null;
        string picName;
        public changeMenu(int val)
        {
            InitializeComponent();
            Region = colors.region(Width, Height);
            chosen = val;
        }

        private void changeMenu_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "menuDataSet.drinks". При необходимости она может быть перемещена или удалена.
            this.drinksTableAdapter.Fill(this.menuDataSet.drinks);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "menuDataSet.garnir". При необходимости она может быть перемещена или удалена.
            this.garnirTableAdapter.Fill(this.menuDataSet.garnir);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "menuDataSet.second". При необходимости она может быть перемещена или удалена.
            this.secondTableAdapter.Fill(this.menuDataSet.second);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "menuDataSet.soups". При необходимости она может быть перемещена или удалена.
            this.soupsTableAdapter.Fill(this.menuDataSet.soups);
            //checkChosen();
            okButton.BorderColor = cancelButton.BorderColor = colors.darkPink;
            okButton.ButtonColor = okButton.OnHoverBorderColor = cancelButton.ButtonColor = cancelButton.OnHoverBorderColor = colors.pink;
            okButton.OnHoverButtonColor = cancelButton.OnHoverButtonColor = colors.lightPink;
            fillData(0);
        }

        private void fillData(int chosenIndex)
        {
            checkChosen();
            textBox1.Text = fullData.Rows[chosenIndex][1].ToString();
            numericUpDown1.Value = int.Parse(fullData.Rows[chosenIndex][2].ToString());
            picName = fullData.Rows[chosenIndex][3].ToString();
            pictureBox2.ImageLocation = $"menu/{fullData.Rows[chosenIndex][3].ToString()}";
            textBox2.Text = fullData.Rows[chosenIndex][4].ToString();
        }

        private void checkChosen()
        {
            switch (chosen)
            {
                case 0:
                    comboBox1.DataSource = menuDataSet.Tables["soups"];
                    comboBox1.ValueMember = "soupName";
                    comboBox1.DisplayMember= "soupName";
                    fullData = (DataTable)menuDataSet.Tables["soups"];
                    break;
                case 1:
                    comboBox1.DataSource = menuDataSet.Tables["[second]"];
                    comboBox1.ValueMember = "dishName";
                    comboBox1.DisplayMember = "dishName";
                    fullData = (DataTable)menuDataSet.Tables["[second]"];
                    break;
                case 2:
                    comboBox1.DataSource = menuDataSet.Tables["garnir"];
                    comboBox1.ValueMember = "garnirName";
                    comboBox1.DisplayMember = "garnirName";
                    fullData = (DataTable)menuDataSet.Tables["garnir"];
                    break;
                case 3:
                    comboBox1.DataSource = menuDataSet.Tables["drinks"];
                    comboBox1.ValueMember = "drinkName";
                    comboBox1.DisplayMember = "drinkName";
                    fullData = (DataTable)menuDataSet.Tables["drinks"];
                    break;
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {            
            fillData(comboBox1.SelectedIndex);
        }

        private void newButton3_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void newButton1_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textBox1.Text))
            {
                string query = "";
                switch (chosen)
                {
                    case 0:
                        query = $"UPDATE soups set soupName=@name, price=@price, pic=@pic, ingredients=@ings WHERE soupName='{this.comboBox1.GetItemText(this.comboBox1.SelectedItem)}'";
                        break;
                    case 1:
                        query = $"UPDATE [second] set dishName=@name, price=@price, pic=@pic, ingredients=@ings WHERE dishName='{this.comboBox1.GetItemText(this.comboBox1.SelectedItem)}'";
                        break;
                    case 2:
                        query = $"UPDATE garnir set garnirName=@name, price=@price, pic=@pic, ingredients=@ings WHERE garnirName='{this.comboBox1.GetItemText(this.comboBox1.SelectedItem)}'";
                        break;
                    case 3:
                        query = $"UPDATE drinks set drinkName=@name, price=@price, pic=@pic, ingredients=@ings WHERE drinkName='{this.comboBox1.GetItemText(this.comboBox1.SelectedItem)}'";
                        break;
                }
                con.Open();
                OleDbCommand cmd = new OleDbCommand(query, con);
                cmd.Parameters.AddWithValue("@name", textBox1.Text);
                cmd.Parameters.AddWithValue("@price", numericUpDown1.Value.ToString());
                cmd.Parameters.AddWithValue("@pic", picName);
                cmd.Parameters.AddWithValue("@ings", textBox2.Text);
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Изменения успешно применены");
                this.Close();
            }
            else
            {
                MessageBox.Show("Необходимо заполнить все поля");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog dlg = new OpenFileDialog())
            {
                dlg.Title = "Open Image";
                dlg.Filter = "jpg files (*.jpg)|*.jpg";

                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    picName = dlg.SafeFileName;
                    pictureBox2.Image = new Bitmap(dlg.FileName);
                    System.IO.File.Copy(dlg.FileName, $"menu/{textBox1.Text}.jpg", true);
                }
            }
        }
    }
}
