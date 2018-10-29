namespace QLKaraoke
{
    partial class FrmXemLichSuTaiKhoan
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
            this.dgvquanlynv = new System.Windows.Forms.DataGridView();
            this.colMALS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMAKH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMAHD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTONGTHANHTOAN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNGAYTHANHTOAN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTONGGIOTHUE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvquanlynv)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvquanlynv
            // 
            this.dgvquanlynv.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvquanlynv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvquanlynv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvquanlynv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colMALS,
            this.colMAKH,
            this.colMAHD,
            this.colTONGTHANHTOAN,
            this.colNGAYTHANHTOAN,
            this.colTONGGIOTHUE});
            this.dgvquanlynv.Location = new System.Drawing.Point(27, 212);
            this.dgvquanlynv.Name = "dgvquanlynv";
            this.dgvquanlynv.RowTemplate.Height = 24;
            this.dgvquanlynv.Size = new System.Drawing.Size(1147, 204);
            this.dgvquanlynv.TabIndex = 6;
            // 
            // colMALS
            // 
            this.colMALS.DataPropertyName = "MALS";
            this.colMALS.HeaderText = "Mã Lịch Sử";
            this.colMALS.Name = "colMALS";
            // 
            // colMAKH
            // 
            this.colMAKH.DataPropertyName = "MAKH";
            this.colMAKH.HeaderText = "Mã KH";
            this.colMAKH.Name = "colMAKH";
            // 
            // colMAHD
            // 
            this.colMAHD.DataPropertyName = "MAHD";
            this.colMAHD.HeaderText = "Mã HĐ";
            this.colMAHD.Name = "colMAHD";
            // 
            // colTONGTHANHTOAN
            // 
            this.colTONGTHANHTOAN.DataPropertyName = "TONGTHANHTOAN";
            this.colTONGTHANHTOAN.HeaderText = "Tổng Thanh Toán";
            this.colTONGTHANHTOAN.Name = "colTONGTHANHTOAN";
            // 
            // colNGAYTHANHTOAN
            // 
            this.colNGAYTHANHTOAN.DataPropertyName = "NGAYTHANHTOAN";
            this.colNGAYTHANHTOAN.HeaderText = "Ngày Thanh Toán";
            this.colNGAYTHANHTOAN.Name = "colNGAYTHANHTOAN";
            // 
            // colTONGGIOTHUE
            // 
            this.colTONGGIOTHUE.DataPropertyName = "TONGGIOTHUE";
            this.colTONGGIOTHUE.HeaderText = "Tổng Giờ Thuê";
            this.colTONGGIOTHUE.Name = "colTONGGIOTHUE";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(169, -111);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(477, 23);
            this.label1.TabIndex = 5;
            this.label1.Text = "Lịch Sử Khách Hàng";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FrmXemLichSuTaiKhoan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1204, 594);
            this.Controls.Add(this.dgvquanlynv);
            this.Controls.Add(this.label1);
            this.Name = "FrmXemLichSuTaiKhoan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmXemLichSuTaiKhoan";
            ((System.ComponentModel.ISupportInitialize)(this.dgvquanlynv)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvquanlynv;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMALS;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMAKH;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMAHD;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTONGTHANHTOAN;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNGAYTHANHTOAN;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTONGGIOTHUE;
        private System.Windows.Forms.Label label1;
    }
}