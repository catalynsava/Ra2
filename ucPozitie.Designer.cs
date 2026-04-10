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
            tableLayoutPozitie = new TableLayoutPanel();
            tableLayoutPozitie.SuspendLayout();
            SuspendLayout();
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Dock = DockStyle.Fill;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 238);
            label3.Location = new Point(3, 120);
            label3.Name = "label3";
            label3.Size = new Size(122, 40);
            label3.TabIndex = 26;
            label3.Text = "STRADA:";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // textBoxStrada
            // 
            tableLayoutPozitie.SetColumnSpan(textBoxStrada, 3);
            textBoxStrada.Dock = DockStyle.Fill;
            textBoxStrada.Location = new Point(131, 124);
            textBoxStrada.Margin = new Padding(3, 4, 3, 4);
            textBoxStrada.Name = "textBoxStrada";
            textBoxStrada.Size = new Size(380, 31);
            textBoxStrada.TabIndex = 25;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Dock = DockStyle.Fill;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 238);
            label2.Location = new Point(259, 80);
            label2.Name = "label2";
            label2.Size = new Size(122, 40);
            label2.TabIndex = 24;
            label2.Text = "POZIȚIE:";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Dock = DockStyle.Fill;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 238);
            label1.Location = new Point(3, 80);
            label1.Name = "label1";
            label1.Size = new Size(122, 40);
            label1.TabIndex = 23;
            label1.Text = "VOLUM:";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // textBoxPozitie
            // 
            textBoxPozitie.Dock = DockStyle.Fill;
            textBoxPozitie.Font = new Font("Segoe UI", 9.75F);
            textBoxPozitie.Location = new Point(387, 84);
            textBoxPozitie.Margin = new Padding(3, 4, 3, 4);
            textBoxPozitie.Name = "textBoxPozitie";
            textBoxPozitie.Size = new Size(124, 29);
            textBoxPozitie.TabIndex = 22;
            // 
            // textBoxVolum
            // 
            textBoxVolum.Dock = DockStyle.Fill;
            textBoxVolum.Font = new Font("Segoe UI", 9.75F);
            textBoxVolum.Location = new Point(131, 84);
            textBoxVolum.Margin = new Padding(3, 4, 3, 4);
            textBoxVolum.Name = "textBoxVolum";
            textBoxVolum.Size = new Size(122, 29);
            textBoxVolum.TabIndex = 21;
            // 
            // buttonTipExploatatie
            // 
            tableLayoutPozitie.SetColumnSpan(buttonTipExploatatie, 4);
            buttonTipExploatatie.Dock = DockStyle.Fill;
            buttonTipExploatatie.Font = new Font("Segoe UI", 9.75F);
            buttonTipExploatatie.Location = new Point(3, 44);
            buttonTipExploatatie.Margin = new Padding(3, 4, 3, 4);
            buttonTipExploatatie.Name = "buttonTipExploatatie";
            buttonTipExploatatie.Size = new Size(508, 32);
            buttonTipExploatatie.TabIndex = 20;
            buttonTipExploatatie.Text = "TIP EXPLOATAȚIE";
            buttonTipExploatatie.UseVisualStyleBackColor = true;
            buttonTipExploatatie.Click += buttonTipExploatatie_Click;
            // 
            // buttonLocalitate
            // 
            tableLayoutPozitie.SetColumnSpan(buttonLocalitate, 2);
            buttonLocalitate.Dock = DockStyle.Fill;
            buttonLocalitate.Font = new Font("Segoe UI", 9.75F);
            buttonLocalitate.Location = new Point(259, 4);
            buttonLocalitate.Margin = new Padding(3, 4, 3, 4);
            buttonLocalitate.Name = "buttonLocalitate";
            buttonLocalitate.Size = new Size(252, 32);
            buttonLocalitate.TabIndex = 19;
            buttonLocalitate.Text = "LOCALITATE";
            buttonLocalitate.UseVisualStyleBackColor = true;
            buttonLocalitate.Click += buttonLocalitate_Click;
            // 
            // buttonTip
            // 
            tableLayoutPozitie.SetColumnSpan(buttonTip, 2);
            buttonTip.Dock = DockStyle.Fill;
            buttonTip.Font = new Font("Segoe UI", 9.75F);
            buttonTip.Location = new Point(3, 4);
            buttonTip.Margin = new Padding(3, 4, 3, 4);
            buttonTip.Name = "buttonTip";
            buttonTip.Size = new Size(250, 32);
            buttonTip.TabIndex = 18;
            buttonTip.Text = "PERSOANĂ FIZICĂ LOCALNICĂ";
            buttonTip.UseVisualStyleBackColor = true;
            buttonTip.Click += buttonTip_Click;
            // 
            // textBox1
            // 
            tableLayoutPozitie.SetColumnSpan(textBox1, 4);
            textBox1.Dock = DockStyle.Fill;
            textBox1.Location = new Point(3, 163);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            tableLayoutPozitie.SetRowSpan(textBox1, 8);
            textBox1.Size = new Size(508, 311);
            textBox1.TabIndex = 27;
            // 
            // tableLayoutPozitie
            // 
            tableLayoutPozitie.ColumnCount = 4;
            tableLayoutPozitie.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPozitie.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPozitie.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPozitie.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPozitie.Controls.Add(buttonTip, 0, 0);
            tableLayoutPozitie.Controls.Add(label1, 0, 2);
            tableLayoutPozitie.Controls.Add(textBoxVolum, 1, 2);
            tableLayoutPozitie.Controls.Add(label2, 2, 2);
            tableLayoutPozitie.Controls.Add(textBoxPozitie, 3, 2);
            tableLayoutPozitie.Controls.Add(label3, 0, 3);
            tableLayoutPozitie.Controls.Add(textBoxStrada, 1, 3);
            tableLayoutPozitie.Controls.Add(buttonLocalitate, 2, 0);
            tableLayoutPozitie.Controls.Add(buttonTipExploatatie, 0, 1);
            tableLayoutPozitie.Controls.Add(textBox1, 0, 4);
            tableLayoutPozitie.Dock = DockStyle.Fill;
            tableLayoutPozitie.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 238);
            tableLayoutPozitie.Location = new Point(0, 0);
            tableLayoutPozitie.Name = "tableLayoutPozitie";
            tableLayoutPozitie.RowCount = 18;
            tableLayoutPozitie.RowStyles.Add(new RowStyle(SizeType.Percent, 5.576383F));
            tableLayoutPozitie.RowStyles.Add(new RowStyle(SizeType.Percent, 5.576383F));
            tableLayoutPozitie.RowStyles.Add(new RowStyle(SizeType.Percent, 5.576383F));
            tableLayoutPozitie.RowStyles.Add(new RowStyle(SizeType.Percent, 5.576383F));
            tableLayoutPozitie.RowStyles.Add(new RowStyle(SizeType.Percent, 5.15463924F));
            tableLayoutPozitie.RowStyles.Add(new RowStyle(SizeType.Percent, 5.623244F));
            tableLayoutPozitie.RowStyles.Add(new RowStyle(SizeType.Percent, 5.576383F));
            tableLayoutPozitie.RowStyles.Add(new RowStyle(SizeType.Percent, 5.576383F));
            tableLayoutPozitie.RowStyles.Add(new RowStyle(SizeType.Percent, 5.576383F));
            tableLayoutPozitie.RowStyles.Add(new RowStyle(SizeType.Percent, 5.576383F));
            tableLayoutPozitie.RowStyles.Add(new RowStyle(SizeType.Percent, 5.576383F));
            tableLayoutPozitie.RowStyles.Add(new RowStyle(SizeType.Percent, 5.576383F));
            tableLayoutPozitie.RowStyles.Add(new RowStyle(SizeType.Percent, 5.576383F));
            tableLayoutPozitie.RowStyles.Add(new RowStyle(SizeType.Percent, 5.576383F));
            tableLayoutPozitie.RowStyles.Add(new RowStyle(SizeType.Percent, 5.576383F));
            tableLayoutPozitie.RowStyles.Add(new RowStyle(SizeType.Percent, 5.576383F));
            tableLayoutPozitie.RowStyles.Add(new RowStyle(SizeType.Percent, 5.576383F));
            tableLayoutPozitie.RowStyles.Add(new RowStyle(SizeType.Percent, 5.576383F));
            tableLayoutPozitie.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPozitie.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPozitie.Size = new Size(514, 729);
            tableLayoutPozitie.TabIndex = 29;
            tableLayoutPozitie.Paint += tableLayoutPozitie_Paint;
            // 
            // ucPozitie
            // 
            AutoScaleMode = AutoScaleMode.None;
            Controls.Add(tableLayoutPozitie);
            Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 238);
            Margin = new Padding(3, 4, 3, 4);
            Name = "ucPozitie";
            Size = new Size(514, 729);
            tableLayoutPozitie.ResumeLayout(false);
            tableLayoutPozitie.PerformLayout();
            ResumeLayout(false);
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
        private TableLayoutPanel tableLayoutPozitie;
    }
}
