namespace QL_BANSACH
{
    partial class ForgetPwd
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ForgetPwd));
            this.lbUsername = new System.Windows.Forms.Label();
            this.lbSdt = new System.Windows.Forms.Label();
            this.txtbUserName = new System.Windows.Forms.TextBox();
            this.txtSdt = new System.Windows.Forms.TextBox();
            this.btnComfirm = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbUsername
            // 
            this.lbUsername.AutoSize = true;
            this.lbUsername.Font = new System.Drawing.Font("UVN Nhan", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbUsername.Location = new System.Drawing.Point(135, 77);
            this.lbUsername.Name = "lbUsername";
            this.lbUsername.Size = new System.Drawing.Size(152, 32);
            this.lbUsername.TabIndex = 0;
            this.lbUsername.Text = "Tên tài khoản";
            // 
            // lbSdt
            // 
            this.lbSdt.AutoSize = true;
            this.lbSdt.Font = new System.Drawing.Font("UVN Nhan", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSdt.Location = new System.Drawing.Point(135, 137);
            this.lbSdt.Name = "lbSdt";
            this.lbSdt.Size = new System.Drawing.Size(146, 32);
            this.lbSdt.TabIndex = 1;
            this.lbSdt.Text = "Số điện thoại";
            // 
            // txtbUserName
            // 
            this.txtbUserName.Location = new System.Drawing.Point(355, 77);
            this.txtbUserName.Margin = new System.Windows.Forms.Padding(4);
            this.txtbUserName.Name = "txtbUserName";
            this.txtbUserName.Size = new System.Drawing.Size(176, 22);
            this.txtbUserName.TabIndex = 2;
            // 
            // txtSdt
            // 
            this.txtSdt.Location = new System.Drawing.Point(355, 147);
            this.txtSdt.Margin = new System.Windows.Forms.Padding(4);
            this.txtSdt.Name = "txtSdt";
            this.txtSdt.Size = new System.Drawing.Size(176, 22);
            this.txtSdt.TabIndex = 3;
            // 
            // btnComfirm
            // 
            this.btnComfirm.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnComfirm.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnComfirm.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnComfirm.ForeColor = System.Drawing.Color.DarkBlue;
            this.btnComfirm.Location = new System.Drawing.Point(256, 199);
            this.btnComfirm.Margin = new System.Windows.Forms.Padding(4);
            this.btnComfirm.Name = "btnComfirm";
            this.btnComfirm.Size = new System.Drawing.Size(111, 40);
            this.btnComfirm.TabIndex = 4;
            this.btnComfirm.Text = "Xác nhận";
            this.btnComfirm.UseVisualStyleBackColor = false;
            this.btnComfirm.Click += new System.EventHandler(this.btnComfirm_Click);
            // 
            // ForgetPwd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnComfirm);
            this.Controls.Add(this.txtSdt);
            this.Controls.Add(this.txtbUserName);
            this.Controls.Add(this.lbSdt);
            this.Controls.Add(this.lbUsername);
            this.Name = "ForgetPwd";
            this.Text = "ForgetPwd";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbUsername;
        private System.Windows.Forms.Label lbSdt;
        private System.Windows.Forms.TextBox txtbUserName;
        private System.Windows.Forms.TextBox txtSdt;
        private System.Windows.Forms.Button btnComfirm;
    }
}