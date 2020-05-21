namespace SUNS_VEW
{
    partial class CauHinhPK
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CauHinhPK));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.rdKhamBenh = new System.Windows.Forms.RadioButton();
            this.rdCLS = new System.Windows.Forms.RadioButton();
            this.cbPhongKham = new System.Windows.Forms.ComboBox();
            this.cbKhoaCLS = new System.Windows.Forms.ComboBox();
            this.CheckAll = new System.Windows.Forms.CheckBox();
            this.bntLuu = new DevExpress.XtraEditors.SimpleButton();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtKhoaCLS = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.rdChoThuNgan = new System.Windows.Forms.RadioButton();
            this.rdChoCapThuoc = new System.Windows.Forms.RadioButton();
            this.cbLoaiThuoc = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.cbLoaiPhieuThu = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtTenPhongKham = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtSDT = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.nbDelay = new System.Windows.Forms.NumericUpDown();
            this.label13 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nbDelay)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label1.Location = new System.Drawing.Point(46, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Phòng Khám";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label2.Location = new System.Drawing.Point(46, 150);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Khoa CLS";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label3.Location = new System.Drawing.Point(98, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(230, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "CẤU HÌNH MÀN HÌNH CHỜ";
            // 
            // rdKhamBenh
            // 
            this.rdKhamBenh.AutoSize = true;
            this.rdKhamBenh.Checked = true;
            this.rdKhamBenh.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdKhamBenh.ForeColor = System.Drawing.SystemColors.Highlight;
            this.rdKhamBenh.Location = new System.Drawing.Point(49, 55);
            this.rdKhamBenh.Name = "rdKhamBenh";
            this.rdKhamBenh.Size = new System.Drawing.Size(253, 17);
            this.rdKhamBenh.TabIndex = 4;
            this.rdKhamBenh.TabStop = true;
            this.rdKhamBenh.Text = "HIỂN THỊ MÀN HÌNH CHỜ KHÁM BỆNH";
            this.rdKhamBenh.UseVisualStyleBackColor = true;
            // 
            // rdCLS
            // 
            this.rdCLS.AutoSize = true;
            this.rdCLS.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdCLS.ForeColor = System.Drawing.SystemColors.Highlight;
            this.rdCLS.Location = new System.Drawing.Point(49, 123);
            this.rdCLS.Name = "rdCLS";
            this.rdCLS.Size = new System.Drawing.Size(289, 17);
            this.rdCLS.TabIndex = 5;
            this.rdCLS.Text = "HIỂN THỊ MÀN HÌNH CHỜ KHOA PHÒNG CLS";
            this.rdCLS.UseVisualStyleBackColor = true;
            this.rdCLS.CheckedChanged += new System.EventHandler(this.rdCLS_CheckedChanged);
            // 
            // cbPhongKham
            // 
            this.cbPhongKham.FormattingEnabled = true;
            this.cbPhongKham.Items.AddRange(new object[] {
            "ALL"});
            this.cbPhongKham.Location = new System.Drawing.Point(127, 73);
            this.cbPhongKham.Name = "cbPhongKham";
            this.cbPhongKham.Size = new System.Drawing.Size(175, 21);
            this.cbPhongKham.TabIndex = 6;
            this.cbPhongKham.SelectedIndexChanged += new System.EventHandler(this.cbPhongKham_SelectedIndexChanged);
            // 
            // cbKhoaCLS
            // 
            this.cbKhoaCLS.FormattingEnabled = true;
            this.cbKhoaCLS.Location = new System.Drawing.Point(33, 8);
            this.cbKhoaCLS.Name = "cbKhoaCLS";
            this.cbKhoaCLS.Size = new System.Drawing.Size(12, 21);
            this.cbKhoaCLS.TabIndex = 7;
            this.cbKhoaCLS.Visible = false;
            // 
            // CheckAll
            // 
            this.CheckAll.AutoSize = true;
            this.CheckAll.ForeColor = System.Drawing.SystemColors.Highlight;
            this.CheckAll.Location = new System.Drawing.Point(125, 100);
            this.CheckAll.Name = "CheckAll";
            this.CheckAll.Size = new System.Drawing.Size(175, 17);
            this.CheckAll.TabIndex = 8;
            this.CheckAll.Text = "Hiễn thị tất cả các phòng khám";
            this.CheckAll.UseVisualStyleBackColor = true;
            // 
            // bntLuu
            // 
            this.bntLuu.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.bntLuu.Appearance.ForeColor = System.Drawing.SystemColors.Highlight;
            this.bntLuu.Appearance.Options.UseFont = true;
            this.bntLuu.Appearance.Options.UseForeColor = true;
            this.bntLuu.Image = ((System.Drawing.Image)(resources.GetObject("bntLuu.Image")));
            this.bntLuu.Location = new System.Drawing.Point(646, 238);
            this.bntLuu.Name = "bntLuu";
            this.bntLuu.Size = new System.Drawing.Size(144, 38);
            this.bntLuu.TabIndex = 10;
            this.bntLuu.Text = "LƯU CẤU HÌNH";
            this.bntLuu.Click += new System.EventHandler(this.bntLuu_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.checkBox1.Location = new System.Drawing.Point(662, 282);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(128, 17);
            this.checkBox1.TabIndex = 11;
            this.checkBox1.Text = "Xem cấu hình hiện tại";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label4.Location = new System.Drawing.Point(46, 57);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 13);
            this.label4.TabIndex = 12;
            // 
            // txtKhoaCLS
            // 
            this.txtKhoaCLS.Location = new System.Drawing.Point(127, 147);
            this.txtKhoaCLS.Name = "txtKhoaCLS";
            this.txtKhoaCLS.Size = new System.Drawing.Size(175, 20);
            this.txtKhoaCLS.TabIndex = 15;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label7.Location = new System.Drawing.Point(46, 172);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(163, 13);
            this.label7.TabIndex = 16;
            this.label7.Text = "Các nhóm cách nhau bằng dấu ;";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label8.Location = new System.Drawing.Point(47, 203);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(0, 13);
            this.label8.TabIndex = 17;
            // 
            // rdChoThuNgan
            // 
            this.rdChoThuNgan.AutoSize = true;
            this.rdChoThuNgan.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdChoThuNgan.ForeColor = System.Drawing.SystemColors.Highlight;
            this.rdChoThuNgan.Location = new System.Drawing.Point(49, 188);
            this.rdChoThuNgan.Name = "rdChoThuNgan";
            this.rdChoThuNgan.Size = new System.Drawing.Size(245, 17);
            this.rdChoThuNgan.TabIndex = 18;
            this.rdChoThuNgan.Text = "HIỂN THỊ MÀN HÌNH CHỜ THU NGÂN";
            this.rdChoThuNgan.UseVisualStyleBackColor = true;
            // 
            // rdChoCapThuoc
            // 
            this.rdChoCapThuoc.AutoSize = true;
            this.rdChoCapThuoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdChoCapThuoc.ForeColor = System.Drawing.SystemColors.Highlight;
            this.rdChoCapThuoc.Location = new System.Drawing.Point(49, 238);
            this.rdChoCapThuoc.Name = "rdChoCapThuoc";
            this.rdChoCapThuoc.Size = new System.Drawing.Size(251, 17);
            this.rdChoCapThuoc.TabIndex = 20;
            this.rdChoCapThuoc.Text = "HIỂN THỊ MÀN HÌNH CHỜ CẤP THUỐC";
            this.rdChoCapThuoc.UseVisualStyleBackColor = true;
            // 
            // cbLoaiThuoc
            // 
            this.cbLoaiThuoc.FormattingEnabled = true;
            this.cbLoaiThuoc.Items.AddRange(new object[] {
            "DỊCH VỤ",
            "BHYT",
            "ALL"});
            this.cbLoaiThuoc.Location = new System.Drawing.Point(125, 267);
            this.cbLoaiThuoc.Name = "cbLoaiThuoc";
            this.cbLoaiThuoc.Size = new System.Drawing.Size(175, 21);
            this.cbLoaiThuoc.TabIndex = 21;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label10.Location = new System.Drawing.Point(47, 275);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(61, 13);
            this.label10.TabIndex = 22;
            this.label10.Text = "Loại Thuốc";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label11.Location = new System.Drawing.Point(46, 219);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(79, 13);
            this.label11.TabIndex = 24;
            this.label11.Text = "Loại Phiếu Thu";
            // 
            // cbLoaiPhieuThu
            // 
            this.cbLoaiPhieuThu.FormattingEnabled = true;
            this.cbLoaiPhieuThu.Items.AddRange(new object[] {
            "DỊCH VỤ",
            "BHYT",
            "ALL"});
            this.cbLoaiPhieuThu.Location = new System.Drawing.Point(127, 211);
            this.cbLoaiPhieuThu.Name = "cbLoaiPhieuThu";
            this.cbLoaiPhieuThu.Size = new System.Drawing.Size(175, 21);
            this.cbLoaiPhieuThu.TabIndex = 23;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label5.Location = new System.Drawing.Point(422, 6);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(318, 20);
            this.label5.TabIndex = 25;
            this.label5.Text = "CẤU HÌNH THÔNG TIN PHÒNG KHÁM";
            // 
            // txtTenPhongKham
            // 
            this.txtTenPhongKham.Location = new System.Drawing.Point(531, 69);
            this.txtTenPhongKham.Name = "txtTenPhongKham";
            this.txtTenPhongKham.Size = new System.Drawing.Size(271, 20);
            this.txtTenPhongKham.TabIndex = 26;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label6.Location = new System.Drawing.Point(413, 76);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(90, 13);
            this.label6.TabIndex = 27;
            this.label6.Text = "Tên Phòng Khám";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label9.Location = new System.Drawing.Point(413, 107);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(105, 13);
            this.label9.TabIndex = 29;
            this.label9.Text = " Hotline phòng khám";
            // 
            // txtSDT
            // 
            this.txtSDT.Location = new System.Drawing.Point(531, 100);
            this.txtSDT.Name = "txtSDT";
            this.txtSDT.Size = new System.Drawing.Size(221, 20);
            this.txtSDT.TabIndex = 28;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label12.Location = new System.Drawing.Point(413, 136);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(112, 13);
            this.label12.TabIndex = 31;
            this.label12.Text = "Số phút ẩn danh sách";
            // 
            // nbDelay
            // 
            this.nbDelay.Location = new System.Drawing.Point(531, 129);
            this.nbDelay.Name = "nbDelay";
            this.nbDelay.Size = new System.Drawing.Size(67, 20);
            this.nbDelay.TabIndex = 32;
            this.nbDelay.Value = new decimal(new int[] {
            30,
            0,
            0,
            0});
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label13.Location = new System.Drawing.Point(604, 136);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(29, 13);
            this.label13.TabIndex = 33;
            this.label13.Text = "Phút";
            // 
            // CauHinhPK
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(806, 327);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.nbDelay);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtSDT);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtTenPhongKham);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.cbLoaiPhieuThu);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.cbLoaiThuoc);
            this.Controls.Add(this.rdChoCapThuoc);
            this.Controls.Add(this.rdChoThuNgan);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtKhoaCLS);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.bntLuu);
            this.Controls.Add(this.CheckAll);
            this.Controls.Add(this.cbKhoaCLS);
            this.Controls.Add(this.cbPhongKham);
            this.Controls.Add(this.rdCLS);
            this.Controls.Add(this.rdKhamBenh);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "CauHinhPK";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CauHinhPK";
            this.Load += new System.EventHandler(this.CauHinhPK_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nbDelay)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton rdKhamBenh;
        private System.Windows.Forms.RadioButton rdCLS;
        private System.Windows.Forms.ComboBox cbPhongKham;
        private System.Windows.Forms.ComboBox cbKhoaCLS;
        private System.Windows.Forms.CheckBox CheckAll;
        private DevExpress.XtraEditors.SimpleButton bntLuu;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtKhoaCLS;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.RadioButton rdChoThuNgan;
        private System.Windows.Forms.RadioButton rdChoCapThuoc;
        private System.Windows.Forms.ComboBox cbLoaiThuoc;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox cbLoaiPhieuThu;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtTenPhongKham;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtSDT;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.NumericUpDown nbDelay;
        private System.Windows.Forms.Label label13;
    }
}