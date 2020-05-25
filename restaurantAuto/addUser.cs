using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace restaurantAuto
{
    public partial class addUser : Form
    {
        public addUser()
        {
            InitializeComponent();
            Region = colors.region(Width, Height);
        }

        private void addUser_Load(object sender, EventArgs e)
        {
            panel1.Location = new Point(0, 0);
            panel1.Size = Size;
            panel1.BackColor = colors.green;
            newButton1.BorderColor = newButton2.BorderColor = colors.darkPink;
            newButton1.ButtonColor = newButton1.OnHoverBorderColor = newButton2.ButtonColor = newButton2.OnHoverBorderColor = colors.pink;
            newButton1.OnHoverButtonColor = newButton2.OnHoverButtonColor = colors.lightPink;
            comboBox1.SelectedIndex = 1;
        }

        private void newButton2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void newButton1_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textBox1.Text) && !string.IsNullOrEmpty(textBox2.Text))
            {
                string query = $"INSERT into workers(nameSurname, occupation, [password]) Values(@Name, @occup, @pass)";
                OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=workers1.mdb");
                OleDbCommand cmd = new OleDbCommand(query, con);
                con.Open();
                cmd.Parameters.Add("@Name", OleDbType.VarChar).Value = textBox1.Text;
                cmd.Parameters.Add("@occup", OleDbType.VarChar).Value = this.comboBox1.GetItemText(this.comboBox1.SelectedItem);
                cmd.Parameters.Add("@pass", OleDbType.VarChar).Value = textBox2.Text;
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Пользователь успешно добавлен");
                Close();
            } else 
            {
                MessageBox.Show("Необходимо заполнить все поля");
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            const float margin = 5;
            RectangleF rect = new RectangleF(margin, margin, this.Width - 10, this.Height - 10);
            using (Pen pen = new Pen(colors.pink, 3))
            {
                SolidBrush br = new SolidBrush(colors.green);
                GraphicsPath path = MakeRoundedRect(rect, 20, 20);
                e.Graphics.FillPath(br, path);
                e.Graphics.DrawPath(pen, path);
            }
        }
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
