using SUNS_VEW.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SUNS_VEW.DAO
{
   public class VewChoCapThuocDAO
    {
        private static VewChoCapThuocDAO instance;

        public static VewChoCapThuocDAO Instance
        {
            get
            {
                if (instance == null) instance = new VewChoCapThuocDAO();
                return VewChoCapThuocDAO.instance;
            }

            set
            {
                instance = value;
            }
        }
        private VewChoCapThuocDAO() { }

        public List<ViewChoCapThuocDTO> ListBV_ChoCapThuocToDay()
        {
            List<ViewChoCapThuocDTO> listfull = new List<ViewChoCapThuocDTO>();
            DataTable data = KeNoiData.Instance.ExecuteQuery("SELECT * FROM VW_ListChoCapThuoc");
            foreach (DataRow item in data.Rows)
            {
                ViewChoCapThuocDTO cls = new ViewChoCapThuocDTO(item);
                listfull.Add(cls);
            }
            return listfull;
        }
    }
}
