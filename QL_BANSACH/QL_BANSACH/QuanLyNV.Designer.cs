﻿namespace QL_BANSACH
{
    partial class QuanLyNV
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.txtbMaNV = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtbTenNV = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtbDC = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtbSDT = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnAddNV = new System.Windows.Forms.Button();
            this.btnEditNV = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnDeleteNV = new System.Windows.Forms.Button();
            this.labelHinh = new System.Windows.Forms.Label();
            this.picbNV = new System.Windows.Forms.PictureBox();
            this.btnUpImg = new System.Windows.Forms.Button();
            this.btnSaveNV = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picbNV)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkBlue;
            this.label1.Location = new System.Drawing.Point(44, 27);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã Nhân Viên";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtbMaNV
            // 
            this.txtbMaNV.Location = new System.Drawing.Point(148, 28);
            this.txtbMaNV.Margin = new System.Windows.Forms.Padding(2);
            this.txtbMaNV.Name = "txtbMaNV";
            this.txtbMaNV.Size = new System.Drawing.Size(227, 20);
            this.txtbMaNV.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DarkBlue;
            this.label2.Location = new System.Drawing.Point(44, 61);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 18);
            this.label2.TabIndex = 0;
            this.label2.Text = "Tên nhân viên";
            // 
            // txtbTenNV
            // 
            this.txtbTenNV.Location = new System.Drawing.Point(147, 62);
            this.txtbTenNV.Margin = new System.Windows.Forms.Padding(2);
            this.txtbTenNV.Name = "txtbTenNV";
            this.txtbTenNV.Size = new System.Drawing.Size(227, 20);
            this.txtbTenNV.TabIndex = 2;
            this.txtbTenNV.TextChanged += new System.EventHandler(this.txtbTnv_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DarkBlue;
            this.label3.Location = new System.Drawing.Point(43, 130);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 18);
            this.label3.TabIndex = 0;
            this.label3.Text = "Địa chỉ";
            // 
            // txtbDC
            // 
            this.txtbDC.Location = new System.Drawing.Point(147, 130);
            this.txtbDC.Margin = new System.Windows.Forms.Padding(2);
            this.txtbDC.Multiline = true;
            this.txtbDC.Name = "txtbDC";
            this.txtbDC.Size = new System.Drawing.Size(227, 32);
            this.txtbDC.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.DarkBlue;
            this.label4.Location = new System.Drawing.Point(44, 96);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 18);
            this.label4.TabIndex = 0;
            this.label4.Text = "Số điện thoại";
            // 
            // txtbSDT
            // 
            this.txtbSDT.Location = new System.Drawing.Point(147, 97);
            this.txtbSDT.Margin = new System.Windows.Forms.Padding(2);
            this.txtbSDT.Name = "txtbSDT";
            this.txtbSDT.Size = new System.Drawing.Size(227, 20);
            this.txtbSDT.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.Color.DarkBlue;
            this.label5.Location = new System.Drawing.Point(237, 21);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(411, 42);
            this.label5.TabIndex = 2;
            this.label5.Text = "QUẢN LÝ NHÂN VIÊN";
            // 
            // btnAddNV
            // 
            this.btnAddNV.BackColor = System.Drawing.Color.Gainsboro;
            this.btnAddNV.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnAddNV.ForeColor = System.Drawing.Color.DarkBlue;
            this.btnAddNV.Location = new System.Drawing.Point(34, 179);
            this.btnAddNV.Margin = new System.Windows.Forms.Padding(2);
            this.btnAddNV.Name = "btnAddNV";
            this.btnAddNV.Size = new System.Drawing.Size(104, 27);
            this.btnAddNV.TabIndex = 6;
            this.btnAddNV.Text = "Thêm ";
            this.btnAddNV.UseVisualStyleBackColor = false;
            this.btnAddNV.Click += new System.EventHandler(this.btnAddNV_Click);
            // 
            // btnEditNV
            // 
            this.btnEditNV.BackColor = System.Drawing.Color.Gainsboro;
            this.btnEditNV.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnEditNV.ForeColor = System.Drawing.Color.DarkBlue;
            this.btnEditNV.Location = new System.Drawing.Point(164, 179);
            this.btnEditNV.Margin = new System.Windows.Forms.Padding(2);
            this.btnEditNV.Name = "btnEditNV";
            this.btnEditNV.Size = new System.Drawing.Size(104, 27);
            this.btnEditNV.TabIndex = 7;
            this.btnEditNV.Text = "Sửa";
            this.btnEditNV.UseVisualStyleBackColor = false;
            this.btnEditNV.Click += new System.EventHandler(this.btnEditNV_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.btnDeleteNV);
            this.groupBox1.Controls.Add(this.labelHinh);
            this.groupBox1.Controls.Add(this.picbNV);
            this.groupBox1.Controls.Add(this.btnUpImg);
            this.groupBox1.Controls.Add(this.txtbSDT);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.btnSaveNV);
            this.groupBox1.Controls.Add(this.txtbDC);
            this.groupBox1.Controls.Add(this.btnEditNV);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.btnAddNV);
            this.groupBox1.Controls.Add(this.txtbTenNV);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtbMaNV);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(21, 79);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(816, 223);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin nhân viên";
            // 
            // btnDeleteNV
            // 
            this.btnDeleteNV.BackColor = System.Drawing.Color.Gainsboro;
            this.btnDeleteNV.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnDeleteNV.ForeColor = System.Drawing.Color.DarkBlue;
            this.btnDeleteNV.Location = new System.Drawing.Point(296, 179);
            this.btnDeleteNV.Margin = new System.Windows.Forms.Padding(2);
            this.btnDeleteNV.Name = "btnDeleteNV";
            this.btnDeleteNV.Size = new System.Drawing.Size(104, 27);
            this.btnDeleteNV.TabIndex = 11;
            this.btnDeleteNV.Text = "Xóa";
            this.btnDeleteNV.UseVisualStyleBackColor = false;
            this.btnDeleteNV.Click += new System.EventHandler(this.btnDeleteNV_Click);
            // 
            // labelHinh
            // 
            this.labelHinh.AutoSize = true;
            this.labelHinh.Location = new System.Drawing.Point(671, 198);
            this.labelHinh.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelHinh.Name = "labelHinh";
            this.labelHinh.Size = new System.Drawing.Size(35, 13);
            this.labelHinh.TabIndex = 10;
            this.labelHinh.Text = "label7";
            // 
            // picbNV
            // 
            this.picbNV.Location = new System.Drawing.Point(608, 28);
            this.picbNV.Name = "picbNV";
            this.picbNV.Size = new System.Drawing.Size(161, 167);
            this.picbNV.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picbNV.TabIndex = 8;
            this.picbNV.TabStop = false;
            // 
            // btnUpImg
            // 
            this.btnUpImg.Location = new System.Drawing.Point(519, 27);
            this.btnUpImg.Name = "btnUpImg";
            this.btnUpImg.Size = new System.Drawing.Size(83, 30);
            this.btnUpImg.TabIndex = 5;
            this.btnUpImg.Text = "Upload ảnh";
            this.btnUpImg.UseVisualStyleBackColor = true;
            this.btnUpImg.Click += new System.EventHandler(this.btnUpImg_Click);
            // 
            // btnSaveNV
            // 
            this.btnSaveNV.BackColor = System.Drawing.Color.Gainsboro;
            this.btnSaveNV.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnSaveNV.ForeColor = System.Drawing.Color.DarkBlue;
            this.btnSaveNV.Location = new System.Drawing.Point(420, 179);
            this.btnSaveNV.Margin = new System.Windows.Forms.Padding(2);
            this.btnSaveNV.Name = "btnSaveNV";
            this.btnSaveNV.Size = new System.Drawing.Size(104, 27);
            this.btnSaveNV.TabIndex = 9;
            this.btnSaveNV.Text = "Lưu";
            this.btnSaveNV.UseVisualStyleBackColor = false;
            this.btnSaveNV.Click += new System.EventHandler(this.btnSaveNV_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.DarkBlue;
            this.label6.Location = new System.Drawing.Point(12, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(86, 16);
            this.label6.TabIndex = 8;
            this.label6.Text = "Wings books";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.dataGridView1);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(21, 308);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(815, 218);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Danh sách nhân viên";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 19);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(792, 193);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // QuanLyNV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(857, 538);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label5);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "QuanLyNV";
            this.Text = "Quản lý nhân viên";
            this.Load += new System.EventHandler(this.ThemNV_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picbNV)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtbMaNV;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtbTenNV;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtbDC;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtbSDT;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnAddNV;
        private System.Windows.Forms.Button btnEditNV;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox picbNV;
        private System.Windows.Forms.Button btnUpImg;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnSaveNV;
        private System.Windows.Forms.Label labelHinh;
        private System.Windows.Forms.Button btnDeleteNV;
    }
}