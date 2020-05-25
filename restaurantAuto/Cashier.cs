using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using System.IO;
using static System.Windows.Forms.TabControl;

namespace restaurantAuto
{
    public partial class Cashier : template
    {
        OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=menu.mdb");
        int counter = 0;
        int total = 0;
        string name;
        public Cashier()
        {
            InitializeComponent();
            Region = colors.region(Width, Height);
        }
        private void Cashier_Load(object sender, EventArgs e)
        {
            
            buttonColors();
            createDTButtons(getPervoyeDT());
            createDTButtons(getMainDT());
            createDTButtons(getGarnir());
            createDTButtons(getDrinks());
        }
       

        private void buttonColors()
        {
            newButton1.BorderColor = newButton2.BorderColor = newButton3.BorderColor = colors.darkPink;
            newButton1.ButtonColor = newButton1.OnHoverBorderColor = 
                newButton2.ButtonColor = newButton2.OnHoverBorderColor = 
                newButton3.ButtonColor = newButton3.OnHoverBorderColor = colors.pink;
            newButton1.OnHoverButtonColor = newButton2.OnHoverButtonColor = newButton3.OnHoverButtonColor = colors.lightPink;
        }

        private void createDTButtons(DataTable dataTable)
        {
            foreach(DataRow row in dataTable.Rows) 
            {                
                createButton(row[1].ToString(), int.Parse(row[2].ToString()),
                    row[3].ToString(), row[4].ToString());
            }
        }

        private void createButton(string btnName, int price, string path, string ingrs)
        {            
            name = btnName;
            Panel pan = new Panel();
            pan.Size = new Size(150, 220);
            PictureBox pic = new PictureBox();
            Label ings = new Label();
            pic.ImageLocation = $"menu/{path}";
            pic.Size = new Size(150, 150);
            pic.SizeMode = PictureBoxSizeMode.Zoom;
            ings.Text = "Состав: " + ingrs;
            ings.AutoSize = true;
            pan.Controls.Add(pic);
            pan.Controls.Add(ings);
            pic.Dock = DockStyle.Top;            
            ings.MaximumSize = new Size(150, 0);
            

            Button btn = new Button();
            btn.AutoSize = true;
            btn.Text = btnName;
            btn.Name = price.ToString();
            pan.Controls.Add(btn);
            btn.Location = new Point(0, pic.Height);
            ings.Location = new Point(0, pic.Height+btn.Height);
            pan.Size = new Size(150, pic.Height + ings.Height + btn.Height + 10);
            btn.Click += new EventHandler(btn_Click);
            switch (counter)
            {
                case 1:
                    flowLayoutPanel1.Controls.Add(pan);
                    break;
                case 2:
                    flowLayoutPanel2.Controls.Add(pan);
                    break;
                case 3:
                    flowLayoutPanel3.Controls.Add(pan);
                    break;
                case 4:
                    flowLayoutPanel4.Controls.Add(pan);
                    break;
            }
        }

        private void btn_Click(object sender, EventArgs e)
        {
            name = ((Button)sender).Text;
            int value = int.Parse(((Button)sender).Name);
            currentUser.adminUserIndex = int.Parse(((Button)sender).Name);
            string[] item = { name, "1", value.ToString() };
            dataGridView1.ColumnCount = 3;
            int row = -1;
            int amount = 1;
            if (dataGridView1.Rows.Count >=1)
            {
                row = checkItem(name);
            }
            if (row > -1)
            {

                amount = Convert.ToInt32(dataGridView1.Rows[row].Cells[1].Value);
                amount++;
                dataGridView1.Rows[row].Cells[1].Value = amount;
                dataGridView1.Rows[row].Cells[2].Value = value * amount;
            }
            else
            {
                dataGridView1.Rows.Add(item);
            }
            total += value;
            label1.Visible = true;
            label1.Text = $" Итого: {total}";
        }
        int checkItem(string name)
        {
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.Cells[0].Value != null && row.Cells[0].Value.ToString().Equals(name))
                {
                    return row.Index;
                }
            }
            return -1;
        }
        DataTable getPervoyeDT() 
        {
            DataTable pervoye = new DataTable();
            string query = "SELECT soups.* FROM soups";
            using (OleDbCommand cmd = new OleDbCommand(query, con)) 
            {
                con.Open();
                pervoye.Load(cmd.ExecuteReader());
                con.Close();
            }
            counter++;
            return pervoye;
        }
        private DataTable getMainDT()
        {
            DataTable vtoroye = new DataTable();
            string query = "SELECT [second].* FROM [second]";
            using (OleDbCommand cmd = new OleDbCommand(query, con))
            {
                con.Open();
                vtoroye.Load(cmd.ExecuteReader());
                con.Close();
            }
            counter++;
            return vtoroye;
        }
        private DataTable getDrinks()
        {
            DataTable drinks = new DataTable();
            string query = "SELECT drinks.* FROM drinks";
            using (OleDbCommand cmd = new OleDbCommand(query, con))
            {
                con.Open();
                drinks.Load(cmd.ExecuteReader());
                con.Close();
            }
            counter++;
            return drinks;
        }

        private DataTable getGarnir()
        {
            DataTable garnir = new DataTable();
            string query = "SELECT garnir.* FROM garnir";
            using (OleDbCommand cmd = new OleDbCommand(query, con))
            {
                con.Open();
                garnir.Load(cmd.ExecuteReader());
                con.Close();
            }
            counter++;
            return garnir;
        }
        private void newButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Cashier_FormClosing(object sender, FormClosingEventArgs e)
        {
            shouldWriteToTxt();
            formsCollection._Login.Show();       
        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void newButton1_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count > 0 && numericUpDown1.Value>0)
            {
                string[] item = { "", "", label1.Text };
                dataGridView1.Rows.Add(item);
                PrintPreviewDialog ppd = new PrintPreviewDialog();
                ppd.Document = printDocument1;
                this.printPreviewDialog1.PrintPreviewControl.Zoom = 1;
                this.printPreviewDialog1.ShowDialog();
                dataGridView1.Rows.RemoveAt(dataGridView1.Rows.Count-1);
            } else
            {
                MessageBox.Show("Чек пустой или номер столика не выбран", "Ошибка", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
            
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Graphics g = e.Graphics;
            int x = 0;
            int y = 20;
            int cell_height = 0;

            int colCount = dataGridView1.ColumnCount;
            int rowCount = dataGridView1.RowCount;

            Font font = new Font("Tahoma", 9, FontStyle.Bold, GraphicsUnit.Point);

            int widthC = 0;

            int current_col = 0;
            int current_row = 0;

            while (current_row < rowCount)
            {
                while (current_col < colCount)
                {
                    if (g.MeasureString(dataGridView1[current_col, current_row].Value.ToString(), font).Width > widthC)
                    {
                        widthC = (int)g.MeasureString(dataGridView1[current_col, current_row].Value.ToString(), font).Width;
                    }                   
                }
                current_col = 0;
                current_row++;
            }
            //if (widthC < 40) widthC = 40;
            current_col++;

            current_col = 0;
            current_row = 0;

            string value = "";

            int width = widthC;
            int height = dataGridView1[current_col, current_row].Size.Height;

            Rectangle cell_border;
            SolidBrush brush = new SolidBrush(Color.Black);

            x = 5;
            y = 20;

            string waiterName = $"Кассир: {currentUser.userLogin.Replace('_', ' ')}";
            string tableNum = $"Столик №{numericUpDown1.Value.ToString()}";
            string time = $"Время: {DateTime.Now.ToString("hh:mm")}";
            g.DrawString(waiterName, font, brush, x, y);
            y += 20;
            g.DrawString(tableNum, font, brush, x, y);
            y += 20;
            g.DrawString(time, font, brush, x, y);
            y += 25;
            

            while (current_col < colCount)
            {

                cell_height = dataGridView1[current_col, current_row].Size.Height;
                cell_border = new Rectangle(x, y, width, height);
                value = dataGridView1.Columns[current_col].HeaderText.ToString();
                g.DrawRectangle(new Pen(Color.Black), cell_border);
                g.DrawString(value, font, brush, x, y);
                x += widthC;
                current_col++;
            }
            current_col = 0;
            current_row = 0;
            x = 5;
            y += cell_height;
            while (current_row < rowCount)
            {
                while (current_col < colCount)
                {

                    cell_height = dataGridView1[current_col, current_row].Size.Height;
                    cell_border = new Rectangle(x, y, width, height);
                    value = dataGridView1[current_col, current_row].Value.ToString();
                    g.DrawRectangle(new Pen(Color.Black), cell_border);
                    g.DrawString(value, font, brush, x, y);
                    current_col++;
                    x += widthC;
                }
                current_col = 0;
                current_row++;
                x = 5;
                y += cell_height;
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = dataGridView1.CurrentCell.RowIndex;
            if(int.Parse(dataGridView1.Rows[index].Cells[1].Value.ToString()) > 1) 
            {
                int val = int.Parse(dataGridView1.Rows[index].Cells[2].Value.ToString()) / int.Parse(dataGridView1.Rows[index].Cells[1].Value.ToString());
                total -= val;
                dataGridView1.Rows[index].Cells[1].Value = int.Parse(dataGridView1.Rows[index].Cells[1].Value.ToString()) - 1;
                dataGridView1.Rows[index].Cells[2].Value = int.Parse(dataGridView1.Rows[index].Cells[2].Value.ToString())-val;
                label1.Text = $"Итого: {total}";
            } else
            {
                total -= int.Parse(dataGridView1.Rows[index].Cells[2].Value.ToString());
                label1.Text = $"Итого: {total}";
                dataGridView1.Rows.RemoveAt(index);
            }
        }

        private void printPreviewDialog1_Load(object sender, EventArgs e)
        {
            
        }

        private void newButton3_Click(object sender, EventArgs e)
        {

            shouldWriteToTxt();
            dataGridView1.Rows.Clear();
            dataGridView1.Refresh();
            total = 0;
            label1.Text = $"Итого: {total}";
        }
        void shouldWriteToTxt() 
        {
            if (total > 0) 
            {
                writeToTxt(total);
            }
        }

        private void writeToTxt(int price)
        {
            StreamReader sr = new StreamReader("profit.txt");            
            List<string> dates = new List<string>();
            List<string> money = new List<string>();
            string line;
            int counter = 0;
            while ((line = sr.ReadLine()) != null)
            {
                dates.Add(line.Split(':')[0]);
                money.Add(line.Split(':')[1]);
            }
            sr.Close();
            string todaysDate = DateTime.Now.ToString("dd");
            int index = dates.IndexOf(todaysDate);
            if ( index > -1) 
            {                
                money[index] = (int.Parse(money[index])+price).ToString();                 
            } else
            {
                dates.Add(DateTime.Now.ToString("dd"));
                money.Add(price.ToString());                                
            }
            counter = 0;
            StreamWriter sw = new StreamWriter("profit.txt");
            foreach (string _money in money)
            {
                sw.WriteLine($"{dates[counter]}:{money[counter]}");
                counter++;
            }
            sw.Close();
        }

        private void flowLayoutPanel4_Paint(object sender, PaintEventArgs e)
        {

        }
        
    }
}
