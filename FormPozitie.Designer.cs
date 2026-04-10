namespace Ra
{
    partial class FormPozitie
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
            label3 = new Label();
            textBoxStrada = new TextBox();
            label2 = new Label();
            label1 = new Label();
            textBoxPozitie = new TextBox();
            textBoxVolum = new TextBox();
            buttonTipExploatatie = new Button();
            buttonLocalitate = new Button();
            buttonTip = new Button();
            SuspendLayout();
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 7.8F);
            label3.Location = new Point(248, 89);
            label3.Name = "label3";
            label3.Size = new Size(58, 17);
            label3.TabIndex = 17;
            label3.Text = "STRADA:";
            // 
            // textBoxStrada
            // 
            textBoxStrada.Location = new Point(248, 113);
            textBoxStrada.Margin = new Padding(3, 4, 3, 4);
            textBoxStrada.Name = "textBoxStrada";
            textBoxStrada.Size = new Size(230, 27);
            textBoxStrada.TabIndex = 16;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 7.8F);
            label2.Location = new Point(131, 89);
            label2.Name = "label2";
            label2.Size = new Size(55, 17);
            label2.TabIndex = 15;
            label2.Text = "POZIȚIE:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 7.8F);
            label1.Location = new Point(12, 89);
            label1.Name = "label1";
            label1.Size = new Size(56, 17);
            label1.TabIndex = 14;
            label1.Text = "VOLUM:";
            // 
            // textBoxPozitie
            // 
            textBoxPozitie.Location = new Point(131, 113);
            textBoxPozitie.Margin = new Padding(3, 4, 3, 4);
            textBoxPozitie.Name = "textBoxPozitie";
            textBoxPozitie.Size = new Size(100, 27);
            textBoxPozitie.TabIndex = 13;
            // 
            // textBoxVolum
            // 
            textBoxVolum.Location = new Point(12, 113);
            textBoxVolum.Margin = new Padding(3, 4, 3, 4);
            textBoxVolum.Name = "textBoxVolum";
            textBoxVolum.Size = new Size(100, 27);
            textBoxVolum.TabIndex = 12;
            // 
            // buttonTipExploatatie
            // 
            buttonTipExploatatie.Location = new Point(12, 50);
            buttonTipExploatatie.Margin = new Padding(3, 4, 3, 4);
            buttonTipExploatatie.Name = "buttonTipExploatatie";
            buttonTipExploatatie.Size = new Size(466, 31);
            buttonTipExploatatie.TabIndex = 11;
            buttonTipExploatatie.Text = "TIP EXPLOATAȚIE";
            buttonTipExploatatie.UseVisualStyleBackColor = true;
            // 
            // buttonLocalitate
            // 
            buttonLocalitate.Location = new Point(248, 11);
            buttonLocalitate.Margin = new Padding(3, 4, 3, 4);
            buttonLocalitate.Name = "buttonLocalitate";
            buttonLocalitate.Size = new Size(230, 31);
            buttonLocalitate.TabIndex = 10;
            buttonLocalitate.Text = "LOCALITATE";
            buttonLocalitate.UseVisualStyleBackColor = true;
            buttonLocalitate.Click += buttonLocalitate_Click;
            // 
            // buttonTip
            // 
            buttonTip.Location = new Point(12, 13);
            buttonTip.Margin = new Padding(3, 4, 3, 4);
            buttonTip.Name = "buttonTip";
            buttonTip.Size = new Size(230, 31);
            buttonTip.TabIndex = 9;
            buttonTip.Text = "PERSOANĂ FIZICĂ LOCALNICĂ";
            buttonTip.UseVisualStyleBackColor = true;
            buttonTip.Click += buttonTip_Click;
            // 
            // FormPozitie
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(549, 521);
            Controls.Add(buttonTipExploatatie);
            Controls.Add(buttonLocalitate);
            Controls.Add(buttonTip);
            Controls.Add(label3);
            Controls.Add(textBoxStrada);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBoxPozitie);
            Controls.Add(textBoxVolum);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormPozitie";
            Text = "FormPozitie";
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
    }
}