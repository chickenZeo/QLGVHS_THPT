using System;
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
    public partial class ThemTTHocSinh : Form
    {
        QLGV_HS_THPTEntities db = new QLGV_HS_THPTEntities();
        public ThemTTHocSinh()
        {
            InitializeComponent();
        }

        private void ThemTTHocSinh_Load(object sender, EventArgs e)
        {
            List<HocSinh> dsHocSinh = db.HocSinhs.ToList();
            foreach (HocSinh hs in dsHocSinh)
            {
                ListViewItem item = new ListViewItem(hs.MaHS.ToString());
                item.SubItems.Add(hs.HoHS);
                item.SubItems.Add(hs.TenHS);
                item.SubItems.Add(hs.NgaySinh.ToString());
                item.SubItems.Add(hs.GioiTinh.ToString());
                item.SubItems.Add(hs.QueQuan);
                item.SubItems.Add(hs.TrangThai.ToString());
                item.SubItems.Add(hs.MaLop.ToString());
                ListHocSinh.Items.Add(item);
            }
            CbBoxLop.DataSource = db.Lops.ToList();
            CbBoxLop.DisplayMember = "TenLop";
            CbBoxLop.ValueMember = "MaLop";
        }
        Boolean CheckGioiTinh(Panel PnGt)
        {
            foreach (RadioButton rad in PnGt.Controls)
            {
                if (rad.Checked == true)
                {
                    if (rad.Text == "Nam")
                        return true;
                    else return false;
                }

            }
            return false;
        }
        Boolean CheckTrangThai(Panel PnTt)
        {
            foreach (RadioButton rad in PnTt.Controls)
            {
                if (rad.Checked == true)
                {
                    if (rad.Text == "Đi Học")
                        return true;
                    else return false;
                }

            }
            return false;
        }

        private void BTThemNV_Click(object sender, EventArgs e)
        {
            try
            {
                HocSinh hs = new HocSinh()
                {
                    HoHS = TbHo.Text,
                    TenHS = TbTen.Text,
                    NgaySinh = DTNgaySinh.Value,
                    GioiTinh = CheckGioiTinh(PnGt),
                    QueQuan = TbDiaChi.Text,
                    TrangThai = CheckTrangThai(PnTt),
                    MaLop = int.Parse(CbBoxLop.SelectedValue.ToString()),
                };
                db.HocSinhs.Add(hs);
                db.SaveChanges();
                MessageBox.Show("Them thanh cong");
                ListViewItem newItem = new ListViewItem(hs.MaHS.ToString());
                newItem.SubItems.Add(hs.HoHS);
                newItem.SubItems.Add(hs.TenHS);
                newItem.SubItems.Add(hs.NgaySinh.ToString());
                newItem.SubItems.Add(hs.GioiTinh.ToString());
                newItem.SubItems.Add(hs.QueQuan);
                newItem.SubItems.Add(hs.TrangThai.ToString());
                newItem.SubItems.Add(hs.MaLop.ToString());
                ListHocSinh.Items.Add(newItem);
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
