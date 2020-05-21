using SUNS_VEW.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SUNS_VEW.DAO
{
   public class VewCLSDAO
    {
        private static VewCLSDAO instance;

        public static VewCLSDAO Instance
        {
            get
            {if (instance == null) instance = new VewCLSDAO();
                return VewCLSDAO.instance;
            }

            set
            {
                instance = value;
            }
        }
       private VewCLSDAO() { }
        
        public List<VewCLSDTO> ListChoCLSByNhomDV(string Nhom)
        {
            List<VewCLSDTO> listcls = new List<VewCLSDTO>();
            DataTable data = KeNoiData.Instance.ExecuteQuery("SELECT * FROM dbo.ListChoCLS WHERE DaThucHien=0 AND Nhom="+"'"+Nhom+"'");
            foreach (DataRow item in data.Rows)
            {
                VewCLSDTO cls = new VewCLSDTO(item);
                listcls.Add(cls);
            }
            return listcls;
        }
        public List<VewCLSDTO> ListChoCLSFull()
        {
            List<VewCLSDTO> listcls = new List<VewCLSDTO>();
            DataTable data = KeNoiData.Instance.ExecuteQuery("SELECT * FROM [SUNS_HIS_TEST].[dbo].[ListChoCLS] WHERE DaThucHien=0");
            foreach (DataRow item in data.Rows)
            {
                VewCLSDTO cls = new VewCLSDTO(item);
                listcls.Add(cls);
            }
            return listcls;
        }
    }
}
