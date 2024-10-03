using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ToDoApp
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();

            this.AutoSize = false;
            this.PasswordField.Size = new Size(this.PasswordField.Width, 36);

            loginFieldTextBox.Text = "Username";
            loginFieldTextBox.ForeColor = Color.Gray;

            PasswordFieldTextBox.Text = "Password";
            PasswordFieldTextBox.ForeColor = Color.Gray;

        }

        Point lastPoint;
        private void label1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void label1_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }
        private void closedButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void closedButton_MouseEnter(object sender, EventArgs e)
        {
            //closeButton.ForeColor = Color.Black;
        }

        private void closedButton_MouseLeave(object sender, EventArgs e)
        {
            closeButton.ForeColor = Color.White;
        }

        private void SignUpLabel_MouseEnter(object sender, EventArgs e)
        {
            SignUpLabel.ForeColor = Color.Black;
        }

        private void SignUpLabel_MouseLeave(object sender, EventArgs e)
        {
            SignUpLabel.ForeColor = Color.White;
        }

        private void loginButtoninLoginForm_Click(object sender, EventArgs e)
        {
            if (loginFieldTextBox.Text == "Username")
            {
                MessageBox.Show("Please enter your login");
                return;
            }

            if (PasswordFieldTextBox.Text == "Password")
            {
                MessageBox.Show("Please enter your password");
                return;
            }

            string userlogin = loginFieldTextBox.Text;
            string passuser = PasswordFieldTextBox.Text;

            DB db = new DB();

            DataTable table = new DataTable();

            MySqlDataAdapter adapter = new MySqlDataAdapter();

            MySqlCommand command = new MySqlCommand("Select * FROM `users` WHERE `login` = @uL AND `pass`=@uP", db.getConnection());
            command.Parameters.Add("@uL", MySqlDbType.VarChar).Value = userlogin;
            command.Parameters.Add("@uP", MySqlDbType.VarChar).Value = passuser;

            adapter.SelectCommand = command;
            adapter.Fill(table); // Записываем данные с запроса в table
            if (table.Rows.Count > 0)
            {
                this.Hide();
                MainForm mainForm = new MainForm();
                mainForm.Show();
            }
            else
            {
                MessageBox.Show("Baaad!!!");
            }
        }

        private void SignUpLabel_Click(object sender, EventArgs e)
        {
            this.Hide(); // Прячем
            RegistrationForm registrationForm = new RegistrationForm();
            registrationForm.Show();
        }

        private void loginFieldTextBox_Enter(object sender, EventArgs e)
        {
            if (loginFieldTextBox.Text == "Username")
            {
                loginFieldTextBox.Text = "";
                loginFieldTextBox.ForeColor = Color.Black;
            }
        }

        private void loginFieldTextBox_Leave(object sender, EventArgs e)
        {
            if (loginFieldTextBox.Text == "")
            {
                loginFieldTextBox.Text = "Username";
                loginFieldTextBox.ForeColor= Color.Gray;
            }
        }

        private void PasswordFieldTextBox_Enter(object sender, EventArgs e)
        {
            if (PasswordFieldTextBox.Text == "Password")
            {
                PasswordFieldTextBox.Text = "";
                PasswordFieldTextBox.ForeColor = Color.Black;
            }
        }

        private void PasswordFieldTextBox_Leave(object sender, EventArgs e)
        {
            if(PasswordFieldTextBox.Text == "")
            {
                PasswordFieldTextBox.Text = "Password";
                PasswordFieldTextBox.ForeColor = Color.Gray;
            }

        }

        private void loginButtoninLoginForm_MouseEnter_1(object sender, EventArgs e)
        {
            loginButtoninLoginForm.BackColor = Color.White;
            loginButtoninLoginForm.ForeColor = Color.FromArgb(45, 48, 51);
        }

        private void loginButtoninLoginForm_MouseLeave_1(object sender, EventArgs e)
        {
            loginButtoninLoginForm.BackColor = Color.FromArgb(45, 48, 51);
            loginButtoninLoginForm.ForeColor = Color.White;
        }

        private void SignUPlabelLoginForm_MouseEnter(object sender, EventArgs e)
        {
            SignUPlabelLoginForm.ForeColor = Color.Black;
        }

        private void SignUPlabelLoginForm_MouseLeave(object sender, EventArgs e)
        {
            SignUPlabelLoginForm.ForeColor= Color.White;
        }

        private void SignUPlabelLoginForm_Click(object sender, EventArgs e)
        {
            this.Hide();
            RegistrationForm registrationForm = new RegistrationForm();
            registrationForm.Show();
        }
    }
}
