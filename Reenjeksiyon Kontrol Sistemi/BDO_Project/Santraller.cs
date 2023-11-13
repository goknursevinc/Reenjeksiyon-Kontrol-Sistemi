using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BDO_Project
{
    public partial class formSantral : Form
    {
        public formSantral()
        {
            InitializeComponent();
        }

        private void btn_EfelerJeo_Click(object sender, EventArgs e)
        {
            this.Hide();
            efelerSantral efelerSantral = new efelerSantral();
            efelerSantral.Show();
        }

        private void btn_Dora3Jeo_Click(object sender, EventArgs e)
        {
            this.Hide();
            Dora3Santral dora3Santral = new Dora3Santral();
            dora3Santral.Show();
        }

        private void btn_BuharkentJeo_Click(object sender, EventArgs e)
        {
            this.Hide();
            BuharkentSantral buharkentSantral = new BuharkentSantral();
            buharkentSantral.Show();
        }

        private void formSantral_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void formSantral_Load(object sender, EventArgs e)
        {

        }
    }
}
