using System;
using System.Windows.Forms;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace restaurantAuto
{
    public partial class password : Form
    {
        
        public password()
        {
            InitializeComponent();
            Region = colors.region(Width, Height);
        }

        private void password_Load(object sender, EventArgs e)
        {
            textBox1.Select();
            panel1.Location = new Point(0, 0);
            panel1.Size = new Size(this.Width, this.Height);
            okButton.FlatAppearance.BorderColor = cancelButton.FlatAppearance.BorderColor = colors.red;
            // TODO: данная строка кода позволяет загрузить данные в таблицу "workers1DataSet1.workers". При необходимости она может быть перемещена или удалена.
            this.workersTableAdapter.Fill(this.workers1DataSet1.workers);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "workers1DataSet.workers". При необходимости она может быть перемещена или удалена.
            // this.workersTableAdapter.Fill(this.workers1DataSet.workers);
            BackColor = colors.green;
            okButton.BorderColor = cancelButton.BorderColor = colors.darkPink;
            okButton.ButtonColor = okButton.OnHoverBorderColor = cancelButton.ButtonColor = cancelButton.OnHoverBorderColor = colors.pink;
            okButton.OnHoverButtonColor = cancelButton.OnHoverButtonColor = colors.lightPink;

        }

        private void okButton_Click(object sender, EventArgs e)
        {
            string password = textBox1.Text;
            checkPass(password);
        }

        private void checkPass(string password)
        {
            if (String.IsNullOrEmpty(password)) 
            {
                MessageBox.Show("Необходимо ввести пароль");
            } else 
            {
                DataGridViewRow row = dataGridView1.Rows[currentUser.index];
                if(row.Cells[2].Value.ToString() == password) 
                {
                    checkOccupation(row.Cells[1].Value.ToString());
                } else 
                {
                    MessageBox.Show("Неверный пароль");
                }                
            }            
        }

        private void checkOccupation(string occupation)
        {
           
            if (occupation == "Менеджер") 
            {
                (new Manager()).Show();
            } else if(occupation == "Официант") 
            {
                (new Cashier()).Show();
            } else
            {
                (new Admin()).Show();
            }
            this.Close();
            formsCollection._Login.Hide();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void password_Paint(object sender, PaintEventArgs e)
        {
            
            
            
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {            
           //panel1.Region = colors.region(this.Width, this.Height);
            const float margin = 5;
            RectangleF rect = new RectangleF(margin, margin, this.Width-10, this.Height-10);
            using (Pen pen = new Pen(colors.pink, 3))
            {
                SolidBrush br = new SolidBrush(colors.green);
                GraphicsPath path = MakeRoundedRect(rect, 20, 20);
                e.Graphics.FillPath(br, path);
                e.Graphics.DrawPath(pen, path);
            }
        }
        // Draw a rectangle in the indicated Rectangle
        // rounding the indicated corners.
        private GraphicsPath MakeRoundedRect(
            RectangleF rect, float xradius, float yradius,
            bool round_ul = true, bool round_ur = true, bool round_lr = true, bool round_ll = true)
        {
            // Make a GraphicsPath to draw the rectangle.
            PointF point1, point2;
            GraphicsPath path = new GraphicsPath();

            // Upper left corner.
            if (round_ul)
            {
                RectangleF corner = new RectangleF(
                    rect.X, rect.Y,
                    2 * xradius, 2 * yradius);
                path.AddArc(corner, 180, 90);
                point1 = new PointF(rect.X + xradius, rect.Y);
            }
            else point1 = new PointF(rect.X, rect.Y);

            // Top side.
            if (round_ur)
                point2 = new PointF(rect.Right - xradius, rect.Y);
            else
                point2 = new PointF(rect.Right, rect.Y);
            path.AddLine(point1, point2);

            // Upper right corner.
            if (round_ur)
            {
                RectangleF corner = new RectangleF(
                    rect.Right - 2 * xradius, rect.Y,
                    2 * xradius, 2 * yradius);
                path.AddArc(corner, 270, 90);
                point1 = new PointF(rect.Right, rect.Y + yradius);
            }
            else point1 = new PointF(rect.Right, rect.Y);

            // Right side.
            if (round_lr)
                point2 = new PointF(rect.Right, rect.Bottom - yradius);
            else
                point2 = new PointF(rect.Right, rect.Bottom);
            path.AddLine(point1, point2);

            // Lower right corner.
            if (round_lr)
            {
                RectangleF corner = new RectangleF(
                    rect.Right - 2 * xradius,
                    rect.Bottom - 2 * yradius,
                    2 * xradius, 2 * yradius);
                path.AddArc(corner, 0, 90);
                point1 = new PointF(rect.Right - xradius, rect.Bottom);
            }
            else point1 = new PointF(rect.Right, rect.Bottom);

            // Bottom side.
            if (round_ll)
                point2 = new PointF(rect.X + xradius, rect.Bottom);
            else
                point2 = new PointF(rect.X, rect.Bottom);
            path.AddLine(point1, point2);

            // Lower left corner.
            if (round_ll)
            {
                RectangleF corner = new RectangleF(
                    rect.X, rect.Bottom - 2 * yradius,
                    2 * xradius, 2 * yradius);
                path.AddArc(corner, 90, 90);
                point1 = new PointF(rect.X, rect.Bottom - yradius);
            }
            else point1 = new PointF(rect.X, rect.Bottom);

            // Left side.
            if (round_ul)
                point2 = new PointF(rect.X, rect.Y + yradius);
            else
                point2 = new PointF(rect.X, rect.Y);
            path.AddLine(point1, point2);

            // Join with the start point.
            path.CloseFigure();

            return path;
        }
    }
}
