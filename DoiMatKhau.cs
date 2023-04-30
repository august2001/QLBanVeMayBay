using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace QLBANVEMAYBAY
{
    public partial class DoiMatKhau : Form
    {
        public DoiMatKhau()
        {
            InitializeComponent();
        }

        public string manv;
        public string tennv;

        Connection cn = new Connection();
        private int doiMatKhau(string matkhaumoi)
        {
            string sqlktmk = "select matkhau from NHANVIEN where manv='" + this.manv + "'";
            DataTable dt = cn.ExecuteData(sqlktmk);
            if (dt.Rows.Count > 0)
            {
                if (dt.Rows[0][0].ToString().Trim() == txtMkcu.Text.Trim())
                {
                    string sql = "update NHANVIEN set matkhau ='" + matkhaumoi + "' where manv='" + this.manv + "'";
                    return cn.ExecuteNonQuery(sql);
                }
                else
                {
                    return -1;
                }
            }
            else
            {
                return -1;
            }
        }


        private void DoiMatKhau_Load(object sender, EventArgs e)
        {
            txtUser.Text = manv;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtMkcu.Text.Trim() == txtMkmoi.Text.Trim())
            {
                MessageBox.Show("Mật khẩu không được trùng");
                return;
            }

            if (txtXnmkmoi.Text.Trim() != txtMkmoi.Text.Trim())
            {
                MessageBox.Show("Xác nhận mật khẩu sai");
                return;
            }

            if (doiMatKhau(txtMkmoi.Text.Trim()) != -1)
            {
                MessageBox.Show("Đổi mật khẩu thành công");
                this.Close();
            }
            else
            {
                MessageBox.Show("Đổi mật khẩu thất bại");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
