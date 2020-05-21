using DevExpress.XtraEditors;
using SUNS_VEW.DAO;
using SUNS_VEW.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SUNS_VEW
{
    public partial class LaySoTT : Form
    {
        public LaySoTT()
        {
            InitializeComponent();
            LoadListSTTToday();
        }
        public static void LoadListSTTToday()
        {
            List<HT_LaySTTDTO> listSTT = HT_LaySTTDAO.Instance.ListHT_LaySTT();
            var CountList = listSTT.Count();
            if (CountList <= 0)
            {
                BienTC.starNumBer = 0;
            }
            else
            {
                var TGMax = listSTT.Max(q => q.SoTT);
                BienTC.starNumBer = TGMax;
            }
            
           // if()
        }
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void LaySoTT_Load(object sender, EventArgs e)
        {
            lbStt1.Text = BienTC.starNumBer.ToString("0000");
        }
       
        public class BienTC
        {
           public static int starNumBer ;
        }
        
        private void btBam1_Click(object sender, EventArgs e)
        {
            DateTime? Ngay = DateTime.Today;
            DateTime? ThoiGian = DateTime.Now;
            int nowNumber =BienTC.starNumBer += 1;
            lbStt1.Text = nowNumber.ToString("0000");
            int UuTien = 0;
            HT_LaySTTDAO.Instance.InsertSTT(Ngay, nowNumber, ThoiGian, UuTien);
            
            //XtraMessageBox.Show("Xin Cảm Ơn", "LẤY SỐ THÀNH CÔNG", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }
    }
}
