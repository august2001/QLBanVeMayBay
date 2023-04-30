using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace QLBANVEMAYBAY
{
    public partial class DatCho : Form
    {
        public DatCho()
        {
            InitializeComponent();
        }
        Connection cn = new Connection();
        private void DatCho_Load(object sender, EventArgs e)
        {         
            cbMachuyenbay.DataSource = cn.ExecuteData("select * from CCHUYENBAY ");
            cbMachuyenbay.ValueMember = "MACHUYENBAY";
            cbMachuyenbay.DisplayMember = "MACHUYENBAY";

            cbMakhachhang.DataSource = cn.ExecuteData("select * from KKHACHHANG ");
            cbMakhachhang.ValueMember = "MAKH";
            cbMakhachhang.DisplayMember = "MAKH";

            cbMatuyenbay.DataSource = cn.ExecuteData("select * from TUYENBAY ");
            cbMatuyenbay.ValueMember = "MATUYENBAY";
            cbMatuyenbay.DisplayMember = "MATUYENBAY";

            cbHangve.DataSource = cn.ExecuteData("select * from HANGVE ");
            cbHangve.ValueMember = "mahangve";
            cbHangve.DisplayMember = "tenhangve";

     
            dgvPhieudat.DataSource = cn.ExecuteData("select * from DATCHO");
        }     
        public DataTable SelectAll()
        {
            return cn.ExecuteData("select * from CCHUYENBAY");
        }

        public int INSERT(string MAPHIEU, string MAKH, string MACHUYENBAY,string MATUYENBAY, string MAHANGVE, int SOGHEDAT, DateTime NGAYDAT, int GIATIEN)
        {
            string sql = "INSERT INTO DATCHO(MAPHIEU,MAKH,MACHUYENBAY,MATUYENBAY,MAHANGVE,SOGHEDAT,NGAYDAT,GIATIEN) VALUES (N'" + MAPHIEU + "',N'" + MAKH + "',N'" + MACHUYENBAY + "',N'" + MATUYENBAY + "',N'" + MAHANGVE + "',N'" + SOGHEDAT + "',N'" + NGAYDAT.ToString("MM/dd/ yyyy") + "',N'" + GIATIEN + "')";
            return cn.ExecuteNonQuery(sql);
        }
        public int UPDATE(string MAPHIEU, string MAKH, string MACHUYENBAY, string MATUYENBAY, string MAHANGVE, int SOGHEDAT, DateTime NGAYDAT, int GIATIEN)
        {
            string sql = "UPDATE DATCHO SET  MAKH=N'" + MAKH + "', MACHUYENBAY=N'" + MACHUYENBAY + "', MATUYENBAY=N'" + MATUYENBAY + "', MAHANGVE=N'" + MAHANGVE + "', SOGHEDAT=N'" + SOGHEDAT + "', NGAYDAT=N'" + NGAYDAT.ToString("MM/dd/ yyyy") + "', GIATIEN=N'" + GIATIEN + "' WHERE MAPHIEU=N'" + MAPHIEU + "'";
            return cn.ExecuteNonQuery(sql);
        }
        public int Delete(string MAPHIEU)
        {
            string sql = "DELETE FROM DATCHO WHERE [MAPHIEU]=N'" + MAPHIEU + "'";
            return cn.ExecuteNonQuery(sql);
        }

        private void bnt_luu_Click(object sender, EventArgs e)
        {
            if (INSERT(txtMaphieu.Text, cbMachuyenbay.Text, cbMakhachhang.Text,cbMatuyenbay.Text, cbHangve.Text, int.Parse(txtSoghedat.Text), dtpNgaydat.Value, int.Parse(txtThanhtien.Text)) != -1)
            {
                MessageBox.Show("Đã thêm phiếu đặt chỗ thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                DatCho_Load(new object(), new EventArgs());
            }
            else
            {
                MessageBox.Show("Thêm phiếu đặt chỗ thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }          
        private void bnt_capnhat_Click(object sender, EventArgs e)
        {
            if (UPDATE(txtMaphieu.Text, cbMachuyenbay.Text, cbMakhachhang.Text, cbMatuyenbay.Text, cbHangve.Text, int.Parse(txtSoghedat.Text), dtpNgaydat.Value, int.Parse(txtThanhtien.Text)) != -1)
            {
                MessageBox.Show("Đã cập nhật phiếu thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
               DatCho_Load(new object(), new EventArgs());
            }
            else
            {
                MessageBox.Show("Cập nhật phiếu thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void bnt_thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bnt_xoa_Click(object sender, EventArgs e)
        {
            if (txtMaphieu.Text != "")
            {
                if (MessageBox.Show("Bạn muốn xóa phiếu: " + txtMaphieu.Text, "Cảnh báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    if (Delete(txtMaphieu.Text) != -1)
                    {
                        MessageBox.Show("Đã xóa phiếu thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        DatCho_Load(new object(), new EventArgs());
                    }
                    else
                    {
                        MessageBox.Show("Xóa phiếu thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SanBay sb = new SanBay();
            sb.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            TuyenBay tb = new TuyenBay();
            tb.ShowDialog();
        }

        private void txt4_TextChanged(object sender, EventArgs e)
        {
            double sl, gn, tt;
            if (txtGiatien.Text == "")
                gn = 0;
            else
                gn = Convert.ToDouble(txtGiatien.Text);
            if (txtSoghedat.Text == "")
                sl = 0;
            else
                sl = Convert.ToDouble(txtSoghedat.Text);
            tt = gn * sl;
            txtThanhtien.Text = tt.ToString();
        }
        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                txtMaphieu.Text = dgvPhieudat.CurrentRow.Cells[0].Value.ToString();
                cbMachuyenbay.Text = dgvPhieudat.CurrentRow.Cells[1].Value.ToString();
                cbMakhachhang.Text = dgvPhieudat.CurrentRow.Cells[2].Value.ToString();
                cbMatuyenbay.Text = dgvPhieudat.CurrentRow.Cells[3].Value.ToString();
                cbHangve.Text = dgvPhieudat.CurrentRow.Cells[4].Value.ToString();
                dtpNgaydat.Text = dgvPhieudat.CurrentRow.Cells[6].Value.ToString();
                txtSoghedat.Text = dgvPhieudat.CurrentRow.Cells[5].Value.ToString();
                txtThanhtien.Text = dgvPhieudat.CurrentRow.Cells[7].Value.ToString();
              
            }
            catch { }
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {         
              
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
