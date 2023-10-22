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
        public MenuKH()
        {
            InitializeComponent();
        }

        private void btnEditPf_Click(object sender, EventArgs e)
        {
            
        }

        private void btnOrder_Click(object sender, EventArgs e)
        {
            DatSach ds = new DatSach();
            ds.Show();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();    
        }
    }
}
