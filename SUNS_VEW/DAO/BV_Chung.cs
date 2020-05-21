using SUNS_VEW.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SUNS_VEW.DAO
{
   public class BV_Chung
    {
        List<BV_BenhNhanDTO> listBN = BV_BenhNhanDAO.Instance.ListBV_BenhNhan();
        List<BV_MasterDTO> listMT = BV_MasterDAO.Instance.ListBV_Master(); 
        public static void LoadDL()
        {

            List<BV_BenhNhanDTO> listBN = BV_BenhNhanDAO.Instance.ListBV_BenhNhan();
            List<BV_MasterDTO> listMT = BV_MasterDAO.Instance.ListBV_Master();

            var listMTChoThu = listMT.Where(k => k.TrangThaiThu > 0 && k.Ngay == DateTime.Today);
            var listChoThuNgan = listBN.Join(listMTChoThu, q => q.Ma, m => m.MaBenhNhan,
                (q, m)
               => new
               {
                   m.STT,
                   q.HoTen,
                   q.NamSinh,
                   m.TrangThai

               }
            );
        }


    }
}
