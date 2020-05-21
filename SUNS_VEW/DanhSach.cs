using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SUNS_VEW
{
  public partial  class DanhSach
    {
        public int STT { get; set; }
        public Nullable<int> AccountSend { get; set; }
        public Nullable<int> Conversation_ID { get; set; }
        public Nullable<System.DateTime> SendDate { get; set; }
        public Nullable<System.DateTime> ReadDate { get; set; }
        public string HoTen { get; set; }
        public int NamSinh { get; set; }
        public string TrangThai { get; set; }
    }
}
