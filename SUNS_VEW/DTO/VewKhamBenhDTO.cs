using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SUNS_VEW.DTO
{
   public class VewKhamBenhDTO
    {
        private int stt;
        private string soVaoVien;
        private string mabn;
        private string hoTen;
        private int namSinh;
        private string trangThai;
        private string noiChiDinh;
        private string tenPhongKham;
        private DateTime? ngay;
        public VewKhamBenhDTO(int stt,string soVaoVien,string mabn,string hoTen, int namSinh, string trangThai, string noiChiDinh, string tenPhongKham, DateTime? ngay)
        {
            this.stt = Stt;
            this.soVaoVien = SoVaoVien;
            this.mabn = Mabn;
            this.hoTen = HoTen;
            this.namSinh = NamSinh;
            this.trangThai = TrangThai;
            this.noiChiDinh = NoiChiDinh;
            this.tenPhongKham = TenPhongKham;
            this.ngay = Ngay;
        }
        public VewKhamBenhDTO(DataRow row)
        {
            this.Stt = (int)row["STT"];
            this.SoVaoVien = row["SoVaoVien"].ToString();
            this.Mabn = row["Ma"].ToString();
            this.HoTen = row["HoTen"].ToString();
            this.NamSinh = (int)row["NamSinh"];
            this.TrangThai = row["TrangThai"].ToString();
            this.NoiChiDinh = row["NoiChiDinh"].ToString();
            this.TenPhongKham = row["TenPK"].ToString();
            this.Ngay = (DateTime?)row["Ngay"];
        }

        public int Stt
        {
            get
            {
                return stt;
            }

            set
            {
                stt = value;
            }
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

        public string Mabn
        {
            get
            {
                return mabn;
            }

            set
            {
                mabn = value;
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

        public string NoiChiDinh
        {
            get
            {
                return noiChiDinh;
            }

            set
            {
                noiChiDinh = value;
            }
        }

        public string TenPhongKham
        {
            get
            {
                return tenPhongKham;
            }

            set
            {
                tenPhongKham = value;
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
    }
}
