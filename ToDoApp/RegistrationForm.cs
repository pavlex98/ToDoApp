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
    public partial class RegistrationForm : Form
    {
        public RegistrationForm()
        {
            InitializeComponent();

            UserNameField.Text = "Name";
            UserNameField.ForeColor = Color.Gray;

            UserSurnameField.Text = "Surname";
            UserSurnameField.ForeColor = Color.Gray;

            LoginField.Text = "Enter login";
            LoginField.ForeColor = Color.Gray;

            PasswordField.Text = "Enter password";
            PasswordField.ForeColor = Color.Gray;
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
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

        private void UserNameField_Enter(object sender, EventArgs e)
        {
            if (UserNameField.Text == "Name")
            {
                UserNameField.Text = "";
                UserNameField.ForeColor = Color.Black;
            }
        }

        private void UserNameField_Leave(object sender, EventArgs e)
        {
            if (UserNameField.Text == "")
            {
                UserNameField.Text = "Name";
                UserNameField.ForeColor = Color.Gray;
            }
        }

        private void LoginField_Enter(object sender, EventArgs e)
        {
            if (LoginField.Text == "Enter login")
            {
                LoginField.Text = "";
                LoginField.ForeColor = Color.Black;
            }
        }
        private void LoginField_Leave(object sender, EventArgs e)
        {
            if (LoginField.Text == "")
            {
                LoginField.Text = "Enter login";
                LoginField.ForeColor = Color.Gray;               
            }
        }
        private void PasswordField_Enter(object sender, EventArgs e)
        {
            if (PasswordField.Text == "Enter password")
            {
                PasswordField.Text = "";
                PasswordField.ForeColor = Color.Black;
            }
        }

        private void PasswordField_Leave(object sender, EventArgs e)
        {
            if (PasswordField.Text == "")
            {
                PasswordField.Text = "Enter password";
                PasswordField.ForeColor = Color.Gray;
            }
        }

        private void UserSurnameField_Enter(object sender, EventArgs e)
        {
            if (UserSurnameField.Text == "Surname")
            {
                UserSurnameField.Text = "";
                UserSurnameField.ForeColor = Color.Black;
             
            }
        }

        private void UserSurnameField_Leave(object sender, EventArgs e)
        {
            if (UserSurnameField.Text == "")
            {
                UserSurnameField.Text = "Surname";
                UserSurnameField.ForeColor = Color.Gray;
            }
        
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            if(UserNameField.Text == "Name")
            {
                MessageBox.Show("Enter yor name");
                return;
            }

            if (UserSurnameField.Text == "Surname")
            {
                MessageBox.Show("Enter yor surname");
                return;
            }

            if (LoginField.Text == "Enter login")
            {
                MessageBox.Show("Enter yor username");
                return;
            }

            if (PasswordField.Text == "Enter password")
            {
                MessageBox.Show("Enter yor password");
                return;
            }

            if(isUserExists())
                return;

            DB db = new DB();
            MySqlCommand command = new MySqlCommand("INSERT INTO `users` (`login`, `pass`, `name`, `surname`) VALUES (@login, @pass, @name, @surname)", db.getConnection());

            command.Parameters.Add("@login",MySqlDbType.VarChar).Value = LoginField.Text;
            command.Parameters.Add("@pass", MySqlDbType.VarChar).Value = PasswordField.Text;
            command.Parameters.Add("@name", MySqlDbType.VarChar).Value = UserNameField.Text;
            command.Parameters.Add("@surname", MySqlDbType.VarChar).Value = UserSurnameField.Text;

            db.openConnection();

            if(command.ExecuteNonQuery() == 1)
            {
                MessageBox.Show("Account was complete");
            }
            else
            {
                MessageBox.Show("Account dos't create");
            }

            db.closeConnection();
        }

        public bool isUserExists()
        {
            DB db = new DB();

            DataTable table = new DataTable();

            MySqlDataAdapter adapter = new MySqlDataAdapter();

            MySqlCommand command = new MySqlCommand("Select * FROM `users` WHERE `login` = @uL", db.getConnection());
            command.Parameters.Add("@uL", MySqlDbType.VarChar).Value = LoginField.Text;
            

            adapter.SelectCommand = command;
            adapter.Fill(table);
            if (table.Rows.Count > 0)
            {
                MessageBox.Show("there is already such a login");
                return true;
            }
            else
                return false;
                
        }

        private void SignUpLabel_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
        }

        private void UserSurnameField_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
