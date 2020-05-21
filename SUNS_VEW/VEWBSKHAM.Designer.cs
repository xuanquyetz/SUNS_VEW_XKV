namespace SUNS_VEW
{
    partial class VEWBSKHAM
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
            this.gDanhSach = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.STT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.HoTen = new DevExpress.XtraGrid.Columns.GridColumn();
            this.NamSinh = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TrangThai = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemFontEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemFontEdit();
            this.repositoryItemFontEdit2 = new DevExpress.XtraEditors.Repository.RepositoryItemFontEdit();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gDanhSach)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemFontEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemFontEdit2)).BeginInit();
            this.SuspendLayout();
            // 
            // gDanhSach
            // 
            this.gDanhSach.EmbeddedNavigator.Appearance.Font = new System.Drawing.Font("Tahoma", 48F, System.Drawing.FontStyle.Bold);
            this.gDanhSach.EmbeddedNavigator.Appearance.ForeColor = System.Drawing.Color.Blue;
            this.gDanhSach.EmbeddedNavigator.Appearance.Options.UseFont = true;
            this.gDanhSach.EmbeddedNavigator.Appearance.Options.UseForeColor = true;
            this.gDanhSach.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(20, 18, 20, 18);
            this.gDanhSach.Font = new System.Drawing.Font("Tahoma", 48F, System.Drawing.FontStyle.Bold);
            this.gDanhSach.Location = new System.Drawing.Point(10, -244);
            this.gDanhSach.MainView = this.gridView1;
            this.gDanhSach.Margin = new System.Windows.Forms.Padding(20, 18, 20, 18);
            this.gDanhSach.Name = "gDanhSach";
            this.gDanhSach.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemFontEdit1,
            this.repositoryItemFontEdit2});
            this.gDanhSach.Size = new System.Drawing.Size(897, 749);
            this.gDanhSach.TabIndex = 1;
            this.gDanhSach.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
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
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsDetail.DetailMode = DevExpress.XtraGrid.Views.Grid.DetailMode.Default;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // STT
            // 
            this.STT.AppearanceCell.BackColor = System.Drawing.Color.White;
            this.STT.AppearanceCell.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.STT.AppearanceCell.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.STT.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 38F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.STT.AppearanceCell.FontStyleDelta = System.Drawing.FontStyle.Bold;
            this.STT.AppearanceCell.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.STT.AppearanceCell.Options.UseBackColor = true;
            this.STT.AppearanceCell.Options.UseBorderColor = true;
            this.STT.AppearanceCell.Options.UseFont = true;
            this.STT.AppearanceCell.Options.UseForeColor = true;
            this.STT.AppearanceCell.Options.UseTextOptions = true;
            this.STT.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.STT.AppearanceHeader.BackColor = System.Drawing.Color.White;
            this.STT.AppearanceHeader.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.STT.AppearanceHeader.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.STT.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 30F, System.Drawing.FontStyle.Bold);
            this.STT.AppearanceHeader.Options.UseBackColor = true;
            this.STT.AppearanceHeader.Options.UseBorderColor = true;
            this.STT.AppearanceHeader.Options.UseFont = true;
            this.STT.AppearanceHeader.Options.UseTextOptions = true;
            this.STT.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.STT.Caption = "STT";
            this.STT.FieldName = "STT";
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
            this.HoTen.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 38F, System.Drawing.FontStyle.Bold);
            this.HoTen.AppearanceCell.FontStyleDelta = System.Drawing.FontStyle.Bold;
            this.HoTen.AppearanceCell.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.HoTen.AppearanceCell.Options.UseBackColor = true;
            this.HoTen.AppearanceCell.Options.UseBorderColor = true;
            this.HoTen.AppearanceCell.Options.UseFont = true;
            this.HoTen.AppearanceCell.Options.UseForeColor = true;
            this.HoTen.AppearanceCell.Options.UseTextOptions = true;
            this.HoTen.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.HoTen.AppearanceHeader.BackColor = System.Drawing.Color.White;
            this.HoTen.AppearanceHeader.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.HoTen.AppearanceHeader.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.HoTen.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 38F, System.Drawing.FontStyle.Bold);
            this.HoTen.AppearanceHeader.FontStyleDelta = System.Drawing.FontStyle.Bold;
            this.HoTen.AppearanceHeader.Options.UseBackColor = true;
            this.HoTen.AppearanceHeader.Options.UseBorderColor = true;
            this.HoTen.AppearanceHeader.Options.UseFont = true;
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
            this.NamSinh.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 38F, System.Drawing.FontStyle.Bold);
            this.NamSinh.AppearanceCell.FontStyleDelta = System.Drawing.FontStyle.Bold;
            this.NamSinh.AppearanceCell.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.NamSinh.AppearanceCell.Options.UseBackColor = true;
            this.NamSinh.AppearanceCell.Options.UseBorderColor = true;
            this.NamSinh.AppearanceCell.Options.UseFont = true;
            this.NamSinh.AppearanceCell.Options.UseForeColor = true;
            this.NamSinh.AppearanceCell.Options.UseTextOptions = true;
            this.NamSinh.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.NamSinh.AppearanceHeader.BackColor = System.Drawing.Color.White;
            this.NamSinh.AppearanceHeader.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.NamSinh.AppearanceHeader.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.NamSinh.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 30F, System.Drawing.FontStyle.Bold);
            this.NamSinh.AppearanceHeader.Options.UseBackColor = true;
            this.NamSinh.AppearanceHeader.Options.UseBorderColor = true;
            this.NamSinh.AppearanceHeader.Options.UseFont = true;
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
            this.TrangThai.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 20F, System.Drawing.FontStyle.Bold);
            this.TrangThai.AppearanceCell.FontStyleDelta = System.Drawing.FontStyle.Bold;
            this.TrangThai.AppearanceCell.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.TrangThai.AppearanceCell.Options.UseBackColor = true;
            this.TrangThai.AppearanceCell.Options.UseBorderColor = true;
            this.TrangThai.AppearanceCell.Options.UseFont = true;
            this.TrangThai.AppearanceCell.Options.UseForeColor = true;
            this.TrangThai.AppearanceCell.Options.UseTextOptions = true;
            this.TrangThai.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.TrangThai.AppearanceHeader.BackColor = System.Drawing.Color.White;
            this.TrangThai.AppearanceHeader.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.TrangThai.AppearanceHeader.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.TrangThai.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 30F, System.Drawing.FontStyle.Bold);
            this.TrangThai.AppearanceHeader.Options.UseBackColor = true;
            this.TrangThai.AppearanceHeader.Options.UseBorderColor = true;
            this.TrangThai.AppearanceHeader.Options.UseFont = true;
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
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(930, 147);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // VEWBSKHAM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1030, 508);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.gDanhSach);
            this.Name = "VEWBSKHAM";
            this.Text = "VEWBSKHAM";
            this.Load += new System.EventHandler(this.VEWBSKHAM_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.VEWBSKHAM_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.gDanhSach)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemFontEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemFontEdit2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        internal DevExpress.XtraGrid.GridControl gDanhSach;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn STT;
        private DevExpress.XtraGrid.Columns.GridColumn HoTen;
        private DevExpress.XtraGrid.Columns.GridColumn NamSinh;
        private DevExpress.XtraGrid.Columns.GridColumn TrangThai;
        private DevExpress.XtraEditors.Repository.RepositoryItemFontEdit repositoryItemFontEdit1;
        private DevExpress.XtraEditors.Repository.RepositoryItemFontEdit repositoryItemFontEdit2;
        private System.Windows.Forms.Button button1;
    }
}