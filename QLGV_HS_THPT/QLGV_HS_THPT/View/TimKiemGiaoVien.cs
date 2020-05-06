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
    public partial class TimKiemGiaoVien : Form
    {
        QLGV_HS_THPTEntities db = new QLGV_HS_THPTEntities();
        public TimKiemGiaoVien()
        {
            InitializeComponent();
        }
        void HienThi(List<GiaoVien> dsGV)
        {
            listViewGiaoVien.Items.Clear();
            foreach(GiaoVien gv in dsGV)
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
                if(mh!=null) item.SubItems.Add(mh.TenMH);
                else item.SubItems.Add("null");

                listViewGiaoVien.Items.Add(item);
            }
        }
        private void TimKiemGiaoVien_Load(object sender, EventArgs e)
        {
            List<GiaoVien> dsGV = db.GiaoViens.ToList();
            HienThi(dsGV);
        }

        private void textBox1_MouseClick(object sender, MouseEventArgs e)
        {
            textBox1.Text = "";
            TimKiemGiaoVien_Load(sender, e);
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            string tenGV = textBox1.Text;
            if (tenGV == "")
            {
                HienThi(db.GiaoViens.ToList());
            }
            else
            {
                List<GiaoVien> KetQua = db.GiaoViens.Where(x => x.TenGV.ToUpper().Contains(tenGV.ToUpper())).ToList();
                HienThi(KetQua);
            }
        }
    }
}
