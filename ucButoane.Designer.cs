namespace Ra
{
    partial class ucButoane
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(6, 0);
            button1.Name = "button1";
            button1.Size = new Size(103, 30);
            button1.TabIndex = 0;
            button1.Text = "REGISTRU";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(6, 36);
            button2.Name = "button2";
            button2.Size = new Size(103, 32);
            button2.TabIndex = 1;
            button2.Text = "CAPITOL 1";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(6, 74);
            button3.Name = "button3";
            button3.Size = new Size(103, 32);
            button3.TabIndex = 2;
            button3.Text = "CAPITOL 2.A";
            button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Location = new Point(6, 112);
            button4.Name = "button4";
            button4.Size = new Size(103, 32);
            button4.TabIndex = 3;
            button4.Text = "CAPITOL 2.B";
            button4.UseVisualStyleBackColor = true;
            // 
            // ucButoane
            // 
            AutoScaleMode = AutoScaleMode.None;
            BorderStyle = BorderStyle.Fixed3D;
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "ucButoane";
            Size = new Size(111, 499);
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
    }
}
