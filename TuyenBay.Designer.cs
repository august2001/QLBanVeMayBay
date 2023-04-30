namespace QLBANVEMAYBAY
{
    partial class TuyenBay
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TuyenBay));
            this.dgvTuyenbay = new System.Windows.Forms.DataGridView();
            this.MATUYENBAY = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MASANBAYDI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MASANBAYDEN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblSanbaydi = new System.Windows.Forms.Label();
            this.comboBoxSbden = new System.Windows.Forms.ComboBox();
            this.comboBoxSbdi = new System.Windows.Forms.ComboBox();
            this.txtMatuyenbay = new System.Windows.Forms.TextBox();
            this.lblSanbayden = new System.Windows.Forms.Label();
            this.lblMatuyenbay = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.bntXoa = new System.Windows.Forms.Button();
            this.bntThem = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTuyenbay)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvTuyenbay
            // 
            this.dgvTuyenbay.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTuyenbay.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MATUYENBAY,
            this.MASANBAYDI,
            this.MASANBAYDEN});
            this.dgvTuyenbay.Location = new System.Drawing.Point(11, 265);
            this.dgvTuyenbay.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.dgvTuyenbay.Name = "dgvTuyenbay";
            this.dgvTuyenbay.RowHeadersWidth = 51;
            this.dgvTuyenbay.Size = new System.Drawing.Size(788, 278);
            this.dgvTuyenbay.TabIndex = 25;
            this.dgvTuyenbay.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_CellMouseClick);
            // 
            // MATUYENBAY
            // 
            this.MATUYENBAY.DataPropertyName = "MATUYENBAY";
            this.MATUYENBAY.HeaderText = "Mã tuyến bay";
            this.MATUYENBAY.MinimumWidth = 6;
            this.MATUYENBAY.Name = "MATUYENBAY";
            this.MATUYENBAY.Width = 150;
            // 
            // MASANBAYDI
            // 
            this.MASANBAYDI.DataPropertyName = "MASANBAYDI";
            this.MASANBAYDI.HeaderText = "Mã Sân Bay Đi";
            this.MASANBAYDI.MinimumWidth = 6;
            this.MASANBAYDI.Name = "MASANBAYDI";
            this.MASANBAYDI.Width = 200;
            // 
            // MASANBAYDEN
            // 
            this.MASANBAYDEN.DataPropertyName = "MASANBAYDEN";
            this.MASANBAYDEN.HeaderText = "Mã Sân Bay Đến";
            this.MASANBAYDEN.MinimumWidth = 6;
            this.MASANBAYDEN.Name = "MASANBAYDEN";
            this.MASANBAYDEN.Width = 200;
            // 
            // lblSanbaydi
            // 
            this.lblSanbaydi.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblSanbaydi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSanbaydi.Location = new System.Drawing.Point(64, 146);
            this.lblSanbaydi.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.lblSanbaydi.Name = "lblSanbaydi";
            this.lblSanbaydi.Size = new System.Drawing.Size(181, 34);
            this.lblSanbaydi.TabIndex = 31;
            this.lblSanbaydi.Text = "Tên Sân Bay đi:";
            this.lblSanbaydi.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // comboBoxSbden
            // 
            this.comboBoxSbden.FormattingEnabled = true;
            this.comboBoxSbden.Location = new System.Drawing.Point(288, 214);
            this.comboBoxSbden.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.comboBoxSbden.Name = "comboBoxSbden";
            this.comboBoxSbden.Size = new System.Drawing.Size(292, 24);
            this.comboBoxSbden.TabIndex = 30;
            this.comboBoxSbden.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // comboBoxSbdi
            // 
            this.comboBoxSbdi.FormattingEnabled = true;
            this.comboBoxSbdi.Location = new System.Drawing.Point(288, 149);
            this.comboBoxSbdi.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.comboBoxSbdi.Name = "comboBoxSbdi";
            this.comboBoxSbdi.Size = new System.Drawing.Size(292, 24);
            this.comboBoxSbdi.TabIndex = 29;
            this.comboBoxSbdi.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // txtMatuyenbay
            // 
            this.txtMatuyenbay.BackColor = System.Drawing.Color.White;
            this.txtMatuyenbay.Location = new System.Drawing.Point(288, 92);
            this.txtMatuyenbay.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.txtMatuyenbay.Multiline = true;
            this.txtMatuyenbay.Name = "txtMatuyenbay";
            this.txtMatuyenbay.ReadOnly = true;
            this.txtMatuyenbay.Size = new System.Drawing.Size(292, 25);
            this.txtMatuyenbay.TabIndex = 24;
            this.txtMatuyenbay.TextChanged += new System.EventHandler(this.txt_1_TextChanged);
            // 
            // lblSanbayden
            // 
            this.lblSanbayden.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblSanbayden.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSanbayden.Location = new System.Drawing.Point(61, 206);
            this.lblSanbayden.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.lblSanbayden.Name = "lblSanbayden";
            this.lblSanbayden.Size = new System.Drawing.Size(184, 33);
            this.lblSanbayden.TabIndex = 23;
            this.lblSanbayden.Text = "Tên Sân Bay đến:";
            this.lblSanbayden.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblMatuyenbay
            // 
            this.lblMatuyenbay.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblMatuyenbay.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMatuyenbay.Location = new System.Drawing.Point(64, 84);
            this.lblMatuyenbay.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.lblMatuyenbay.Name = "lblMatuyenbay";
            this.lblMatuyenbay.Size = new System.Drawing.Size(180, 33);
            this.lblMatuyenbay.TabIndex = 22;
            this.lblMatuyenbay.Text = "Mã Tuyến Bay:";
            this.lblMatuyenbay.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Navy;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Cyan;
            this.label1.Location = new System.Drawing.Point(323, 11);
            this.label1.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(158, 29);
            this.label1.TabIndex = 21;
            this.label1.Text = "TUYẾN BAY";
            // 
            // bntXoa
            // 
            this.bntXoa.BackColor = System.Drawing.Color.LightSeaGreen;
            this.bntXoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bntXoa.ForeColor = System.Drawing.Color.Navy;
            this.bntXoa.Location = new System.Drawing.Point(651, 144);
            this.bntXoa.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.bntXoa.Name = "bntXoa";
            this.bntXoa.Size = new System.Drawing.Size(131, 37);
            this.bntXoa.TabIndex = 28;
            this.bntXoa.Text = "Xóa";
            this.bntXoa.UseVisualStyleBackColor = false;
            this.bntXoa.Click += new System.EventHandler(this.bt_Xoa_Click);
            // 
            // bntThem
            // 
            this.bntThem.BackColor = System.Drawing.Color.LightSeaGreen;
            this.bntThem.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bntThem.ForeColor = System.Drawing.Color.Navy;
            this.bntThem.Location = new System.Drawing.Point(651, 84);
            this.bntThem.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.bntThem.Name = "bntThem";
            this.bntThem.Size = new System.Drawing.Size(131, 37);
            this.bntThem.TabIndex = 26;
            this.bntThem.Text = "Thêm ";
            this.bntThem.UseVisualStyleBackColor = false;
            this.bntThem.Click += new System.EventHandler(this.bt_them_Click);
            // 
            // TuyenBay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(816, 548);
            this.Controls.Add(this.dgvTuyenbay);
            this.Controls.Add(this.lblSanbaydi);
            this.Controls.Add(this.comboBoxSbden);
            this.Controls.Add(this.comboBoxSbdi);
            this.Controls.Add(this.txtMatuyenbay);
            this.Controls.Add(this.lblSanbayden);
            this.Controls.Add(this.lblMatuyenbay);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bntXoa);
            this.Controls.Add(this.bntThem);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "TuyenBay";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tuyến Bay";
            this.Load += new System.EventHandler(this.TuyenBay_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTuyenbay)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvTuyenbay;
        private System.Windows.Forms.Label lblSanbaydi;
        private System.Windows.Forms.ComboBox comboBoxSbden;
        private System.Windows.Forms.ComboBox comboBoxSbdi;
        private System.Windows.Forms.TextBox txtMatuyenbay;
        private System.Windows.Forms.Label lblSanbayden;
        private System.Windows.Forms.Label lblMatuyenbay;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bntXoa;
        private System.Windows.Forms.Button bntThem;
        private System.Windows.Forms.DataGridViewTextBoxColumn MATUYENBAY;
        private System.Windows.Forms.DataGridViewTextBoxColumn MASANBAYDI;
        private System.Windows.Forms.DataGridViewTextBoxColumn MASANBAYDEN;
    }
}