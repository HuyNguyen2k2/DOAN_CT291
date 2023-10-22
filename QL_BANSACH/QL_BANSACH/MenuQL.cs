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
    public partial class MenuQL : Form
    {
        public MenuQL()
        {
            InitializeComponent();
        }

        private void btnEditBooks_Click(object sender, EventArgs e)
        {
            QuanLySach qls = new QuanLySach();
            qls.Show();
        }

        private void btnEditNV_Click(object sender, EventArgs e)
        {
            QuanLyNV quanLyNV = new QuanLyNV(); 
            quanLyNV.Show();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
