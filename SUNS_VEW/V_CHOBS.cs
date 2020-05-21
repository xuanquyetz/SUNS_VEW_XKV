using SUNS_VEW;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SUNS_VEW
{
   public class V_CHOBS
    {
        private static V_CHOBS ketnoi;

        internal static V_CHOBS Ketnoi
        {
            get
            {
                if (ketnoi == null) ketnoi = new V_CHOBS();
               
                return ketnoi;
            }

            set
            {
                ketnoi = value;
            }
        }
    private V_CHOBS() { }
       
        public DataTable LoadDanhDS()
        {
            return KeNoiData.Instance.ExecuteQuery("SELECT [STT],[HoTen],[NamSinh],[TrangThai] FROM dbo.[VW_DanhsachchoKham]");
        }
       public DataTable LoadListDangKham()
        {
            return KeNoiData.Instance.ExecuteQuery("SELECT [STT],[HoTen],[NamSinh],[TrangThai] FROM dbo.[VW_Danhsachdangthuchien]");
        }
    }
}
