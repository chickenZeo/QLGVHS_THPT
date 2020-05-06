using QLGV_HS_THPT.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLGV_HS_THPT.View
{
    public partial class TimKiemHocSinh : Form
    {
        QLGV_HS_THPTEntities db = new QLGV_HS_THPTEntities();
        public TimKiemHocSinh()
        {
            InitializeComponent();
        }
        void HienThi(List<HocSinh> dsHS)
        {
            listViewHocSinh.Items.Clear();
            foreach(HocSinh hs in dsHS)
            {
                ListViewItem item = new ListViewItem(hs.MaHS.ToString());
                item.SubItems.Add(hs.HoHS+ " "+ hs.TenHS);
                item.SubItems.Add(hs.NgaySinh.ToString());

                if (hs.GioiTinh == true) item.SubItems.Add("Nam");
                else item.SubItems.Add("Nữ");
                item.SubItems.Add(hs.QueQuan);

                if (hs.TrangThai==true) item.SubItems.Add("Đang đi học");
                else item.SubItems.Add("Đã nghỉ học hoặc ra trường");

                Lop lp = db.Lops.SingleOrDefault(x => x.MaLop == hs.MaLop);
                if (lp != null) item.SubItems.Add(lp.TenLop);
                else item.SubItems.Add("null");

                GiaoVien gv = db.GiaoViens.SingleOrDefault(x => x.MaGV == lp.MaGVCN);
                if (gv != null) item.SubItems.Add(gv.HoGV+ " "+ gv.TenGV);
                else item.SubItems.Add("null");
                listViewHocSinh.Items.Add(item);
            }
        }
        private void TimKiemHocSinh_Load(object sender, EventArgs e)
        {
            List<HocSinh> dsHS = db.HocSinhs.ToList();

            HienThi(dsHS);
        }

        private void textBox1_MouseClick(object sender, MouseEventArgs e)
        {
            textBox1.Text = "";
            TimKiemHocSinh_Load(sender, e);
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            string tenHS = textBox1.Text;
            if (tenHS == "")
            {
                HienThi(db.HocSinhs.ToList());
            }
            else
            {
                List<HocSinh> KetQua = db.HocSinhs.Where(x => x.TenHS.ToUpper().Contains(tenHS.ToUpper())).ToList();
                HienThi(KetQua);
            }
        }
    }
}
