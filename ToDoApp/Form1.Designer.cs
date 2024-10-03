namespace ToDoApp
{
    partial class LoginForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.closedButton = new System.Windows.Forms.Button();
            this.closeButton = new System.Windows.Forms.Button();
            this.SignUpLabel = new System.Windows.Forms.Label();
            this.loginFieldTextBox = new System.Windows.Forms.TextBox();
            this.PasswordFieldTextBox = new System.Windows.Forms.TextBox();
            this.SignUPlabelLoginForm = new System.Windows.Forms.Label();
            this.loginButtoninLoginForm = new ToDoApp.RoundedButton();
            this.LoginButton = new ToDoApp.RoundedButton();
            this.PasswordField = new ToDoApp.RoundedTextBox();
            this.LoginField = new ToDoApp.RoundedTextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.Font = new System.Drawing.Font("Constantia", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(862, 100);
            this.label1.TabIndex = 0;
            this.label1.Text = "Login";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.label1_MouseDown);
            this.label1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.label1_MouseMove);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.closedButton);
            this.panel1.Controls.Add(this.closeButton);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(0, 3, 0, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(862, 100);
            this.panel1.TabIndex = 1;
            // 
            // closedButton
            // 
            this.closedButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(48)))), ((int)(((byte)(51)))));
            this.closedButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.closedButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.closedButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.closedButton.ForeColor = System.Drawing.Color.Transparent;
            this.closedButton.Location = new System.Drawing.Point(822, 12);
            this.closedButton.Name = "closedButton";
            this.closedButton.Size = new System.Drawing.Size(28, 36);
            this.closedButton.TabIndex = 9;
            this.closedButton.Text = "x";
            this.closedButton.UseVisualStyleBackColor = false;
            this.closedButton.Click += new System.EventHandler(this.closedButton_Click);
            this.closedButton.MouseEnter += new System.EventHandler(this.closedButton_MouseEnter);
            this.closedButton.MouseLeave += new System.EventHandler(this.closedButton_MouseLeave);
            // 
            // closeButton
            // 
            this.closeButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(48)))), ((int)(((byte)(51)))));
            this.closeButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.closeButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.closeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.closeButton.ForeColor = System.Drawing.Color.Transparent;
            this.closeButton.Location = new System.Drawing.Point(-32768, 3);
            this.closeButton.Margin = new System.Windows.Forms.Padding(0, 3, 0, 3);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(0, 36);
            this.closeButton.TabIndex = 1;
            this.closeButton.Text = "x";
            this.closeButton.UseVisualStyleBackColor = false;
            // 
            // SignUpLabel
            // 
            this.SignUpLabel.AutoSize = true;
            this.SignUpLabel.Location = new System.Drawing.Point(-32768, 455);
            this.SignUpLabel.Margin = new System.Windows.Forms.Padding(0);
            this.SignUpLabel.Name = "SignUpLabel";
            this.SignUpLabel.Size = new System.Drawing.Size(45, 13);
            this.SignUpLabel.TabIndex = 8;
            this.SignUpLabel.Text = "Sign Up";
            this.SignUpLabel.Click += new System.EventHandler(this.SignUpLabel_Click);
            this.SignUpLabel.MouseEnter += new System.EventHandler(this.SignUpLabel_MouseEnter);
            this.SignUpLabel.MouseLeave += new System.EventHandler(this.SignUpLabel_MouseLeave);
            // 
            // loginFieldTextBox
            // 
            this.loginFieldTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.loginFieldTextBox.Font = new System.Drawing.Font("Georgia", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.loginFieldTextBox.ForeColor = System.Drawing.SystemColors.ControlText;
            this.loginFieldTextBox.Location = new System.Drawing.Point(275, 227);
            this.loginFieldTextBox.Multiline = true;
            this.loginFieldTextBox.Name = "loginFieldTextBox";
            this.loginFieldTextBox.Size = new System.Drawing.Size(323, 36);
            this.loginFieldTextBox.TabIndex = 10;
            this.loginFieldTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.loginFieldTextBox.Enter += new System.EventHandler(this.loginFieldTextBox_Enter);
            this.loginFieldTextBox.Leave += new System.EventHandler(this.loginFieldTextBox_Leave);
            // 
            // PasswordFieldTextBox
            // 
            this.PasswordFieldTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PasswordFieldTextBox.Font = new System.Drawing.Font("Georgia", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PasswordFieldTextBox.ForeColor = System.Drawing.SystemColors.ControlText;
            this.PasswordFieldTextBox.Location = new System.Drawing.Point(275, 309);
            this.PasswordFieldTextBox.Multiline = true;
            this.PasswordFieldTextBox.Name = "PasswordFieldTextBox";
            this.PasswordFieldTextBox.Size = new System.Drawing.Size(323, 36);
            this.PasswordFieldTextBox.TabIndex = 11;
            this.PasswordFieldTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.PasswordFieldTextBox.Enter += new System.EventHandler(this.PasswordFieldTextBox_Enter);
            this.PasswordFieldTextBox.Leave += new System.EventHandler(this.PasswordFieldTextBox_Leave);
            // 
            // SignUPlabelLoginForm
            // 
            this.SignUPlabelLoginForm.AutoSize = true;
            this.SignUPlabelLoginForm.Location = new System.Drawing.Point(423, 502);
            this.SignUPlabelLoginForm.Name = "SignUPlabelLoginForm";
            this.SignUPlabelLoginForm.Size = new System.Drawing.Size(43, 13);
            this.SignUPlabelLoginForm.TabIndex = 12;
            this.SignUPlabelLoginForm.Text = "Sign up";
            this.SignUPlabelLoginForm.Click += new System.EventHandler(this.SignUPlabelLoginForm_Click);
            this.SignUPlabelLoginForm.MouseEnter += new System.EventHandler(this.SignUPlabelLoginForm_MouseEnter);
            this.SignUPlabelLoginForm.MouseLeave += new System.EventHandler(this.SignUPlabelLoginForm_MouseLeave);
            // 
            // loginButtoninLoginForm
            // 
            this.loginButtoninLoginForm.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.loginButtoninLoginForm.CornerRadius = 30;
            this.loginButtoninLoginForm.Location = new System.Drawing.Point(386, 437);
            this.loginButtoninLoginForm.Name = "loginButtoninLoginForm";
            this.loginButtoninLoginForm.Size = new System.Drawing.Size(120, 40);
            this.loginButtoninLoginForm.TabIndex = 9;
            this.loginButtoninLoginForm.Text = "Login";
            this.loginButtoninLoginForm.UseVisualStyleBackColor = true;
            this.loginButtoninLoginForm.Click += new System.EventHandler(this.loginButtoninLoginForm_Click);
            this.loginButtoninLoginForm.MouseEnter += new System.EventHandler(this.loginButtoninLoginForm_MouseEnter_1);
            this.loginButtoninLoginForm.MouseLeave += new System.EventHandler(this.loginButtoninLoginForm_MouseLeave_1);
            // 
            // LoginButton
            // 
            this.LoginButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.LoginButton.CornerRadius = 30;
            this.LoginButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LoginButton.Location = new System.Drawing.Point(-32337, 403);
            this.LoginButton.Margin = new System.Windows.Forms.Padding(0, 3, 0, 3);
            this.LoginButton.Name = "LoginButton";
            this.LoginButton.Size = new System.Drawing.Size(0, 71);
            this.LoginButton.TabIndex = 7;
            this.LoginButton.Text = "Login";
            this.LoginButton.UseVisualStyleBackColor = true;
            // 
            // PasswordField
            // 
            this.PasswordField.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PasswordField.CornerRadius = 25;
            this.PasswordField.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PasswordField.Location = new System.Drawing.Point(-32768, 287);
            this.PasswordField.Margin = new System.Windows.Forms.Padding(0, 3, 0, 3);
            this.PasswordField.Multiline = true;
            this.PasswordField.Name = "PasswordField";
            this.PasswordField.Size = new System.Drawing.Size(862, 36);
            this.PasswordField.TabIndex = 6;
            this.PasswordField.Text = "Password";
            this.PasswordField.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.PasswordField.UseSystemPasswordChar = true;
            // 
            // LoginField
            // 
            this.LoginField.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LoginField.CornerRadius = 25;
            this.LoginField.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoginField.Location = new System.Drawing.Point(-32768, 221);
            this.LoginField.Margin = new System.Windows.Forms.Padding(0, 3, 0, 3);
            this.LoginField.Multiline = true;
            this.LoginField.Name = "LoginField";
            this.LoginField.Size = new System.Drawing.Size(862, 73);
            this.LoginField.TabIndex = 5;
            this.LoginField.Text = "Username";
            this.LoginField.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(48)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(862, 533);
            this.Controls.Add(this.SignUPlabelLoginForm);
            this.Controls.Add(this.PasswordFieldTextBox);
            this.Controls.Add(this.loginFieldTextBox);
            this.Controls.Add(this.loginButtoninLoginForm);
            this.Controls.Add(this.SignUpLabel);
            this.Controls.Add(this.LoginButton);
            this.Controls.Add(this.PasswordField);
            this.Controls.Add(this.LoginField);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.SystemColors.Control;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(0, 3, 0, 3);
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LoginForm";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button closeButton;
        private RoundedTextBox LoginField;
        private RoundedTextBox PasswordField;
        private RoundedButton LoginButton;
        private System.Windows.Forms.Label SignUpLabel;
        private System.Windows.Forms.Button closedButton;
        private RoundedButton loginButtoninLoginForm;
        private System.Windows.Forms.TextBox loginFieldTextBox;
        private System.Windows.Forms.TextBox PasswordFieldTextBox;
        private System.Windows.Forms.Label SignUPlabelLoginForm;
    }
}

