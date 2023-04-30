namespace QLBANVEMAYBAY
{
    partial class NhanVien
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NhanVien));
            this.bntXoa = new System.Windows.Forms.Button();
            this.lblDiachi = new System.Windows.Forms.Label();
            this.txtDiachi = new System.Windows.Forms.TextBox();
            this.bntNhaplai = new System.Windows.Forms.Button();
            this.bntCapnhat = new System.Windows.Forms.Button();
            this.bntThem = new System.Windows.Forms.Button();
            this.txtDienthoai = new System.Windows.Forms.TextBox();
            this.dgvNhanvien = new System.Windows.Forms.DataGridView();
            this.MANV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TENNV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DIENTHOAI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DIACHI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtTennv = new System.Windows.Forms.TextBox();
            this.txtManv = new System.Windows.Forms.TextBox();
            this.lblDienthoai = new System.Windows.Forms.Label();
            this.lblTennv = new System.Windows.Forms.Label();
            this.lblManv = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNhanvien)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // bntXoa
            // 
            this.bntXoa.BackColor = System.Drawing.Color.LightSeaGreen;
            this.bntXoa.ForeColor = System.Drawing.Color.Navy;
            this.bntXoa.Location = new System.Drawing.Point(418, 166);
            this.bntXoa.Name = "bntXoa";
            this.bntXoa.Size = new System.Drawing.Size(86, 30);
            this.bntXoa.TabIndex = 15;
            this.bntXoa.Text = "Xóa";
            this.bntXoa.UseVisualStyleBackColor = false;
            this.bntXoa.Click += new System.EventHandler(this.btxoa_Click);
            // 
            // lblDiachi
            // 
            this.lblDiachi.AutoSize = true;
            this.lblDiachi.Location = new System.Drawing.Point(347, 50);
            this.lblDiachi.Name = "lblDiachi";
            this.lblDiachi.Size = new System.Drawing.Size(65, 20);
            this.lblDiachi.TabIndex = 12;
            this.lblDiachi.Text = "Địa chỉ :";
            // 
            // txtDiachi
            // 
            this.txtDiachi.Location = new System.Drawing.Point(418, 42);
            this.txtDiachi.Multiline = true;
            this.txtDiachi.Name = "txtDiachi";
            this.txtDiachi.Size = new System.Drawing.Size(285, 67);
            this.txtDiachi.TabIndex = 11;
            // 
            // bntNhaplai
            // 
            this.bntNhaplai.BackColor = System.Drawing.Color.LightSeaGreen;
            this.bntNhaplai.ForeColor = System.Drawing.Color.Navy;
            this.bntNhaplai.Location = new System.Drawing.Point(617, 166);
            this.bntNhaplai.Name = "bntNhaplai";
            this.bntNhaplai.Size = new System.Drawing.Size(86, 30);
            this.bntNhaplai.TabIndex = 10;
            this.bntNhaplai.Text = "Nhập lại";
            this.bntNhaplai.UseVisualStyleBackColor = false;
            this.bntNhaplai.Click += new System.EventHandler(this.bt_themmoi_Click);
            // 
            // bntCapnhat
            // 
            this.bntCapnhat.BackColor = System.Drawing.Color.LightSeaGreen;
            this.bntCapnhat.ForeColor = System.Drawing.Color.Navy;
            this.bntCapnhat.Location = new System.Drawing.Point(227, 166);
            this.bntCapnhat.Name = "bntCapnhat";
            this.bntCapnhat.Size = new System.Drawing.Size(89, 30);
            this.bntCapnhat.TabIndex = 9;
            this.bntCapnhat.Text = "Cập nhật";
            this.bntCapnhat.UseVisualStyleBackColor = false;
            this.bntCapnhat.Click += new System.EventHandler(this.bt_capnhat_Click);
            // 
            // bntThem
            // 
            this.bntThem.BackColor = System.Drawing.Color.LightSeaGreen;
            this.bntThem.ForeColor = System.Drawing.Color.Navy;
            this.bntThem.Location = new System.Drawing.Point(24, 166);
            this.bntThem.Name = "bntThem";
            this.bntThem.Size = new System.Drawing.Size(87, 30);
            this.bntThem.TabIndex = 8;
            this.bntThem.Text = "Thêm";
            this.bntThem.UseVisualStyleBackColor = false;
            this.bntThem.Click += new System.EventHandler(this.bt_luu_Click);
            // 
            // txtDienthoai
            // 
            this.txtDienthoai.Location = new System.Drawing.Point(139, 115);
            this.txtDienthoai.Multiline = true;
            this.txtDienthoai.Name = "txtDienthoai";
            this.txtDienthoai.Size = new System.Drawing.Size(177, 28);
            this.txtDienthoai.TabIndex = 6;
            // 
            // dgvNhanvien
            // 
            this.dgvNhanvien.AllowUserToOrderColumns = true;
            this.dgvNhanvien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNhanvien.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MANV,
            this.TENNV,
            this.DIENTHOAI,
            this.DIACHI});
            this.dgvNhanvien.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvNhanvien.Location = new System.Drawing.Point(3, 16);
            this.dgvNhanvien.Name = "dgvNhanvien";
            this.dgvNhanvien.RowHeadersWidth = 51;
            this.dgvNhanvien.Size = new System.Drawing.Size(723, 190);
            this.dgvNhanvien.TabIndex = 0;
            this.dgvNhanvien.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_CellMouseClick);
            // 
            // MANV
            // 
            this.MANV.DataPropertyName = "MANV";
            this.MANV.HeaderText = "Mã nhân viên";
            this.MANV.MinimumWidth = 6;
            this.MANV.Name = "MANV";
            this.MANV.Width = 125;
            // 
            // TENNV
            // 
            this.TENNV.DataPropertyName = "TENNV";
            this.TENNV.HeaderText = "Tên Nhân Viên";
            this.TENNV.MinimumWidth = 6;
            this.TENNV.Name = "TENNV";
            this.TENNV.Width = 170;
            // 
            // DIENTHOAI
            // 
            this.DIENTHOAI.DataPropertyName = "DIENTHOAI";
            this.DIENTHOAI.HeaderText = "Điện thoại";
            this.DIENTHOAI.MinimumWidth = 6;
            this.DIENTHOAI.Name = "DIENTHOAI";
            this.DIENTHOAI.Width = 125;
            // 
            // DIACHI
            // 
            this.DIACHI.DataPropertyName = "DIACHI";
            this.DIACHI.HeaderText = "Địa chỉ";
            this.DIACHI.MinimumWidth = 6;
            this.DIACHI.Name = "DIACHI";
            this.DIACHI.Width = 250;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.Desktop;
            this.groupBox2.Controls.Add(this.dgvNhanvien);
            this.groupBox2.Location = new System.Drawing.Point(17, 254);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(729, 209);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            // 
            // txtTennv
            // 
            this.txtTennv.Location = new System.Drawing.Point(139, 81);
            this.txtTennv.Multiline = true;
            this.txtTennv.Name = "txtTennv";
            this.txtTennv.Size = new System.Drawing.Size(177, 28);
            this.txtTennv.TabIndex = 5;
            // 
            // txtManv
            // 
            this.txtManv.Location = new System.Drawing.Point(138, 47);
            this.txtManv.Multiline = true;
            this.txtManv.Name = "txtManv";
            this.txtManv.Size = new System.Drawing.Size(177, 28);
            this.txtManv.TabIndex = 4;
            // 
            // lblDienthoai
            // 
            this.lblDienthoai.AutoSize = true;
            this.lblDienthoai.Location = new System.Drawing.Point(15, 118);
            this.lblDienthoai.Name = "lblDienthoai";
            this.lblDienthoai.Size = new System.Drawing.Size(89, 20);
            this.lblDienthoai.TabIndex = 2;
            this.lblDienthoai.Text = "Điên thoại :";
            // 
            // lblTennv
            // 
            this.lblTennv.AutoSize = true;
            this.lblTennv.Location = new System.Drawing.Point(15, 84);
            this.lblTennv.Name = "lblTennv";
            this.lblTennv.Size = new System.Drawing.Size(118, 20);
            this.lblTennv.TabIndex = 1;
            this.lblTennv.Text = "Tên Nhân Viên:";
            // 
            // lblManv
            // 
            this.lblManv.AutoSize = true;
            this.lblManv.Location = new System.Drawing.Point(15, 50);
            this.lblManv.Name = "lblManv";
            this.lblManv.Size = new System.Drawing.Size(117, 20);
            this.lblManv.TabIndex = 0;
            this.lblManv.Text = "Mã Nhân Viên :";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox1.Controls.Add(this.bntXoa);
            this.groupBox1.Controls.Add(this.lblDiachi);
            this.groupBox1.Controls.Add(this.txtDiachi);
            this.groupBox1.Controls.Add(this.bntNhaplai);
            this.groupBox1.Controls.Add(this.bntCapnhat);
            this.groupBox1.Controls.Add(this.bntThem);
            this.groupBox1.Controls.Add(this.txtDienthoai);
            this.groupBox1.Controls.Add(this.txtTennv);
            this.groupBox1.Controls.Add(this.txtManv);
            this.groupBox1.Controls.Add(this.lblDienthoai);
            this.groupBox1.Controls.Add(this.lblTennv);
            this.groupBox1.Controls.Add(this.lblManv);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.Cyan;
            this.groupBox1.Location = new System.Drawing.Point(20, 46);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(723, 202);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Navy;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label4.ForeColor = System.Drawing.Color.Cyan;
            this.label4.Location = new System.Drawing.Point(297, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(218, 24);
            this.label4.TabIndex = 4;
            this.label4.Text = "QUẢN LÝ NHÂN VIÊN";
            // 
            // NhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(761, 470);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "NhanVien";
            this.Text = "Nhân Viên";
            this.Load += new System.EventHandler(this.NhanVien_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvNhanvien)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button bntXoa;
        private System.Windows.Forms.Label lblDiachi;
        private System.Windows.Forms.TextBox txtDiachi;
        private System.Windows.Forms.Button bntNhaplai;
        private System.Windows.Forms.Button bntCapnhat;
        private System.Windows.Forms.Button bntThem;
        private System.Windows.Forms.TextBox txtDienthoai;
        private System.Windows.Forms.DataGridView dgvNhanvien;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtTennv;
        private System.Windows.Forms.TextBox txtManv;
        private System.Windows.Forms.Label lblDienthoai;
        private System.Windows.Forms.Label lblTennv;
        private System.Windows.Forms.Label lblManv;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridViewTextBoxColumn MANV;
        private System.Windows.Forms.DataGridViewTextBoxColumn TENNV;
        private System.Windows.Forms.DataGridViewTextBoxColumn DIENTHOAI;
        private System.Windows.Forms.DataGridViewTextBoxColumn DIACHI;
    }
}