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
    public partial class ucStatus : UserControl
    {
        public ucStatus()
        {
            InitializeComponent();
        }
        public string GetTextStatus()
        { 
            return labelIdRol.Text; 
        }

        public void SetTextStatusl(string value)
        { 
            labelIdRol.Text = value; 
        }

    }
}
