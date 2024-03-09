namespace InvidualProject
{
    partial class frm_NhanVien
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
            this.Lib_Menu = new System.Windows.Forms.ListBox();
            this.Lib_DsKhachOrder = new System.Windows.Forms.ListBox();
            this.btn_1 = new System.Windows.Forms.Button();
            this.btn_2 = new System.Windows.Forms.Button();
            this.btn_3 = new System.Windows.Forms.Button();
            this.btn_4 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(143, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(498, 42);
            this.label1.TabIndex = 0;
            this.label1.Text = "ORDER MÓN CHO KHÁCH";
            // 
            // Lib_Menu
            // 
            this.Lib_Menu.FormattingEnabled = true;
            this.Lib_Menu.Items.AddRange(new object[] {
            "Cà phê đen",
            "Cà phê sữa",
            "Bạc xỉu",
            "Trà đào"});
            this.Lib_Menu.Location = new System.Drawing.Point(73, 159);
            this.Lib_Menu.Name = "Lib_Menu";
            this.Lib_Menu.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.Lib_Menu.Size = new System.Drawing.Size(229, 251);
            this.Lib_Menu.TabIndex = 10;
            // 
            // Lib_DsKhachOrder
            // 
            this.Lib_DsKhachOrder.FormattingEnabled = true;
            this.Lib_DsKhachOrder.Location = new System.Drawing.Point(466, 159);
            this.Lib_DsKhachOrder.Name = "Lib_DsKhachOrder";
            this.Lib_DsKhachOrder.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.Lib_DsKhachOrder.Size = new System.Drawing.Size(229, 251);
            this.Lib_DsKhachOrder.TabIndex = 15;
            // 
            // btn_1
            // 
            this.btn_1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btn_1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_1.Location = new System.Drawing.Point(349, 173);
            this.btn_1.Name = "btn_1";
            this.btn_1.Size = new System.Drawing.Size(56, 31);
            this.btn_1.TabIndex = 11;
            this.btn_1.Text = ">";
            this.btn_1.UseVisualStyleBackColor = false;
            this.btn_1.Click += new System.EventHandler(this.btn_1_Click);
            // 
            // btn_2
            // 
            this.btn_2.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btn_2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_2.Location = new System.Drawing.Point(349, 228);
            this.btn_2.Name = "btn_2";
            this.btn_2.Size = new System.Drawing.Size(56, 31);
            this.btn_2.TabIndex = 12;
            this.btn_2.Text = ">>";
            this.btn_2.UseVisualStyleBackColor = false;
            this.btn_2.Click += new System.EventHandler(this.btn_2_Click);
            // 
            // btn_3
            // 
            this.btn_3.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btn_3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_3.Location = new System.Drawing.Point(349, 307);
            this.btn_3.Name = "btn_3";
            this.btn_3.Size = new System.Drawing.Size(56, 31);
            this.btn_3.TabIndex = 13;
            this.btn_3.Text = "<";
            this.btn_3.UseVisualStyleBackColor = false;
            this.btn_3.Click += new System.EventHandler(this.btn_3_Click);
            // 
            // btn_4
            // 
            this.btn_4.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btn_4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_4.Location = new System.Drawing.Point(349, 366);
            this.btn_4.Name = "btn_4";
            this.btn_4.Size = new System.Drawing.Size(56, 31);
            this.btn_4.TabIndex = 14;
            this.btn_4.Text = "<<";
            this.btn_4.UseVisualStyleBackColor = false;
            this.btn_4.Click += new System.EventHandler(this.btn_4_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(146, 109);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 23);
            this.label4.TabIndex = 16;
            this.label4.Text = "Menu";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(484, 109);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(197, 23);
            this.label5.TabIndex = 17;
            this.label5.Text = "Danh sách khách order";
            // 
            // frm_NhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 639);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btn_4);
            this.Controls.Add(this.btn_3);
            this.Controls.Add(this.btn_2);
            this.Controls.Add(this.btn_1);
            this.Controls.Add(this.Lib_DsKhachOrder);
            this.Controls.Add(this.Lib_Menu);
            this.Controls.Add(this.label1);
            this.Name = "frm_NhanVien";
            this.Text = "frm_NhanVien";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox Lib_Menu;
        private System.Windows.Forms.ListBox Lib_DsKhachOrder;
        private System.Windows.Forms.Button btn_1;
        private System.Windows.Forms.Button btn_2;
        private System.Windows.Forms.Button btn_3;
        private System.Windows.Forms.Button btn_4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}