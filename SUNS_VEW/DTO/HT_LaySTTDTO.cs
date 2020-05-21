using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SUNS_VEW.DTO
{
   public class HT_LaySTTDTO
    {
        private string iD;
        private DateTime? ngay;
        private int soTT;
        private DateTime? thoiGian;
        private int uuTien;
        public HT_LaySTTDTO(string iD, DateTime? ngay, int soTT, DateTime? thoiGian, int uuTien)
        {
            this.iD = ID;
            this.ngay = Ngay;
            this.soTT = SoTT;
            this.thoiGian = ThoiGian;
            this.uuTien = UuTien;
        }
        public HT_LaySTTDTO(DataRow row)
        {
            ID = row["STT"].ToString();
            Ngay = (DateTime?)row["Ngay"];
            SoTT = (int)row["STT"];
            ThoiGian = (DateTime?)row["ThoiGian"];
            UuTien =(int)row["UuTien"];
        }

        public string ID
        {
            get
            {
                return iD;
            }

            set
            {
                iD = value;
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

        public int SoTT
        {
            get
            {
                return soTT;
            }

            set
            {
                soTT = value;
            }
        }

        public DateTime? ThoiGian
        {
            get
            {
                return thoiGian;
            }

            set
            {
                thoiGian = value;
            }
        }

        public int UuTien
        {
            get
            {
                return uuTien;
            }

            set
            {
                uuTien = value;
            }
        }
    }
}
