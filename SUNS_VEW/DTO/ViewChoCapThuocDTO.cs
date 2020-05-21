using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SUNS_VEW.DTO
{
   public class ViewChoCapThuocDTO
    {
        private int sTT;
        private string maBN;
        private string soVaoVien;
        private string tinhBHYT;
        private bool daCap;
        private decimal tienThuocChuaThu;
        private decimal tienThuocBHYTChuaThu;
        private string doiTuong;
        private DateTime? ngay;
        public ViewChoCapThuocDTO(int sTT, string maBN, string soVaoVien, string tinhBHYT, bool daCap, decimal tienThuocChuaThu, decimal tienThuocBHYTChuaThu, string doiTuong, DateTime? ngay)
        {
            this.sTT = STT;
            this.maBN = MaBN;
            this.soVaoVien = SoVaoVien;
            this.tinhBHYT = TinhBHYT;
            this.tienThuocChuaThu = TienThuocChuaThu;
            this.tienThuocBHYTChuaThu = TienThuocBHYTChuaThu;
            this.doiTuong = DoiTuong;
            this.ngay = Ngay;
        }
        public ViewChoCapThuocDTO(DataRow row)
        {
            this.STT = (int)row["STT"];
            this.MaBN = row["MaBN"].ToString();
            this.SoVaoVien = row["SoVaoVien"].ToString();
            this.TinhBHYT = row["TinhBHYT"].ToString();
            this.DaCap = (bool)row["DaCap"];
            this.TienThuocChuaThu=(decimal)row["TienThuocChuaThu"];
            this.TienThuocBHYTChuaThu = (decimal)row["TienThuocBHYTChuaThu"];
            this.DoiTuong = row["DoiTuong"].ToString();
            this.Ngay = (DateTime?)row["Ngay"];
        }

        public int STT
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

        public string TinhBHYT
        {
            get
            {
                return tinhBHYT;
            }

            set
            {
                tinhBHYT = value;
            }
        }

        public bool DaCap
        {
            get
            {
                return daCap;
            }

            set
            {
                daCap = value;
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
