using SUNS_VEW.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static SUNS_VEW.Form1;

namespace SUNS_VEW
{
    public partial class ListDangThucHien : Form
    {
        public ListDangThucHien()
        {
            InitializeComponent();
            LoadList();
            FullScreen();
           // timer2.Start();
            ReadConnect2();
        }
        private string times;
        private string days;

        public string Times
        {
            get
            {
                return times=LbGio.Text;
            }

            set
            {
                times = value;
            }
        }

        public string Days
        {
            get
            {
                return days=lbNgay.Text;
            }

            set
            {
                days = value;
            }
        }

        private void FullScreen()
        {
            FormBorderStyle = FormBorderStyle.None;
            WindowState = FormWindowState.Maximized;
            TopMost = true;
        }
        private void CloseList()
        {
            FormBorderStyle = FormBorderStyle.Sizable;
            WindowState = FormWindowState.Normal;
            TopMost = false;
        }
        private void LoadList()
        {
            if (BienToanCuc.CheckAll_TC == "Unchecked")
            {
                string banKham = BienToanCuc.MaPhongKham_TC;
                gDanhSach.DataSource = VewKhamBenhDAO.Instance.ListChoXuTriByPK(banKham);
            }
            else { gDanhSach.DataSource = VewKhamBenhDAO.Instance.LoadFullListChoXuTri(); }
            
        }
        private void ListDangThucHien_Load(object sender, EventArgs e)
        {
            
        }

        private void ListDangThucHien_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                CloseList();
            }
        }

        private void gDanhSach_Click(object sender, EventArgs e)
        {

        }

        private void gridView1_CustomDrawGroupPanel(object sender, DevExpress.XtraGrid.Views.Base.CustomDrawEventArgs e)
        {
           
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            LoadList();
            lbNgay.Text = DateTime.Now.ToLongTimeString();
            LbGio.Text = DateTime.Now.ToLongDateString();
        }
       
        private void timer2_Tick(object sender, EventArgs e)
        {
            timer2.Stop();
            Form1 list2 = new Form1();
            this.Visible = false;
            list2.ShowDialog();
           
        }

        private void BntChuyenForm_Click(object sender, EventArgs e)
        {
            
        }

        private void bntChuyenForm_Click_1(object sender, EventArgs e)
        {

        }

        private void gridView1_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void gridView1_CustomDrawRowFooter(object sender, DevExpress.XtraGrid.Views.Base.RowObjectCustomDrawEventArgs e)
        {

        }

        private void gridView1_CustomDrawFooter(object sender, DevExpress.XtraGrid.Views.Base.RowObjectCustomDrawEventArgs e)
        {
            //Rectangle displayRectangle =
            //new Rectangle(new Point(40, 40), new Size(80, 80));
            StringFormat stringFormat = new StringFormat();
            stringFormat.Alignment = StringAlignment.Near;
            stringFormat.LineAlignment = StringAlignment.Center;
            //stringFormat.Alignment =;
            var rect = e.Bounds;
            rect.X += 50;
            e.DefaultDraw();
            //e.Cache.DrawRectangle(Pens.Black, displayRectangle);
            //e.Cache.DrawString("PHÒNG KHÁM XƯƠNG KHỚP VIỆT -- LIÊN HỆ:  0913 630 416 - 0283 845 0820                      Copyright © 2019 SUNS Software JSC", e.Appearance.GetFont(), e.Appearance.GetForeBrush(e.Cache), rect, stringFormat);
            e.Cache.DrawString(Times+"  "+ Days+" --------------------- "+BienToanCuc.TenPhongKham+"  -  "+"Hotline: "+BienToanCuc.SoDT+ "                                                                               Copyright © 2019 SUNS Software JSC", e.Appearance.GetFont(), e.Appearance.GetForeBrush(e.Cache), rect, stringFormat);
           e.Handled = true;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
