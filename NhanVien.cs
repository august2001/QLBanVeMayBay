using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace QLBANVEMAYBAY
{
    public partial class NhanVien : Form
    {
        public NhanVien()
        {
            InitializeComponent();
        }

        Connection ketnoi = new Connection();
        public int INSERT(string MANV, string TENNV, string DIENTHOAI, string DIACHI, string MATKHAU)
        {
            string sql = "INSERT INTO NHANVIEN(manv,tennv,dienthoai,diachi,matkhau) VALUES (N'" + MANV + "',N'" + TENNV + "',N'" + DIENTHOAI + "',N'" + DIACHI + "',N'" + MATKHAU + "')";

            return ketnoi.ExecuteNonQuery(sql);
        }
        public int UPDATE(string MANV, string TENNV, string DIENTHOAI, string DIACHI)
        {
            string sql = "UPDATE NHANVIEN SET tennv=N'" + TENNV + "', dienthoai=N'" + DIENTHOAI + "', diachi=N'" + DIACHI + "' WHERE manv=N'" + MANV + "'";
            return ketnoi.ExecuteNonQuery(sql);
        }
        public int Delete(string MANV)
        {
            string sql = "DELETE FROM NHANVIEN WHERE manv=N'" + MANV + "'";
            return ketnoi.ExecuteNonQuery(sql);
        }
        private void NhanVien_Load(object sender, EventArgs e)
        {
            string sql = "select * from NHANVIEN";
            dgvNhanvien.DataSource = ketnoi.ExecuteData(sql);
        }
        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try  
            {
                txtManv.Text = dgvNhanvien.CurrentRow.Cells[0].Value.ToString(); 
                txtTennv.Text = dgvNhanvien.CurrentRow.Cells["TENNV"].Value.ToString();
                txtDienthoai.Text = dgvNhanvien.CurrentRow.Cells["DIENTHOAI"].Value.ToString();
                txtDiachi.Text = dgvNhanvien.CurrentRow.Cells["Diachi"].Value.ToString();
            }
            catch (Exception j) { MessageBox.Show(j.Message); }
        }

        private void bt_luu_Click(object sender, EventArgs e)
        {
            if (INSERT(txtManv.Text, txtTennv.Text, txtDienthoai.Text, txtDiachi.Text, "123456789") != -1)
            {
                MessageBox.Show("Đã thêm nhân viên thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                NhanVien_Load(new object(), new EventArgs());
            }
            else
            {
                MessageBox.Show("Thêm nhân viên thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void bt_capnhat_Click(object sender, EventArgs e)
        {
            if (UPDATE(txtManv.Text, txtTennv.Text, txtDienthoai.Text, txtDiachi.Text) != -1)
            {
                MessageBox.Show("Đã cập nhật nhân viên thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                NhanVien_Load(new object(), new EventArgs());
            }
            else
            {
                MessageBox.Show("Cập nhật nhân viên thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void bt_themmoi_Click(object sender, EventArgs e)
        {
            txtTennv.Clear();
            txtDiachi.Clear();
            txtManv.Clear();
            txtDienthoai.Clear();        }

        private void btxoa_Click(object sender, EventArgs e)
        {
            if (txtManv.Text != "")
            {
                if (MessageBox.Show("Bạn muốn xóa nhân viên: " + txtTennv.Text, "Cảnh báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    if (Delete(txtManv.Text) != -1)
                    {
                        MessageBox.Show("Đã xóa nhân viên thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        NhanVien_Load(new object(), new EventArgs());
                    }
                    else
                    {
                        MessageBox.Show("Xóa nhân viên thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btxoa_Click_1(object sender, EventArgs e)
        {

        }

        private void bt_capnhat_Click_1(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter_1(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
