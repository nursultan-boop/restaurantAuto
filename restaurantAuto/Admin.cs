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
    public partial class Admin : template
    {
        public Admin()
        {
            InitializeComponent();
            Region = colors.region(Width, Height);
            formsCollection._Admin = this;
        }

        private void Admin_Load(object sender, EventArgs e)
        {

            
            updateForm();
            
            newButton1.BorderColor = newButton2.BorderColor = colors.darkPink;
            newButton1.ButtonColor = newButton1.OnHoverBorderColor = newButton2.ButtonColor = newButton2.OnHoverBorderColor = colors.pink;
            newButton1.OnHoverButtonColor = newButton2.OnHoverButtonColor = colors.lightPink;
        }

        public void updateForm() 
        {
            this.workersTableAdapter.Fill(this.workers1DataSet1.workers);            
            flowLayoutPanel1.Controls.Clear();            
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                createUserPanel(row.Cells[0].Value.ToString(), row.Cells[1].Value.ToString(), row.Cells[2].Value.ToString(), row.Index);
            }
        }
        private void createUserPanel(string login, string occupation, string password, int index)
        {   
            newButton change = new newButton();
            change.Name = index.ToString();
            change.AutoSize = true;
            change.Text = login;
            flowLayoutPanel1.Controls.Add(change);
            change.BorderColor = colors.darkPink;
            change.ButtonColor = change.OnHoverBorderColor = colors.pink;
            change.OnHoverButtonColor = colors.lightPink;
            change.FlatStyle = FlatStyle.Flat;
            change.FlatAppearance.BorderSize = 0;
            change.FlatAppearance.BorderColor = colors.green;
            change.OnHoverTextColor = Color.White;
            change.Click += new EventHandler(btn_Click);
        }

        private void btn_Click(object sender, EventArgs e)
        {
            currentUser.adminUserIndex = int.Parse(((Button)sender).Name);
            (new EditUser()).Show();
        }

        private void Admin_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
            formsCollection._Login.Show();
        }

        private void newButton1_Click(object sender, EventArgs e)
        {
            (new addUser()).ShowDialog();
            updateForm();
        }

        private void newButton2_Click(object sender, EventArgs e)
        {
            (new deleteUser()).ShowDialog();
            updateForm();
        }
    }
}
