using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ra
{
    public partial class FormPozitie : Form
    {
        public FormPozitie()
        {
            InitializeComponent();
        }

        private void buttonTip_Click(object sender, EventArgs e)
        {
            MessageBox.Show("mesaj");
            ContextMenuStrip menu = new ContextMenuStrip();

            menu.Items.Add("Optiune 1", null, (s, e) =>
            {
                MessageBox.Show("Ai ales 1");
            });

            menu.Items.Add("Optiune 2", null, (s, e) =>
            {
                MessageBox.Show("Ai ales 2");
            });

            menu.Show(buttonTip, 0, buttonTip.Height);
        }

        private void buttonLocalitate_Click(object sender, EventArgs e)
        {
            MessageBox.Show("alt mesaj");
        }
    }
}
