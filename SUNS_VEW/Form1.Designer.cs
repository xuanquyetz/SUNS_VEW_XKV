using DevExpress.XtraGrid.Columns;
using System.Drawing;
using static DevExpress.XtraExport.Helpers.TableCellCss;
namespace SUNS_VEW
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.gDanhSach = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.STT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.HoTen = new DevExpress.XtraGrid.Columns.GridColumn();
            this.NamSinh = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TrangThai = new DevExpress.XtraGrid.Columns.GridColumn();
            this.SoVV = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TongTime = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemFontEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemFontEdit();
            this.repositoryItemFontEdit2 = new DevExpress.XtraEditors.Repository.RepositoryItemFontEdit();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.bntChuyen = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.timer3 = new System.Windows.Forms.Timer(this.components);
            this.timer4 = new System.Windows.Forms.Timer(this.components);
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gDanhSach)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemFontEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemFontEdit2)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
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
            this.gDanhSach.Size = new System.Drawing.Size(1370, 749);
            this.gDanhSach.TabIndex = 0;
            this.gDanhSach.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            this.gDanhSach.Click += new System.EventHandler(this.gDanhSach_Click);
            this.gDanhSach.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.gDanhSach_MouseDoubleClick);
            // 
            // gridView1
            // 
            this.gridView1.Appearance.FocusedCell.BackColor = System.Drawing.Color.White;
            this.gridView1.Appearance.FocusedCell.BackColor2 = System.Drawing.Color.White;
            this.gridView1.Appearance.FocusedCell.Options.UseBackColor = true;
            this.gridView1.Appearance.FooterPanel.Font = new System.Drawing.Font("Times New Roman", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridView1.Appearance.FooterPanel.ForeColor = System.Drawing.Color.DodgerBlue;
            this.gridView1.Appearance.FooterPanel.Options.UseFont = true;
            this.gridView1.Appearance.FooterPanel.Options.UseForeColor = true;
            this.gridView1.Appearance.GroupFooter.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridView1.Appearance.GroupFooter.Image = global::SUNS_VEW.Properties.Resources.Screenshot_at_Aug_22_01_15_04;
            this.gridView1.Appearance.GroupFooter.Options.UseFont = true;
            this.gridView1.Appearance.GroupFooter.Options.UseImage = true;
            this.gridView1.Appearance.GroupPanel.Font = new System.Drawing.Font("Times New Roman", 39.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridView1.Appearance.GroupPanel.ForeColor = System.Drawing.Color.DodgerBlue;
            this.gridView1.Appearance.GroupPanel.Image = global::SUNS_VEW.Properties.Resources.Screenshot_at_Aug_22_01_15_32;
            this.gridView1.Appearance.GroupPanel.Options.UseFont = true;
            this.gridView1.Appearance.GroupPanel.Options.UseForeColor = true;
            this.gridView1.Appearance.GroupPanel.Options.UseImage = true;
            this.gridView1.Appearance.GroupPanel.Options.UseTextOptions = true;
            this.gridView1.Appearance.GroupPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridView1.Appearance.HeaderPanel.Font = new System.Drawing.Font("Times New Roman", 39.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridView1.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.DodgerBlue;
            this.gridView1.Appearance.HeaderPanel.Image = global::SUNS_VEW.Properties.Resources.Screenshot_at_Aug_22_01_15_04;
            this.gridView1.Appearance.HeaderPanel.Options.UseFont = true;
            this.gridView1.Appearance.HeaderPanel.Options.UseForeColor = true;
            this.gridView1.Appearance.HeaderPanel.Options.UseImage = true;
            this.gridView1.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.gridView1.Appearance.HideSelectionRow.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.gridView1.Appearance.HideSelectionRow.ForeColor = System.Drawing.Color.Yellow;
            this.gridView1.Appearance.HideSelectionRow.Options.UseBackColor = true;
            this.gridView1.Appearance.HideSelectionRow.Options.UseForeColor = true;
            this.gridView1.Appearance.Row.Font = new System.Drawing.Font("Tahoma", 38F);
            this.gridView1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.gridView1.ColumnPanelRowHeight = 60;
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.STT,
            this.HoTen,
            this.NamSinh,
            this.TrangThai,
            this.SoVV,
            this.TongTime});
            this.gridView1.FixedLineWidth = 12;
            this.gridView1.GridControl = this.gDanhSach;
            this.gridView1.GroupFormat = "{0:n0}: [#image]{1} {2}";
            this.gridView1.GroupPanelText = "DANH SÁCH CHỜ KHÁM ";
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsDetail.DetailMode = DevExpress.XtraGrid.Views.Grid.DetailMode.Default;
            this.gridView1.OptionsNavigation.AutoFocusNewRow = true;
            this.gridView1.OptionsNavigation.EnterMoveNextColumn = true;
            this.gridView1.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView1.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CellSelect;
            this.gridView1.OptionsView.ShowFooter = true;
            this.gridView1.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.STT, DevExpress.Data.ColumnSortOrder.Ascending)});
            this.gridView1.CustomDrawFooterCell += new DevExpress.XtraGrid.Views.Grid.FooterCellCustomDrawEventHandler(this.gridView1_CustomDrawFooterCell);
            this.gridView1.CustomDrawFooter += new DevExpress.XtraGrid.Views.Base.RowObjectCustomDrawEventHandler(this.gridView1_CustomDrawFooter);
            this.gridView1.SelectionChanged += new DevExpress.Data.SelectionChangedEventHandler(this.gridView1_SelectionChanged);
            // 
            // STT
            // 
            this.STT.AppearanceCell.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.STT.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 27.75F, System.Drawing.FontStyle.Bold);
            this.STT.AppearanceCell.ForeColor = System.Drawing.Color.DodgerBlue;
            this.STT.AppearanceCell.Options.UseFont = true;
            this.STT.AppearanceCell.Options.UseForeColor = true;
            this.STT.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 27.75F, System.Drawing.FontStyle.Bold);
            this.STT.AppearanceHeader.ForeColor = System.Drawing.Color.DodgerBlue;
            this.STT.AppearanceHeader.Options.UseFont = true;
            this.STT.AppearanceHeader.Options.UseForeColor = true;
            this.STT.Caption = "STT";
            this.STT.FieldName = "Stt";
            this.STT.Name = "STT";
            this.STT.Visible = true;
            this.STT.VisibleIndex = 0;
            this.STT.Width = 105;
            // 
            // HoTen
            // 
            this.HoTen.AppearanceCell.BackColor = System.Drawing.Color.White;
            this.HoTen.AppearanceCell.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.HoTen.AppearanceCell.BorderColor = System.Drawing.Color.White;
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
            this.HoTen.Caption = "HỌ TÊN";
            this.HoTen.FieldName = "HoTen";
            this.HoTen.Name = "HoTen";
            this.HoTen.Visible = true;
            this.HoTen.VisibleIndex = 1;
            this.HoTen.Width = 538;
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
            this.NamSinh.AppearanceHeader.FontStyleDelta = System.Drawing.FontStyle.Bold;
            this.NamSinh.AppearanceHeader.ForeColor = System.Drawing.Color.DodgerBlue;
            this.NamSinh.AppearanceHeader.Options.UseBackColor = true;
            this.NamSinh.AppearanceHeader.Options.UseBorderColor = true;
            this.NamSinh.AppearanceHeader.Options.UseFont = true;
            this.NamSinh.AppearanceHeader.Options.UseForeColor = true;
            this.NamSinh.AppearanceHeader.Options.UseTextOptions = true;
            this.NamSinh.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.NamSinh.Caption = "NS";
            this.NamSinh.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.NamSinh.FieldName = "NamSinh";
            this.NamSinh.Name = "NamSinh";
            this.NamSinh.Visible = true;
            this.NamSinh.VisibleIndex = 2;
            this.NamSinh.Width = 125;
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
            this.TrangThai.AppearanceHeader.FontStyleDelta = System.Drawing.FontStyle.Bold;
            this.TrangThai.AppearanceHeader.ForeColor = System.Drawing.Color.DodgerBlue;
            this.TrangThai.AppearanceHeader.Options.UseBackColor = true;
            this.TrangThai.AppearanceHeader.Options.UseBorderColor = true;
            this.TrangThai.AppearanceHeader.Options.UseFont = true;
            this.TrangThai.AppearanceHeader.Options.UseForeColor = true;
            this.TrangThai.AppearanceHeader.Options.UseTextOptions = true;
            this.TrangThai.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.TrangThai.Caption = "TRẠNG THÁI";
            this.TrangThai.DisplayFormat.FormatString = "{0:#,0.####}";
            this.TrangThai.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.TrangThai.FieldName = "TrangThai";
            this.TrangThai.Name = "TrangThai";
            this.TrangThai.Visible = true;
            this.TrangThai.VisibleIndex = 3;
            this.TrangThai.Width = 365;
            // 
            // SoVV
            // 
            this.SoVV.AppearanceCell.BackColor = System.Drawing.Color.White;
            this.SoVV.AppearanceCell.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.SoVV.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 27.75F);
            this.SoVV.AppearanceCell.ForeColor = System.Drawing.Color.DodgerBlue;
            this.SoVV.AppearanceCell.Options.UseBackColor = true;
            this.SoVV.AppearanceCell.Options.UseFont = true;
            this.SoVV.AppearanceCell.Options.UseForeColor = true;
            this.SoVV.AppearanceCell.Options.UseTextOptions = true;
            this.SoVV.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.SoVV.AppearanceHeader.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.SoVV.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 27.75F, System.Drawing.FontStyle.Bold);
            this.SoVV.AppearanceHeader.FontStyleDelta = System.Drawing.FontStyle.Bold;
            this.SoVV.AppearanceHeader.ForeColor = System.Drawing.Color.DodgerBlue;
            this.SoVV.AppearanceHeader.Options.UseFont = true;
            this.SoVV.AppearanceHeader.Options.UseForeColor = true;
            this.SoVV.AppearanceHeader.Options.UseTextOptions = true;
            this.SoVV.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.SoVV.Caption = "SỐ VV";
            this.SoVV.FieldName = "SoVaoVien";
            this.SoVV.Name = "SoVV";
            this.SoVV.Visible = true;
            this.SoVV.VisibleIndex = 4;
            this.SoVV.Width = 140;
            // 
            // TongTime
            // 
            this.TongTime.Caption = "TIME";
            this.TongTime.FieldName = "TongTime";
            this.TongTime.Name = "TongTime";
            this.TongTime.Width = 79;
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
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(311, 714);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.button1_KeyDown);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.bntChuyen);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.gDanhSach);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1370, 749);
            this.panel1.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Blue;
            this.label5.Location = new System.Drawing.Point(1041, 67);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(326, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Copyright © 2019 SUNS Software JSC - www.suns.com.vn";
            // 
            // panel3
            // 
            this.panel3.Location = new System.Drawing.Point(1258, 12);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(23, 32);
            this.panel3.TabIndex = 9;
            this.panel3.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Enabled = false;
            this.label2.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Blue;
            this.label2.Location = new System.Drawing.Point(1042, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 29);
            this.label2.TabIndex = 1;
            this.label2.Text = "00:00:00";
            this.label2.Visible = false;
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(111, 78);
            this.panel2.TabIndex = 8;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = global::SUNS_VEW.Properties.Resources.logoXKV;
            this.pictureBox1.InitialImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(111, 78);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Visible = false;
            // 
            // bntChuyen
            // 
            this.bntChuyen.Enabled = false;
            this.bntChuyen.Location = new System.Drawing.Point(907, 723);
            this.bntChuyen.Name = "bntChuyen";
            this.bntChuyen.Size = new System.Drawing.Size(75, 23);
            this.bntChuyen.TabIndex = 5;
            this.bntChuyen.Text = "button2";
            this.bntChuyen.UseVisualStyleBackColor = true;
            this.bntChuyen.Visible = false;
            this.bntChuyen.Click += new System.EventHandler(this.bntChuyen_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.Blue;
            this.label4.Location = new System.Drawing.Point(519, 730);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(337, 19);
            this.label4.TabIndex = 3;
            this.label4.Text = "LIÊN HỆ:  0913 630 416 - 0283 845 0820";
            this.label4.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.Blue;
            this.label3.Location = new System.Drawing.Point(229, 730);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(284, 19);
            this.label3.TabIndex = 2;
            this.label3.Text = "PHÒNG KHÁM XƯƠNG KHỚP VIỆT";
            this.label3.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Enabled = false;
            this.label1.Font = new System.Drawing.Font("Agency FB", 50F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label1.Location = new System.Drawing.Point(110, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(250, 80);
            this.label1.TabIndex = 0;
            this.label1.Text = "00:00:00";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // timer2
            // 
            this.timer2.Interval = 30000;
            // 
            // timer3
            // 
            this.timer3.Interval = 1000;
            this.timer3.Tick += new System.EventHandler(this.timer3_Tick);
            // 
            // timer4
            // 
            this.timer4.Interval = 1900;
            this.timer4.Tick += new System.EventHandler(this.timer4_Tick);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 6F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.label6.Location = new System.Drawing.Point(1250, 58);
            this.label6.Name = "label6";
            this.label6.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label6.Size = new System.Drawing.Size(107, 10);
            this.label6.TabIndex = 10;
            this.label6.Text = "Nhấn Control + Esc để tắt ";
            // 
            // Form1
            // 
            this.AllowDrop = true;
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(40F, 77F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1370, 749);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button1);
            this.Font = new System.Drawing.Font("Tahoma", 48F, System.Drawing.FontStyle.Bold);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(20, 18, 20, 18);
            this.Name = "Form1";
            this.Text = "SUNS- Sreen";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.gDanhSach)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemFontEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemFontEdit2)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        internal DevExpress.XtraGrid.GridControl gDanhSach;
        private DevExpress.XtraGrid.Columns.GridColumn HoTen;
        private DevExpress.XtraEditors.Repository.RepositoryItemFontEdit repositoryItemFontEdit1;
        private DevExpress.XtraGrid.Columns.GridColumn NamSinh;
        private DevExpress.XtraGrid.Columns.GridColumn TrangThai;
        private DevExpress.XtraEditors.Repository.RepositoryItemFontEdit repositoryItemFontEdit2;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button bntChuyen;
        private System.Windows.Forms.Timer timer2;
        private GridColumn SoVV;
        private System.Windows.Forms.Timer timer3;
        private System.Windows.Forms.Timer timer4;
        private GridColumn STT;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private GridColumn TongTime;
        private System.Windows.Forms.Label label6;
    }
}

