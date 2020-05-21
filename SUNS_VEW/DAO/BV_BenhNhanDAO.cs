using SUNS_VEW.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SUNS_VEW.DAO
{
   public class BV_BenhNhanDAO
    {
        private static BV_BenhNhanDAO instance;

        public static BV_BenhNhanDAO Instance
        {
            get
            {
                if (instance == null) instance = new BV_BenhNhanDAO();
                return BV_BenhNhanDAO.instance;
            }

            set
            {
                instance = value;
            }
        }
        private BV_BenhNhanDAO() { }

        public List<BV_BenhNhanDTO> ListBV_BenhNhan()
        {
            List<BV_BenhNhanDTO> listfull = new List<BV_BenhNhanDTO>();
            DataTable data = KeNoiData.Instance.ExecuteQuery("SELECT *FROM  dbo.BV_BenhNhan WHERE  NgayCapNhat=CONVERT (DATE, GETDATE()) OR Ngay=CONVERT (DATE, GETDATE())");
            foreach (DataRow item in data.Rows)
            {
                BV_BenhNhanDTO cls = new BV_BenhNhanDTO(item);
                listfull.Add(cls);
            }
            return listfull;
        }
    }
}
