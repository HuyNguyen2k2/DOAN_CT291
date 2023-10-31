using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QL_BANSACH
{
    public partial class QuanLyNV : Form
    {

        public SqlConnection conn = new SqlConnection();
        Function func = new Function();


        private int isEditMode = 0;

        public QuanLyNV()
        {
            InitializeComponent();
        }

        private void btnSaveNV_Click(object sender, EventArgs e)
        {
            string manv = txtbMaNV.Text;
            string tennv = txtbTenNV.Text;
            string sdtnv = txtbSDT.Text;
            string dcnv = txtbDC.Text;

            if(isEditMode ==1 || isEditMode == 2)
            {
                string linkanhnv = AppDomain.CurrentDomain.BaseDirectory + "\\Imgs\\" + Path.GetFileName(labelHinh.Text);
                File.Copy(labelHinh.Text, linkanhnv, true);
            }
            


            string sql = "";
            if(isEditMode == 1)
            {
                sql = "Insert into Nhan_vien  Values ('" + manv + "', N'" + tennv + "', N'" + dcnv + "','" + sdtnv + "','" + Path.GetFileName(labelHinh.Text) + "')";
            }
            else if(isEditMode == 2)
            {
                sql = "UPDATE Nhan_vien SET TenNV = N'" + tennv + "',Diachinv = N'" + dcnv + "',sdt_nv = '" + sdtnv + "', link_anh = '" + Path.GetFileName(labelHinh.Text) + "' WHERE MaNV = '" + manv + "'";
            }
            else
            {
                sql = "Delete from nhan_vien where manv = '"+manv+"'";
                txtbMaNV.Text = "";
                txtbTenNV.Text = "";
                txtbDC.Text = "";
                txtbSDT.Text = "";
           

            }


            func.CapNhat(sql, conn);

            func.HienThiDuLieuDG(dataGridView1, "Select * from Nhan_vien", conn);
            isEditMode = 0;
            btnAddNV.Enabled = true;
            btnDeleteNV.Enabled = true;
            btnEditNV.Enabled = true;
           
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtbTnv_TextChanged(object sender, EventArgs e)
        {

        }

        private void ThemNV_Load(object sender, EventArgs e)
        {

            func.ketnoi(conn);

            txtbMaNV.Enabled = false;

            func.HienThiDuLieuDG(dataGridView1, "Select * from Nhan_vien", conn);

            FormatDataGridViewColumns();

        }
        private void FormatDataGridViewColumns()
        {
            if (dataGridView1.Columns.Count == 0) return;

            int columnWidth = dataGridView1.Width / dataGridView1.Columns.Count;

            foreach (DataGridViewColumn column in dataGridView1.Columns)
            {
                column.Width = columnWidth;
            }
        }

        private void btnAddNV_Click(object sender, EventArgs e)
        {
            btnDeleteNV.Enabled = false;
            btnEditNV.Enabled = false;
            isEditMode = 1;
            string sql_manv = "SELECT MAX(SUBSTRING(MANV,4,2)) FROM NHAN_VIEN";
            SqlCommand comd = new SqlCommand(sql_manv, conn);
            SqlDataReader reader = comd.ExecuteReader();

            if (reader.Read())
            {
                int manvmoi = Convert.ToInt16(reader.GetValue(0).ToString()) + 1;
                if (manvmoi < 10)
                {
                    txtbMaNV.Text = "NV00" + manvmoi;
                }
                else
                {
                    txtbMaNV.Text = "NV0" + manvmoi;
                }
                txtbMaNV.Enabled = false;
            }

            txtbTenNV.Text = "";
            txtbSDT.Text = "";
            txtbDC.Text = "";

            reader.Close();
        }

        private void btnEditNV_Click(object sender, EventArgs e)
        {

            btnAddNV.Enabled = false;
            btnDeleteNV.Enabled = false;
            isEditMode = 2;
            func.HienThiDuLieuDG(dataGridView1, "SELECT * FROM Nhan_vien;", conn);

        }

        private void btnUpImg_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFD = new OpenFileDialog();
            DialogResult digresult = openFD.ShowDialog();
            if (digresult == DialogResult.OK)
            {
                string filename = openFD.FileName;
                picbNV.Image = new Bitmap(filename);

                labelHinh.Text = filename;
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            btnAddNV.Enabled = true;
            btnSaveNV.Enabled = true;
            btnDeleteNV.Enabled = true;
            txtbMaNV.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtbTenNV.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtbDC.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            txtbSDT.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            labelHinh.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();

            string filename = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            string fullPath = AppDomain.CurrentDomain.BaseDirectory + "\\Imgs\\" + filename;

            if (File.Exists(fullPath))
            {
                picbNV.Image = new Bitmap(fullPath);
                labelHinh.Text = filename;
            }
            else
            {
                // Nếu không tìm thấy ảnh, bạn có thể hiển thị một ảnh mặc định hoặc thông báo lỗi tùy ý.
                picbNV.Image = null;
                labelHinh.Text = "Không tìm thấy ảnh";
            }

        }

        private void btnDeleteNV_Click(object sender, EventArgs e)
        {

            btnEditNV.Enabled = false;
            btnAddNV.Enabled = false;

            isEditMode = 3;

            func.HienThiDuLieuDG(dataGridView1, "SELECT * FROM Nhan_vien;", conn);

        }
    }
}
