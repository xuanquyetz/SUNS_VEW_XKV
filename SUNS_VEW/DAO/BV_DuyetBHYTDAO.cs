using SUNS_VEW.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SUNS_VEW.DAO
{
   public class BV_DuyetBHYTDAO
    {
        private static BV_DuyetBHYTDAO instance;

        public static BV_DuyetBHYTDAO Instance
        {
            get
            {
                if (instance == null) instance = new BV_DuyetBHYTDAO();
                return BV_DuyetBHYTDAO.instance;
            }

            set
            {
                instance = value;
            }
        }
        private BV_DuyetBHYTDAO() { }
        public List<BV_DuyetBHYTDTO> ListDuyetBHYT()
        {
            List<BV_DuyetBHYTDTO> listfull = new List<BV_DuyetBHYTDTO>();
            DataTable data = KeNoiData.Instance.ExecuteQuery("SELECT *FROM dbo.BV_DuyetBHYT WHERE NgayThanhToan=CONVERT (DATE, GETDATE())");
            foreach (DataRow item in data.Rows)
            {
                BV_DuyetBHYTDTO stt = new BV_DuyetBHYTDTO(item);
                listfull.Add(stt);
            }
            return listfull;
        }
    }
}
