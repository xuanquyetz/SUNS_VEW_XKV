using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SUNS_VEW.DTO
{
   public class BV_BenhNhanDTO
    {
        private string ma;
        private string hoTen;
        private string hoTenKhongDau;
        private int ngaySinh;
        private int thangSinh;
        private int namSinh;
        private string soDienThoai;
        private string gioiTinh;
        private string diaChi;
        private string quocTich;
        private string tinhThanh;
        private string quanHuyen;
        private string phuongXa;
        private string doiTuong;
        private string soBHYT;
        private string maNoiDKBHYT;
        private DateTime? ngay;
        private DateTime? ngayCapNhat;
        private string ngaySinhs;
        public BV_BenhNhanDTO(string ma, string hoTen, string hoTenKhongDau, int ngaySinh, int thangSinh, int namSinh, string soDienThoai, string gioiTinh, string diaChi,
          string quocTich, string tinhThanh, string quanHuyen, string phuongXa, string doiTuong, string soBHYT, string maNoiDKBHYT, DateTime? ngay, DateTime? ngayCapNhat, string ngaySinhs)
        {
            this.ma = Ma;
            this.hoTen = HoTen;
            this.hoTenKhongDau = HoTenKhongDau;
            this.ngaySinh = NgaySinh;
            //this.ngaySinh = ngaySinh.ToString() ==null ? NgaySinh = 0 : ngaySinh = NgaySinh; 
            this.thangSinh = ThangSinh;
            this.namSinh = NamSinh;
            this.soDienThoai = SoDienThoai;
            this.gioiTinh = GioiTinh;
            this.diaChi = DiaChi;
            this.quocTich = QuocTich;
            this.tinhThanh = TinhThanh;
            this.quanHuyen = QuanHuyen;
            this.phuongXa = PhuongXa;
            this.doiTuong = DoiTuong;
            this.soBHYT = SoBHYT;
            this.maNoiDKBHYT = MaNoiDKBHYT;
            this.ngay = Ngay;
            this.ngayCapNhat = NgayCapNhat;
            this.ngaySinhs = NgaySinhs;
        }
        public BV_BenhNhanDTO(DataRow row)
        {
            this.Ma = row["Ma"].ToString();
            this.HoTen = row["HoTen"].ToString();
            this.HoTenKhongDau = row["HoTenKhongDau"].ToString();
            //this.NgaySinh
            //var hh = row["NgaySinh"];
            //this.NgaySinh =(int) hh;
            //this.NgaySinh = (int)row["NgaySinh"];
            //this.ThangSinh =(int)row["ThangSinh"];
            this.NamSinh = (int)row["NamSinh"];
            this.SoDienThoai = row["DienThoai"].ToString();
            this.GioiTinh = row["GioiTinh"].ToString();
            this.DiaChi = row["DiaChi"].ToString();
            this.QuocTich = row["QuocTich"].ToString();
            this.TinhThanh = row["TinhThanh"].ToString();
            this.QuanHuyen = row["QuanHuyen"].ToString();
            this.PhuongXa = row["PhuongXa"].ToString();
            this.DoiTuong = row["DoiTuong"].ToString();
            this.SoBHYT = row["SoBHYT"].ToString();
            this.MaNoiDKBHYT = row["MaNoiDKBHYT"].ToString();
            this.Ngay = (DateTime?)row["Ngay"];
           // this.NgayCapNhat = (DateTime?)row["NgayCapNhat"];
           // this.NgaySinhs = row["NgaySinh"].ToString();
        }

        public string Ma
        {
            get
            {
                return ma;
            }

            set
            {
                ma = value;
            }
        }

        public string HoTen
        {
            get
            {
                return hoTen;
            }

            set
            {
                hoTen = value;
            }
        }

        public string HoTenKhongDau
        {
            get
            {
                return hoTenKhongDau;
            }

            set
            {
                hoTenKhongDau = value;
            }
        }

        public int NgaySinh
        {
            get
            {
                return ngaySinh;
            }

            set
            {
                ngaySinh = value;
            }
        }

        public int ThangSinh
        {
            get
            {
                return thangSinh;
            }

            set
            {
                thangSinh = value;
            }
        }

        public int NamSinh
        {
            get
            {
                return namSinh;
            }

            set
            {
                namSinh = value;
            }
        }

        public string SoDienThoai
        {
            get
            {
                return soDienThoai;
            }

            set
            {
                soDienThoai = value;
            }
        }

        public string GioiTinh
        {
            get
            {
                return gioiTinh;
            }

            set
            {
                gioiTinh = value;
            }
        }

        public string DiaChi
        {
            get
            {
                return diaChi;
            }

            set
            {
                diaChi = value;
            }
        }

        public string QuocTich
        {
            get
            {
                return quocTich;
            }

            set
            {
                quocTich = value;
            }
        }

        public string TinhThanh
        {
            get
            {
                return tinhThanh;
            }

            set
            {
                tinhThanh = value;
            }
        }

        public string QuanHuyen
        {
            get
            {
                return quanHuyen;
            }

            set
            {
                quanHuyen = value;
            }
        }

        public string PhuongXa
        {
            get
            {
                return phuongXa;
            }

            set
            {
                phuongXa = value;
            }
        }

        public string DoiTuong
        {
            get
            {
                return doiTuong;
            }

            set
            {
                doiTuong = value;
            }
        }

        public string SoBHYT
        {
            get
            {
                return soBHYT;
            }

            set
            {
                soBHYT = value;
            }
        }

        public string MaNoiDKBHYT
        {
            get
            {
                return maNoiDKBHYT;
            }

            set
            {
                maNoiDKBHYT = value;
            }
        }

        public DateTime? Ngay
        {
            get
            {
                return ngay;
            }

            set
            {
                ngay = value;
            }
        }

        public DateTime? NgayCapNhat
        {
            get
            {
                return ngayCapNhat;
            }

            set
            {
                ngayCapNhat = value;
            }
        }

        public string NgaySinhs
        {
            get
            {
                return ngaySinhs;
            }

            set
            {
                ngaySinhs = value;
            }
        }
    }

    public class BenNhanInfo
    {
        public int STT { get; set; }
        public string TenBN { get; set; }
        public int NamSinh { get; set; }
        public decimal ThucThu { get; set; }
        
    }
}
