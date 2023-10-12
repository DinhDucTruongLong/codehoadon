namespace DoAn_CuoiKy
{
    partial class DanhsachHD
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
            this.dgvDanhsachHD = new System.Windows.Forms.DataGridView();
            this.buttonLammoi = new System.Windows.Forms.Button();
            this.buttonXoa = new System.Windows.Forms.Button();
            this.buttonxemCT = new System.Windows.Forms.Button();
            this.buttonthanhtoan = new System.Windows.Forms.Button();
            this.clntenphong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnthang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clntienphong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clntienDv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clntiendien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clntiennuoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnthanhtien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnthanhtoan = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhsachHD)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvDanhsachHD
            // 
            this.dgvDanhsachHD.AllowUserToAddRows = false;
            this.dgvDanhsachHD.AllowUserToDeleteRows = false;
            this.dgvDanhsachHD.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDanhsachHD.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clntenphong,
            this.clnthang,
            this.clntienphong,
            this.clntienDv,
            this.clntiendien,
            this.clntiennuoc,
            this.clnthanhtien,
            this.clnthanhtoan});
            this.dgvDanhsachHD.Location = new System.Drawing.Point(40, 115);
            this.dgvDanhsachHD.Name = "dgvDanhsachHD";
            this.dgvDanhsachHD.ReadOnly = true;
            this.dgvDanhsachHD.RowHeadersWidth = 51;
            this.dgvDanhsachHD.RowTemplate.Height = 24;
            this.dgvDanhsachHD.Size = new System.Drawing.Size(1057, 314);
            this.dgvDanhsachHD.TabIndex = 9;
            // 
            // buttonLammoi
            // 
            this.buttonLammoi.Location = new System.Drawing.Point(519, 24);
            this.buttonLammoi.Name = "buttonLammoi";
            this.buttonLammoi.Size = new System.Drawing.Size(102, 47);
            this.buttonLammoi.TabIndex = 8;
            this.buttonLammoi.Text = "Làm mới";
            this.buttonLammoi.UseVisualStyleBackColor = true;
            // 
            // buttonXoa
            // 
            this.buttonXoa.Location = new System.Drawing.Point(353, 24);
            this.buttonXoa.Name = "buttonXoa";
            this.buttonXoa.Size = new System.Drawing.Size(102, 47);
            this.buttonXoa.TabIndex = 7;
            this.buttonXoa.Text = "Xóa";
            this.buttonXoa.UseVisualStyleBackColor = true;
            // 
            // buttonxemCT
            // 
            this.buttonxemCT.Location = new System.Drawing.Point(195, 24);
            this.buttonxemCT.Name = "buttonxemCT";
            this.buttonxemCT.Size = new System.Drawing.Size(102, 47);
            this.buttonxemCT.TabIndex = 6;
            this.buttonxemCT.Text = "xem chi tiết";
            this.buttonxemCT.UseVisualStyleBackColor = true;
            // 
            // buttonthanhtoan
            // 
            this.buttonthanhtoan.Location = new System.Drawing.Point(40, 24);
            this.buttonthanhtoan.Name = "buttonthanhtoan";
            this.buttonthanhtoan.Size = new System.Drawing.Size(102, 47);
            this.buttonthanhtoan.TabIndex = 5;
            this.buttonthanhtoan.Text = "Thanh toán";
            this.buttonthanhtoan.UseVisualStyleBackColor = true;
            // 
            // clntenphong
            // 
            this.clntenphong.HeaderText = "Mã phòng";
            this.clntenphong.MinimumWidth = 6;
            this.clntenphong.Name = "clntenphong";
            this.clntenphong.ReadOnly = true;
            this.clntenphong.Width = 125;
            // 
            // clnthang
            // 
            this.clnthang.HeaderText = "Thời gian";
            this.clnthang.MinimumWidth = 6;
            this.clnthang.Name = "clnthang";
            this.clnthang.ReadOnly = true;
            this.clnthang.Width = 125;
            // 
            // clntienphong
            // 
            this.clntienphong.HeaderText = "Tiền phòng";
            this.clntienphong.MinimumWidth = 6;
            this.clntienphong.Name = "clntienphong";
            this.clntienphong.ReadOnly = true;
            this.clntienphong.Width = 125;
            // 
            // clntienDv
            // 
            this.clntienDv.HeaderText = "Tiền Dịch Vụ";
            this.clntienDv.MinimumWidth = 6;
            this.clntienDv.Name = "clntienDv";
            this.clntienDv.ReadOnly = true;
            this.clntienDv.Width = 125;
            // 
            // clntiendien
            // 
            this.clntiendien.HeaderText = "Tiền điện";
            this.clntiendien.MinimumWidth = 6;
            this.clntiendien.Name = "clntiendien";
            this.clntiendien.ReadOnly = true;
            this.clntiendien.Width = 125;
            // 
            // clntiennuoc
            // 
            this.clntiennuoc.HeaderText = "Tiền nước";
            this.clntiennuoc.MinimumWidth = 6;
            this.clntiennuoc.Name = "clntiennuoc";
            this.clntiennuoc.ReadOnly = true;
            this.clntiennuoc.Width = 125;
            // 
            // clnthanhtien
            // 
            this.clnthanhtien.HeaderText = "Tổng tiền";
            this.clnthanhtien.MinimumWidth = 6;
            this.clnthanhtien.Name = "clnthanhtien";
            this.clnthanhtien.ReadOnly = true;
            this.clnthanhtien.Width = 125;
            // 
            // clnthanhtoan
            // 
            this.clnthanhtoan.HeaderText = "Đã Thanh Toán";
            this.clnthanhtoan.MinimumWidth = 6;
            this.clnthanhtoan.Name = "clnthanhtoan";
            this.clnthanhtoan.ReadOnly = true;
            this.clnthanhtoan.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.clnthanhtoan.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.clnthanhtoan.Width = 125;
            // 
            // DanhsachHD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1411, 666);
            this.Controls.Add(this.dgvDanhsachHD);
            this.Controls.Add(this.buttonLammoi);
            this.Controls.Add(this.buttonXoa);
            this.Controls.Add(this.buttonxemCT);
            this.Controls.Add(this.buttonthanhtoan);
            this.Name = "DanhsachHD";
            this.Text = "DanhsachHD";
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhsachHD)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvDanhsachHD;
        private System.Windows.Forms.Button buttonLammoi;
        private System.Windows.Forms.Button buttonXoa;
        private System.Windows.Forms.Button buttonxemCT;
        private System.Windows.Forms.Button buttonthanhtoan;
        private System.Windows.Forms.DataGridViewTextBoxColumn clntenphong;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnthang;
        private System.Windows.Forms.DataGridViewTextBoxColumn clntienphong;
        private System.Windows.Forms.DataGridViewTextBoxColumn clntienDv;
        private System.Windows.Forms.DataGridViewTextBoxColumn clntiendien;
        private System.Windows.Forms.DataGridViewTextBoxColumn clntiennuoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnthanhtien;
        private System.Windows.Forms.DataGridViewCheckBoxColumn clnthanhtoan;
    }
}