﻿namespace QLKaraoke
{
    partial class FrmQuanLyTaiKhoan
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
            this.btnquayve = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.colTINHTRANG = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colLOAIND = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMANV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMATKHAU = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTAIKHOAN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grbdstknv = new System.Windows.Forms.GroupBox();
            this.dgvdstknv = new System.Windows.Forms.DataGridView();
            this.lbldanhsachnv = new System.Windows.Forms.Label();
            this.grbdstknv.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvdstknv)).BeginInit();
            this.SuspendLayout();
            // 
            // btnquayve
            // 
            this.btnquayve.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnquayve.Location = new System.Drawing.Point(1078, 22);
            this.btnquayve.Name = "btnquayve";
            this.btnquayve.Size = new System.Drawing.Size(121, 37);
            this.btnquayve.TabIndex = 5;
            this.btnquayve.Text = "Quay Về";
            this.btnquayve.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(5, 129);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(121, 37);
            this.button3.TabIndex = 5;
            this.button3.Text = "Tra cứu";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(6, 75);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(120, 37);
            this.button2.TabIndex = 4;
            this.button2.Text = "Cập nhật";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(5, 24);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(121, 35);
            this.button1.TabIndex = 3;
            this.button1.Text = "Thêm";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(584, 90);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 24);
            this.comboBox2.TabIndex = 2;
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(584, 37);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(222, 22);
            this.textBox6.TabIndex = 1;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(234, 90);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(222, 22);
            this.textBox5.TabIndex = 1;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(234, 37);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(222, 22);
            this.textBox4.TabIndex = 1;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label8.Location = new System.Drawing.Point(493, 92);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(71, 20);
            this.label8.TabIndex = 0;
            this.label8.Text = "Loại ND";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label7.Location = new System.Drawing.Point(493, 39);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(60, 20);
            this.label7.TabIndex = 0;
            this.label7.Text = "Mã NV";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label6.Location = new System.Drawing.Point(136, 92);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 20);
            this.label6.TabIndex = 0;
            this.label6.Text = "Mật Khẩu";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label5.Location = new System.Drawing.Point(132, 39);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 20);
            this.label5.TabIndex = 0;
            this.label5.Text = "Tài Khoản";
            // 
            // colTINHTRANG
            // 
            this.colTINHTRANG.DataPropertyName = "TINHTRANG";
            this.colTINHTRANG.HeaderText = "Tình Trạng";
            this.colTINHTRANG.Name = "colTINHTRANG";
            // 
            // colLOAIND
            // 
            this.colLOAIND.DataPropertyName = "LOAIND";
            this.colLOAIND.HeaderText = "Loại Người Dùng";
            this.colLOAIND.Name = "colLOAIND";
            // 
            // colMANV
            // 
            this.colMANV.DataPropertyName = "MANV";
            this.colMANV.HeaderText = "MANV";
            this.colMANV.Name = "colMANV";
            // 
            // colMATKHAU
            // 
            this.colMATKHAU.DataPropertyName = "MATKHAU";
            this.colMATKHAU.HeaderText = "Mật Khẩu";
            this.colMATKHAU.Name = "colMATKHAU";
            // 
            // colTAIKHOAN
            // 
            this.colTAIKHOAN.DataPropertyName = "TAIKHOAN";
            this.colTAIKHOAN.HeaderText = "Tài Khoản";
            this.colTAIKHOAN.Name = "colTAIKHOAN";
            // 
            // grbdstknv
            // 
            this.grbdstknv.Controls.Add(this.btnquayve);
            this.grbdstknv.Controls.Add(this.button3);
            this.grbdstknv.Controls.Add(this.button2);
            this.grbdstknv.Controls.Add(this.button1);
            this.grbdstknv.Controls.Add(this.comboBox2);
            this.grbdstknv.Controls.Add(this.textBox6);
            this.grbdstknv.Controls.Add(this.textBox5);
            this.grbdstknv.Controls.Add(this.textBox4);
            this.grbdstknv.Controls.Add(this.label8);
            this.grbdstknv.Controls.Add(this.label7);
            this.grbdstknv.Controls.Add(this.label6);
            this.grbdstknv.Controls.Add(this.label5);
            this.grbdstknv.Location = new System.Drawing.Point(12, 158);
            this.grbdstknv.Name = "grbdstknv";
            this.grbdstknv.Size = new System.Drawing.Size(1206, 174);
            this.grbdstknv.TabIndex = 5;
            this.grbdstknv.TabStop = false;
            this.grbdstknv.Text = "Thông tin";
            // 
            // dgvdstknv
            // 
            this.dgvdstknv.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvdstknv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvdstknv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvdstknv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colTAIKHOAN,
            this.colMATKHAU,
            this.colMANV,
            this.colLOAIND,
            this.colTINHTRANG});
            this.dgvdstknv.Location = new System.Drawing.Point(12, 338);
            this.dgvdstknv.Name = "dgvdstknv";
            this.dgvdstknv.RowTemplate.Height = 24;
            this.dgvdstknv.Size = new System.Drawing.Size(1206, 199);
            this.dgvdstknv.TabIndex = 4;
            // 
            // lbldanhsachnv
            // 
            this.lbldanhsachnv.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbldanhsachnv.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbldanhsachnv.Location = new System.Drawing.Point(12, 78);
            this.lbldanhsachnv.Name = "lbldanhsachnv";
            this.lbldanhsachnv.Size = new System.Drawing.Size(1206, 40);
            this.lbldanhsachnv.TabIndex = 3;
            this.lbldanhsachnv.Text = "Danh Sách Tài Khoản Nhân Viên";
            this.lbldanhsachnv.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FrmQuanLyTaiKhoan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1230, 614);
            this.Controls.Add(this.grbdstknv);
            this.Controls.Add(this.dgvdstknv);
            this.Controls.Add(this.lbldanhsachnv);
            this.Name = "FrmQuanLyTaiKhoan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmQuanLyTaiKhoan";
            this.grbdstknv.ResumeLayout(false);
            this.grbdstknv.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvdstknv)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnquayve;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTINHTRANG;
        private System.Windows.Forms.DataGridViewTextBoxColumn colLOAIND;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMANV;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMATKHAU;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTAIKHOAN;
        private System.Windows.Forms.GroupBox grbdstknv;
        private System.Windows.Forms.DataGridView dgvdstknv;
        private System.Windows.Forms.Label lbldanhsachnv;
    }
}