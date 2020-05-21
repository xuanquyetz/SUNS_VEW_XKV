using SUNS_VEW.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SUNS_VEW.DAO
{
   public class HT_LaySTTDAO
    {
        private static HT_LaySTTDAO instance;

        public static HT_LaySTTDAO Instance
        {
            get
            {
                if (instance == null) instance = new HT_LaySTTDAO();
                return HT_LaySTTDAO.instance;
            }

            set
            {
                instance = value;
            }
        }
        private HT_LaySTTDAO() { }
        public void InsertSTT( DateTime? Ngay, int STT, DateTime? Thoigian, int UuTien)
        {
            KeNoiData.Instance.ExecuteNonQuery("INSERT INTO [dbo].[HT_LaySTT]([ID], [Ngay], [STT], [ThoiGian], [UuTien]) VALUES (NEWID() , @Ngay , @STT , @ThoiGian , @UuTien )", new object[] { Ngay, STT, Thoigian, UuTien});
        }
        public List<HT_LaySTTDTO> ListHT_LaySTT()
        {
            List<HT_LaySTTDTO> listfull = new List<HT_LaySTTDTO>();
            DataTable data = KeNoiData.Instance.ExecuteQuery("SELECT*FROM HT_LaySTT where [Ngay]=CONVERT (DATE, GETDATE())");
            foreach (DataRow item in data.Rows)
            {
                HT_LaySTTDTO stt = new HT_LaySTTDTO(item);
                listfull.Add(stt);
            }
            return listfull;
        }
    }
}
