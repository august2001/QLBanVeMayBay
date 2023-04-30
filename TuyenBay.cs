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
    public partial class TuyenBay : Form
    {
        public TuyenBay()
        {
            InitializeComponent();
        }

        private void bt_them_Click(object sender, EventArgs e)
        {
            int c1 = comboBoxSbdi.SelectedIndex;
            int c2 = comboBoxSbden.SelectedIndex;
            try
            {
                if (comboBoxSbdi.SelectedIndex.CompareTo(comboBoxSbden.SelectedIndex) == 0)
                {
                    MessageBox.Show("Sân bay đi và sân bay đến không được trùng");
                    return;
                }
                if (INSERT(txtMatuyenbay.Text, comboBoxSbdi.SelectedValue.ToString(), comboBoxSbden.SelectedValue.ToString()) != -1)
                {
                    dgvTuyenbay.DataSource = cn.ExecuteData("select * from TUYENBAY");
                    MessageBox.Show("Đã thêm thành công", "Thông báo");
                }
                else
                {
                    MessageBox.Show("Thêm thất bại", "Thông báo");
                }
                

            }
            catch (Exception d)
            {
                MessageBox.Show("Thêm thất bại \n" + d.Message, "Thông báo");
            }
        }

        private void bt_Xoa_Click(object sender, EventArgs e)
        {
            if (txtMatuyenbay.Text != "")
            {
                if (MessageBox.Show("Bạn muốn xóa tuyến bay: " + txtMatuyenbay.Text, "Cảnh báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    if (Delete(txtMatuyenbay.Text) != -1)
                    {
                        MessageBox.Show("Đã xóa tuyến bay thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        TuyenBay_Load(new object(), new EventArgs());
                    }
                    else
                    {
                        MessageBox.Show("Xóa tuyến bay thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
        }

        Connection cn = new Connection();
        private void TuyenBay_Load(object sender, EventArgs e)
        {
            comboBoxSbdi.DataSource = cn.ExecuteData("select * from sanbay");
            comboBoxSbdi.DisplayMember = "TenSanBay";
            comboBoxSbdi.ValueMember = "MaSanBay";
            comboBoxSbden.DataSource = cn.ExecuteData("select * from sanbay");
            comboBoxSbden.DisplayMember = "TenSanBay";
            comboBoxSbden.ValueMember = "MaSanBay";
            txtMatuyenbay.Text = "";
            dgvTuyenbay.DataSource = cn.ExecuteData("select * from TUYENBAY");
            comboBoxSbdi.SelectedIndex = 0;
            comboBoxSbden.SelectedIndex = 0;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtMatuyenbay.Text = comboBoxSbdi.SelectedValue + "-" + comboBoxSbden.SelectedValue;
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtMatuyenbay.Text = comboBoxSbdi.SelectedValue + "-" + comboBoxSbden.SelectedValue;
        }
        public int INSERT(string MATUYENBAY, string MASANBAYDI, string MASANBAYDEN)
        {
            if (MATUYENBAY == "")
                return -1;
            string sql = "INSERT INTO TUYENBAY(MATUYENBAY,MASANBAYDI,MASANBAYDEN) VALUES (N'" + MATUYENBAY + "',N'" + MASANBAYDI + "',N'" + MASANBAYDEN + "')";
            return cn.ExecuteNonQuery(sql);
        }

        public int Delete(string MATUYENBAY)
        {
            string sql = "DELETE FROM TUYENBAY WHERE [MATUYENBAY]=N'" + MATUYENBAY + "'";
            return cn.ExecuteNonQuery(sql);
        }

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            txtMatuyenbay.Text = dgvTuyenbay.CurrentRow.Cells["MATUYENBAY"].Value.ToString();
            comboBoxSbdi.SelectedValue = dgvTuyenbay.CurrentRow.Cells["MASANBAYDI"].Value.ToString();
            comboBoxSbden.SelectedValue = dgvTuyenbay.CurrentRow.Cells["MASANBAYDEN"].Value.ToString();
        }

        private void txt_1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
