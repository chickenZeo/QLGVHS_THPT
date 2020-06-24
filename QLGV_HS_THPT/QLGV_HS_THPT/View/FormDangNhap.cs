using QLGV_HS_THPT.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using QLGV_HS_THPT.Controller;

namespace QLGV_HS_THPT.View
{
    public partial class FormDangNhap : Form
    {
        QLGV_HS_THPTEntities db = new QLGV_HS_THPTEntities();
        public FormDangNhap()
        {
            InitializeComponent();
            textBoxPassWord.PasswordChar = '*';
        }

        private void labelDangKy_Click(object sender, EventArgs e)
        {
            FormDangKy Dk = new FormDangKy();
            this.Hide();
            Dk.ShowDialog();
            this.Show();
        }

       

        private void btDangNhap_Click(object sender, EventArgs e)
        {
            try
            {
                User resUser = db.Users.SingleOrDefault(x => x.UserName == textBoxUserName.Text
                    && x.PassWords == textBoxPassWord.Text);
                if (resUser != null)
                {
                    FormMain fm = new FormMain();
                    this.Hide();
                    fm.ShowDialog();
                    this.Close();
                }


            }
            catch (Exception ex) { MessageBox.Show("" + ex.Message); }
        }
    }
}
