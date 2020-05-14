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
    public partial class XoaGiaoVien : Form
    {
        QLGV_HS_THPTEntities db = new QLGV_HS_THPTEntities();
        public XoaGiaoVien()
        {
            InitializeComponent();
        }
        void HienThi(List<GiaoVien> dsGV)
        {
            listViewGiaoVien.Items.Clear();
            foreach (GiaoVien gv in dsGV)
            {
                ListViewItem item = new ListViewItem(gv.MaGV.ToString());
                item.SubItems.Add(gv.HoGV);
                item.SubItems.Add(gv.TenGV);
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

                listViewGiaoVien.Items.Add(item);
            }

        }

        private void XoaGiaoVien_Load(object sender, EventArgs e)
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
                listViewGiaoVien.Items.Add(item);
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

        private void listViewGiaoVien_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewGiaoVien.SelectedItems.Count > 0)
            {
                ListViewItem itemSelected = listViewGiaoVien.SelectedItems[0];
                txtMaGV.Text = itemSelected.SubItems[0].Text;
                txtHoGv.Text = itemSelected.SubItems[1].Text;
                txtTenGv.Text = itemSelected.SubItems[2].Text;
                txtquequan.Text = itemSelected.SubItems[5].Text;
                DTNgaySinh.Value = DateTime.Parse(itemSelected.SubItems[3].Text);
                cbBoxGtinh.Text = itemSelected.SubItems[4].Text;
                txtCMND.Text = itemSelected.SubItems[6].Text;
                txtluong.Text = itemSelected.SubItems[7].Text;
                cbBoxTT.Text = itemSelected.SubItems[8].Text;
                //cbBoxMaMH.SelectedValue = int.Parse(itemSelected.SubItems[9].ToString());


            }
        }

        private void button_Sua_Click(object sender, EventArgs e)
        {
            try
            {
                GiaoVien gv = db.GiaoViens.Find(int.Parse(txtMaGV.Text));
                db.GiaoViens.Remove(gv);
                db.SaveChanges();
                MessageBox.Show("Xóa Thành Công");
                XoaGiaoVien_Load(sender, e);
            }
            catch (Exception ex)
            { MessageBox.Show("" + ex.Message); }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
