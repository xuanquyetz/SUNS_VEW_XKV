using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SUNS_VEW
{
    public partial class VEWBSKHAM : Form
    {
        public VEWBSKHAM()
        {
            InitializeComponent();
            FullScreen();
        }
        private void FullScreen()
        {
            FormBorderStyle = FormBorderStyle.None;
            WindowState = FormWindowState.Maximized;
            TopMost = true;
        }
        private void VEWBSKHAM_Load(object sender, EventArgs e)
        {

        }

        private void VEWBSKHAM_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                //MessageBox.Show("show ok");
                FormBorderStyle = FormBorderStyle.Sizable;
                WindowState = FormWindowState.Normal;
                TopMost = false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 pp = new Form1();
            this.Visible = false;
            pp.ShowDialog();
        }
    }
}
