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

namespace restaurantAuto
{
    public partial class Manager : template
    {
        
        static OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=menu.mdb");

        public Manager()
        {
            InitializeComponent();
            Region = colors.region(Width, Height);
        }

        private void Manager_Load(object sender, EventArgs e)
        {
            updateDGVs();
            fillProfitData();
            newButton1.Text = "  Добавить\n     пункт\n     меню";
            newButton3.Text = "  Изменить\n     пункт\n     меню";
            newButton2.Text = "  Удалить\n    пункт\n    меню";
            newButton1.BorderColor = newButton2.BorderColor = newButton3.BorderColor = colors.darkPink;
            newButton1.ButtonColor = newButton1.OnHoverBorderColor = newButton2.ButtonColor = newButton2.OnHoverBorderColor =
                newButton3.ButtonColor = newButton3.OnHoverBorderColor = colors.pink;
            newButton1.OnHoverButtonColor = newButton2.OnHoverButtonColor = newButton3.OnHoverButtonColor = colors.lightPink;
        }

        void fillProfitData()
        {
            StreamReader sr = new StreamReader("profit.txt");
            string line;
            List<string> dates = new List<string>();
            List<string> profit = new List<string>();
            while ((line = sr.ReadLine())!= null) 
            {
                dates.Add(line.Split(':')[0]);
                profit.Add(line.Split(':')[1]);
            }
            for (int i = 0; i < dates.Count; i++)
            {
                string[] item = { dates[i], profit[i] };
                dataGridView5.Rows.Add(item);
            }
        }

        private void Manager_FormClosing(object sender, FormClosingEventArgs e)
        {
            formsCollection._Login.Show();
        }

        private void newButton1_Click(object sender, EventArgs e)
        {
            string query = "";
            string tabName = tabControl1.SelectedTab.Name;
            string name="";
            string value="";
            string pic = "";
            string ings = "";
            switch (tabName)
            {
                case "tabPage1":
                    query = $"INSERT into soups(soupName, price, pic, ingredients) Values(@Name, @price, @pic, @ings)";                    
                    break;
                case "tabPage2":
                    query = $"INSERT into [second](dishName, price, pic, ingredients) Values(@Name, @price, @pic, @ings)";                    
                    break;
                case "tabPage3":
                    query = $"INSERT into garnir(garnirName, price, pic, ingredients) Values(@Name, @price, @pic, @ings)";
                    break;
                case "tabPage4":
                    query = $"INSERT into drinks(drinkName, price, pic, ingredients) Values(@Name, @price, @pic, @ings)";
                    break;
            }
            OleDbCommand cmd = new OleDbCommand(query, con);
            using (var form = new addToMenu())
            {
                var result = form.ShowDialog();
                if (result == DialogResult.OK)
                {
                    name = form.itemName;
                    value = form.itemValue.ToString();
                    pic = form.pic;
                    ings = form.ingrs;
                }
            }
            con.Open();
            cmd.Parameters.Add("@Name", OleDbType.VarChar).Value = name;
            cmd.Parameters.Add("@price", OleDbType.VarChar).Value = value;
            cmd.Parameters.Add("@pic", OleDbType.VarChar).Value = pic;
            cmd.Parameters.Add("@ings", OleDbType.VarChar).Value = ings;
            cmd.ExecuteNonQuery();
            con.Close();
            updateDGVs();
        }

        private void updateDGVs()
        {
            string select;
            select = "select * from soups";
            using (OleDbDataAdapter da = new OleDbDataAdapter(select, con))
            {
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;

                dataGridView1.Columns[0].Visible = false;
                dataGridView1.Columns[1].HeaderText = "Наименование блюда";
                dataGridView1.Columns[2].HeaderText = "Цена";
                dataGridView1.Columns[3].HeaderText = "Название картинки";
                dataGridView1.Columns[4].HeaderText = "Состав";
            }

            select = "select * from [second]";
            using (OleDbDataAdapter da = new OleDbDataAdapter(select, con))
            {
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView2.DataSource = dt;

                dataGridView2.Columns[0].Visible = false;
                dataGridView2.Columns[1].HeaderText = "Наименование блюда";
                dataGridView2.Columns[2].HeaderText = "Цена";
                dataGridView2.Columns[3].HeaderText = "Название картинки";
                dataGridView2.Columns[4].HeaderText = "Состав";
            }

            select = "select * from garnir";
            using (OleDbDataAdapter da = new OleDbDataAdapter(select, con))
            {
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView3.DataSource = dt;

                dataGridView3.Columns[0].Visible = false;
                dataGridView3.Columns[1].HeaderText = "Наименование гарнира";
                dataGridView3.Columns[2].HeaderText = "Цена";
                dataGridView3.Columns[3].HeaderText = "Название картинки";
                dataGridView3.Columns[4].HeaderText = "Состав";
            }

            select = "select * from drinks";
            using (OleDbDataAdapter da = new OleDbDataAdapter(select, con))
            {
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView4.DataSource = dt;

                dataGridView4.Columns[0].Visible = false;
                dataGridView4.Columns[1].HeaderText = "Наименование напитка";
                dataGridView4.Columns[2].HeaderText = "Цена";
                dataGridView4.Columns[3].HeaderText = "Название картинки";
                dataGridView4.Columns[4].HeaderText = "Состав";
            }
        }

        private void newButton2_Click(object sender, EventArgs e)
        {
            (new deleteFromMenu(tabControl1.SelectedIndex)).ShowDialog();
            updateDGVs();
        }

        private void newButton3_Click(object sender, EventArgs e)
        {
            (new changeMenu(tabControl1.SelectedIndex)).ShowDialog();
            updateDGVs();
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControl1.SelectedIndex > 3) 
            {
                newButton1.Visible = newButton2.Visible = newButton3.Visible = false;
            } else
            {
                newButton1.Visible = newButton2.Visible = newButton3.Visible = true;
            }
        }

        private void upperBar_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
