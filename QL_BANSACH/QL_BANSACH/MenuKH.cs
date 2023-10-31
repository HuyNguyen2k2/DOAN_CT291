using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QL_BANSACH
{
    public partial class MenuKH : Form
    {
        public string MaKH;
        public MenuKH(string makh, string username)
        {
            InitializeComponent();
            MaKH = makh;
            label2.Text = username;
        }

        private void btnEditPf_Click(object sender, EventArgs e)
        {
            QuanLyNV qlnv = new QuanLyNV();
            qlnv.Show();
        }

        private void btnOrder_Click(object sender, EventArgs e)
        {
            DatSach ds = new DatSach(MaKH);
            ds.Show();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();    
        }
    }
}
