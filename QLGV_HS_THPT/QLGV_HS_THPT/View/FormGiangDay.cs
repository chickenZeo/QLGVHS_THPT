using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLGV_HS_THPT.View
{
    public partial class FormGiangDay : Form
    {
        public FormGiangDay()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection("server = DESKTOP-1HGH8ER\\SQLEXPRESS;database = QLGV_HS_THPT; integrated security = SSPI");
        private void HienThi(string truyvan)
        {
            con.Open();
            SqlDataAdapter da = new SqlDataAdapter(truyvan, con); // lay du lieu vao da
            DataTable tb = new DataTable();
            da.Fill(tb); // do du lieu vao table
            dtgr.DataSource = tb; // do table len view
            con.Close();
        }
        private void FormGiangDay_Load(object sender, EventArgs e)
        {
            HienThi("select * from GiangDay");
        }

        private void dtgr_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_MaGV.Text = dtgr.CurrentRow.Cells[0].Value.ToString();
            txt_MaLop.Text = dtgr.CurrentRow.Cells[1].Value.ToString();
            dtime_NgayDay.Text = dtgr.CurrentRow.Cells[2].Value.ToString();

        }

        private void bt_Them_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cd = con.CreateCommand(); // Tu nguon cua sql tao 1 command
            cd.CommandText = "insert into GiangDay values('" + txt_MaGV.Text + "',N'" + txt_MaLop.Text + "','" + dtime_NgayDay.Text + "' )";
            cd.ExecuteNonQuery();
            con.Close();
            HienThi("select * from GiangDay");
        }

        private void bt_Sua_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cd = con.CreateCommand(); // Tu nguon cua sql tao 1 command
            cd.CommandText = "update GiangDay set MaLop= N'" + txt_MaLop.Text + "', NgayDay = '" + dtime_NgayDay.Text + "' where MaGV ='" + txt_MaGV.Text + "'";
            cd.ExecuteNonQuery();
            con.Close();
            HienThi("select * from GiangDay");
        }

        private void Bt_Xoa_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cd = con.CreateCommand();
            cd.CommandText = "delete from GiangDay where MaGV = '" + txt_MaGV.Text + "'";
            cd.ExecuteNonQuery();
            con.Close();
            HienThi("select * from GiangDay");
        }
    }
}

