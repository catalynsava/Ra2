using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ra.Design
{
    public partial class Mdira : Form
    {
        public Mdira()
        {
            InitializeComponent();

            Panel panelTop = new Panel();
            Panel panelLeft = new Panel();
            Panel panelMiddle = new Panel();
            Panel panelRight = new Panel();
            Panel panelBottom = new Panel();

            panelTop.Height = 30;
            panelLeft.Width = 270;
            panelMiddle.Width = 150;
            panelBottom.Height = 30;

            //panelLeft.BackColor = Color.Red;
            //panelMiddle.BackColor = Color.Green;
            //panelRight.BackColor = Color.Blue;
            //panelBottom.BackColor = Color.DarkGray;
            //panelTop.BackColor = Color.YellowGreen;

            panelTop.Dock = DockStyle.Top;
            panelBottom.Dock = DockStyle.Bottom;

            panelLeft.Dock = DockStyle.Left;
            panelMiddle.Dock = DockStyle.Left;
            panelRight.Dock = DockStyle.Fill;


            this.Controls.Add(panelRight);

            this.Controls.Add(panelMiddle);
            this.Controls.Add(panelLeft);


            this.Controls.Add(panelTop);
            this.Controls.Add(panelBottom);

            Program.ucOpis = new ucOpis();
            Program.ucOpis.Dock = DockStyle.Fill;
            panelLeft.Controls.Clear(); // opțional
            panelLeft.Controls.Add(Program.ucOpis);

            Program.ucButoane = new ucButoane();
            Program.ucButoane.Dock = DockStyle.Fill;
            panelMiddle.Controls.Clear();
            panelMiddle.Controls.Add(Program.ucButoane);

            Program.ucStatus = new ucStatus();
            Program.ucStatus.Dock = DockStyle.Fill;
            panelBottom.Controls.Clear();
            panelBottom.Controls.Add(Program.ucStatus);
        }
    }
}
