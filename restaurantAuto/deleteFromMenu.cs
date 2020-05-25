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
    public partial class deleteFromMenu : Form
    {
        static OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=menu.mdb");
        int chosenOne;
        public deleteFromMenu(int value)
        {
            InitializeComponent();
            Region = colors.region(Width, Height);
            chosenOne = value;
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void deleteFromMenu_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "menuDataSet.drinks". При необходимости она может быть перемещена или удалена.
            this.drinksTableAdapter.Fill(this.menuDataSet.drinks);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "menuDataSet.garnir". При необходимости она может быть перемещена или удалена.
            this.garnirTableAdapter.Fill(this.menuDataSet.garnir);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "menuDataSet.second". При необходимости она может быть перемещена или удалена.
            this.secondTableAdapter.Fill(this.menuDataSet.second);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "menuDataSet.soups". При необходимости она может быть перемещена или удалена.
            this.soupsTableAdapter.Fill(this.menuDataSet.soups);

            BackColor = colors.green;
            okButton.BorderColor = cancelButton.BorderColor = colors.darkPink;
            okButton.ButtonColor = okButton.OnHoverBorderColor = cancelButton.ButtonColor = cancelButton.OnHoverBorderColor = colors.pink;
            okButton.OnHoverButtonColor = cancelButton.OnHoverButtonColor = colors.lightPink;
            if (chosenOne == 0) 
            {
                pervoyeCB.Visible = true;
            } else if(chosenOne == 1) 
            {
                vtoroyeCB.Visible = true;
            } else if(chosenOne == 2) 
            {
                garnirCB.Visible = true;
            } else 
            {
                drinksCB.Visible = true;
            }
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            string query = "";
            switch (chosenOne) 
            {
                case 0:
                    query = $"DELETE FROM soups WHERE soupName='{this.pervoyeCB.GetItemText(this.pervoyeCB.SelectedItem)}'";
                    break;
                case 1:
                    query = $"DELETE FROM [second] WHERE dishName='{this.vtoroyeCB.GetItemText(this.vtoroyeCB.SelectedItem)}'";
                    break;
                case 2:
                    query = $"DELETE FROM garnir WHERE garnirName='{this.garnirCB.GetItemText(this.garnirCB.SelectedItem)}'";
                    break;
                case 3:
                    query = $"DELETE FROM drinks WHERE drinkName='{this.drinksCB.GetItemText(this.drinksCB.SelectedItem)}'";
                    break;
            }
            con.Open();
            OleDbCommand cmd = new OleDbCommand(query, con);
            cmd.ExecuteNonQuery();
            con.Close();
            this.Close();
        }
    }
}
