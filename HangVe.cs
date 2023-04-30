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
    public partial class HangVe : Form
    {
        public HangVe()
        {
            InitializeComponent();
        }

        Connection cn = new Connection();
        private void frm_ThemHangVe_Load(object sender, EventArgs e)
        {
            comboBoxHv.DataSource = cn.ExecuteData("select * from HANGVE");
            comboBoxHv.ValueMember = "Mahangve";
            comboBoxHv.DisplayMember = "Tenhangve";
        }
        public int INSERT(string MAHANGVE, string TENHANGVE)
        {
            string sql = "INSERT INTO HANGVE(MAHANGVE,TENHANGVE) VALUES (N'" + MAHANGVE + "',N'" + TENHANGVE + "')";
            return cn.ExecuteNonQuery(sql);
        }
        public int UPDATE(string MAHANGVE, string TENHANGVE)
        {
            string sql = "UPDATE HANGVE SET [MAHANGVE]=" + MAHANGVE + ",[TENHANGVE]=" + TENHANGVE + " WHERE [MAHANGVE]=N'" + MAHANGVE + "'";
            return cn.ExecuteNonQuery(sql);
        }
        public int Delete(string MAHANGVE)
        {
            string sql = "DELETE FROM HANGVE WHERE [MAHANGVE]=N'" + MAHANGVE + "'";
            return cn.ExecuteNonQuery(sql);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtMahangve.Text != "" && txtTenHangve.Text != "")
                    UPDATE(txtMahangve.Text, txtTenHangve.Text);
                comboBoxHv.DataSource = cn.ExecuteData("select * from HANGVE");
                comboBoxHv.ValueMember = "Mahangve";
                comboBoxHv.DisplayMember = "Tenhangve";
            }
            catch { }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtMahangve.Text != "" && txtTenHangve.Text != "")
                    INSERT(txtMahangve.Text, txtTenHangve.Text);
                comboBoxHv.DataSource = cn.ExecuteData("select * from HANGVE");
                comboBoxHv.ValueMember = "Mahangve";
                comboBoxHv.DisplayMember = "Tenhangve";
            }
            catch { }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtTenHangve.Text = comboBoxHv.Text;
            txtMahangve.Text = comboBoxHv.SelectedValue.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
