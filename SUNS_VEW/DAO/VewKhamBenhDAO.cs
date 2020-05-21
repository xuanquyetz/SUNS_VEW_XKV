using SUNS_VEW.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SUNS_VEW.DAO
{
  public class VewKhamBenhDAO
    {
        private static VewKhamBenhDAO instance;

        public static VewKhamBenhDAO Instance
        {
            get
            {
                if (instance == null) instance = new VewKhamBenhDAO();
                return VewKhamBenhDAO.instance;
            }

            set
            {
                instance = value;
            }
        }
        private VewKhamBenhDAO() { }
        public List<VewKhamBenhDTO> ListChoKhamByPK(string maKhoa)
        {
            List<VewKhamBenhDTO> listbn = new List<VewKhamBenhDTO>();
            DataTable data = KeNoiData.Instance.ExecuteQuery("SELECT * FROM VW_ListBNKham WHERE TrangThai=N'Chờ_thực_hiện' AND NoiChiDinh=" + "'" + maKhoa + "'");
            foreach (DataRow item in data.Rows)
            {
                VewKhamBenhDTO kb = new VewKhamBenhDTO(item);
                listbn.Add(kb);
            }
            return listbn;
        }
        public DataTable LoadFullListChoKham()
        {
            DataTable listpk = new DataTable();
            return listpk = KeNoiData.Instance.ExecuteQuery("SELECT * FROM VW_ListBNKham WHERE TrangThai=N'Chờ_thực_hiện'");
        }
        public List<VewKhamBenhDTO> LoadFullListChoKham2()
        {
            List<VewKhamBenhDTO> listbnfull = new List<VewKhamBenhDTO>();
            DataTable data = KeNoiData.Instance.ExecuteQuery("SELECT * FROM VW_ListBNKham WHERE TrangThai=N'Chờ_thực_hiện' ");
            foreach (DataRow item in data.Rows)
            {
                VewKhamBenhDTO kb = new VewKhamBenhDTO(item);
                listbnfull.Add(kb);
            }
            return listbnfull;
        }
        public List<VewKhamBenhDTO> ListChoXuTriByPK(string maKhoa)
        {
            List<VewKhamBenhDTO> listbn = new List<VewKhamBenhDTO>();
            DataTable data = KeNoiData.Instance.ExecuteQuery("SELECT * FROM VW_ListBNKham WHERE TrangThai=N'Đang_thực_hiện' AND NoiChiDinh=" + "'" + maKhoa + "'");
            foreach (DataRow item in data.Rows)
            {
                VewKhamBenhDTO kb = new VewKhamBenhDTO(item);
                listbn.Add(kb);
            }
            return listbn;
        }
        public DataTable LoadFullListChoXuTri()
        {
            DataTable listpk = new DataTable();
            return listpk = KeNoiData.Instance.ExecuteQuery("SELECT * FROM VW_ListBNKham WHERE TrangThai=N'Đang_thực_hiện'");
        }
        public DataTable LoadPhongKham()
        {
            DataTable listpk = new DataTable();
            return listpk= KeNoiData.Instance.ExecuteQuery("SELECT * FROM dbo.HT_DMBanKham WHERE Iskhoa=0");
        }
        public DataTable LoadKhoaCLS()
        {
            DataTable listclskhoa =new DataTable();
            return listclskhoa= KeNoiData.Instance.ExecuteQuery("SELECT * FROM dbo.HT_DMBanKham WHERE Iskhoa=1");
        }
        //public DataTable LoadNhomDV()
        //{
        //    DataTable nhomdv = new DataTable();
        //    return nhomdv = KeNoiData.Instance.ExecuteQuery("SELECT*FROM dbo.HT_DMNhomDichVu");
        //}

    }
}
