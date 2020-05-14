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
    public partial class XoaTTHocSinh : Form
    {
        QLGV_HS_THPTEntities db = new QLGV_HS_THPTEntities();
        public XoaTTHocSinh()
        {
            InitializeComponent();
        }

        private void XoaTTHocSinh_Load(object sender, EventArgs e)
        {
            ListHocSinh.Items.Clear();
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

        private void ListHocSinh_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ListHocSinh.SelectedItems.Count > 0)
            {
                ListViewItem itemSelected = ListHocSinh.SelectedItems[0];
                lbMaHs.Text = itemSelected.SubItems[0].Text;
                TbHo.Text = itemSelected.SubItems[1].Text;
                TbTen.Text = itemSelected.SubItems[2].Text;
                DTNgaySinh.Value = DateTime.Parse(itemSelected.SubItems[3].Text);
                if (itemSelected.SubItems[4].Text == "True") RdNam.Checked = true;
                else RdNu.Checked = true;
                TbDiaChi.Text = itemSelected.SubItems[5].Text;
                if (itemSelected.SubItems[6].Text == "True") radioButton3.Checked = true;
                else radioButton1.Checked = true;
                CbBoxLop.SelectedValue = int.Parse(itemSelected.SubItems[7].Text);
            }
        }

        private void BTXoa_Click(object sender, EventArgs e)
        {
            try
            {
                HocSinh hs = db.HocSinhs.Find(int.Parse(lbMaHs.Text));
                db.HocSinhs.Remove(hs);
                db.SaveChanges();
                MessageBox.Show("Xóa Thành Công");
                XoaTTHocSinh_Load(sender, e);
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
