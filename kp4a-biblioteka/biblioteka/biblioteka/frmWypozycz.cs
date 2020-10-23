using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.Sql;
using System.Globalization;

namespace biblioteka
{
    public partial class frmWypozycz : Form
    {
        public static SqlConnection conn = null;
        public frmWypozycz()
        {
            InitializeComponent();
        }

        private void frmWypozycz_Load(object sender, EventArgs e)
        {
            conn = new SqlConnection("user=sa;password=zaq1@WSX;server=DESKTOP-KUJR4Q8\\SQLEXPRESS;database=bibliotek");
            SqlCommand command;
        }
    }
}
