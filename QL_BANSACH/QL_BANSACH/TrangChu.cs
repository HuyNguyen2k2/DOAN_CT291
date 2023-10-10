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
    public partial class TrangChu : Form
    {
        public TrangChu()
        {
            InitializeComponent();
        }

        private void btnSignIn_Click(object sender, EventArgs e)
        {
            DangKy dk = new DangKy();
            dk.Show();
        }

        private void btnLogIn_Click(object sender, EventArgs e)
        {
            DangNhap dn = new DangNhap();
            dn.Show();
        }
    }
}
