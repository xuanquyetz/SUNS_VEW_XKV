using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SUNS_VEW.DTO
{
  public class VewCLSDTO
    {
        private int stt;
        private string soVaoVien;
        private string maBN;
        private string hoTen;
        private int namSinh;
        private bool daThucHien;
        private string maDV;
        private string nhom;
        private DateTime? ngay;
        public VewCLSDTO(int stt, string soVaoVien, string maBN, string hoTen, int namSinh, bool daThucHien, string maDV, string nhom, DateTime?ngay)
        {
            this.stt = STT;
            this.soVaoVien = SoVaoVien;
            this.maBN = maBN;
            this.hoTen = HoTen;
            this.namSinh = NamSinh;
            this.daThucHien = DaThucHien;
            this.maDV = MaDV;
            this.nhom = Nhom;
            this.ngay = Ngay;
        }
        public VewCLSDTO(DataRow row)
        {
            this.STT = (int)row["STT"];
            this.SoVaoVien = row["SoVaoVien"].ToString();
            this.MaBN = row["MaBN"].ToString();
            this.HoTen = row["HoTen"].ToString();
            this.NamSinh = (int)row["NamSinh"];
            this.DaThucHien=(bool)row["DaThucHien"];
            this.MaDV = row["MaDV"].ToString();
            this.Nhom = row["Nhom"].ToString();
            this.Ngay = (DateTime?)row["Ngay"];
        }

        public int STT
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

        public string MaBN
        {
            get
            {
                return maBN;
            }

            set
            {
                maBN = value;
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

        public bool DaThucHien
        {
            get
            {
                return daThucHien;
            }

            set
            {
                daThucHien = value;
            }
        }

        public string MaDV
        {
            get
            {
                return maDV;
            }

            set
            {
                maDV = value;
            }
        }

        public string Nhom
        {
            get
            {
                return nhom;
            }

            set
            {
                nhom = value;
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
