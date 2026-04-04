namespace Ra
{
    partial class ucPozitie
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
            label3 = new Label();
            textBoxStrada = new TextBox();
            label2 = new Label();
            label1 = new Label();
            textBoxPozitie = new TextBox();
            textBoxVolum = new TextBox();
            buttonTipExploatatie = new Button();
            buttonLocalitate = new Button();
            buttonTip = new Button();
            textBox1 = new TextBox();
            SuspendLayout();
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 7.8F);
            label3.Location = new Point(253, 82);
            label3.Name = "label3";
            label3.Size = new Size(58, 17);
            label3.TabIndex = 26;
            label3.Text = "STRADA:";
            // 
            // textBoxStrada
            // 
            textBoxStrada.Location = new Point(253, 106);
            textBoxStrada.Margin = new Padding(3, 4, 3, 4);
            textBoxStrada.Name = "textBoxStrada";
            textBoxStrada.Size = new Size(230, 27);
            textBoxStrada.TabIndex = 25;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 7.8F);
            label2.Location = new Point(136, 82);
            label2.Name = "label2";
            label2.Size = new Size(55, 17);
            label2.TabIndex = 24;
            label2.Text = "POZIȚIE:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 7.8F);
            label1.Location = new Point(17, 82);
            label1.Name = "label1";
            label1.Size = new Size(56, 17);
            label1.TabIndex = 23;
            label1.Text = "VOLUM:";
            // 
            // textBoxPozitie
            // 
            textBoxPozitie.Location = new Point(136, 106);
            textBoxPozitie.Margin = new Padding(3, 4, 3, 4);
            textBoxPozitie.Name = "textBoxPozitie";
            textBoxPozitie.Size = new Size(100, 27);
            textBoxPozitie.TabIndex = 22;
            // 
            // textBoxVolum
            // 
            textBoxVolum.Location = new Point(17, 106);
            textBoxVolum.Margin = new Padding(3, 4, 3, 4);
            textBoxVolum.Name = "textBoxVolum";
            textBoxVolum.Size = new Size(100, 27);
            textBoxVolum.TabIndex = 21;
            // 
            // buttonTipExploatatie
            // 
            buttonTipExploatatie.Location = new Point(17, 43);
            buttonTipExploatatie.Margin = new Padding(3, 4, 3, 4);
            buttonTipExploatatie.Name = "buttonTipExploatatie";
            buttonTipExploatatie.Size = new Size(466, 31);
            buttonTipExploatatie.TabIndex = 20;
            buttonTipExploatatie.Text = "TIP EXPLOATAȚIE";
            buttonTipExploatatie.UseVisualStyleBackColor = true;
            // 
            // buttonLocalitate
            // 
            buttonLocalitate.Location = new Point(253, 4);
            buttonLocalitate.Margin = new Padding(3, 4, 3, 4);
            buttonLocalitate.Name = "buttonLocalitate";
            buttonLocalitate.Size = new Size(230, 31);
            buttonLocalitate.TabIndex = 19;
            buttonLocalitate.Text = "LOCALITATE";
            buttonLocalitate.UseVisualStyleBackColor = true;
            // 
            // buttonTip
            // 
            buttonTip.Location = new Point(17, 6);
            buttonTip.Margin = new Padding(3, 4, 3, 4);
            buttonTip.Name = "buttonTip";
            buttonTip.Size = new Size(230, 31);
            buttonTip.TabIndex = 18;
            buttonTip.Text = "PERSOANĂ FIZICĂ LOCALNICĂ";
            buttonTip.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(17, 157);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(466, 123);
            textBox1.TabIndex = 27;
            // 
            // ucPozitie
            // 
            AutoScaleMode = AutoScaleMode.None;
            Controls.Add(textBox1);
            Controls.Add(label3);
            Controls.Add(textBoxStrada);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBoxPozitie);
            Controls.Add(textBoxVolum);
            Controls.Add(buttonTipExploatatie);
            Controls.Add(buttonLocalitate);
            Controls.Add(buttonTip);
            Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 238);
            Margin = new Padding(3, 4, 3, 4);
            Name = "ucPozitie";
            Size = new Size(979, 425);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label3;
        private TextBox textBoxStrada;
        private Label label2;
        private Label label1;
        private TextBox textBoxPozitie;
        private TextBox textBoxVolum;
        private Button buttonTipExploatatie;
        private Button buttonLocalitate;
        private Button buttonTip;
        public TextBox textBox1;
    }
}
