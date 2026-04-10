using Ra.Database;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.ComponentModel.Design.ObjectSelectorEditor;

namespace Ra
{
    public partial class ucPozitie : UserControl
    {
        public static ContextMenuStrip mnuCfg_tip_roluri;
        public static ContextMenuStrip mnuCfg_localitati;
        public static ContextMenuStrip mnuCfg_exploatatii;
        public ucPozitie()
        {
            InitializeComponent();
            mnuCfg_tip_roluri = new ContextMenuStrip();
            mnuCfg_localitati = new ContextMenuStrip();
            mnuCfg_exploatatii = new ContextMenuStrip();
            load_cfg_tip_roluri();
            load_mnuCfg_localitati();
            load_mnuCfg_exploatatii();


            mnuCfg_tip_roluri.ItemClicked += new ToolStripItemClickedEventHandler
                (
                    mnuCfg_tip_roluri_ItemClicked
                );
            mnuCfg_localitati.ItemClicked += new ToolStripItemClickedEventHandler
                (
                    mnuCfg_localitati_ItemClicked
                );
            mnuCfg_exploatatii.ItemClicked += new ToolStripItemClickedEventHandler
                (
                    mnuCfg_exploatatii_ItemClicked
                );
        }
        internal static void load_mnuCfg_localitati()
        {
            string sql = "SELECT cfg_localitati.cod, cfg_localitati.localitate, cfg_localitati.cod_siruta, cfg_localitati.cod_postal FROM cfg_localitati;";
            BazaDeDate.ExecutaQuery(sql, null, reader =>
            {
                mnuCfg_localitati.Items.Add(reader.GetString(reader.GetOrdinal("localitate")));
            });
        }
        internal static void load_cfg_tip_roluri()
        {
            string sql = "SELECT cfg_tip_roluri.cod, cfg_tip_roluri.descriere FROM cfg_tip_roluri;";
            BazaDeDate.ExecutaQuery(sql, null, reader =>
            {
                mnuCfg_tip_roluri.Items.Add(reader.GetString(reader.GetOrdinal("descriere")));
            });
        }
        internal static void load_mnuCfg_exploatatii()
        {
            string sql = "SELECT cfg_exploatatii.cod, cfg_exploatatii.descriere FROM cfg_exploatatii;";
            BazaDeDate.ExecutaQuery(sql, null, reader =>
            {
                mnuCfg_exploatatii.Items.Add(reader.GetString(reader.GetOrdinal("descriere")));
            });
        }
        private void mnuCfg_tip_roluri_ItemClicked(Object sender, ToolStripItemClickedEventArgs e)
        {
            buttonTip.Text = e.ClickedItem is null ? "" : e.ClickedItem.ToString();
        }
        private void mnuCfg_localitati_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            buttonLocalitate.Text = e.ClickedItem is null ? "" : e.ClickedItem.ToString();
        }
        private void mnuCfg_exploatatii_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            buttonTipExploatatie.Text = e.ClickedItem is null ? "" : e.ClickedItem.ToString();
        }
        private void buttonTip_Click(object sender, EventArgs e)
        {
            mnuCfg_tip_roluri.Show(buttonTip, buttonTip.Left, buttonTip.Height);
        }

        private void buttonLocalitate_Click(object sender, EventArgs e)
        {
            mnuCfg_localitati.Show(buttonTip, buttonLocalitate.Left, buttonLocalitate.Height);
        }

        private void buttonTipExploatatie_Click(object sender, EventArgs e)
        {
            mnuCfg_exploatatii.Show(buttonTipExploatatie, buttonTipExploatatie.Left, buttonTipExploatatie.Height);
        }

        private void tableLayoutPozitie_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
