using DevExpress.XtraEditors;
using SUNS_VEW.DAO;
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
using static SUNS_VEW.Form1;

namespace SUNS_VEW
{
    public partial class CauHinhPK : Form
    {
        public CauHinhPK()
        {
            InitializeComponent();
            LoadKhoaCLS();
            LoadPhongKham();
            HienThiCauHinh();
        }
        public void HienThiCauHinh()
        {
            txtTenPhongKham.Text = BienToanCuc.TenPhongKham;
            txtSDT.Text = BienToanCuc.SoDT;
        }
        private void LoadPhongKham()
        {
            cbPhongKham.DataSource = VewKhamBenhDAO.Instance.LoadPhongKham();
            cbPhongKham.DisplayMember = "Ma";
            cbPhongKham.ValueMember = "Ma";
        }
        private void LoadKhoaCLS()
        {
            cbKhoaCLS.DataSource = VewKhamBenhDAO.Instance.LoadKhoaCLS();
            cbKhoaCLS.DisplayMember = "Ten";
            cbKhoaCLS.ValueMember = "Ma";
        }
        private void InsertConfig()
        {
            string path = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetEntryAssembly().Location);

            if (!Directory.Exists(path + @"\log"))
            {
                Directory.CreateDirectory(path + @"\log");
            }
            FileStream stream = new FileStream(Path.Combine(path,"log\\config.txt"), FileMode.Create);

            StreamWriter writer = new StreamWriter(stream, Encoding.Unicode);
            // writer.Write("[");
            writer.Write(cbPhongKham.Text);
            writer.Write("\t");
            //writer.Write(cbKhoaCLS.Text);
            //writer.Write("\t");
            if (rdKhamBenh.Checked == true)
            {
                writer.Write("true");
            }
            else { writer.Write("false"); }
            //writer.Write(rdKhamBenh.Text);
            writer.Write("\t");
            if (rdCLS.Checked == true)
            {
                writer.Write("true");
            }
            else { writer.Write("false"); }
            writer.Write("\t");
            if (CheckAll.Checked == true)
            {
                writer.Write("Checked");
            }
            else { writer.Write("Unchecked"); }
            writer.Write("\t");
            if (rdChoThuNgan.Checked == true) { writer.Write("true"); } else { writer.Write("false"); }
            writer.Write("\t");
            writer.Write(cbLoaiPhieuThu.Text);
            writer.Write("\t");
            if (rdChoCapThuoc.Checked == true) { writer.Write("true"); } else { writer.Write("false"); }
            writer.Write("\t");
            writer.Write(cbLoaiThuoc.Text);
            writer.Write("\t");
            writer.Write(txtTenPhongKham.Text);
            writer.Write("\t");
            writer.Write(txtSDT.Text);
            writer.Write("\t");
            writer.Write(nbDelay.Value);
            //writer.Write("]");
            writer.Close();
            stream.Close();
            if (txtKhoaCLS.Text == "")
            {
                XtraMessageBox.Show("Nhóm CLS không được để trống và không được lớn hơn 4 nhóm", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            //CLS
            FileStream streamCLS = new FileStream(Path.Combine(path, "log\\configCLS.txt"), FileMode.Create);
            StreamWriter writerCLS = new StreamWriter(streamCLS, Encoding.Unicode);
            writerCLS.Write(txtKhoaCLS.Text);
            writerCLS.Write("\t");
            if (rdCLS.Checked == true)
            {
                writerCLS.Write(rdCLS.Text = "true");
            }
            else { writerCLS.Write(rdCLS.Text = "false"); }
           
            writerCLS.Close();
            streamCLS.Close();
            XtraMessageBox.Show("Lưu thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void bntLuu_Click(object sender, EventArgs e)
        {
            InsertConfig();
     }

        private void CauHinhPK_Load(object sender, EventArgs e)
        {

        }

        private void rdCLS_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void cbPhongKham_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
