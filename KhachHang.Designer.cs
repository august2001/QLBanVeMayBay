namespace QLBANVEMAYBAY
{
    partial class HangKhach
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HangKhach));
            this.dgvKhachhang = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bntThem = new System.Windows.Forms.Button();
            this.txtDienthoai = new System.Windows.Forms.TextBox();
            this.txtTenkh = new System.Windows.Forms.TextBox();
            this.lblDienthoai = new System.Windows.Forms.Label();
            this.lblTenkh = new System.Windows.Forms.Label();
            this.lblCmnd = new System.Windows.Forms.Label();
            this.txtCmnd = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtMakh = new System.Windows.Forms.TextBox();
            this.lblMakh = new System.Windows.Forms.Label();
            this.bntSua = new System.Windows.Forms.Button();
            this.bntXoa = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKhachhang)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvKhachhang
            // 
            this.dgvKhachhang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKhachhang.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column4,
            this.Column3});
            this.dgvKhachhang.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvKhachhang.Location = new System.Drawing.Point(0, 367);
            this.dgvKhachhang.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvKhachhang.Name = "dgvKhachhang";
            this.dgvKhachhang.RowHeadersWidth = 51;
            this.dgvKhachhang.Size = new System.Drawing.Size(839, 192);
            this.dgvKhachhang.TabIndex = 19;
            this.dgvKhachhang.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick_1);
            this.dgvKhachhang.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_CellMouseClick);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "MAKH";
            this.Column1.HeaderText = "Mã Khách hàng";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.Width = 150;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "Tenkh";
            this.Column2.HeaderText = "Tên Khách Hàng";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.Width = 150;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "CMND";
            this.Column4.HeaderText = "CMND";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.Width = 125;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "Dienthoai";
            this.Column3.HeaderText = "Điện Thoại";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.Width = 150;
            // 
            // bntThem
            // 
            this.bntThem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.bntThem.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bntThem.ForeColor = System.Drawing.Color.Red;
            this.bntThem.Location = new System.Drawing.Point(64, 304);
            this.bntThem.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bntThem.Name = "bntThem";
            this.bntThem.Size = new System.Drawing.Size(153, 44);
            this.bntThem.TabIndex = 17;
            this.bntThem.Text = "Thêm mới";
            this.bntThem.UseVisualStyleBackColor = false;
            this.bntThem.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtDienthoai
            // 
            this.txtDienthoai.Location = new System.Drawing.Point(395, 263);
            this.txtDienthoai.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.txtDienthoai.Multiline = true;
            this.txtDienthoai.Name = "txtDienthoai";
            this.txtDienthoai.Size = new System.Drawing.Size(265, 29);
            this.txtDienthoai.TabIndex = 16;
            // 
            // txtTenkh
            // 
            this.txtTenkh.Location = new System.Drawing.Point(395, 206);
            this.txtTenkh.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.txtTenkh.Multiline = true;
            this.txtTenkh.Name = "txtTenkh";
            this.txtTenkh.Size = new System.Drawing.Size(265, 29);
            this.txtTenkh.TabIndex = 15;
            // 
            // lblDienthoai
            // 
            this.lblDienthoai.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.lblDienthoai.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDienthoai.ForeColor = System.Drawing.Color.Navy;
            this.lblDienthoai.Location = new System.Drawing.Point(151, 263);
            this.lblDienthoai.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblDienthoai.Name = "lblDienthoai";
            this.lblDienthoai.Size = new System.Drawing.Size(169, 30);
            this.lblDienthoai.TabIndex = 14;
            this.lblDienthoai.Text = "Điện Thoại";
            this.lblDienthoai.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblTenkh
            // 
            this.lblTenkh.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.lblTenkh.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTenkh.ForeColor = System.Drawing.Color.Navy;
            this.lblTenkh.Location = new System.Drawing.Point(149, 206);
            this.lblTenkh.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblTenkh.Name = "lblTenkh";
            this.lblTenkh.Size = new System.Drawing.Size(171, 30);
            this.lblTenkh.TabIndex = 13;
            this.lblTenkh.Text = "Tên Khách Hàng";
            this.lblTenkh.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblCmnd
            // 
            this.lblCmnd.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.lblCmnd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCmnd.ForeColor = System.Drawing.Color.Navy;
            this.lblCmnd.Location = new System.Drawing.Point(148, 149);
            this.lblCmnd.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblCmnd.Name = "lblCmnd";
            this.lblCmnd.Size = new System.Drawing.Size(171, 27);
            this.lblCmnd.TabIndex = 12;
            this.lblCmnd.Text = "Số CMND ";
            this.lblCmnd.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtCmnd
            // 
            this.txtCmnd.Location = new System.Drawing.Point(395, 146);
            this.txtCmnd.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.txtCmnd.Multiline = true;
            this.txtCmnd.Name = "txtCmnd";
            this.txtCmnd.Size = new System.Drawing.Size(265, 29);
            this.txtCmnd.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Navy;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label3.ForeColor = System.Drawing.Color.Cyan;
            this.label3.Location = new System.Drawing.Point(321, 28);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(179, 29);
            this.label3.TabIndex = 20;
            this.label3.Text = "KHÁCH HÀNG";
            // 
            // txtMakh
            // 
            this.txtMakh.Location = new System.Drawing.Point(395, 90);
            this.txtMakh.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.txtMakh.Multiline = true;
            this.txtMakh.Name = "txtMakh";
            this.txtMakh.Size = new System.Drawing.Size(265, 29);
            this.txtMakh.TabIndex = 21;
            // 
            // lblMakh
            // 
            this.lblMakh.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.lblMakh.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMakh.ForeColor = System.Drawing.Color.Navy;
            this.lblMakh.Location = new System.Drawing.Point(148, 92);
            this.lblMakh.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblMakh.Name = "lblMakh";
            this.lblMakh.Size = new System.Drawing.Size(172, 27);
            this.lblMakh.TabIndex = 22;
            this.lblMakh.Text = "Mã Khách Hàng";
            this.lblMakh.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // bntSua
            // 
            this.bntSua.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.bntSua.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bntSua.ForeColor = System.Drawing.Color.Red;
            this.bntSua.Location = new System.Drawing.Point(336, 304);
            this.bntSua.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bntSua.Name = "bntSua";
            this.bntSua.Size = new System.Drawing.Size(153, 44);
            this.bntSua.TabIndex = 23;
            this.bntSua.Text = "Cập Nhật";
            this.bntSua.UseVisualStyleBackColor = false;
            this.bntSua.Click += new System.EventHandler(this.button2_Click_2);
            // 
            // bntXoa
            // 
            this.bntXoa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.bntXoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bntXoa.ForeColor = System.Drawing.Color.Red;
            this.bntXoa.Location = new System.Drawing.Point(607, 304);
            this.bntXoa.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bntXoa.Name = "bntXoa";
            this.bntXoa.Size = new System.Drawing.Size(153, 44);
            this.bntXoa.TabIndex = 24;
            this.bntXoa.Text = "Xóa";
            this.bntXoa.UseVisualStyleBackColor = false;
            this.bntXoa.Click += new System.EventHandler(this.button3_Click_2);
            // 
            // HangKhach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(839, 559);
            this.Controls.Add(this.bntXoa);
            this.Controls.Add(this.bntSua);
            this.Controls.Add(this.lblMakh);
            this.Controls.Add(this.txtMakh);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dgvKhachhang);
            this.Controls.Add(this.bntThem);
            this.Controls.Add(this.txtDienthoai);
            this.Controls.Add(this.txtTenkh);
            this.Controls.Add(this.lblDienthoai);
            this.Controls.Add(this.lblTenkh);
            this.Controls.Add(this.lblCmnd);
            this.Controls.Add(this.txtCmnd);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "HangKhach";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Khách Hàng";
            this.Load += new System.EventHandler(this.frm_KhachHang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvKhachhang)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvKhachhang;
        private System.Windows.Forms.Button bntThem;
        private System.Windows.Forms.TextBox txtDienthoai;
        private System.Windows.Forms.TextBox txtTenkh;
        private System.Windows.Forms.Label lblDienthoai;
        private System.Windows.Forms.Label lblTenkh;
        private System.Windows.Forms.Label lblCmnd;
        private System.Windows.Forms.TextBox txtCmnd;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtMakh;
        private System.Windows.Forms.Label lblMakh;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.Button bntSua;
        private System.Windows.Forms.Button bntXoa;
    }
}