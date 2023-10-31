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

namespace QL_BANSACH
{
    public partial class MenuKH : Form
    {
        SqlConnection conn = new SqlConnection();

        Function func = new Function();

        public MenuKH()    
        {
            InitializeComponent();
        }

        private void btnEditPf_Click(object sender, EventArgs e)
        {
            TTKH tTKH = new TTKH();
            tTKH.Show();
        }

        private void btnOrder_Click(object sender, EventArgs e)
        {
            DatSach ds = new DatSach();
            //ds.FormClosed += MenuKH_FormClosed;
            //this.Hide();
            ds.Show();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();    
        }

        private void MenuKH_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Show();
        }

        private void MenuKH_Load(object sender, EventArgs e)
        {
            func.ketnoi(conn);

        }
    }
}
