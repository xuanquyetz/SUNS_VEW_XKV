using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SUNS_VEW.DTO
{
    public class BV_MasterDTO
    {
        private string soVaoVien;
        private string maBenhNhan;
        private DateTime? ngay;
        private string doiTuong;
        private decimal tongChiPhi;
        private decimal tongThu;
        private string khoaPhongDK;
        private string trangThai;
        private decimal tienDichVuChuaThu;
        private decimal tienThuocChuaThu;
        private int? trangThaiThu;
        private string coBHYT;
        private decimal tienDichVuBHYTChuaThu;
        private decimal tienThuocBHYTChuaThu;
        private int? sTT;
        private string ngayCapNhat;
        private DateTime? timeNow;
        private DateTime? ngayCapNhatFull;
        double tongTime;
        public BV_MasterDTO(string soVaoVien, string maBenhNhan, DateTime? ngay, string doiTuong, decimal tongChiPhi, decimal tongThu, string khoaPhongDK,
           string trangThai, decimal tienDichVuChuaThu, decimal tienThuocChuaThu, int? trangThaiThu, string coBHYT, decimal tienDichVuBHYTChuaThu, decimal tienThuocBHYTChuaThu, int? sTT,string ngayCapNhat,
           DateTime? timeNow, DateTime? ngayCapNhatFull,double tongTime)
        {
            this.soVaoVien = SoVaoVien;
            this.maBenhNhan = MaBenhNhan;
            this.ngay = Ngay;
            this.doiTuong = DoiTuong;
            this.tongChiPhi = TongChiPhi;
            this.tongThu = TongThu;
            this.khoaPhongDK = KhoaPhongDK;
            this.trangThai = TrangThai;
            this.tienDichVuChuaThu = TienDichVuChuaThu;
            this.tienThuocChuaThu = TienThuocChuaThu;
            this.trangThaiThu = TrangThaiThu;
            this.coBHYT = CoBHYT;
            this.tienDichVuBHYTChuaThu = TienDichVuBHYTChuaThu;
            this.tienThuocBHYTChuaThu = TienDichVuBHYTChuaThu;
            this.sTT = STT;
            this.ngayCapNhat = NgayCapNhat;
            this.timeNow = TimeNow;
            this.ngayCapNhatFull = NgayCapNhatFull;
            this.tongTime = TongTime;
        }
        public BV_MasterDTO(DataRow row)
        {
            this.SoVaoVien = row["SoVaoVien"].ToString();
            this.MaBenhNhan = row["MaBN"].ToString();
            this.Ngay = (DateTime?)row["Ngay"];
            this.DoiTuong= row["DoiTuong"].ToString();
            this.TongChiPhi =(decimal) row["TongChiPhi"];
            this.TongThu=(decimal) row["TongThu"];
            this.KhoaPhongDK= row["KhoaPhongDK"].ToString();
            this.TrangThai= row["TrangThai"].ToString();
            this.TienDichVuChuaThu= (decimal)row["TienDichVuChuaThu"];
            this.TienThuocChuaThu= (decimal)row["TienThuocChuaThu"];
            this.TrangThaiThu = (int?)row["TrangThaiThu"];
            this.CoBHYT= row["CoBHYT"].ToString();
            this.TienDichVuBHYTChuaThu= (decimal)row["TienDichVuBHYTChuaThu"];
            this.TienThuocBHYTChuaThu= (decimal)row["TienThuocBHYTChuaThu"];
            this.STT= (int?)row["STT"];
            this.NgayCapNhat = row["NgayCapNhat"].ToString();
           // this.TimeNow = DateTime.Now;
           // this.NgayCapNhatFull =Convert.ToDateTime(NgayCapNhat.Substring(0, 4) + "/" + NgayCapNhat.Substring(4, 2) + "/" + NgayCapNhat.Substring(6, 2) + " " + NgayCapNhat.Substring(8, 2) + ":" + NgayCapNhat.Substring(10, 2) + ":" + NgayCapNhat.Substring(12, 2));
            this.TongTime = (int) (DateTime.Now - Convert.ToDateTime(NgayCapNhat.Substring(0, 4) + "/" + NgayCapNhat.Substring(4, 2) + "/" + NgayCapNhat.Substring(6, 2) + " " + NgayCapNhat.Substring(8, 2) + ":" + NgayCapNhat.Substring(10, 2) + ":" + NgayCapNhat.Substring(12, 2))).TotalMinutes;

        } 
        public string SoVaoVien
        {
            get
            {
                return soVaoVien;
            }

            set
            {
                soVaoVien = value;
            }
        }

        public string MaBenhNhan
        {
            get
            {
                return maBenhNhan;
            }

            set
            {
                maBenhNhan = value;
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

        public decimal TongChiPhi
        {
            get
            {
                return tongChiPhi;
            }

            set
            {
                tongChiPhi = value;
            }
        }

        public decimal TongThu
        {
            get
            {
                return tongThu;
            }

            set
            {
                tongThu = value;
            }
        }

        public string KhoaPhongDK
        {
            get
            {
                return khoaPhongDK;
            }

            set
            {
                khoaPhongDK = value;
            }
        }

        public string TrangThai
        {
            get
            {
                return trangThai;
            }

            set
            {
                trangThai = value;
            }
        }

        public decimal TienDichVuChuaThu
        {
            get
            {
                return tienDichVuChuaThu;
            }

            set
            {
                tienDichVuChuaThu = value;
            }
        }

        public decimal TienThuocChuaThu
        {
            get
            {
                return tienThuocChuaThu;
            }

            set
            {
                tienThuocChuaThu = value;
            }
        }

        public int? TrangThaiThu
        {
            get
            {
                return trangThaiThu;
            }

            set
            {
                trangThaiThu = value;
            }
        }

        public string CoBHYT
        {
            get
            {
                return coBHYT;
            }

            set
            {
                coBHYT = value;
            }
        }

        public decimal TienDichVuBHYTChuaThu
        {
            get
            {
                return tienDichVuBHYTChuaThu;
            }

            set
            {
                tienDichVuBHYTChuaThu = value;
            }
        }

        public decimal TienThuocBHYTChuaThu
        {
            get
            {
                return tienThuocBHYTChuaThu;
            }

            set
            {
                tienThuocBHYTChuaThu = value;
            }
        }

        public int? STT
        {
            get
            {
                return sTT;
            }

            set
            {
                sTT = value;
            }
        }

        public string NgayCapNhat
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

        public DateTime? TimeNow
        {
            get
            {
                return timeNow;
            }

            set
            {
                timeNow = value;
            }
        }

        public DateTime? NgayCapNhatFull
        {
            get
            {
                return ngayCapNhatFull;
            }

            set
            {
                ngayCapNhatFull = value;
            }
        }

        public double TongTime
        {
            get
            {
                return tongTime;
            }

            set
            {
                tongTime = value;
            }
        }
        public override string ToString()
        {
           return ""+ tongTime;
        }
    }
}
