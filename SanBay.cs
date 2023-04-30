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
    public partial class SanBay : Form
    {
        public SanBay()
        {
            InitializeComponent();
        }

        Connection cn = new Connection();

        private void bt_them_Click(object sender, EventArgs e)
        {
            if (txtMasanbay.Text != "" && txtTensanbay.Text != "")
            {
                INSERT(txtMasanbay.Text, txtTensanbay.Text);
            }
            
            dgvSanbay.DataSource = SelectAll();
            txtMasanbay.Clear();
            txtTensanbay.Clear();
            
           
        }
        public void INSERT(string MASANBAY, string TENSANBAY)
        {
            string sql = "INSERT INTO SANBAY(MASANBAY,TENSANBAY) VALUES (N'" + MASANBAY + "',N'" + TENSANBAY + "')";
            cn.ExecuteNonQuery(sql);
        }
        public void UPDATE(string MASANBAY, string TENSANBAY)
        {
            this.cn.KetNoi();
            string sql = "UPDATE SANBAY SET [MASANBAY]=N'" + MASANBAY + "',[TENSANBAY]=N'" + TENSANBAY + "' WHERE [MASANBAY]=N'" + MASANBAY + "'";
            cn.ExecuteNonQuery(sql);
        }
        public void Delete(string MASANBAY)
        {
            this.cn.KetNoi();
            string sql = "DELETE FROM SANBAY WHERE [MASANBAY]=N'" + MASANBAY + "'";
            cn.ExecuteNonQuery(sql);
        }

        public DataTable SelectAll()
        {
            return cn.ExecuteData("select * from SANBAY");
        }

        private void frm_ThemSanBay_Load(object sender, EventArgs e)
        {
            dgvSanbay.DataSource = SelectAll();
        }

        private void bt_capnhat_Click(object sender, EventArgs e)
        {
            if (txtMasanbay.Text != "" && txtTensanbay.Text != "")

                UPDATE(txtMasanbay.Text, txtTensanbay.Text);
            dgvSanbay.DataSource = SelectAll();
        }

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            txtMasanbay.Text = dgvSanbay.CurrentRow.Cells[0].Value.ToString();
            txtTensanbay.Text = dgvSanbay.CurrentRow.Cells[1].Value.ToString();
        }

        private void bt_xoa_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtMasanbay.Text != "")
                    Delete(txtMasanbay.Text);
                dgvSanbay.DataSource = SelectAll();
            }
            catch (Exception a)
            {
                MessageBox.Show(a.Message, "Thông báo");
            }
        }
    }
}
