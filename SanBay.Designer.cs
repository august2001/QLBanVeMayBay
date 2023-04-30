namespace QLBANVEMAYBAY
{
    partial class SanBay
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SanBay));
            this.dgvSanbay = new System.Windows.Forms.DataGridView();
            this.Masanbay = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tensanbay = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtTensanbay = new System.Windows.Forms.TextBox();
            this.txtMasanbay = new System.Windows.Forms.TextBox();
            this.lblTensanbay = new System.Windows.Forms.Label();
            this.lblMasanbay = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.bntXoa = new System.Windows.Forms.Button();
            this.bntSua = new System.Windows.Forms.Button();
            this.bntThem = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSanbay)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvSanbay
            // 
            this.dgvSanbay.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSanbay.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Masanbay,
            this.Tensanbay});
            this.dgvSanbay.Location = new System.Drawing.Point(11, 242);
            this.dgvSanbay.Margin = new System.Windows.Forms.Padding(4);
            this.dgvSanbay.Name = "dgvSanbay";
            this.dgvSanbay.ReadOnly = true;
            this.dgvSanbay.RowHeadersWidth = 51;
            this.dgvSanbay.Size = new System.Drawing.Size(541, 317);
            this.dgvSanbay.TabIndex = 14;
            this.dgvSanbay.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_CellMouseClick);
            // 
            // Masanbay
            // 
            this.Masanbay.DataPropertyName = "MASANBAY";
            this.Masanbay.HeaderText = "Mã sân bay";
            this.Masanbay.MinimumWidth = 6;
            this.Masanbay.Name = "Masanbay";
            this.Masanbay.ReadOnly = true;
            this.Masanbay.Width = 140;
            // 
            // Tensanbay
            // 
            this.Tensanbay.DataPropertyName = "Tensanbay";
            this.Tensanbay.HeaderText = "Tên sân bay";
            this.Tensanbay.MinimumWidth = 6;
            this.Tensanbay.Name = "Tensanbay";
            this.Tensanbay.ReadOnly = true;
            this.Tensanbay.Width = 220;
            // 
            // txtTensanbay
            // 
            this.txtTensanbay.Location = new System.Drawing.Point(171, 185);
            this.txtTensanbay.Margin = new System.Windows.Forms.Padding(5);
            this.txtTensanbay.Multiline = true;
            this.txtTensanbay.Name = "txtTensanbay";
            this.txtTensanbay.Size = new System.Drawing.Size(220, 36);
            this.txtTensanbay.TabIndex = 13;
            // 
            // txtMasanbay
            // 
            this.txtMasanbay.Location = new System.Drawing.Point(171, 130);
            this.txtMasanbay.Margin = new System.Windows.Forms.Padding(5);
            this.txtMasanbay.Multiline = true;
            this.txtMasanbay.Name = "txtMasanbay";
            this.txtMasanbay.Size = new System.Drawing.Size(220, 36);
            this.txtMasanbay.TabIndex = 12;
            // 
            // lblTensanbay
            // 
            this.lblTensanbay.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblTensanbay.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTensanbay.Location = new System.Drawing.Point(17, 185);
            this.lblTensanbay.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblTensanbay.Name = "lblTensanbay";
            this.lblTensanbay.Size = new System.Drawing.Size(143, 37);
            this.lblTensanbay.TabIndex = 11;
            this.lblTensanbay.Text = "Tên Sân Bay";
            this.lblTensanbay.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblMasanbay
            // 
            this.lblMasanbay.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblMasanbay.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMasanbay.Location = new System.Drawing.Point(17, 130);
            this.lblMasanbay.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblMasanbay.Name = "lblMasanbay";
            this.lblMasanbay.Size = new System.Drawing.Size(143, 33);
            this.lblMasanbay.TabIndex = 10;
            this.lblMasanbay.Text = "Mã Sân Bay";
            this.lblMasanbay.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Navy;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.ForeColor = System.Drawing.Color.Cyan;
            this.label1.Location = new System.Drawing.Point(208, 32);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 25);
            this.label1.TabIndex = 9;
            this.label1.Text = "SÂN BAY";
            // 
            // bntXoa
            // 
            this.bntXoa.BackColor = System.Drawing.Color.LightSeaGreen;
            this.bntXoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bntXoa.ForeColor = System.Drawing.Color.Navy;
            this.bntXoa.Location = new System.Drawing.Point(416, 197);
            this.bntXoa.Margin = new System.Windows.Forms.Padding(4);
            this.bntXoa.Name = "bntXoa";
            this.bntXoa.Size = new System.Drawing.Size(100, 38);
            this.bntXoa.TabIndex = 17;
            this.bntXoa.Text = "Xóa";
            this.bntXoa.UseVisualStyleBackColor = false;
            this.bntXoa.Click += new System.EventHandler(this.bt_xoa_Click);
            // 
            // bntSua
            // 
            this.bntSua.BackColor = System.Drawing.Color.LightSeaGreen;
            this.bntSua.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bntSua.ForeColor = System.Drawing.Color.Navy;
            this.bntSua.Location = new System.Drawing.Point(416, 150);
            this.bntSua.Margin = new System.Windows.Forms.Padding(4);
            this.bntSua.Name = "bntSua";
            this.bntSua.Size = new System.Drawing.Size(100, 39);
            this.bntSua.TabIndex = 16;
            this.bntSua.Text = "Cập Nhật";
            this.bntSua.UseVisualStyleBackColor = false;
            this.bntSua.Click += new System.EventHandler(this.bt_capnhat_Click);
            // 
            // bntThem
            // 
            this.bntThem.BackColor = System.Drawing.Color.LightSeaGreen;
            this.bntThem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bntThem.ForeColor = System.Drawing.Color.Navy;
            this.bntThem.Location = new System.Drawing.Point(416, 111);
            this.bntThem.Margin = new System.Windows.Forms.Padding(4);
            this.bntThem.Name = "bntThem";
            this.bntThem.Size = new System.Drawing.Size(100, 32);
            this.bntThem.TabIndex = 15;
            this.bntThem.Text = "Thêm ";
            this.bntThem.UseVisualStyleBackColor = false;
            this.bntThem.Click += new System.EventHandler(this.bt_them_Click);
            // 
            // SanBay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(568, 572);
            this.Controls.Add(this.dgvSanbay);
            this.Controls.Add(this.txtTensanbay);
            this.Controls.Add(this.txtMasanbay);
            this.Controls.Add(this.lblTensanbay);
            this.Controls.Add(this.lblMasanbay);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bntXoa);
            this.Controls.Add(this.bntSua);
            this.Controls.Add(this.bntThem);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "SanBay";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sân Bay";
            this.Load += new System.EventHandler(this.frm_ThemSanBay_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSanbay)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvSanbay;
        private System.Windows.Forms.TextBox txtTensanbay;
        private System.Windows.Forms.TextBox txtMasanbay;
        private System.Windows.Forms.Label lblTensanbay;
        private System.Windows.Forms.Label lblMasanbay;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bntXoa;
        private System.Windows.Forms.Button bntSua;
        private System.Windows.Forms.Button bntThem;
        private System.Windows.Forms.DataGridViewTextBoxColumn Masanbay;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tensanbay;
    }
}