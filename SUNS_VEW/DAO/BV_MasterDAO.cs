using SUNS_VEW.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SUNS_VEW.DAO
{
    public class BV_MasterDAO
    {
        private static BV_MasterDAO instance;

        public static BV_MasterDAO Instance
        {
            get
            {
                if (instance == null) instance = new BV_MasterDAO();
                return BV_MasterDAO.instance;
            }

            set
            {
                instance = value;
            }
        }
        private BV_MasterDAO() { }

        public List<BV_MasterDTO> ListBV_Master()
        {
            List<BV_MasterDTO> listfull = new List<BV_MasterDTO>();
            DataTable data = KeNoiData.Instance.ExecuteQuery("SELECT *  FROM [BV_Master]");
            foreach (DataRow item in data.Rows)
            {
                BV_MasterDTO cls = new BV_MasterDTO(item);
                listfull.Add(cls);
            }
            return listfull;
        }
        public List<BV_MasterDTO> ListBV_Master_Cho()
        {
            List<BV_MasterDTO> listfull = new List<BV_MasterDTO>();
            DataTable data = KeNoiData.Instance.ExecuteQuery("SELECT *  FROM [BV_Master] Where [TrangThaiThu]!=-99 AND Ngay=CONVERT (DATE, GETDATE())");
            foreach (DataRow item in data.Rows)
            {
                BV_MasterDTO cls = new BV_MasterDTO(item);
                listfull.Add(cls);
            }
            return listfull;
        }

    }
}
