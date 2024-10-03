namespace ToDoApp
{
    partial class RegistrationForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.UserNameField = new ToDoApp.RoundedTextBox();
            this.UserSurnameField = new ToDoApp.RoundedTextBox();
            this.LoginButton = new ToDoApp.RoundedButton();
            this.PasswordField = new ToDoApp.RoundedTextBox();
            this.LoginField = new ToDoApp.RoundedTextBox();
            this.SignUpLabel = new System.Windows.Forms.Label();
            this.closeButton = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.closeButton);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 100);
            this.panel1.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Constantia", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(800, 100);
            this.label1.TabIndex = 0;
            this.label1.Text = "Sign up";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.label1_MouseDown);
            this.label1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.label1_MouseMove);
            // 
            // UserNameField
            // 
            this.UserNameField.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.UserNameField.CornerRadius = 25;
            this.UserNameField.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserNameField.Location = new System.Drawing.Point(112, 148);
            this.UserNameField.Multiline = true;
            this.UserNameField.Name = "UserNameField";
            this.UserNameField.Size = new System.Drawing.Size(259, 36);
            this.UserNameField.TabIndex = 14;
            this.UserNameField.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.UserNameField.Enter += new System.EventHandler(this.UserNameField_Enter);
            this.UserNameField.Leave += new System.EventHandler(this.UserNameField_Leave);
            // 
            // UserSurnameField
            // 
            this.UserSurnameField.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.UserSurnameField.CornerRadius = 25;
            this.UserSurnameField.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserSurnameField.Location = new System.Drawing.Point(463, 148);
            this.UserSurnameField.Multiline = true;
            this.UserSurnameField.Name = "UserSurnameField";
            this.UserSurnameField.Size = new System.Drawing.Size(259, 36);
            this.UserSurnameField.TabIndex = 13;
            this.UserSurnameField.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.UserSurnameField.TextChanged += new System.EventHandler(this.UserSurnameField_TextChanged);
            this.UserSurnameField.Enter += new System.EventHandler(this.UserSurnameField_Enter);
            this.UserSurnameField.Leave += new System.EventHandler(this.UserSurnameField_Leave);
            // 
            // LoginButton
            // 
            this.LoginButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.LoginButton.CornerRadius = 30;
            this.LoginButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LoginButton.ForeColor = System.Drawing.SystemColors.Control;
            this.LoginButton.Location = new System.Drawing.Point(333, 359);
            this.LoginButton.Name = "LoginButton";
            this.LoginButton.Size = new System.Drawing.Size(173, 50);
            this.LoginButton.TabIndex = 12;
            this.LoginButton.Text = "Sign up";
            this.LoginButton.UseVisualStyleBackColor = true;
            this.LoginButton.Click += new System.EventHandler(this.LoginButton_Click);
            // 
            // PasswordField
            // 
            this.PasswordField.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PasswordField.CornerRadius = 25;
            this.PasswordField.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PasswordField.Location = new System.Drawing.Point(463, 256);
            this.PasswordField.Multiline = true;
            this.PasswordField.Name = "PasswordField";
            this.PasswordField.Size = new System.Drawing.Size(259, 36);
            this.PasswordField.TabIndex = 11;
            this.PasswordField.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.PasswordField.Enter += new System.EventHandler(this.PasswordField_Enter);
            this.PasswordField.Leave += new System.EventHandler(this.PasswordField_Leave);
            // 
            // LoginField
            // 
            this.LoginField.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LoginField.CornerRadius = 25;
            this.LoginField.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoginField.Location = new System.Drawing.Point(112, 256);
            this.LoginField.Multiline = true;
            this.LoginField.Name = "LoginField";
            this.LoginField.Size = new System.Drawing.Size(259, 36);
            this.LoginField.TabIndex = 10;
            this.LoginField.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.LoginField.Enter += new System.EventHandler(this.LoginField_Enter);
            this.LoginField.Leave += new System.EventHandler(this.LoginField_Leave);
            // 
            // SignUpLabel
            // 
            this.SignUpLabel.AutoSize = true;
            this.SignUpLabel.Location = new System.Drawing.Point(389, 428);
            this.SignUpLabel.Name = "SignUpLabel";
            this.SignUpLabel.Size = new System.Drawing.Size(68, 13);
            this.SignUpLabel.TabIndex = 15;
            this.SignUpLabel.Text = "Authorization";
            this.SignUpLabel.Click += new System.EventHandler(this.SignUpLabel_Click);
            // 
            // closeButton
            // 
            this.closeButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(48)))), ((int)(((byte)(51)))));
            this.closeButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.closeButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.closeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.closeButton.ForeColor = System.Drawing.Color.Transparent;
            this.closeButton.Location = new System.Drawing.Point(760, 12);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(28, 36);
            this.closeButton.TabIndex = 1;
            this.closeButton.Text = "x";
            this.closeButton.UseVisualStyleBackColor = false;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // RegistrationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(48)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.SignUpLabel);
            this.Controls.Add(this.UserNameField);
            this.Controls.Add(this.UserSurnameField);
            this.Controls.Add(this.LoginButton);
            this.Controls.Add(this.PasswordField);
            this.Controls.Add(this.LoginField);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "RegistrationForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RegistrationForm";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private RoundedButton LoginButton;
        private RoundedTextBox PasswordField;
        private RoundedTextBox LoginField;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private RoundedTextBox UserSurnameField;
        private RoundedTextBox UserNameField;
        private System.Windows.Forms.Label SignUpLabel;
        private System.Windows.Forms.Button closeButton;
    }
}