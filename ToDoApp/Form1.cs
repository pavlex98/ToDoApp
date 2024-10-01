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

        }

        private void roundedButton1_MouseMove(object sender, MouseEventArgs e)
        {

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

        private void closeButton_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void closeButton_MouseEnter(object sender, EventArgs e)
        {
            closeButton.ForeColor = Color.Black;
        }

        private void closeButton_MouseLeave(object sender, EventArgs e)
        {
            closeButton.ForeColor = Color.White;
        }

        private void LoginButton_MouseEnter(object sender, EventArgs e)
        {
            LoginButton.BackColor = Color.White;
            LoginButton.ForeColor = Color.FromArgb(45, 48, 51);
        }

        private void LoginButton_MouseLeave(object sender, EventArgs e)
        {
            LoginButton.BackColor = Color.FromArgb(45, 48, 51);
            LoginButton.ForeColor = Color.White;
        }

        private void SignUpLabel_MouseEnter(object sender, EventArgs e)
        {
            SignUpLabel.ForeColor = Color.Black;
        }

        private void SignUpLabel_MouseLeave(object sender, EventArgs e)
        {
            SignUpLabel.ForeColor = Color.White;
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            string userlogin = LoginField.Text;
            string passuser = PasswordField.Text;

            DB db = new DB();

            DataTable table = new DataTable();

            MySqlDataAdapter adapter = new MySqlDataAdapter();

            MySqlCommand command = new MySqlCommand("Select * FROM `users` WHERE `login` = @uL AND `pass`=@uP", db.getConnection());
            command.Parameters.Add("@uL", MySqlDbType.VarChar).Value = userlogin;
            command.Parameters.Add("@uP", MySqlDbType.VarChar).Value = passuser;

            adapter.SelectCommand = command;
            adapter.Fill(table); // Записываем данные с запроса в table
            if (table.Rows.Count > 0)
                MessageBox.Show("Good Job!!!");
            else
                MessageBox.Show("Baaad!!!");

        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }

        private void PasswordField_TextChanged(object sender, EventArgs e)
        {

        }

        private void LoginField_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void SignUpLabel_Click(object sender, EventArgs e)
        {

        }
    }
    
}
