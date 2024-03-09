namespace InvidualProject
{
    partial class frm_DangNhap
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
            this.ck_HienThiMatKhau = new System.Windows.Forms.CheckBox();
            this.btn_Thoat = new System.Windows.Forms.Button();
            this.btn_QLDangNhap = new System.Windows.Forms.Button();
            this.txt_MatKhau = new System.Windows.Forms.TextBox();
            this.txt_TaiKhoan = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_nvDangNhap = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ck_HienThiMatKhau
            // 
            this.ck_HienThiMatKhau.AutoSize = true;
            this.ck_HienThiMatKhau.Location = new System.Drawing.Point(549, 218);
            this.ck_HienThiMatKhau.Margin = new System.Windows.Forms.Padding(2);
            this.ck_HienThiMatKhau.Name = "ck_HienThiMatKhau";
            this.ck_HienThiMatKhau.Size = new System.Drawing.Size(66, 17);
            this.ck_HienThiMatKhau.TabIndex = 20;
            this.ck_HienThiMatKhau.Text = "Hiển Thị";
            this.ck_HienThiMatKhau.UseVisualStyleBackColor = true;
            this.ck_HienThiMatKhau.CheckedChanged += new System.EventHandler(this.ck_HienThiMatKhau_CheckedChanged);
            // 
            // btn_Thoat
            // 
            this.btn_Thoat.Font = new System.Drawing.Font("Times New Roman", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Thoat.Location = new System.Drawing.Point(585, 254);
            this.btn_Thoat.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Thoat.Name = "btn_Thoat";
            this.btn_Thoat.Size = new System.Drawing.Size(102, 31);
            this.btn_Thoat.TabIndex = 19;
            this.btn_Thoat.Text = "Thoát";
            this.btn_Thoat.UseVisualStyleBackColor = true;
            this.btn_Thoat.Click += new System.EventHandler(this.btn_Thoat_Click);
            // 
            // btn_QLDangNhap
            // 
            this.btn_QLDangNhap.Font = new System.Drawing.Font("Times New Roman", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_QLDangNhap.Location = new System.Drawing.Point(157, 254);
            this.btn_QLDangNhap.Margin = new System.Windows.Forms.Padding(2);
            this.btn_QLDangNhap.Name = "btn_QLDangNhap";
            this.btn_QLDangNhap.Size = new System.Drawing.Size(168, 28);
            this.btn_QLDangNhap.TabIndex = 18;
            this.btn_QLDangNhap.Text = "Quản lý đăng nhập";
            this.btn_QLDangNhap.UseVisualStyleBackColor = true;
            this.btn_QLDangNhap.Click += new System.EventHandler(this.btn_QLDangNhap_Click);
            // 
            // txt_MatKhau
            // 
            this.txt_MatKhau.Font = new System.Drawing.Font("Times New Roman", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_MatKhau.Location = new System.Drawing.Point(323, 211);
            this.txt_MatKhau.Margin = new System.Windows.Forms.Padding(2);
            this.txt_MatKhau.Name = "txt_MatKhau";
            this.txt_MatKhau.Size = new System.Drawing.Size(207, 27);
            this.txt_MatKhau.TabIndex = 17;
            this.txt_MatKhau.UseSystemPasswordChar = true;
            // 
            // txt_TaiKhoan
            // 
            this.txt_TaiKhoan.Font = new System.Drawing.Font("Times New Roman", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_TaiKhoan.Location = new System.Drawing.Point(323, 168);
            this.txt_TaiKhoan.Margin = new System.Windows.Forms.Padding(2);
            this.txt_TaiKhoan.Name = "txt_TaiKhoan";
            this.txt_TaiKhoan.Size = new System.Drawing.Size(207, 27);
            this.txt_TaiKhoan.TabIndex = 16;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(185, 209);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 20);
            this.label2.TabIndex = 15;
            this.label2.Text = "Mật khẩu:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(185, 168);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 20);
            this.label1.TabIndex = 14;
            this.label1.Text = "Tên tài khoản:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.LimeGreen;
            this.label3.Location = new System.Drawing.Point(296, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(178, 31);
            this.label3.TabIndex = 21;
            this.label3.Text = "ĐĂNG NHẬP";
            // 
            // btn_nvDangNhap
            // 
            this.btn_nvDangNhap.Font = new System.Drawing.Font("Times New Roman", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_nvDangNhap.Location = new System.Drawing.Point(356, 254);
            this.btn_nvDangNhap.Margin = new System.Windows.Forms.Padding(2);
            this.btn_nvDangNhap.Name = "btn_nvDangNhap";
            this.btn_nvDangNhap.Size = new System.Drawing.Size(198, 28);
            this.btn_nvDangNhap.TabIndex = 22;
            this.btn_nvDangNhap.Text = "Nhân Viên Đăng Nhập";
            this.btn_nvDangNhap.UseVisualStyleBackColor = true;
            this.btn_nvDangNhap.Click += new System.EventHandler(this.btn_nvDangNhap_Click);
            // 
            // frm_DangNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_nvDangNhap);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ck_HienThiMatKhau);
            this.Controls.Add(this.btn_Thoat);
            this.Controls.Add(this.btn_QLDangNhap);
            this.Controls.Add(this.txt_MatKhau);
            this.Controls.Add(this.txt_TaiKhoan);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frm_DangNhap";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox ck_HienThiMatKhau;
        private System.Windows.Forms.Button btn_Thoat;
        private System.Windows.Forms.Button btn_QLDangNhap;
        private System.Windows.Forms.TextBox txt_MatKhau;
        private System.Windows.Forms.TextBox txt_TaiKhoan;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_nvDangNhap;
    }
}

