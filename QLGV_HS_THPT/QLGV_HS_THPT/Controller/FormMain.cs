using QLGV_HS_THPT.View;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLGV_HS_THPT.Controller
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void toolStripTextBox1_Click(object sender, EventArgs e)
        {

        }

        private void đăngNhậpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormDangNhap DN = new FormDangNhap();
            this.Hide();
            DN.ShowDialog();
            this.Show();
        }

        private void đăngKýToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormDangKy Dk = new FormDangKy();
            this.Hide();
            Dk.ShowDialog();
            this.Show();
        }

        private void tìmKiếmGiáoViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TimKiemGiaoVien Dk = new TimKiemGiaoVien();
            this.Hide();
            Dk.ShowDialog();
            this.Show();
        }

        private void tìmKiếmHọcSinhToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TimKiemHocSinh Dk = new TimKiemHocSinh();
            this.Hide();
            Dk.ShowDialog();
            this.Show();
        }
    }
}
