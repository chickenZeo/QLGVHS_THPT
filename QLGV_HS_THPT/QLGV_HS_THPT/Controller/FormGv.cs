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
using QLGV_HS_THPT.View;

namespace QLGV_HS_THPT.Controller
{
    public partial class FormGv : Form
    {
        public FormGv()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ThemGiaoVien add = new ThemGiaoVien();
            this.Hide();
            add.ShowDialog();
            this.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            SuaGiaoVien add = new SuaGiaoVien();
            this.Hide();
            add.ShowDialog();
            this.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            XoaGiaoVien add = new XoaGiaoVien();
            this.Hide();
            add.ShowDialog();
            this.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
    
}
