using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using DevExpress.UserSkins;
using DevExpress.Skins;
using DevExpress.LookAndFeel;
using static SUNS_VEW.Form1;

namespace SUNS_VEW
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
      
        static void Main()
        {
            ReadConnect2();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            BonusSkins.Register();
            SkinManager.EnableFormSkins();
            UserLookAndFeel.Default.SetSkinStyle("DevExpress Style");

            if (BienToanCuc.hienthiDsKham == "true" || BienToanCuc.hienThiDsCLS == "true" || BienToanCuc.HienThiCapThuoc == "true" || BienToanCuc.HienThiThuNgan == "true")
            {
                Application.Run(new Form1());
            }
            else
            {
                Application.Run(new CauHinhPK());
            }
            //Application.Run(new LaySoTT());
        }
    }
}
