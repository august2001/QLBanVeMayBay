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


namespace QLBANVEMAYBAY
{
    public partial class DoanhThu : Form
    {
        Connection lopchung = new Connection();
     
        public DoanhThu()
        {
            InitializeComponent();   
       
        }

        private void btnTimTheoKhoangtg_Click(object sender, EventArgs e)
        {
            lopchung.connection().Open();
            string sql = "SELECT * FROM DATCHO WHERE 1=1";
            if ((dtpTgiantruoc.Text != "") && (dtpTgiansau.Text != ""))
            {
                sql = sql + " AND NGAYDAT >= '" + dtpTgiantruoc.Text + "' AND NGAYDAT <= '" + dtpTgiansau.Text + "'";
            }
            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter(sql, lopchung.connection());
            da.Fill(ds);
            lopchung.connection().Close();
            dgvThongke.DataSource = ds.Tables[0];
            dgvThongke.Refresh();
        }

        private void btn_load_Click(object sender, EventArgs e)
        {
            string sql = "select * from DATCHO";
            dgvThongke.DataSource = lopchung.ExecuteData(sql);
        }
        private void btn_tinhtong_Click(object sender, EventArgs e)
        {

            int sc = dgvThongke.Rows.Count;
            Double thanhtien = 0;
            for (int i = 0; i < sc - 1; i++)
                thanhtien += float.Parse(dgvThongke.Rows[i].Cells["GIATIEN"].Value.ToString());
            txtTong.Text = thanhtien.ToString();
        }

        private void frm_thongke_Load(object sender, EventArgs e)
        {

        }
    }
}
