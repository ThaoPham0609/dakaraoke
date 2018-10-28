namespace QLKaraoke
{
    partial class FrmChonBaoCao
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
            this.label1 = new System.Windows.Forms.Label();
            this.cboNhaXB = new System.Windows.Forms.ComboBox();
            this.rdbHoaDon = new System.Windows.Forms.RadioButton();
            this.rdbTheoLoai = new System.Windows.Forms.RadioButton();
            this.rdbTatCaPhong = new System.Windows.Forms.RadioButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnXemBaoCao = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Harlow Solid Italic", 27.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Salmon;
            this.label1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label1.Location = new System.Drawing.Point(86, 26);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(322, 46);
            this.label1.TabIndex = 16;
            this.label1.Text = "Thống kê - Báo cáo";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // cboNhaXB
            // 
            this.cboNhaXB.FormattingEnabled = true;
            this.cboNhaXB.Location = new System.Drawing.Point(250, 126);
            this.cboNhaXB.Name = "cboNhaXB";
            this.cboNhaXB.Size = new System.Drawing.Size(121, 21);
            this.cboNhaXB.TabIndex = 15;
            // 
            // rdbHoaDon
            // 
            this.rdbHoaDon.AutoSize = true;
            this.rdbHoaDon.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbHoaDon.Location = new System.Drawing.Point(94, 172);
            this.rdbHoaDon.Name = "rdbHoaDon";
            this.rdbHoaDon.Size = new System.Drawing.Size(95, 24);
            this.rdbHoaDon.TabIndex = 10;
            this.rdbHoaDon.TabStop = true;
            this.rdbHoaDon.Text = "Hóa đơn";
            this.rdbHoaDon.UseVisualStyleBackColor = true;
            // 
            // rdbTheoLoai
            // 
            this.rdbTheoLoai.AutoSize = true;
            this.rdbTheoLoai.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbTheoLoai.Location = new System.Drawing.Point(92, 126);
            this.rdbTheoLoai.Name = "rdbTheoLoai";
            this.rdbTheoLoai.Size = new System.Drawing.Size(152, 24);
            this.rdbTheoLoai.TabIndex = 12;
            this.rdbTheoLoai.TabStop = true;
            this.rdbTheoLoai.Text = "Phòng theo loại";
            this.rdbTheoLoai.UseVisualStyleBackColor = true;
            // 
            // rdbTatCaPhong
            // 
            this.rdbTatCaPhong.AutoSize = true;
            this.rdbTatCaPhong.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbTatCaPhong.Location = new System.Drawing.Point(92, 82);
            this.rdbTatCaPhong.Name = "rdbTatCaPhong";
            this.rdbTatCaPhong.Size = new System.Drawing.Size(132, 24);
            this.rdbTatCaPhong.TabIndex = 13;
            this.rdbTatCaPhong.TabStop = true;
            this.rdbTatCaPhong.Text = "Tất cả phòng";
            this.rdbTatCaPhong.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::QLKaraoke.Properties.Resources.HoaDon;
            this.pictureBox1.Location = new System.Drawing.Point(12, 26);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(56, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 17;
            this.pictureBox1.TabStop = false;
            // 
            // btnXemBaoCao
            // 
            this.btnXemBaoCao.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXemBaoCao.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnXemBaoCao.Image = global::QLKaraoke.Properties.Resources.search;
            this.btnXemBaoCao.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnXemBaoCao.Location = new System.Drawing.Point(94, 231);
            this.btnXemBaoCao.Name = "btnXemBaoCao";
            this.btnXemBaoCao.Size = new System.Drawing.Size(150, 39);
            this.btnXemBaoCao.TabIndex = 14;
            this.btnXemBaoCao.Text = "Xem báo cáo";
            this.btnXemBaoCao.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnXemBaoCao.UseVisualStyleBackColor = true;
            // 
            // FrmChonBaoCao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(630, 342);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cboNhaXB);
            this.Controls.Add(this.btnXemBaoCao);
            this.Controls.Add(this.rdbHoaDon);
            this.Controls.Add(this.rdbTheoLoai);
            this.Controls.Add(this.rdbTatCaPhong);
            this.Name = "FrmChonBaoCao";
            this.Text = "Thống kê-Báo cáo ";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboNhaXB;
        private System.Windows.Forms.Button btnXemBaoCao;
        private System.Windows.Forms.RadioButton rdbHoaDon;
        private System.Windows.Forms.RadioButton rdbTheoLoai;
        private System.Windows.Forms.RadioButton rdbTatCaPhong;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

