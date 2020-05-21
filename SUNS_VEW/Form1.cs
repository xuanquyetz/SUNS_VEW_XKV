using DevExpress.XtraEditors;
using SUNS_VEW.DAO;
using SUNS_VEW.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net;
using Newtonsoft.Json;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Collections;

namespace SUNS_VEW
{
    public partial class Form1 : DevExpress.XtraEditors.XtraForm
    {
        //Button bt = new Button();
        private string times;
        private string days;

        public string Times
        {
            get
            {
                return times = label1.Text;
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
                return days = label2.Text;
            }

            set
            {
                days = value;
            }
        }

        public string HienThiFormKham
        {
            get
            {
                return hienThiFormKham;
            }

            set
            {
                hienThiFormKham = value;
            }
        }

        public Form1()
        {
            InitializeComponent();
            ReadConnect();
            ReadConnectCLS();
            LoadDanhSach();
            FullScreen();
            // var result = GetData();
            timer3.Enabled = true;
        }
        string MaPK;
        string CheckAll;
        private string hienThiFormKham;
        string MaNhomDV;
        string HienThiCLS;
        string HienThiThuNgan;
        string TenLoaiThu;
        string HienThuCapThuoc;
        string TenLoaiCap;
        string TenPhongKham;
        string SoDT;
        private object hienthiDsKham;
        string NumberDelay;

        public class BienToanCuc
        {
            public static string hienthiDsKham;
            public static string MaPhongKham_TC;
            public static string CheckAll_TC;
            public static string MaKhoa_TC;
            public static string hienThiDsCLS;
            public static string HienThiThuNgan;
            public static string HienThiCapThuoc;
            public static string TenPhongKham;
            public static string SoDT;
            public static int countChoThu;
            public static int cuontBNQuaGio;
        }
        public static void ReadConnect2() //Method toàn cục
        {

            string path = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetEntryAssembly().Location);

            if (!Directory.Exists(path + @"\log"))
            {
                Directory.CreateDirectory(path + @"\log");
            }
            FileStream stream = new FileStream(Path.Combine(path, "log\\config.txt"), FileMode.Open);
            StreamReader read = new StreamReader(stream, Encoding.Unicode);
            var chuoicf = read.ReadLine();
            string[] araylistchuoi = chuoicf.Split(new char[] { '\t' });
            BienToanCuc.hienthiDsKham = araylistchuoi[1];
            BienToanCuc.MaPhongKham_TC = araylistchuoi[0];
            //BienToanCuc.MaKhoa_TC = araylistchuoi[1];
            BienToanCuc.hienThiDsCLS = araylistchuoi[2];
            BienToanCuc.CheckAll_TC = araylistchuoi[3];
            BienToanCuc.HienThiThuNgan = araylistchuoi[4];
            BienToanCuc.HienThiCapThuoc = araylistchuoi[6];
            BienToanCuc.TenPhongKham = araylistchuoi[8];
            BienToanCuc.SoDT = araylistchuoi[9];
            read.Close();
            stream.Close();
        }
        
        public static List<ScreenWaiting> GetData()
        {
            var client = new HttpClient();
            client.DefaultRequestHeaders.Accept
                 .Add(new MediaTypeWithQualityHeaderValue("application/json"));
            var result = client.GetAsync("http://192.168.1.250/api/BV_ThuTienVienPhi/get-screen-waiting").Result;
            if (result.IsSuccessStatusCode)
            {
                return JsonConvert.DeserializeObject<List<ScreenWaiting>>(result.Content.ReadAsStringAsync().Result);
            }
            return null;
        }
        public void ReadConnect()
        {
            string path = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetEntryAssembly().Location);

            if (!Directory.Exists(path + @"\log"))
            {
                Directory.CreateDirectory(path + @"\log");
            }
            FileStream stream = new FileStream(Path.Combine(path, "log\\config.txt"), FileMode.Open);
            StreamReader read = new StreamReader(stream, Encoding.Unicode);
            var chuoicf = read.ReadLine();
            string[] araylistchuoi = chuoicf.Split(new char[] { '\t' });
            MaPK = araylistchuoi[0];
            CheckAll = araylistchuoi[3];
            BienToanCuc.hienthiDsKham = araylistchuoi[1];
            HienThiCLS = araylistchuoi[2];
            HienThiThuNgan = araylistchuoi[4];
            TenLoaiThu = araylistchuoi[5];
            HienThuCapThuoc = araylistchuoi[6];
            TenLoaiCap = araylistchuoi[7];
            TenPhongKham = araylistchuoi[8];
            SoDT = araylistchuoi[9];
            NumberDelay = araylistchuoi[10];
            read.Close();
            stream.Close();
        }
        public void ReadConnectCLS()
        {
            string path = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetEntryAssembly().Location);

            if (!Directory.Exists(path + @"\log"))
            {
                Directory.CreateDirectory(path + @"\log");
            }
            FileStream streamCLS = new FileStream(Path.Combine(path, "log\\configCLS.txt"), FileMode.Open);
            StreamReader readCLS = new StreamReader(streamCLS, Encoding.Unicode);
            var chuoicls = readCLS.ReadLine();
            string[] araylistchuoi = chuoicls.Split(new char[] { '\t' });
            MaNhomDV = araylistchuoi[0];
            readCLS.Close();
            streamCLS.Close();
        }
        private void FullScreen()
        {
            FormBorderStyle = FormBorderStyle.None;
             WindowState = FormWindowState.Maximized;
            WindowState = FormWindowState.Maximized;
            TopMost = true;
        }
        private void Minimize()
        {
            FormBorderStyle = FormBorderStyle.None;
            WindowState = FormWindowState.Maximized;
            WindowState = FormWindowState.Minimized;
            TopMost = true;
        }
        private void CloseList()
        {
            FormBorderStyle = FormBorderStyle.Sizable;
            WindowState = FormWindowState.Normal;
            TopMost = false;
        }
        private void LoadDanhSach()
        {
            if (BienToanCuc.hienthiDsKham == "true")
            {
               if(CheckAll == "Unchecked")
                {
                    LoadDanhSachChoKhamByKhoa();
                }
               else  LoadDanhSachChoKhamAll();
           
            }
            else if (HienThiCLS == "true")
            {
                LoadDanhSachCLS();
                //else { XtraMessageBox.Show("Nhóm dịch vụ không được rỗng, vui lòng kiểm tra lại", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning); }
            }
            else if (HienThiThuNgan == "true")
            {
                LoadDanhSachThuNgan();
            }
            else if (HienThuCapThuoc == "true")
            {
                LoadDanhSachChoCapThuoc();
            }
            //if (CheckAll=="Unchecked")
            // gDanhSach.DataSource = VewKhamBenhDAO.Instance.ListChoKhamByPK(MaPK);  
        }
        private void LoadDanhSachChoKhamAll()
        {
            var listMaster = BV_MasterDAO.Instance.ListBV_Master_Cho();
            var listChoKhamFull = VewKhamBenhDAO.Instance.LoadFullListChoKham2();
            var listFull = listMaster.Join(listChoKhamFull, m => m.MaBenhNhan, k => k.Mabn,
                (m, k)
                => new
                {
                    k.Stt,
                    k.HoTen,
                    k.NamSinh,
                    k.TrangThai,
                    k.SoVaoVien,
                    m.TongTime

                }
                ).ToList();
            // timer2.Start();
           // var listBNChoKhamByKhoa = gDanhSach.DataSource = VewKhamBenhDAO.Instance.ListChoKhamByPK(MaPK);
           // gDanhSach.DataSource = listFull.Where(q => q.TongTime < 30);
            gDanhSach.DataSource = listFull;
           // var hh = CheckAll == "Unchecked" ? listBNChoKhamByKhoa : listBNFull;
        }
        private void LoadDanhSachChoKhamByKhoa()
        {
            var listMaster = BV_MasterDAO.Instance.ListBV_Master_Cho();
            var listChoKhamFull = VewKhamBenhDAO.Instance.ListChoKhamByPK(MaPK);
            var listFull = listMaster.Join(listChoKhamFull, m => m.MaBenhNhan, k => k.Mabn,
                (m, k)
                => new
                {
                    STT=k.Stt,
                    k.HoTen,
                    k.NamSinh,
                    k.TrangThai,
                    k.SoVaoVien,
                    m.TongTime

                }
                ).ToList();
            gDanhSach.DataSource = listFull;
        }
        private void LoadDanhSachCLS()
        {
            string nhomcls1;
            string nhomcls2;
            string nhomcls3;
            string nhomcls4;
            if (MaNhomDV != "")
            {
                string[] araylistchuoi = MaNhomDV.Split(new char[] { ';' });
                int cuontaray = araylistchuoi.Count();
                List<VewCLSDTO> listfullcls = VewCLSDAO.Instance.ListChoCLSFull();
                switch (cuontaray)
                {
                    case 1:
                        nhomcls1 = araylistchuoi[0];
                        var hh = listfullcls.Where(q => q.Nhom == nhomcls1);
                        gDanhSach.DataSource = hh;
                        //gDanhSach.DataSource = listfullcls.Where(q => q.Nhom == nhomcls1);
                        gridView1.GroupPanelText = "DANH SÁCH CHỜ PHÒNG " + nhomcls1;
                        break;
                    case 2:
                        nhomcls1 = araylistchuoi[0];
                        nhomcls2 = araylistchuoi[1];
                        gDanhSach.DataSource = listfullcls.Where(q => q.Nhom == nhomcls1 || q.Nhom == nhomcls2);
                        gridView1.GroupPanelText = "DANH SÁCH CHỜ PHÒNG " + nhomcls1 + " , " + nhomcls2;
                        break;
                    case 3:
                        nhomcls1 = araylistchuoi[0];
                        nhomcls2 = araylistchuoi[1];
                        nhomcls3 = araylistchuoi[2];
                        gDanhSach.DataSource = listfullcls.Where(q => q.Nhom == nhomcls1 || q.Nhom == nhomcls2 || q.Nhom == nhomcls3);
                        gridView1.GroupPanelText = "DANH SÁCH CHỜ PHÒNG " + nhomcls1 + " , " + nhomcls2 + " , " + nhomcls3;
                        break;
                    case 4:
                        nhomcls1 = araylistchuoi[0];
                        nhomcls2 = araylistchuoi[1];
                        nhomcls3 = araylistchuoi[2];
                        nhomcls4 = araylistchuoi[3];
                        gDanhSach.DataSource = listfullcls.Where(q => q.Nhom == nhomcls1 || q.Nhom == nhomcls2 || q.Nhom == nhomcls3 || q.Nhom == nhomcls4);
                        gridView1.GroupPanelText = "DANH SÁCH CHỜ PHÒNG " + nhomcls1 + ", " + nhomcls2 + ", " + nhomcls3 + ", " + nhomcls4;
                        break;
                    default:
                        //XtraMessageBox.Show("Số nhóm bạn cấu hình vượt quá 4 nhóm, vui lòng cấu hình ít hơn", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        break;
                }
                 
            }
            //else { XtraMessageBox.Show("Nhóm dịch vụ không được rỗng, vui lòng kiểm tra lại", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning); }
        }
        private void LoadDanhSachThuNgan()
        {

            List<BV_BenhNhanDTO> listBN = BV_BenhNhanDAO.Instance.ListBV_BenhNhan();
            List<BV_MasterDTO> listMT = BV_MasterDAO.Instance.ListBV_Master_Cho();
            List<BV_DuyetBHYTDTO> listBV_DuyetBHYT = BV_DuyetBHYTDAO.Instance.ListDuyetBHYT();
           // List<ScreenWaiting> ListChoThuAPI = GetData().Distinct().ToList();
            //var dd = listBN;
            int count2 = listMT.Count();
            var listMT2 = listMT.Where(q => q.TongTime < int.Parse(NumberDelay) );
            int count = listMT2.Count();
            BienToanCuc.countChoThu = count>0?count-1:count;
            BienToanCuc.cuontBNQuaGio = count2 - count;
            var listMTChoThu = listMT2.Where(k => k.Ngay == DateTime.Today);
            var listChoThuNgan = listBN.Join(listMTChoThu, q => q.Ma, m => m.MaBenhNhan,
                (q, m)
               => new
               {
                   m.STT,
                   q.HoTen,
                   q.NamSinh,
                   TT = m.TrangThai,
                   m.CoBHYT,
                   m.DoiTuong,
                   m.MaBenhNhan,
                   // TrangThai="Chưa Thu",
                   m.TienDichVuBHYTChuaThu,
                   m.TienThuocBHYTChuaThu,
                   m.TienDichVuChuaThu,
                   m.TienThuocChuaThu,
                   m.SoVaoVien,
                   ThanhTienBH = m.TienDichVuBHYTChuaThu + m.TienThuocBHYTChuaThu,
                   ThanhTienDV = m.TienDichVuChuaThu + m.TienThuocChuaThu,
                   ThanhTien2 = m.TienDichVuBHYTChuaThu + m.TienThuocBHYTChuaThu + m.TienDichVuChuaThu + m.TienThuocChuaThu,
                   m.KhoaPhongDK,
                  // NgayCapNhatFull= m.NgayCapNhat.Substring(0, 4)+"/"+ m.NgayCapNhat.Substring(4, 2)+"/"+m.NgayCapNhat.Substring(6, 2)+" "+ m.NgayCapNhat.Substring(8, 2)+":"+ m.NgayCapNhat.Substring(10, 2)+":"+ m.NgayCapNhat.Substring(12, 2),
                   //now= DateTime.Now.ToLongTimeString(),
                   m.NgayCapNhat,
                   now =DateTime.Now,
                   //jj = Convert.ToDateTime(m.NgayCapNhat),
                  // TongGio=(DateTime.Now - Convert.ToDateTime(m.NgayCapNhat.Substring(0, 4)+"/"+ m.NgayCapNhat.Substring(4, 2)+"/"+m.NgayCapNhat.Substring(6, 2)+" "+ m.NgayCapNhat.Substring(8, 2)+":"+ m.NgayCapNhat.Substring(10, 2)+":"+ m.NgayCapNhat.Substring(12, 2))).TotalMinutes
                  m.TongTime
               }
            ).ToList();
            var listFull = listChoThuNgan.Join(listBV_DuyetBHYT, q => q.SoVaoVien, k => k.SoVaoVien,
                (q, k)
                => new
                {
                    q.STT,
                    q.HoTen,
                    q.NamSinh,
                    q.ThanhTienBH,
                    q.ThanhTienDV,
                    q.CoBHYT,
                    q.SoVaoVien,
                    q.DoiTuong,
                    k.TiLeThanhToan,
                    k.DungTuyen,
                    BNCCT = k.TiLeThanhToan == 80 && q.ThanhTienBH > 223500 ? (q.ThanhTienBH * 20 / 100) : k.TiLeThanhToan == 95 ? (q.ThanhTienBH * 15 / 100) : q.ThanhTienBH - q.ThanhTienBH,
                    TongTien = (k.TiLeThanhToan == 80 && q.ThanhTienBH > 205500 ? (q.ThanhTienBH * 20 / 100) : k.TiLeThanhToan == 95 ? (q.ThanhTienBH * 15 / 100) : q.ThanhTienBH - q.ThanhTienBH) + q.ThanhTienDV,
                    q.KhoaPhongDK,
                    q.MaBenhNhan,
                    q.NgayCapNhat,
                    q.TongTime
                }
                ).ToList();

            //var ListChung = listChoThuNgan.Join(listBN, q => q.MaBenhNhan, k => k.Ma, (q, k)
            //=> new
            //{
            //    q.STT,
            //    q.HoTen,
            //    q.NamSinh,
            //    ThucThuBHYT = listBV_DuyetBHYT.OrderBy(o => o.TiLeThanhToan == 80 && q.ThanhTienBH > 205500 ? (q.ThanhTienBH * 20 / 100) : o.TiLeThanhToan == 95 ? (q.ThanhTienBH * 15 / 100) : q.ThanhTienDV),
            //    ThucThu = q.ThanhTienBH > 0 ? ( listBV_DuyetBHYT.OrderBy(o => o.TiLeThanhToan == 80 && q.ThanhTienBH > 205500 ? (q.ThanhTienBH * 20 / 100) : o.TiLeThanhToan == 95 ? (q.ThanhTienBH * 15 / 100) : 0) )
            //});
            //Cach viet LeftOuter Join

            /*

            List<BenNhanInfo> listBNV2 = new List<BenNhanInfo>();
            // var stt = 1;
            foreach (var item in listChoThuNgan)
            {
                var bninfo = new BenNhanInfo();
                bninfo.STT = item.STT.GetValueOrDefault();
                bninfo.TenBN = item.HoTen;
                bninfo.NamSinh = item.NamSinh;
                bninfo.ThucThu = item.ThanhTienDV;
                if (listBV_DuyetBHYT != null && listBV_DuyetBHYT.Any(x => x.SoVaoVien == item.SoVaoVien))
                {
                    var info = listBV_DuyetBHYT.Where(o => o.SoVaoVien == item.SoVaoVien).FirstOrDefault();
                    var tileBHYT = info.TiLeThanhToan;
                    var thanhTienBHYT = item.ThanhTienBH;
                    var tiendichvu = item.TienDichVuChuaThu + item.TienThuocChuaThu;
                    var thucThu = tileBHYT == 80 && thanhTienBHYT > 205500 ? thanhTienBHYT * 20 / 100 : tileBHYT == 95 ? thanhTienBHYT * 15 / 100 : 0;
                    var thucThufn = thucThu + tiendichvu;
                    bninfo.ThucThu = thucThufn;
                }
                listBNV2.Add(bninfo);

            

            }
            */
            //var listFull2 = from tn in listChoThuNgan
            //                join dbh in listBV_DuyetBHYT on tn.SoVaoVien equals dbh.SoVaoVien
            //                into a
            //                from b in a.DefaultIfEmpty()
            //                select new
            //                {

            //                    tn.STT,
            //                    tn.HoTen,
            //                    tn.NamSinh,
            //                    DungTuyen2= (b.DungTuyen)!=null?b.DungTuyen:false,
            //                    TiLeThanhToan2= (b.TiLeThanhToan!=null)?b.TiLeThanhToan:0,
            //                    tn.ThanhTienDV,
            //                    tn.ThanhTienBH,
            //                    TongTien = (b.TiLeThanhToan == 80 && tn.ThanhTienBH > 205500 ? (tn.ThanhTienBH * 20 / 100) : b.TiLeThanhToan == 95 ? (tn.ThanhTienBH * 15 / 100) : tn.ThanhTienBH - tn.ThanhTienBH) + tn.ThanhTienDV
            //                };

            // var listf = listFull.A
            //  var ListChung= listChoThuNgan.GroupJoin(listBV_DuyetBHYT)
            //=====================================================================================================
            /*
            var DanhSachChoTinDuc = ListChoThuAPI.Join(listFull, q => q.MaBN, m => m.MaBenhNhan,
                 (q, m)
                => new
                {
                    Stt=q.STT,
                    q.TenBN,
                    q.NamSinh,
                    TongTien = m.KhoaPhongDK == "BK006" || m.KhoaPhongDK == "BK008" ? q.TongTien-m.BNCCT : q.TongTien ,
                   TrangThai = "Chờ Cấp",
                    m.NgayCapNhat,
                    m.TongTime,
                    m.SoVaoVien
                }
             );
            int cuont3 = DanhSachChoTinDuc.Count();
            */
            if (TenLoaiThu == "ALL")
            {
                this.TrangThai.FieldName = "TongTien";
                this.TrangThai.Caption = "THÀNH TIỀN";
                this.HoTen.FieldName = "HoTen";
                gridView1.GroupPanelText = " BỆNH NHÂN CHỜ THANH TOÁN";
               // gridView1.Appearance.HeaderPanel = "";
                // var hh = 0;
                // var list = listFull.Where(q => q.TongGio == hh);
                // var lists = listFull.Sort(new SUNS_VEW.SortList());
                gDanhSach.DataSource = listFull;
               // gDanhSach.DataSource = DanhSachChoTinDuc.Distinct(); // Gọi Tu API
            }
            else
            {
                MessageBox.Show("Vui lòng cấu hình quầy thu chọn ALL");
            }
            // DÙNG CHUNG

            /*
            switch (TenLoaiThu)
            {
                case "DỊCH VỤ":
                    this.TrangThai.FieldName = "ThanhTienDV";
                    // this.TrangThai.Name = "";
                    this.TrangThai.Caption = "THÀNH TIỀN";
                    gridView1.GroupPanelText = "DANH SÁCH CHỜ THANH TOÁN DỊCH VỤ";
                    gDanhSach.DataSource = listChoThuNgan.Where(q => q.ThanhTienDV > 0);
                    break;
                case "BHYT":
                    this.TrangThai.FieldName = "BNCCT";
                    //this.TrangThai.Name = "TrangThai";
                    this.TrangThai.Caption = "THÀNH TIỀN";
                    gridView1.GroupPanelText = "DANH SÁCH CHỜ THANH TOÁN BHYT";
                    gDanhSach.DataSource = listFull.Where(q => q.CoBHYT == "True" && q.DoiTuong == "BHYT");
                    break;
                case "ALL":
                    this.TrangThai.FieldName = "TongTien";
                    this.TrangThai.Caption = "THÀNH TIỀN";
                    this.HoTen.FieldName = "TenBN";
                    gridView1.GroupPanelText = "DANH SÁCH BỆNH NHÂN CHỜ THANH TOÁN";
                    // gDanhSach.DataSource = listMTChoThu;
                    gDanhSach.DataSource = ListChoThuAPI.Distinct();
                    break;
                default:
                    break;
            }
            */

            // gDanhSach.DataSource = listChoThuNgan;
        }
        
        private void LoadDanhSachChoCapThuoc()
        {

            // this.TrangThai.FieldName = "TienThuocChuaThu";
            this.TrangThai.FieldName = "TrangThai";
            List<BV_BenhNhanDTO> listBN = BV_BenhNhanDAO.Instance.ListBV_BenhNhan();
            List<ViewChoCapThuocDTO> listChoCapThuoc = VewChoCapThuocDAO.Instance.ListBV_ChoCapThuocToDay();
            var listChoCapFull = listBN.Join(listChoCapThuoc, q => q.Ma, m => m.MaBN,
                (q, m)
               => new
               {
                   m.STT,
                   q.HoTen,
                   q.NamSinh,
                   m.DaCap,
                   m.TienThuocBHYTChuaThu,
                   m.TienThuocChuaThu,
                   m.DoiTuong,
                   m.TinhBHYT,
                   TrangThai = "Chờ Cấp"
               }
            );
           
            switch (TenLoaiCap)
            {
                case "DỊCH VỤ":
                    gridView1.GroupPanelText = "DANH SÁCH CHỜ CẤP THUỐC DỊCH VỤ";
                    gDanhSach.DataSource = listChoCapFull.Where(q => q.TinhBHYT != "True");
                    break;
                case "BHYT":
                    gridView1.GroupPanelText = "DANH SÁCH CHỜ CẤP THUỐC BHYT";
                    gDanhSach.DataSource = listChoCapFull.Where(q => q.TinhBHYT == "True");
                    break;
                case "ALL":
                    gridView1.GroupPanelText = "DANH SÁCH CHỜ CẤP THUỐC";
                    gDanhSach.DataSource = listChoCapFull;
                    break;
                default:
                    break;
            }
            //gDanhSach.DataSource = listChoCapFull.Where(q=>q.TinhBHYT=="True");
        }
        public class SortListq : IComparer
        {
            public int Compare(object x, object y)
            {
                BV_MasterDTO p1 = x as BV_MasterDTO;
                BV_MasterDTO p2 = y as BV_MasterDTO;
                if (p1 == null || p2 == null)
                {
                    throw new InvalidOperationException();
                }
                else
                {

                    if (p1.TongTime > p2.TongTime)
                    {
                        return 1;
                    }
                    else if (p1.TongTime == p1.TongTime)
                    {
                        return 0;
                    }
                    else
                    {
                        return -1;
                    }
                }

            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            LoadDanhSach();
            label1.Text = DateTime.Now.ToLongTimeString();
            label2.Text = DateTime.Now.ToLongDateString();
        }
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                CloseList();
                //ListDangThucHien hh = new ListDangThucHien();
                //hh.Visible = false;
                //this.Visible = false;
                //Form1 form = new Form1();
                //form.Close();
            }
        }

        private void button1_KeyDown(object sender, KeyEventArgs e)
        {
            //if (e.KeyCode == Keys.Escape)
            //{
            //    FormBorderStyle = FormBorderStyle.Sizable;
            //    WindowState = FormWindowState.Normal;
            //    TopMost = false;
            //}
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void gDanhSach_MouseDoubleClick(object sender, MouseEventArgs e)
        {

        }

        private void bntChuyen_Click(object sender, EventArgs e)
        {


        }

        private void gridView1_CustomDrawFooterCell(object sender, DevExpress.XtraGrid.Views.Grid.FooterCellCustomDrawEventArgs e)
        {
            //DateTime.Now.ToLongTimeString();
            //DateTime.Now.ToLongDateString();
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
            e.Cache.DrawString(TenPhongKham+"        Hotline: "+SoDT, e.Appearance.GetFont(), e.Appearance.GetForeBrush(e.Cache), rect, stringFormat);
        }

        private void Bt_Click(object sender, EventArgs e)
        {

        }

        private void BntChuyen_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void gDanhSach_Click(object sender, EventArgs e)
        {
            CauHinhPK ch = new CauHinhPK();
            ch.ShowDialog();
        }

        private void gridView1_SelectionChanged(object sender, DevExpress.Data.SelectionChangedEventArgs e)
        {

        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            gridView1.Appearance.HideSelectionRow.ForeColor = System.Drawing.Color.Yellow;
            timer4.Enabled = true;
            timer3.Enabled = false;
        }
        private void timer4_Tick(object sender, EventArgs e)
        {
            gridView1.Appearance.HideSelectionRow.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            timer3.Enabled = true;
            timer4.Enabled = false;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }


}
