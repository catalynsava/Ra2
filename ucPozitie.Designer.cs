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
            buttonTip = new Button();
            buttonLocalitate = new Button();
            buttonTipExploatatie = new Button();
            textBoxVolum = new TextBox();
            textBoxPozitie = new TextBox();
            label1 = new Label();
            label2 = new Label();
            textBoxStrada = new TextBox();
            label3 = new Label();
            SuspendLayout();
            // 
            // buttonTip
            // 
            buttonTip.Location = new Point(14, 12);
            buttonTip.Margin = new Padding(3, 4, 3, 4);
            buttonTip.Name = "buttonTip";
            buttonTip.Size = new Size(230, 31);
            buttonTip.TabIndex = 0;
            buttonTip.Text = "PERSOANĂ FIZICĂ LOCALNICĂ";
            buttonTip.UseVisualStyleBackColor = true;
            // 
            // buttonLocalitate
            // 
            buttonLocalitate.Location = new Point(250, 10);
            buttonLocalitate.Margin = new Padding(3, 4, 3, 4);
            buttonLocalitate.Name = "buttonLocalitate";
            buttonLocalitate.Size = new Size(230, 31);
            buttonLocalitate.TabIndex = 1;
            buttonLocalitate.Text = "LOCALITATE";
            buttonLocalitate.UseVisualStyleBackColor = true;
            // 
            // buttonTipExploatatie
            // 
            buttonTipExploatatie.Location = new Point(14, 49);
            buttonTipExploatatie.Margin = new Padding(3, 4, 3, 4);
            buttonTipExploatatie.Name = "buttonTipExploatatie";
            buttonTipExploatatie.Size = new Size(466, 31);
            buttonTipExploatatie.TabIndex = 2;
            buttonTipExploatatie.Text = "TIP EXPLOATAȚIE";
            buttonTipExploatatie.UseVisualStyleBackColor = true;
            // 
            // textBoxVolum
            // 
            textBoxVolum.Location = new Point(14, 112);
            textBoxVolum.Margin = new Padding(3, 4, 3, 4);
            textBoxVolum.Name = "textBoxVolum";
            textBoxVolum.Size = new Size(100, 27);
            textBoxVolum.TabIndex = 3;
            // 
            // textBoxPozitie
            // 
            textBoxPozitie.Location = new Point(133, 112);
            textBoxPozitie.Margin = new Padding(3, 4, 3, 4);
            textBoxPozitie.Name = "textBoxPozitie";
            textBoxPozitie.Size = new Size(100, 27);
            textBoxPozitie.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 7.8F);
            label1.Location = new Point(14, 88);
            label1.Name = "label1";
            label1.Size = new Size(56, 17);
            label1.TabIndex = 5;
            label1.Text = "VOLUM:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 7.8F);
            label2.Location = new Point(133, 88);
            label2.Name = "label2";
            label2.Size = new Size(55, 17);
            label2.TabIndex = 6;
            label2.Text = "POZIȚIE:";
            // 
            // textBoxStrada
            // 
            textBoxStrada.Location = new Point(250, 112);
            textBoxStrada.Margin = new Padding(3, 4, 3, 4);
            textBoxStrada.Name = "textBoxStrada";
            textBoxStrada.Size = new Size(230, 27);
            textBoxStrada.TabIndex = 7;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 7.8F);
            label3.Location = new Point(250, 88);
            label3.Name = "label3";
            label3.Size = new Size(58, 17);
            label3.TabIndex = 8;
            label3.Text = "STRADA:";
            // 
            // ucPozitie
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
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
            Size = new Size(495, 187);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonTip;
        private Button buttonLocalitate;
        private Button buttonTipExploatatie;
        private TextBox textBoxVolum;
        private TextBox textBoxPozitie;
        private Label label1;
        private Label label2;
        private TextBox textBoxStrada;
        private Label label3;
    }
}
