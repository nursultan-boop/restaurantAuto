using System;
using System.Drawing;
using System.Windows.Forms;

namespace restaurantAuto
{
    public partial class login : template
    {
        
        public login()
        {
            InitializeComponent();
            Region = colors.region(this.Width, this.Height);
            formsCollection._Login = this;
        }

        private void login_Load(object sender, EventArgs e)
        {
            loginText.Select(); //выбор текстбокса как активного элемента управленияя
            this.workersTableAdapter.Fill(this.workers1DataSet.workers); // заполнение таблицы из dataset
             acceptButton.FlatAppearance.BorderColor = colors.green;                   //цвет кнопок
            acceptButton.BorderColor = colors.darkPink;                                //
            acceptButton.ButtonColor = acceptButton.OnHoverBorderColor = colors.pink;  //
            acceptButton.OnHoverButtonColor = colors.lightPink;                        //
            AutoCompleteStringCollection autoComplete = new AutoCompleteStringCollection();// автозаполнение текстбокса
            foreach (DataGridViewRow row in dataGridView1.Rows)                            //
            {                                                                              //
                autoComplete.Add(row.Cells[0].Value.ToString());                           //
            }                                                                              //
            loginText.AutoCompleteCustomSource = autoComplete;                             //
        }

        private void roundTextbox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void roundButton1_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(loginText.Text) || String.IsNullOrWhiteSpace(loginText.Text)) //проверка пустоты текстбокса
            {
                MessageBox.Show("Вы не ввели логин");
            }
            else
            {
                if (checkLogin(loginText.Text)) //проверка этого логина
                {
                    currentUser.userLogin = loginText.Text;   // запись логина в статический класс
                    (new password()).Show();                  // запуск формы для ввода пароля  
                } else 
                {
                    MessageBox.Show("Убедитесь в правильности написания или обратитесь к Администратору", "Данный пользователь не существует", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private bool checkLogin(string text)
        {
            foreach(DataGridViewRow row in dataGridView1.Rows)  //пробег по всем элементам таблицы
            {
                if(text == row.Cells[0].Value.ToString()) 
                {
                    currentUser.index = row.Index;
                    return true;
                } 
            }
            return false;
        }
                

        private void pictureBox1_Click_1(object sender, EventArgs e)    //выход из приложения при нажатии на кнопку
        {
            Application.Exit();
        }

        private void backPanel_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
