using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SUNS_VEW.DTO
{
  public  class ScreenWaiting
    {
        public int  STT{ get; set; }
        public string MaBN { get; set; }
        public int NamSinh { get; set; }
        public string TenBN { get; set; }
        public decimal TongTien { get; set; }
        public bool IsBHYT { get; set; }
        public string SoVaoVien { get; set; }
    }
}
