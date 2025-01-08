namespace MoneyNote
{
    partial class frmLogin
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            tbUsername = new TextBox();
            colorDialog1 = new ColorDialog();
            tbPassword = new TextBox();
            btnLogin = new Button();
            label2 = new Label();
            btnEye2 = new Button();
            label3 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            label1.ForeColor = Color.CornflowerBlue;
            label1.Location = new Point(141, 25);
            label1.Name = "label1";
            label1.Size = new Size(198, 37);
            label1.TabIndex = 0;
            label1.Text = "Nò tè tool toy";
            // 
            // tbUsername
            // 
            tbUsername.Font = new Font("Segoe UI", 12F);
            tbUsername.Location = new Point(95, 78);
            tbUsername.Name = "tbUsername";
            tbUsername.PlaceholderText = "User name";
            tbUsername.Size = new Size(284, 29);
            tbUsername.TabIndex = 1;
            // 
            // tbPassword
            // 
            tbPassword.Font = new Font("Segoe UI", 12F);
            tbPassword.Location = new Point(95, 118);
            tbPassword.Name = "tbPassword";
            tbPassword.PlaceholderText = "Password";
            tbPassword.Size = new Size(235, 29);
            tbPassword.TabIndex = 2;
            tbPassword.UseSystemPasswordChar = true;
            // 
            // btnLogin
            // 
            btnLogin.Cursor = Cursors.Hand;
            btnLogin.Font = new Font("Segoe UI", 12F);
            btnLogin.Location = new Point(318, 153);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(61, 30);
            btnLogin.TabIndex = 3;
            btnLogin.Text = "➡️";
            btnLogin.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = SystemColors.ButtonShadow;
            label2.Location = new Point(15, 204);
            label2.Name = "label2";
            label2.Size = new Size(75, 15);
            label2.TabIndex = 4;
            label2.Text = "version: 1.0.0";
            // 
            // btnEye2
            // 
            btnEye2.Cursor = Cursors.Hand;
            btnEye2.Font = new Font("Segoe UI", 12F);
            btnEye2.ForeColor = SystemColors.AppWorkspace;
            btnEye2.Location = new Point(336, 118);
            btnEye2.Name = "btnEye2";
            btnEye2.Size = new Size(43, 29);
            btnEye2.TabIndex = 14;
            btnEye2.Text = "👁️";
            btnEye2.UseVisualStyleBackColor = true;
            btnEye2.MouseDown += btnEye2_MouseDown;
            btnEye2.MouseUp += btnEye2_MouseUp;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Cursor = Cursors.Hand;
            label3.ForeColor = SystemColors.Highlight;
            label3.Location = new Point(95, 163);
            label3.Name = "label3";
            label3.Size = new Size(108, 15);
            label3.TabIndex = 15;
            label3.Text = "Create an account?";
            label3.Click += label3_Click;
            // 
            // frmLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(476, 225);
            Controls.Add(label3);
            Controls.Add(btnEye2);
            Controls.Add(label2);
            Controls.Add(btnLogin);
            Controls.Add(tbPassword);
            Controls.Add(tbUsername);
            Controls.Add(label1);
            Name = "frmLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            WindowState = FormWindowState.Minimized;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox tbUsername;
        private ColorDialog colorDialog1;
        private TextBox tbPassword;
        private Button btnLogin;
        private Label label2;
        private Button btnEye2;
        private Label label3;
    }
}
