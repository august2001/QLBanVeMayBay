namespace QLBANVEMAYBAY
{
    partial class DoanhThu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DoanhThu));
            this.dgvThongke = new System.Windows.Forms.DataGridView();
            this.dtpTgiansau = new System.Windows.Forms.DateTimePicker();
            this.btnTimtatca = new System.Windows.Forms.Button();
            this.dtpTgiantruoc = new System.Windows.Forms.DateTimePicker();
            this.bntTimtheokhoang = new System.Windows.Forms.Button();
            this.txtTong = new System.Windows.Forms.TextBox();
            this.btnTinhtong = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvThongke)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvThongke
            // 
            this.dgvThongke.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvThongke.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvThongke.GridColor = System.Drawing.Color.WhiteSmoke;
            this.dgvThongke.Location = new System.Drawing.Point(16, 251);
            this.dgvThongke.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvThongke.Name = "dgvThongke";
            this.dgvThongke.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dgvThongke.RowHeadersWidth = 51;
            this.dgvThongke.Size = new System.Drawing.Size(803, 276);
            this.dgvThongke.TabIndex = 96;
            // 
            // dtpTgiansau
            // 
            this.dtpTgiansau.CustomFormat = "MM/dd/yyyy";
            this.dtpTgiansau.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpTgiansau.Location = new System.Drawing.Point(252, 32);
            this.dtpTgiansau.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dtpTgiansau.Name = "dtpTgiansau";
            this.dtpTgiansau.Size = new System.Drawing.Size(197, 32);
            this.dtpTgiansau.TabIndex = 85;
            // 
            // btnTimtatca
            // 
            this.btnTimtatca.BackColor = System.Drawing.Color.Transparent;
            this.btnTimtatca.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnTimtatca.Font = new System.Drawing.Font("Times New Roman", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTimtatca.ForeColor = System.Drawing.Color.Indigo;
            this.btnTimtatca.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTimtatca.Location = new System.Drawing.Point(252, 79);
            this.btnTimtatca.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnTimtatca.Name = "btnTimtatca";
            this.btnTimtatca.Size = new System.Drawing.Size(199, 59);
            this.btnTimtatca.TabIndex = 86;
            this.btnTimtatca.Text = "Tìm tất cả hóa đơn";
            this.btnTimtatca.UseVisualStyleBackColor = false;
            this.btnTimtatca.Click += new System.EventHandler(this.btn_load_Click);
            // 
            // dtpTgiantruoc
            // 
            this.dtpTgiantruoc.CustomFormat = "MM/dd/yyyy";
            this.dtpTgiantruoc.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpTgiantruoc.Location = new System.Drawing.Point(20, 31);
            this.dtpTgiantruoc.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dtpTgiantruoc.Name = "dtpTgiantruoc";
            this.dtpTgiantruoc.Size = new System.Drawing.Size(184, 32);
            this.dtpTgiantruoc.TabIndex = 84;
            // 
            // bntTimtheokhoang
            // 
            this.bntTimtheokhoang.BackColor = System.Drawing.Color.Transparent;
            this.bntTimtheokhoang.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.bntTimtheokhoang.Font = new System.Drawing.Font("Times New Roman", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bntTimtheokhoang.ForeColor = System.Drawing.Color.Indigo;
            this.bntTimtheokhoang.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bntTimtheokhoang.Location = new System.Drawing.Point(20, 79);
            this.bntTimtheokhoang.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bntTimtheokhoang.Name = "bntTimtheokhoang";
            this.bntTimtheokhoang.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.bntTimtheokhoang.Size = new System.Drawing.Size(193, 59);
            this.bntTimtheokhoang.TabIndex = 4;
            this.bntTimtheokhoang.Text = "Tìm";
            this.bntTimtheokhoang.UseVisualStyleBackColor = false;
            this.bntTimtheokhoang.Click += new System.EventHandler(this.btnTimTheoKhoangtg_Click);
            // 
            // txtTong
            // 
            this.txtTong.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTong.Location = new System.Drawing.Point(540, 176);
            this.txtTong.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtTong.Name = "txtTong";
            this.txtTong.Size = new System.Drawing.Size(219, 32);
            this.txtTong.TabIndex = 100;
            // 
            // btnTinhtong
            // 
            this.btnTinhtong.BackColor = System.Drawing.Color.Transparent;
            this.btnTinhtong.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTinhtong.ForeColor = System.Drawing.Color.Indigo;
            this.btnTinhtong.Location = new System.Drawing.Point(567, 103);
            this.btnTinhtong.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnTinhtong.Name = "btnTinhtong";
            this.btnTinhtong.Size = new System.Drawing.Size(181, 41);
            this.btnTinhtong.TabIndex = 99;
            this.btnTinhtong.Text = "Tính tổng";
            this.btnTinhtong.UseVisualStyleBackColor = false;
            this.btnTinhtong.Click += new System.EventHandler(this.btn_tinhtong_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Navy;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.label2.Location = new System.Drawing.Point(201, 11);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(432, 45);
            this.label2.TabIndex = 98;
            this.label2.Text = "BÁO CÁO THỐNG KÊ";
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.groupBox3.Controls.Add(this.dtpTgiansau);
            this.groupBox3.Controls.Add(this.btnTimtatca);
            this.groupBox3.Controls.Add(this.dtpTgiantruoc);
            this.groupBox3.Controls.Add(this.bntTimtheokhoang);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.groupBox3.Location = new System.Drawing.Point(16, 73);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox3.Size = new System.Drawing.Size(488, 158);
            this.groupBox3.TabIndex = 97;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Tìm kiếm theo thời gian";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(768, 181);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 25);
            this.label1.TabIndex = 101;
            this.label1.Text = "VNĐ";
            // 
            // DoanhThu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(837, 542);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvThongke);
            this.Controls.Add(this.txtTong);
            this.Controls.Add(this.btnTinhtong);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox3);
            this.DoubleBuffered = true;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "DoanhThu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frm_thongke_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvThongke)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.DataGridView dgvThongke;
        private System.Windows.Forms.DateTimePicker dtpTgiansau;
        private System.Windows.Forms.Button btnTimtatca;
        private System.Windows.Forms.DateTimePicker dtpTgiantruoc;
        private System.Windows.Forms.Button bntTimtheokhoang;
        private System.Windows.Forms.TextBox txtTong;
        private System.Windows.Forms.Button btnTinhtong;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label1;
    }
}