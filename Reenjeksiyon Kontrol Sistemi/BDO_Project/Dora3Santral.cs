using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;

namespace BDO_Project
{
    public partial class Dora3Santral : Form
    {
        public Dora3Santral()
        {
            InitializeComponent();
        }

        private void Dora3Santral_Load(object sender, EventArgs e)
        {
            XmlDocument xDoc = new XmlDocument();
            DataSet ds = new DataSet();
            XmlReader xmlFile;
            xmlFile = XmlReader.Create(@"dora3.xml", new XmlReaderSettings());
            ds.ReadXml(xmlFile);
            dgw_dora3.DataSource = ds.Tables[0];

            int debi1 = Convert.ToInt32(dgw_dora3.Rows[0].Cells[1].Value);
            if (debi1 < 531.000)
                lbl_kuyu1debi.Text = "Kuyu 1 Debi Yükseltilmeli";
            if (debi1 > 605.000)
                lbl_kuyu1debi.Text = "Kuyu 1 Geri Basma Gerekli";
            else
                lbl_kuyu1debi.Text = "Kuyu 1 Değerler Normal";

            int ps1 = Convert.ToInt32(dgw_dora3.Rows[0].Cells[2].Value);
            if (Convert.ToInt32(ps1) < 58)
                lbl_kuyu1ps.Text = "Kuyu 1 Basınç Yetersiz";
            if (Convert.ToInt32(ps1) > 67)
                lbl_kuyu1ps.Text = "Kuyu 1 Basınç Fazla";
            else
                lbl_kuyu1ps.Text = "Kuyu 1 Basınç Normal";

            int debi2 = Convert.ToInt32(dgw_dora3.Rows[1].Cells[1].Value);
            if (Convert.ToInt32(debi2) < 531.000)
                lbl_kuyu2debi.Text = "Kuyu 2 Debi Yükseltilmeli";
            if (Convert.ToInt32(debi2) > 605.000)
                lbl_kuyu2debi.Text = "Kuyu 2 Geri Basma Gerekli";
            else
                lbl_kuyu2debi.Text = "Kuyu 2 Değerler Normal";

            int ps2 = Convert.ToInt32(dgw_dora3.Rows[1].Cells[2].Value);
            if (Convert.ToInt32(ps2) < 58)
                lbl_kuyu2ps.Text = "Kuyu 2 Basınç Yetersiz";
            if (Convert.ToInt32(ps2) > 67)
                lbl_kuyu2ps.Text = "Kuyu 2 Basınç Fazla";
            else
                lbl_kuyu2ps.Text = "Kuyu 2 Basınç Normal";

            xmlFile.Close();
        }

        private void Dora3Santral_FormClosing(object sender, FormClosingEventArgs e)
        {
            formSantral formSantral = new formSantral();
            formSantral.Show();
        }
    }
}
