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
using QLGV_HS_THPT.Model;
using QLGV_HS_THPT.Controller;
using System.Data.SqlTypes;

namespace QLGV_HS_THPT.View
{
    public partial class ThemGiaoVien : Form
    {
        QLGV_HS_THPTEntities db = new QLGV_HS_THPTEntities();
        public ThemGiaoVien()
        {
            InitializeComponent();
        }
        void HienThi(List<GiaoVien> dsGV)
        {
            listGiaoVien.Items.Clear();
            foreach (GiaoVien gv in dsGV)
            {
                ListViewItem item = new ListViewItem(gv.MaGV.ToString());
                item.SubItems.Add(gv.HoGV + " " + gv.TenGV);
                item.SubItems.Add(gv.NgaySinh.ToString());
                if (gv.GioiTinh == true) item.SubItems.Add("Nam");
                else item.SubItems.Add("Nữ");

                item.SubItems.Add(gv.QueQuan);
                item.SubItems.Add(gv.CMND.ToString());
                item.SubItems.Add(gv.Luong.ToString());

                if (gv.TrangThai == true) item.SubItems.Add("Đang đi dạy");
                else item.SubItems.Add("Đã nghỉ dạy");

                MonHoc mh = db.MonHocs.SingleOrDefault(x => x.MaMH == gv.MaMH);
                if (mh != null) item.SubItems.Add(mh.TenMH);
                else item.SubItems.Add("null");

                listGiaoVien.Items.Add(item);
            }

        }

        private void ThemGiaoVien_Load(object sender, EventArgs e)
        {
            List<GiaoVien> dsGV = db.GiaoViens.ToList();
            foreach (GiaoVien gv in dsGV)
            {
                ListViewItem item = new ListViewItem(gv.MaGV.ToString());
                item.SubItems.Add(gv.TenGV);
                item.SubItems.Add(gv.HoGV);
                item.SubItems.Add(gv.QueQuan);
                item.SubItems.Add(gv.NgaySinh.ToString());
                item.SubItems.Add(gv.GioiTinh.ToString());
                item.SubItems.Add(gv.CMND.ToString());
                item.SubItems.Add(gv.Luong.ToString());
                item.SubItems.Add(gv.TrangThai.ToString());
                item.SubItems.Add(gv.MaMH.ToString());
                listGiaoVien.Items.Add(item);
            }
            cbBoxMaMH.DataSource = db.MonHocs.ToList();
            cbBoxMaMH.DisplayMember = "TenMH";
            cbBoxMaMH.ValueMember = "MaMH";
            HienThi(dsGV);
        }
        Boolean ktraTrueFalse(string str)
        {
            if (str == "Nam") return true;
            else return false;
        }
        Boolean ktraTrueFalse1(string a)
        {
            if (a == "Đang đi dạy") return true;
            else return false;
        }

        private void button_Them_Click(object sender, EventArgs e)
        {

            try
            {
                GiaoVien gv = new GiaoVien()
                {
                    HoGV = txtHoGv.Text,
                    TenGV = txtTenGv.Text,
                    QueQuan = txtquequan.Text,
                    NgaySinh = dateTimePicker1.Value,
                    GioiTinh = ktraTrueFalse(cbBoxGtinh.Text),
                    CMND = int.Parse(txtCMND.Text),
                    Luong = int.Parse(txtluong.Text),
                    TrangThai = ktraTrueFalse1(cbBoxTT.Text),
                    MaMH = int.Parse(cbBoxMaMH.SelectedValue.ToString())
                };
                db.GiaoViens.Add(gv);
                db.SaveChanges();
                MessageBox.Show("them thanh cong");
                ThemGiaoVien_Load(sender, e);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Them That bai. Chi tiet loi: " + ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
