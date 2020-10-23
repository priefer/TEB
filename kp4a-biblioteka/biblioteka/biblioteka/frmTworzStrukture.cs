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
    
    public partial class frmTworzStrukture : Form
    {
        public static SqlConnection conn = null;
        public frmTworzStrukture()
        {
            InitializeComponent();
        }

        private void frmTworzStrukture_Load(object sender, EventArgs e)
        {
            conn = new SqlConnection("user=sa;password=zaq1@WSX;server=DESKTOP-KUJR4Q8\\SQLEXPRESS;database=biblioteka");
            SqlCommand command;
        }

        private void btn_add_tab_czyt_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                MessageBox.Show("Połączyło");
                SqlCommand command;
                command = new SqlCommand("CREATE TABLE tbl_czytelnik (id int not null identity(1,1), imie varchar(30), nazwisko varchar(50), ades varchar(50), telefon varchar(15))", conn);
                command.ExecuteNonQuery();
                conn.Close();
            }
            catch(Exception Ex)
            {
                MessageBox.Show(Ex.ToString());
            }
        }
    }
}
