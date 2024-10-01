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

            LoginField.Text = "Enter login";
            LoginField.ForeColor = Color.Gray;
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close();
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
            }
        }

        private void UserNameField_Leave(object sender, EventArgs e)
        {
            if (UserNameField.Text == "")
            {
                UserNameField.Text = "Name";
                UserNameField.ForeColor = Color.Black;
            }
        }

        private void LoginField_Enter(object sender, EventArgs e)
        {
            if(LoginField.Text == "Enter login")
            {
                LoginField.Text = "";
            }
        }
        private void LoginField_Leave(object sender, EventArgs e)
        {
            if(LoginField.Text == "")
            {
                LoginField.Text = "Enter login";
                LoginField.ForeColor = Color.Black;
            }
        }

        private void PasswordField_Leave(object sender, EventArgs e)
        {

        }

    }
}
