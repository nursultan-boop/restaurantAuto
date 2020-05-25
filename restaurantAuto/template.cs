using System;
using System.Windows.Forms;

namespace restaurantAuto
{
    public partial class template : Form
    {

        public template()
        {
            InitializeComponent();
        }

        private void login_Load(object sender, EventArgs e)
        {
            backPanel.BackColor = colors.green;
            upperBar.BackColor = colors.darkGreen;
        }

        public void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void backPanel_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
