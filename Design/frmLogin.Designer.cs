using System.Windows.Forms;

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
            textBazaDeDate = new TextBox();
            textServer = new TextBox();
            textPort = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            tableLayoutPanel1 = new TableLayoutPanel();
            labelLogin = new Label();
            buttonLogin = new Button();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // textUser
            // 
            textUser.Anchor = AnchorStyles.None;
            textUser.Font = new Font("Segoe UI", 9F);
            textUser.Location = new Point(143, 77);
            textUser.Name = "textUser";
            textUser.Size = new Size(177, 27);
            textUser.TabIndex = 4;
            // 
            // textPassword
            // 
            textPassword.Anchor = AnchorStyles.None;
            textPassword.Font = new Font("Segoe UI", 9F);
            textPassword.Location = new Point(143, 110);
            textPassword.Name = "textPassword";
            textPassword.PasswordChar = '●';
            textPassword.Size = new Size(177, 27);
            textPassword.TabIndex = 0;
            textPassword.KeyUp += textPassword_KeyUp;
            // 
            // textBazaDeDate
            // 
            textBazaDeDate.Anchor = AnchorStyles.Left;
            textBazaDeDate.Font = new Font("Segoe UI", 9F);
            textBazaDeDate.Location = new Point(141, 143);
            textBazaDeDate.Name = "textBazaDeDate";
            textBazaDeDate.Size = new Size(177, 27);
            textBazaDeDate.TabIndex = 5;
            // 
            // textServer
            // 
            textServer.Anchor = AnchorStyles.None;
            textServer.Font = new Font("Segoe UI", 9F);
            textServer.Location = new Point(143, 7);
            textServer.Name = "textServer";
            textServer.Size = new Size(177, 27);
            textServer.TabIndex = 2;
            // 
            // textPort
            // 
            textPort.Anchor = AnchorStyles.None;
            textPort.Font = new Font("Segoe UI", 9F);
            textPort.Location = new Point(143, 44);
            textPort.Name = "textPort";
            textPort.Size = new Size(177, 27);
            textPort.TabIndex = 3;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Left;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F);
            label1.Location = new Point(3, 10);
            label1.Name = "label1";
            label1.Size = new Size(51, 20);
            label1.TabIndex = 6;
            label1.Text = "server:";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Left;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F);
            label2.Location = new Point(3, 47);
            label2.Name = "label2";
            label2.Size = new Size(40, 20);
            label2.TabIndex = 7;
            label2.Text = "port:";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Left;
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F);
            label3.Location = new Point(3, 80);
            label3.Name = "label3";
            label3.Size = new Size(71, 20);
            label3.TabIndex = 8;
            label3.Text = "utilizator:";
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Left;
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F);
            label4.Location = new Point(3, 113);
            label4.Name = "label4";
            label4.Size = new Size(55, 20);
            label4.TabIndex = 9;
            label4.Text = "parola:";
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Left;
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F);
            label5.Location = new Point(3, 146);
            label5.Name = "label5";
            label5.Size = new Size(99, 20);
            label5.TabIndex = 10;
            label5.Text = "baza de date:";
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.Anchor = AnchorStyles.None;
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 42.67352F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 57.3264771F));
            tableLayoutPanel1.Controls.Add(labelLogin, 0, 5);
            tableLayoutPanel1.Controls.Add(textServer, 1, 0);
            tableLayoutPanel1.Controls.Add(label1, 0, 0);
            tableLayoutPanel1.Controls.Add(label5, 0, 4);
            tableLayoutPanel1.Controls.Add(label2, 0, 1);
            tableLayoutPanel1.Controls.Add(textBazaDeDate, 1, 4);
            tableLayoutPanel1.Controls.Add(textPort, 1, 1);
            tableLayoutPanel1.Controls.Add(textUser, 1, 2);
            tableLayoutPanel1.Controls.Add(label3, 0, 2);
            tableLayoutPanel1.Controls.Add(textPassword, 1, 3);
            tableLayoutPanel1.Controls.Add(label4, 0, 3);
            tableLayoutPanel1.Controls.Add(buttonLogin, 1, 6);
            tableLayoutPanel1.Location = new Point(8, 10);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 7;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.Size = new Size(325, 238);
            tableLayoutPanel1.TabIndex = 12;
            // 
            // labelLogin
            // 
            tableLayoutPanel1.SetColumnSpan(labelLogin, 2);
            labelLogin.Dock = DockStyle.Fill;
            labelLogin.Font = new Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 238);
            labelLogin.ForeColor = SystemColors.ControlDarkDark;
            labelLogin.Location = new Point(3, 173);
            labelLogin.Name = "labelLogin";
            labelLogin.Size = new Size(319, 20);
            labelLogin.TabIndex = 13;
            labelLogin.Text = "ⓒRegistrul Agricol V.1.283226";
            labelLogin.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // buttonLogin
            // 
            buttonLogin.Anchor = AnchorStyles.Right;
            buttonLogin.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 238);
            buttonLogin.Location = new Point(245, 196);
            buttonLogin.Name = "buttonLogin";
            buttonLogin.Size = new Size(77, 39);
            buttonLogin.TabIndex = 14;
            buttonLogin.Text = "LOGIN";
            buttonLogin.UseVisualStyleBackColor = true;
            buttonLogin.Click += buttonLogin_Click;
            // 
            // frmLogin
            // 
            AutoScaleDimensions = new SizeF(120F, 120F);
            AutoScaleMode = AutoScaleMode.Dpi;
            ClientSize = new Size(341, 258);
            Controls.Add(tableLayoutPanel1);
            Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 238);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmLogin";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "RA";
            TopMost = true;
            FormClosing += frmLogin_FormClosing;
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TextBox textUser;
        private TextBox textPassword;
        private TextBox textBazaDeDate;
        private TextBox textServer;
        private TextBox textPort;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TableLayoutPanel tableLayoutPanel1;
        private Label labelLogin;
        private Button buttonLogin;
    }
}