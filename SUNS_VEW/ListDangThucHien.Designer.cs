namespace SUNS_VEW
{
    partial class ListDangThucHien
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
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.bntChuyenForm = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.LbGio = new System.Windows.Forms.Label();
            this.lbNgay = new System.Windows.Forms.Label();
            this.gDanhSach = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.STT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.HoTen = new DevExpress.XtraGrid.Columns.GridColumn();
            this.NamSinh = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TrangThai = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemFontEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemFontEdit();
            this.repositoryItemFontEdit2 = new DevExpress.XtraEditors.Repository.RepositoryItemFontEdit();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gDanhSach)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemFontEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemFontEdit2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.bntChuyenForm);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.LbGio);
            this.panel1.Controls.Add(this.lbNgay);
            this.panel1.Controls.Add(this.gDanhSach);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1444, 765);
            this.panel1.TabIndex = 3;
            // 
            // bntChuyenForm
            // 
            this.bntChuyenForm.Location = new System.Drawing.Point(860, 355);
            this.bntChuyenForm.Name = "bntChuyenForm";
            this.bntChuyenForm.Size = new System.Drawing.Size(75, 23);
            this.bntChuyenForm.TabIndex = 4;
            this.bntChuyenForm.Text = "button1";
            this.bntChuyenForm.UseVisualStyleBackColor = true;
            this.bntChuyenForm.Visible = false;
            this.bntChuyenForm.Click += new System.EventHandler(this.bntChuyenForm_Click_1);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 7F);
            this.label5.ForeColor = System.Drawing.Color.Blue;
            this.label5.Location = new System.Drawing.Point(1127, 737);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(178, 12);
            this.label5.TabIndex = 4;
            this.label5.Text = "Copyright © 2019 SUNS Software JSC";
            // 
            // LbGio
            // 
            this.LbGio.AutoSize = true;
            this.LbGio.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbGio.ForeColor = System.Drawing.Color.Blue;
            this.LbGio.Location = new System.Drawing.Point(3, 0);
            this.LbGio.Name = "LbGio";
            this.LbGio.Size = new System.Drawing.Size(106, 25);
            this.LbGio.TabIndex = 1;
            this.LbGio.Text = "00:00:00";
            this.LbGio.Click += new System.EventHandler(this.label2_Click);
            // 
            // lbNgay
            // 
            this.lbNgay.AutoSize = true;
            this.lbNgay.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNgay.ForeColor = System.Drawing.Color.Blue;
            this.lbNgay.Location = new System.Drawing.Point(138, 0);
            this.lbNgay.Name = "lbNgay";
            this.lbNgay.Size = new System.Drawing.Size(106, 25);
            this.lbNgay.TabIndex = 0;
            this.lbNgay.Text = "00:00:00";
            // 
            // gDanhSach
            // 
            this.gDanhSach.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gDanhSach.EmbeddedNavigator.Appearance.Font = new System.Drawing.Font("Tahoma", 48F, System.Drawing.FontStyle.Bold);
            this.gDanhSach.EmbeddedNavigator.Appearance.ForeColor = System.Drawing.Color.Blue;
            this.gDanhSach.EmbeddedNavigator.Appearance.Options.UseFont = true;
            this.gDanhSach.EmbeddedNavigator.Appearance.Options.UseForeColor = true;
            this.gDanhSach.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(20, 18, 20, 18);
            this.gDanhSach.Font = new System.Drawing.Font("Tahoma", 48F, System.Drawing.FontStyle.Bold);
            this.gDanhSach.Location = new System.Drawing.Point(0, 0);
            this.gDanhSach.MainView = this.gridView1;
            this.gDanhSach.Margin = new System.Windows.Forms.Padding(20, 18, 20, 18);
            this.gDanhSach.Name = "gDanhSach";
            this.gDanhSach.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemFontEdit1,
            this.repositoryItemFontEdit2});
            this.gDanhSach.Size = new System.Drawing.Size(1444, 765);
            this.gDanhSach.TabIndex = 0;
            this.gDanhSach.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            this.gDanhSach.Click += new System.EventHandler(this.gDanhSach_Click);
            // 
            // gridView1
            // 
            this.gridView1.Appearance.GroupPanel.Font = new System.Drawing.Font("Tahoma", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridView1.Appearance.GroupPanel.ForeColor = System.Drawing.Color.DodgerBlue;
            this.gridView1.Appearance.GroupPanel.Options.UseFont = true;
            this.gridView1.Appearance.GroupPanel.Options.UseForeColor = true;
            this.gridView1.Appearance.GroupPanel.Options.UseTextOptions = true;
            this.gridView1.Appearance.GroupPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridView1.Appearance.GroupPanel.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.Show;
            this.gridView1.Appearance.GroupPanel.TextOptions.Trimming = DevExpress.Utils.Trimming.Word;
            this.gridView1.Appearance.GroupPanel.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gridView1.Appearance.Row.Font = new System.Drawing.Font("Tahoma", 38F);
            this.gridView1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.gridView1.ColumnPanelRowHeight = 60;
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.STT,
            this.HoTen,
            this.NamSinh,
            this.TrangThai});
            this.gridView1.FixedLineWidth = 12;
            this.gridView1.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.None;
            this.gridView1.GridControl = this.gDanhSach;
            this.gridView1.GroupPanelText = "DANH SÁCH CHỜ KÊ TOA";
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsDetail.DetailMode = DevExpress.XtraGrid.Views.Grid.DetailMode.Default;
            this.gridView1.OptionsView.AllowHtmlDrawHeaders = true;
            this.gridView1.OptionsView.ShowFooter = true;
            this.gridView1.CustomDrawGroupPanel += new DevExpress.XtraGrid.Views.Base.CustomDrawEventHandler(this.gridView1_CustomDrawGroupPanel);
            this.gridView1.CustomDrawRowFooter += new DevExpress.XtraGrid.Views.Base.RowObjectCustomDrawEventHandler(this.gridView1_CustomDrawRowFooter);
            this.gridView1.CustomDrawFooter += new DevExpress.XtraGrid.Views.Base.RowObjectCustomDrawEventHandler(this.gridView1_CustomDrawFooter);
            this.gridView1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.gridView1_KeyDown);
            // 
            // STT
            // 
            this.STT.AppearanceCell.BackColor = System.Drawing.Color.White;
            this.STT.AppearanceCell.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.STT.AppearanceCell.BorderColor = System.Drawing.Color.Red;
            this.STT.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.STT.AppearanceCell.ForeColor = System.Drawing.Color.DodgerBlue;
            this.STT.AppearanceCell.Options.UseBackColor = true;
            this.STT.AppearanceCell.Options.UseBorderColor = true;
            this.STT.AppearanceCell.Options.UseFont = true;
            this.STT.AppearanceCell.Options.UseForeColor = true;
            this.STT.AppearanceCell.Options.UseTextOptions = true;
            this.STT.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.STT.AppearanceHeader.BackColor = System.Drawing.Color.White;
            this.STT.AppearanceHeader.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.STT.AppearanceHeader.BorderColor = System.Drawing.Color.Red;
            this.STT.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 27.75F, System.Drawing.FontStyle.Bold);
            this.STT.AppearanceHeader.ForeColor = System.Drawing.Color.DodgerBlue;
            this.STT.AppearanceHeader.Options.UseBackColor = true;
            this.STT.AppearanceHeader.Options.UseBorderColor = true;
            this.STT.AppearanceHeader.Options.UseFont = true;
            this.STT.AppearanceHeader.Options.UseForeColor = true;
            this.STT.AppearanceHeader.Options.UseTextOptions = true;
            this.STT.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.STT.Caption = "STT";
            this.STT.FieldName = "Stt";
            this.STT.FilterMode = DevExpress.XtraGrid.ColumnFilterMode.DisplayText;
            this.STT.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Left;
            this.STT.Name = "STT";
            this.STT.OptionsEditForm.StartNewRow = true;
            this.STT.Visible = true;
            this.STT.VisibleIndex = 0;
            this.STT.Width = 138;
            // 
            // HoTen
            // 
            this.HoTen.AppearanceCell.BackColor = System.Drawing.Color.White;
            this.HoTen.AppearanceCell.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.HoTen.AppearanceCell.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.HoTen.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 27.75F);
            this.HoTen.AppearanceCell.ForeColor = System.Drawing.Color.DodgerBlue;
            this.HoTen.AppearanceCell.Options.UseBackColor = true;
            this.HoTen.AppearanceCell.Options.UseBorderColor = true;
            this.HoTen.AppearanceCell.Options.UseFont = true;
            this.HoTen.AppearanceCell.Options.UseForeColor = true;
            this.HoTen.AppearanceCell.Options.UseTextOptions = true;
            this.HoTen.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.HoTen.AppearanceHeader.BackColor = System.Drawing.Color.White;
            this.HoTen.AppearanceHeader.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.HoTen.AppearanceHeader.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.HoTen.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 27.75F, System.Drawing.FontStyle.Bold);
            this.HoTen.AppearanceHeader.FontStyleDelta = System.Drawing.FontStyle.Bold;
            this.HoTen.AppearanceHeader.ForeColor = System.Drawing.Color.DodgerBlue;
            this.HoTen.AppearanceHeader.Options.UseBackColor = true;
            this.HoTen.AppearanceHeader.Options.UseBorderColor = true;
            this.HoTen.AppearanceHeader.Options.UseFont = true;
            this.HoTen.AppearanceHeader.Options.UseForeColor = true;
            this.HoTen.AppearanceHeader.Options.UseTextOptions = true;
            this.HoTen.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.HoTen.Caption = "FULL NAME";
            this.HoTen.FieldName = "HoTen";
            this.HoTen.Name = "HoTen";
            this.HoTen.Visible = true;
            this.HoTen.VisibleIndex = 1;
            this.HoTen.Width = 838;
            // 
            // NamSinh
            // 
            this.NamSinh.AppearanceCell.BackColor = System.Drawing.Color.White;
            this.NamSinh.AppearanceCell.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.NamSinh.AppearanceCell.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.NamSinh.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 27.75F);
            this.NamSinh.AppearanceCell.ForeColor = System.Drawing.Color.DodgerBlue;
            this.NamSinh.AppearanceCell.Options.UseBackColor = true;
            this.NamSinh.AppearanceCell.Options.UseBorderColor = true;
            this.NamSinh.AppearanceCell.Options.UseFont = true;
            this.NamSinh.AppearanceCell.Options.UseForeColor = true;
            this.NamSinh.AppearanceCell.Options.UseTextOptions = true;
            this.NamSinh.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.NamSinh.AppearanceHeader.BackColor = System.Drawing.Color.White;
            this.NamSinh.AppearanceHeader.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.NamSinh.AppearanceHeader.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.NamSinh.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 27.75F, System.Drawing.FontStyle.Bold);
            this.NamSinh.AppearanceHeader.ForeColor = System.Drawing.Color.DodgerBlue;
            this.NamSinh.AppearanceHeader.Options.UseBackColor = true;
            this.NamSinh.AppearanceHeader.Options.UseBorderColor = true;
            this.NamSinh.AppearanceHeader.Options.UseFont = true;
            this.NamSinh.AppearanceHeader.Options.UseForeColor = true;
            this.NamSinh.AppearanceHeader.Options.UseTextOptions = true;
            this.NamSinh.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.NamSinh.Caption = "YEAR";
            this.NamSinh.FieldName = "NamSinh";
            this.NamSinh.Name = "NamSinh";
            this.NamSinh.Visible = true;
            this.NamSinh.VisibleIndex = 2;
            this.NamSinh.Width = 154;
            // 
            // TrangThai
            // 
            this.TrangThai.AppearanceCell.BackColor = System.Drawing.Color.White;
            this.TrangThai.AppearanceCell.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.TrangThai.AppearanceCell.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.TrangThai.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 27.75F);
            this.TrangThai.AppearanceCell.ForeColor = System.Drawing.Color.DodgerBlue;
            this.TrangThai.AppearanceCell.Options.UseBackColor = true;
            this.TrangThai.AppearanceCell.Options.UseBorderColor = true;
            this.TrangThai.AppearanceCell.Options.UseFont = true;
            this.TrangThai.AppearanceCell.Options.UseForeColor = true;
            this.TrangThai.AppearanceCell.Options.UseTextOptions = true;
            this.TrangThai.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.TrangThai.AppearanceHeader.BackColor = System.Drawing.Color.White;
            this.TrangThai.AppearanceHeader.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.TrangThai.AppearanceHeader.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.TrangThai.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 27.75F, System.Drawing.FontStyle.Bold);
            this.TrangThai.AppearanceHeader.ForeColor = System.Drawing.Color.DodgerBlue;
            this.TrangThai.AppearanceHeader.Options.UseBackColor = true;
            this.TrangThai.AppearanceHeader.Options.UseBorderColor = true;
            this.TrangThai.AppearanceHeader.Options.UseFont = true;
            this.TrangThai.AppearanceHeader.Options.UseForeColor = true;
            this.TrangThai.AppearanceHeader.Options.UseTextOptions = true;
            this.TrangThai.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.TrangThai.Caption = "STATUS";
            this.TrangThai.FieldName = "TrangThai";
            this.TrangThai.Name = "TrangThai";
            this.TrangThai.Visible = true;
            this.TrangThai.VisibleIndex = 3;
            this.TrangThai.Width = 284;
            // 
            // repositoryItemFontEdit1
            // 
            this.repositoryItemFontEdit1.AutoHeight = false;
            this.repositoryItemFontEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemFontEdit1.Name = "repositoryItemFontEdit1";
            // 
            // repositoryItemFontEdit2
            // 
            this.repositoryItemFontEdit2.AutoHeight = false;
            this.repositoryItemFontEdit2.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemFontEdit2.Name = "repositoryItemFontEdit2";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Interval = 10000;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // ListDangThucHien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1444, 765);
            this.Controls.Add(this.panel1);
            this.Name = "ListDangThucHien";
            this.Text = "ListDangThucHien";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.ListDangThucHien_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ListDangThucHien_KeyDown);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gDanhSach)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemFontEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemFontEdit2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label LbGio;
        private System.Windows.Forms.Label lbNgay;
        internal DevExpress.XtraGrid.GridControl gDanhSach;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn STT;
        private DevExpress.XtraGrid.Columns.GridColumn HoTen;
        private DevExpress.XtraGrid.Columns.GridColumn NamSinh;
        private DevExpress.XtraGrid.Columns.GridColumn TrangThai;
        private DevExpress.XtraEditors.Repository.RepositoryItemFontEdit repositoryItemFontEdit1;
        private DevExpress.XtraEditors.Repository.RepositoryItemFontEdit repositoryItemFontEdit2;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Button bntChuyenForm;
    }
}