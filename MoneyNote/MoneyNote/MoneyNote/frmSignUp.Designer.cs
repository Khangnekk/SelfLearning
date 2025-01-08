namespace MoneyNote
{
    partial class frmSignUp
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
            tbUsername = new TextBox();
            label1 = new Label();
            colorDialog1 = new ColorDialog();
            label2 = new Label();
            btnLogin = new Button();
            tbPassword = new TextBox();
            tbRePassword = new TextBox();
            btnEye2 = new Button();
            button1 = new Button();
            label3 = new Label();
            SuspendLayout();
            // 
            // tbUsername
            // 
            tbUsername.Font = new Font("Segoe UI", 12F);
            tbUsername.Location = new Point(130, 95);
            tbUsername.Name = "tbUsername";
            tbUsername.PlaceholderText = "User name";
            tbUsername.Size = new Size(320, 29);
            tbUsername.TabIndex = 7;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            label1.ForeColor = Color.CornflowerBlue;
            label1.Location = new Point(186, 40);
            label1.Name = "label1";
            label1.Size = new Size(198, 37);
            label1.TabIndex = 6;
            label1.Text = "Nò tè tool toy";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = SystemColors.ButtonShadow;
            label2.Location = new Point(28, 274);
            label2.Name = "label2";
            label2.Size = new Size(75, 15);
            label2.TabIndex = 10;
            label2.Text = "version: 1.0.0";
            // 
            // btnLogin
            // 
            btnLogin.Cursor = Cursors.Hand;
            btnLogin.Font = new Font("Segoe UI", 12F);
            btnLogin.Location = new Point(358, 217);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(92, 30);
            btnLogin.TabIndex = 9;
            btnLogin.Text = "➡️";
            btnLogin.UseVisualStyleBackColor = true;
            // 
            // tbPassword
            // 
            tbPassword.Font = new Font("Segoe UI", 12F);
            tbPassword.Location = new Point(130, 135);
            tbPassword.Name = "tbPassword";
            tbPassword.PlaceholderText = "Password";
            tbPassword.Size = new Size(271, 29);
            tbPassword.TabIndex = 8;
            tbPassword.UseSystemPasswordChar = true;
            // 
            // tbRePassword
            // 
            tbRePassword.Font = new Font("Segoe UI", 12F);
            tbRePassword.Location = new Point(130, 173);
            tbRePassword.Name = "tbRePassword";
            tbRePassword.PlaceholderText = "Re-Password";
            tbRePassword.Size = new Size(271, 29);
            tbRePassword.TabIndex = 12;
            tbRePassword.UseSystemPasswordChar = true;
            // 
            // btnEye2
            // 
            btnEye2.Font = new Font("Segoe UI", 12F);
            btnEye2.ForeColor = SystemColors.AppWorkspace;
            btnEye2.Location = new Point(407, 173);
            btnEye2.Name = "btnEye2";
            btnEye2.Size = new Size(43, 29);
            btnEye2.TabIndex = 13;
            btnEye2.Text = "👁️";
            btnEye2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 12F);
            button1.ForeColor = SystemColors.AppWorkspace;
            button1.Location = new Point(407, 135);
            button1.Name = "button1";
            button1.Size = new Size(43, 28);
            button1.TabIndex = 14;
            button1.Text = "👁️";
            button1.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Cursor = Cursors.Hand;
            label3.ForeColor = SystemColors.Highlight;
            label3.Location = new Point(130, 227);
            label3.Name = "label3";
            label3.Size = new Size(100, 15);
            label3.TabIndex = 16;
            label3.Text = "I have an account";
            label3.Click += label3_Click;
            // 
            // frmSignUp
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(594, 308);
            Controls.Add(label3);
            Controls.Add(button1);
            Controls.Add(btnEye2);
            Controls.Add(tbRePassword);
            Controls.Add(tbUsername);
            Controls.Add(label1);
            Controls.Add(label2);
            Controls.Add(btnLogin);
            Controls.Add(tbPassword);
            Name = "frmSignUp";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmSignUp";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox tbUsername;
        private Label label1;
        private ColorDialog colorDialog1;
        private Label label2;
        private Button btnLogin;
        private TextBox tbPassword;
        private TextBox tbRePassword;
        private Button btnEye2;
        private Button button1;
        private Label label3;
    }
}