using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace biblioteka
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnZamknij_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            btnStruktura.Visible = false;
        }

        private void label1_DoubleClick(object sender, EventArgs e)
        {
            btnStruktura.Visible = true;
        }

        private void btnDodajKsiazke_Click(object sender, EventArgs e)
        {
            frmDodajKsiazke f = new frmDodajKsiazke();
            f.Show();
        }

        private void btnDodajCzytelnika_Click(object sender, EventArgs e)
        {
            frmDodajCzytelnika f = new frmDodajCzytelnika();
            f.Show();
        }

        private void btnWypozycz_Click(object sender, EventArgs e)
        {
            frmWypozycz f = new frmWypozycz();
            f.Show();
        }

        private void btnStruktura_Click(object sender, EventArgs e)
        {
            frmTworzStrukture f = new frmTworzStrukture();
            f.Show();
        }
    }
}
