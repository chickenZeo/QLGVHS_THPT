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
    public partial class FormStudent : Form
    {
        public FormStudent()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ThemTTHocSinh add = new ThemTTHocSinh();
            this.Hide();
            add.ShowDialog();
            this.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            SuaTTHocSinh repair = new SuaTTHocSinh();
            this.Hide();
            repair.ShowDialog();
            this.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            XoaTTHocSinh delete = new XoaTTHocSinh();
            this.Hide();
            delete.ShowDialog();
            this.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
