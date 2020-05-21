using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace SUNS_VEW.DTO
{
   public class BV_DuyetBHYTDTO
    {
        public KeyValuePair<string, Guid> KeyPair { get { return new KeyValuePair<string, Guid>("ID", ID); } }
        [NotMapped]
        public string Key { get { return KeyPair.ToString(); } }

        private string _NewID;
        public string NewID { get { return _NewID; } set { _NewID = value; } }
        private Guid _ID;
        public Guid ID { get { return _ID; } set { _ID = value; } }

        private DateTime? _Ngay;
        public DateTime? Ngay { get { return _Ngay; } set { _Ngay = value; } }

        private string _SoVaoVien;
        public string SoVaoVien { get { return _SoVaoVien; } set { _SoVaoVien = value; } }

        private string _SoBH;
        public string SoBH { get { return _SoBH; } set { _SoBH = value; } }

        private string _SoBH2;
        public string SoBH2 { get { return _SoBH2; } set { _SoBH2 = value; } }

        private string _MaBN;
        public string MaBN { get { return _MaBN; } set { _MaBN = value; } }

        private string _DiaChiBHYT;
        public string DiaChiBHYT { get { return _DiaChiBHYT; } set { _DiaChiBHYT = value; } }

        private string _TrangThai;
        public string TrangThai { get { return _TrangThai; } set { _TrangThai = value; } }

        private DateTime? _NgayThanhToan;
        public DateTime? NgayThanhToan { get { return _NgayThanhToan; } set { _NgayThanhToan = value; } }

        private DateTime? _TuNgay;
        public DateTime? TuNgay { get { return _TuNgay; } set { _TuNgay = value; } }

        private DateTime? _DenNgay;
        public DateTime? DenNgay { get { return _DenNgay; } set { _DenNgay = value; } }

        private string _LoaiBH;
        public string LoaiBH { get { return _LoaiBH; } set { _LoaiBH = value; } }

        private string _NguoiDuyet;
        public string NguoiDuyet { get { return _NguoiDuyet; } set { _NguoiDuyet = value; } }

        private string _NoiDangKy;
        public string NoiDangKy { get { return _NoiDangKy; } set { _NoiDangKy = value; } }

        private double? _TiLeThanhToan;
        public double? TiLeThanhToan { get { return _TiLeThanhToan; } set { _TiLeThanhToan = value; } }

        private bool? _CapCuu;
        public bool? CapCuu { get { return _CapCuu; } set { _CapCuu = value; } }

        private bool? _DungTuyen;
        public bool? DungTuyen { get { return _DungTuyen; } set { _DungTuyen = value; } }

        private bool? _TraiTuyen;
        public bool? TraiTuyen { get { return _TraiTuyen; } set { _TraiTuyen = value; } }

        private bool? _CoGiayChuyenVien;
        public bool? CoGiayChuyenVien { get { return _CoGiayChuyenVien; } set { _CoGiayChuyenVien = value; } }

        private string _NoiChuyenDen;
        public string NoiChuyenDen { get { return _NoiChuyenDen; } set { _NoiChuyenDen = value; } }

        private string _ChanDoanNoiChuyenDen;
        public string ChanDoanNoiChuyenDen { get { return _ChanDoanNoiChuyenDen; } set { _ChanDoanNoiChuyenDen = value; } }

        private string _MaCSDL_BHYT;
        public string MaCSDL_BHYT { get { return _MaCSDL_BHYT; } set { _MaCSDL_BHYT = value; } }

        private string _MaNoiDKBD;
        public string MaNoiDKBD { get { return _MaNoiDKBD; } set { _MaNoiDKBD = value; } }

        private string _QRCode;
        public string QRCode { get { return _QRCode; } set { _QRCode = value; } }

        private double? _TiLeBT;
        public double? TiLeBT { get { return _TiLeBT; } set { _TiLeBT = value; } }

        private double? _TiLeDVCao;
        public double? TiLeDVCao { get { return _TiLeDVCao; } set { _TiLeDVCao = value; } }

        private double? _TiLeTraiTuyen;
        public double? TiLeTraiTuyen { get { return _TiLeTraiTuyen; } set { _TiLeTraiTuyen = value; } }

        private string _MaNoiSS;
        public string MaNoiSS { get { return _MaNoiSS; } set { _MaNoiSS = value; } }

        private Guid? _MaPTTonghop;
        public Guid? MaPTTonghop { get { return _MaPTTonghop; } set { _MaPTTonghop = value; } }

        private DateTime? _NgayTK;
        public DateTime? NgayTK { get { return _NgayTK; } set { _NgayTK = value; } }

        private int? _SoNgayTK;
        public int? SoNgayTK { get { return _SoNgayTK; } set { _SoNgayTK = value; } }

        private string _SoPhieu;
        public string SoPhieu { get { return _SoPhieu; } set { _SoPhieu = value; } }

        private DateTime? _TGDuyet;
        public DateTime? TGDuyet { get { return _TGDuyet; } set { _TGDuyet = value; } }
        private string _MaTNTT;
        public string MaTNTT { get { return _MaTNTT; } set { _MaTNTT = value; } }
        public BV_DuyetBHYTDTO(string _SoVaoVien, string _MaBN, string _SoHB,DateTime?_NgayThanhToan, double _TiLeThanhToan, bool _DungTuyen, string _MaNoiDKBD, DateTime? _TGDuyet)
        {
            this._SoVaoVien = SoVaoVien;
            this._MaBN = MaBN;
            this._SoBH = SoBH;
            this._NgayThanhToan = NgayThanhToan;
            this._TiLeThanhToan = TiLeThanhToan;
            this._DungTuyen = DungTuyen;
            this._MaNoiDKBD = MaNoiDKBD;
        }
        public BV_DuyetBHYTDTO(DataRow row)
        {
            SoVaoVien = row["SoVaoVien"].ToString();
            MaBN = row["MaBN"].ToString();
            SoBH = row["SoBH"].ToString();
            NgayThanhToan =(DateTime?) row["NgayThanhToan"];
            TiLeThanhToan =(double) row["TiLeThanhToan"];
            DungTuyen = (bool)row["DungTuyen"];
            MaNoiDKBD = row["MaNoiDKBD"].ToString();
            TGDuyet = (DateTime?)row["TGDuyet"];
        }
    }
    
}
