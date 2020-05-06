﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QLGV_HS_THPT.Model;

namespace QLGV_HS_THPT.View
{
    public partial class FormDangKy : Form
    {
        QLGV_HS_THPTEntities db = new QLGV_HS_THPTEntities();
        public FormDangKy()
        {
            InitializeComponent();
        }

        private void btDangKy_Click(object sender, EventArgs e)
        {
            try
            {
                if(MessageBox.Show("Bạn có muốn đăng ký tài khoản mới không?","Thông báo",MessageBoxButtons.YesNo)
                    == System.Windows.Forms.DialogResult.Yes)
                {
                    User resUser = db.Users.SingleOrDefault(x => x.UserName == textBoxUserName.Text);
                    if (resUser == null)
                    {
                        User newUser = TaoUser();
                        db.Users.Add(newUser);
                        db.SaveChanges();
                        MessageBox.Show("Chúc mừng bạn đã đăng ký thành công!", "Thông báo");
                        FormDangNhap DN = new FormDangNhap();
                        this.Hide();
                        DN.ShowDialog();
                        this.Close();
                    }
                    else MessageBox.Show("Tài khoản đã có người sử dụng!", "Thông báo");
                }    
            }
            catch(Exception ex) { MessageBox.Show("" + ex.Message, "Thông báo"); }
        }
        User TaoUser()
        {
            User newUser = new User()
            {
                Email = textBoxEmail.Text,
                UserName = textBoxUserName.Text,
                PassWords = textBoxPassWord.Text
            };
            return newUser;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}