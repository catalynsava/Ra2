namespace Ra.Design
{
    partial class frmLogin
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
            textUser = new TextBox();
            textPassword = new TextBox();
            buttonLogin = new Button();
            textBazaDeDate = new TextBox();
            textServer = new TextBox();
            textPort = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            SuspendLayout();
            // 
            // textUser
            // 
            textUser.Location = new Point(133, 82);
            textUser.Name = "textUser";
            textUser.Size = new Size(177, 27);
            textUser.TabIndex = 0;
            // 
            // textPassword
            // 
            textPassword.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 238);
            textPassword.Location = new Point(133, 115);
            textPassword.Name = "textPassword";
            textPassword.PasswordChar = '●';
            textPassword.Size = new Size(177, 27);
            textPassword.TabIndex = 0;
            // 
            // buttonLogin
            // 
            buttonLogin.Location = new Point(216, 181);
            buttonLogin.Name = "buttonLogin";
            buttonLogin.Size = new Size(94, 37);
            buttonLogin.TabIndex = 2;
            buttonLogin.Text = "Login";
            buttonLogin.UseVisualStyleBackColor = true;
            buttonLogin.Click += buttonLogin_Click;
            // 
            // textBazaDeDate
            // 
            textBazaDeDate.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 238);
            textBazaDeDate.Location = new Point(133, 148);
            textBazaDeDate.Name = "textBazaDeDate";
            textBazaDeDate.Size = new Size(177, 27);
            textBazaDeDate.TabIndex = 3;
            // 
            // textServer
            // 
            textServer.Location = new Point(133, 16);
            textServer.Name = "textServer";
            textServer.Size = new Size(177, 27);
            textServer.TabIndex = 4;
            // 
            // textPort
            // 
            textPort.Location = new Point(233, 49);
            textPort.Name = "textPort";
            textPort.Size = new Size(77, 27);
            textPort.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(29, 16);
            label1.Name = "label1";
            label1.Size = new Size(51, 20);
            label1.TabIndex = 6;
            label1.Text = "server:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(29, 49);
            label2.Name = "label2";
            label2.Size = new Size(40, 20);
            label2.TabIndex = 7;
            label2.Text = "port:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(29, 82);
            label3.Name = "label3";
            label3.Size = new Size(71, 20);
            label3.TabIndex = 8;
            label3.Text = "utilizator:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(29, 115);
            label4.Name = "label4";
            label4.Size = new Size(55, 20);
            label4.TabIndex = 9;
            label4.Text = "parola:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(29, 148);
            label5.Name = "label5";
            label5.Size = new Size(99, 20);
            label5.TabIndex = 10;
            label5.Text = "baza de date:";
            // 
            // frmLogin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(338, 234);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textPort);
            Controls.Add(textServer);
            Controls.Add(textBazaDeDate);
            Controls.Add(buttonLogin);
            Controls.Add(textPassword);
            Controls.Add(textUser);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmLogin";
            SizeGripStyle = SizeGripStyle.Hide;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "RA";
            FormClosing += frmLogin_FormClosing;
            Load += frmLogin_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textUser;
        private TextBox textPassword;
        private Button buttonLogin;
        private TextBox textBazaDeDate;
        private TextBox textServer;
        private TextBox textPort;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
    }
}