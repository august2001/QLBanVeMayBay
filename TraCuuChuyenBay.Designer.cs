namespace QLBANVEMAYBAY
{
    partial class TraCuuChuyenBay
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
            this.dgvTracuu = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.bnt_thoat = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTracuu)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvTracuu
            // 
            this.dgvTracuu.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgvTracuu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTracuu.Location = new System.Drawing.Point(46, 84);
            this.dgvTracuu.Margin = new System.Windows.Forms.Padding(4);
            this.dgvTracuu.Name = "dgvTracuu";
            this.dgvTracuu.RowHeadersWidth = 51;
            this.dgvTracuu.Size = new System.Drawing.Size(791, 343);
            this.dgvTracuu.TabIndex = 41;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Navy;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Cyan;
            this.label1.Location = new System.Drawing.Point(359, 25);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(211, 25);
            this.label1.TabIndex = 29;
            this.label1.Text = "TRA CỨU LỊCH BAY";
            // 
            // bnt_thoat
            // 
            this.bnt_thoat.Location = new System.Drawing.Point(683, 458);
            this.bnt_thoat.Margin = new System.Windows.Forms.Padding(4);
            this.bnt_thoat.Name = "bnt_thoat";
            this.bnt_thoat.Size = new System.Drawing.Size(126, 37);
            this.bnt_thoat.TabIndex = 38;
            this.bnt_thoat.Text = "Thoát";
            this.bnt_thoat.UseVisualStyleBackColor = true;
            this.bnt_thoat.Click += new System.EventHandler(this.bnt_thoat_Click_1);
            // 
            // TraCuuChuyenBay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::QLBANVEMAYBAY.Properties.Resources._3aff7ee84530b46eed21;
            this.ClientSize = new System.Drawing.Size(879, 517);
            this.Controls.Add(this.dgvTracuu);
            this.Controls.Add(this.bnt_thoat);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "TraCuuChuyenBay";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TraCuuChuyenBay";
            this.Load += new System.EventHandler(this.TraCuuChuyenBay_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTracuu)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvTracuu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bnt_thoat;
    }
}