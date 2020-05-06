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
    public partial class TimKiemLichGiangDay : Form
    {
        QLGV_HS_THPTEntities db = new QLGV_HS_THPTEntities();
        public TimKiemLichGiangDay()
        {
            InitializeComponent();
        }
        void HienThi(List<GiangDay> dsGD)
        {
            listViewLich.Items.Clear();
            foreach(GiangDay gd in dsGD)
            {
                
                GiaoVien gv = db.GiaoViens.SingleOrDefault(x => x.MaGV == gd.MaGV);
                ListViewItem item = new ListViewItem(gv.HoGV + " " + gv.TenGV);

                MonHoc mh= db.MonHocs.SingleOrDefault(x => x.MaMH == gv.MaMH);
                item.SubItems.Add(mh.TenMH);

                Lop lp = db.Lops.SingleOrDefault(x => x.MaLop == gd.MaLop);
                item.SubItems.Add(lp.TenLop);

                item.SubItems.Add(gd.NgayDay);

                listViewLich.Items.Add(item);
            }    
        }
        private void TimKiemLichGiangDay_Load(object sender, EventArgs e)
        {
            List<GiangDay> dsGD = db.GiangDays.ToList();
            HienThi(dsGD);
        }

        private void textBox1_MouseClick(object sender, MouseEventArgs e)
        {
            textBox1.Text = "";
            TimKiemLichGiangDay_Load(sender, e);
        }


        private void btTimKiem_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                HienThi(db.GiangDays.ToList());
            }
            else
            {
                GiaoVien gv = db.GiaoViens.SingleOrDefault(x => x.TenGV == textBox1.Text);
                if(gv!=null)
                {
                    List<GiangDay> dsGD = db.GiangDays.Where(x => x.MaGV == gv.MaGV).ToList();
                    HienThi(dsGD);
                }
                else
                {
                    MessageBox.Show("Không tìm thấy", "Thông báo");
                    TimKiemLichGiangDay_Load(sender, e);
                }
            }
        }
    }
}
