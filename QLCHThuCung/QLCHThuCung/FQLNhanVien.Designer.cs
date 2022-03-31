
namespace QLCHThuCung
{
    partial class FQLNhanVien
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FQLNhanVien));
            this.btBack = new System.Windows.Forms.Button();
            this.dgDSNV = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cbTimKiem = new System.Windows.Forms.ComboBox();
            this.tbTimKiem = new System.Windows.Forms.TextBox();
            this.btTim = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.tbMaNV = new System.Windows.Forms.TextBox();
            this.dtpNgayVaoLam = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.tbTaiKhoan = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.tbHoTen = new System.Windows.Forms.TextBox();
            this.dtpNgaySinh = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.tbGioiTinh = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.tbCMND = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.tbEmail = new System.Windows.Forms.TextBox();
            this.tb = new System.Windows.Forms.Label();
            this.tbSDT = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.cbLoaiNV = new System.Windows.Forms.ComboBox();
            this.cbTrangThai = new System.Windows.Forms.ComboBox();
            this.btThêm = new System.Windows.Forms.Button();
            this.btCapNhat = new System.Windows.Forms.Button();
            this.btXoa = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.tbDiaChi = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgDSNV)).BeginInit();
            this.SuspendLayout();
            // 
            // btBack
            // 
            this.btBack.BackColor = System.Drawing.Color.Bisque;
            this.btBack.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btBack.FlatAppearance.BorderSize = 0;
            this.btBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btBack.Image = ((System.Drawing.Image)(resources.GetObject("btBack.Image")));
            this.btBack.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btBack.Location = new System.Drawing.Point(11, 11);
            this.btBack.Margin = new System.Windows.Forms.Padding(2);
            this.btBack.Name = "btBack";
            this.btBack.Size = new System.Drawing.Size(93, 39);
            this.btBack.TabIndex = 0;
            this.btBack.Text = "Back";
            this.btBack.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.btBack.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btBack.UseMnemonic = false;
            this.btBack.UseVisualStyleBackColor = false;
            this.btBack.Click += new System.EventHandler(this.button1_Click);
            // 
            // dgDSNV
            // 
            this.dgDSNV.BackgroundColor = System.Drawing.Color.Bisque;
            this.dgDSNV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgDSNV.Location = new System.Drawing.Point(120, 408);
            this.dgDSNV.Margin = new System.Windows.Forms.Padding(2);
            this.dgDSNV.Name = "dgDSNV";
            this.dgDSNV.RowHeadersWidth = 51;
            this.dgDSNV.RowTemplate.Height = 24;
            this.dgDSNV.Size = new System.Drawing.Size(1042, 240);
            this.dgDSNV.TabIndex = 1;
            this.dgDSNV.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgDSNV_CellClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Bisque;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.MediumPurple;
            this.label1.Location = new System.Drawing.Point(527, 25);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(441, 46);
            this.label1.TabIndex = 2;
            this.label1.Text = "QUẢN LÝ NHÂN VIÊN";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(94, 139);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(1372, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "-------Thông tin chi tiết--------------------------------------------------------" +
    "--------------------------------------------------------------------------------" +
    "-------------------------------";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(148, 95);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 25);
            this.label3.TabIndex = 4;
            this.label3.Text = "Tìm kiếm";
            // 
            // cbTimKiem
            // 
            this.cbTimKiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbTimKiem.FormattingEnabled = true;
            this.cbTimKiem.Location = new System.Drawing.Point(249, 95);
            this.cbTimKiem.Margin = new System.Windows.Forms.Padding(2);
            this.cbTimKiem.Name = "cbTimKiem";
            this.cbTimKiem.Size = new System.Drawing.Size(191, 26);
            this.cbTimKiem.TabIndex = 5;
            // 
            // tbTimKiem
            // 
            this.tbTimKiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbTimKiem.Location = new System.Drawing.Point(468, 95);
            this.tbTimKiem.Margin = new System.Windows.Forms.Padding(2);
            this.tbTimKiem.Name = "tbTimKiem";
            this.tbTimKiem.Size = new System.Drawing.Size(568, 27);
            this.tbTimKiem.TabIndex = 6;
            this.tbTimKiem.TextChanged += new System.EventHandler(this.tbTimKiem_TextChanged);
            // 
            // btTim
            // 
            this.btTim.BackColor = System.Drawing.Color.MediumPurple;
            this.btTim.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btTim.ForeColor = System.Drawing.Color.White;
            this.btTim.Location = new System.Drawing.Point(1070, 92);
            this.btTim.Margin = new System.Windows.Forms.Padding(2);
            this.btTim.Name = "btTim";
            this.btTim.Size = new System.Drawing.Size(87, 32);
            this.btTim.TabIndex = 7;
            this.btTim.Text = "Tìm";
            this.btTim.UseVisualStyleBackColor = false;
            this.btTim.Click += new System.EventHandler(this.btTim_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(189, 181);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 18);
            this.label4.TabIndex = 8;
            this.label4.Text = "Mã:";
            // 
            // tbMaNV
            // 
            this.tbMaNV.BackColor = System.Drawing.Color.Bisque;
            this.tbMaNV.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbMaNV.ForeColor = System.Drawing.Color.Black;
            this.tbMaNV.Location = new System.Drawing.Point(229, 178);
            this.tbMaNV.Margin = new System.Windows.Forms.Padding(2);
            this.tbMaNV.Name = "tbMaNV";
            this.tbMaNV.ReadOnly = true;
            this.tbMaNV.Size = new System.Drawing.Size(76, 24);
            this.tbMaNV.TabIndex = 9;
            // 
            // dtpNgayVaoLam
            // 
            this.dtpNgayVaoLam.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpNgayVaoLam.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpNgayVaoLam.Location = new System.Drawing.Point(914, 217);
            this.dtpNgayVaoLam.Margin = new System.Windows.Forms.Padding(2);
            this.dtpNgayVaoLam.Name = "dtpNgayVaoLam";
            this.dtpNgayVaoLam.Size = new System.Drawing.Size(286, 24);
            this.dtpNgayVaoLam.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(805, 220);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(102, 18);
            this.label5.TabIndex = 11;
            this.label5.Text = "Ngày vào làm:";
            // 
            // tbTaiKhoan
            // 
            this.tbTaiKhoan.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbTaiKhoan.Location = new System.Drawing.Point(227, 305);
            this.tbTaiKhoan.Margin = new System.Windows.Forms.Padding(2);
            this.tbTaiKhoan.Name = "tbTaiKhoan";
            this.tbTaiKhoan.Size = new System.Drawing.Size(156, 24);
            this.tbTaiKhoan.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(114, 307);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(101, 18);
            this.label6.TabIndex = 13;
            this.label6.Text = "Tên tài khoản:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(425, 176);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(56, 18);
            this.label7.TabIndex = 14;
            this.label7.Text = "Họ tên:";
            // 
            // tbHoTen
            // 
            this.tbHoTen.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbHoTen.Location = new System.Drawing.Point(491, 173);
            this.tbHoTen.Margin = new System.Windows.Forms.Padding(2);
            this.tbHoTen.Name = "tbHoTen";
            this.tbHoTen.Size = new System.Drawing.Size(276, 24);
            this.tbHoTen.TabIndex = 15;
            // 
            // dtpNgaySinh
            // 
            this.dtpNgaySinh.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpNgaySinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpNgaySinh.Location = new System.Drawing.Point(914, 168);
            this.dtpNgaySinh.Margin = new System.Windows.Forms.Padding(2);
            this.dtpNgaySinh.Name = "dtpNgaySinh";
            this.dtpNgaySinh.Size = new System.Drawing.Size(244, 24);
            this.dtpNgaySinh.TabIndex = 16;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(823, 172);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(77, 18);
            this.label8.TabIndex = 17;
            this.label8.Text = "Ngày sinh:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(149, 217);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(66, 18);
            this.label9.TabIndex = 18;
            this.label9.Text = "Giới tính:";
            // 
            // tbGioiTinh
            // 
            this.tbGioiTinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbGioiTinh.Location = new System.Drawing.Point(227, 215);
            this.tbGioiTinh.Margin = new System.Windows.Forms.Padding(2);
            this.tbGioiTinh.Name = "tbGioiTinh";
            this.tbGioiTinh.Size = new System.Drawing.Size(88, 24);
            this.tbGioiTinh.TabIndex = 19;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(361, 217);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(129, 18);
            this.label10.TabIndex = 20;
            this.label10.Text = "Số CMND/CCCD:";
            // 
            // tbCMND
            // 
            this.tbCMND.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbCMND.Location = new System.Drawing.Point(491, 214);
            this.tbCMND.Margin = new System.Windows.Forms.Padding(2);
            this.tbCMND.Name = "tbCMND";
            this.tbCMND.Size = new System.Drawing.Size(276, 24);
            this.tbCMND.TabIndex = 21;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(431, 265);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(49, 18);
            this.label11.TabIndex = 22;
            this.label11.Text = "Email:";
            // 
            // tbEmail
            // 
            this.tbEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbEmail.Location = new System.Drawing.Point(491, 262);
            this.tbEmail.Margin = new System.Windows.Forms.Padding(2);
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.Size = new System.Drawing.Size(245, 24);
            this.tbEmail.TabIndex = 23;
            // 
            // tb
            // 
            this.tb.AutoSize = true;
            this.tb.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb.Location = new System.Drawing.Point(117, 264);
            this.tb.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.tb.Name = "tb";
            this.tb.Size = new System.Drawing.Size(98, 18);
            this.tb.TabIndex = 24;
            this.tb.Text = "Số điện thoại:";
            // 
            // tbSDT
            // 
            this.tbSDT.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbSDT.Location = new System.Drawing.Point(227, 261);
            this.tbSDT.Margin = new System.Windows.Forms.Padding(2);
            this.tbSDT.Name = "tbSDT";
            this.tbSDT.Size = new System.Drawing.Size(174, 24);
            this.tbSDT.TabIndex = 25;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(798, 264);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(106, 18);
            this.label12.TabIndex = 26;
            this.label12.Text = "Loại nhân viên:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(823, 303);
            this.label13.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(141, 18);
            this.label13.TabIndex = 27;
            this.label13.Text = "Trạng thái tài khoản:";
            // 
            // cbLoaiNV
            // 
            this.cbLoaiNV.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbLoaiNV.FormattingEnabled = true;
            this.cbLoaiNV.Location = new System.Drawing.Point(914, 262);
            this.cbLoaiNV.Margin = new System.Windows.Forms.Padding(2);
            this.cbLoaiNV.Name = "cbLoaiNV";
            this.cbLoaiNV.Size = new System.Drawing.Size(221, 26);
            this.cbLoaiNV.TabIndex = 28;
            // 
            // cbTrangThai
            // 
            this.cbTrangThai.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbTrangThai.FormattingEnabled = true;
            this.cbTrangThai.Location = new System.Drawing.Point(977, 300);
            this.cbTrangThai.Margin = new System.Windows.Forms.Padding(2);
            this.cbTrangThai.Name = "cbTrangThai";
            this.cbTrangThai.Size = new System.Drawing.Size(166, 26);
            this.cbTrangThai.TabIndex = 29;
            // 
            // btThêm
            // 
            this.btThêm.BackColor = System.Drawing.Color.MediumPurple;
            this.btThêm.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btThêm.ForeColor = System.Drawing.Color.White;
            this.btThêm.Location = new System.Drawing.Point(834, 351);
            this.btThêm.Margin = new System.Windows.Forms.Padding(2);
            this.btThêm.Name = "btThêm";
            this.btThêm.Size = new System.Drawing.Size(76, 37);
            this.btThêm.TabIndex = 30;
            this.btThêm.Text = "Thêm";
            this.btThêm.UseVisualStyleBackColor = false;
            this.btThêm.Click += new System.EventHandler(this.btThêm_Click);
            // 
            // btCapNhat
            // 
            this.btCapNhat.BackColor = System.Drawing.Color.MediumPurple;
            this.btCapNhat.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCapNhat.ForeColor = System.Drawing.Color.White;
            this.btCapNhat.Location = new System.Drawing.Point(1040, 351);
            this.btCapNhat.Margin = new System.Windows.Forms.Padding(2);
            this.btCapNhat.Name = "btCapNhat";
            this.btCapNhat.Size = new System.Drawing.Size(122, 37);
            this.btCapNhat.TabIndex = 31;
            this.btCapNhat.Text = "Cập nhật";
            this.btCapNhat.UseVisualStyleBackColor = false;
            this.btCapNhat.Click += new System.EventHandler(this.btCapNhat_Click);
            // 
            // btXoa
            // 
            this.btXoa.BackColor = System.Drawing.Color.MediumPurple;
            this.btXoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btXoa.ForeColor = System.Drawing.Color.White;
            this.btXoa.Location = new System.Drawing.Point(933, 351);
            this.btXoa.Margin = new System.Windows.Forms.Padding(2);
            this.btXoa.Name = "btXoa";
            this.btXoa.Size = new System.Drawing.Size(76, 37);
            this.btXoa.TabIndex = 32;
            this.btXoa.Text = "Xóa";
            this.btXoa.UseVisualStyleBackColor = false;
            this.btXoa.Click += new System.EventHandler(this.btXoa_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(424, 305);
            this.label14.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(57, 18);
            this.label14.TabIndex = 33;
            this.label14.Text = "Địa chỉ:";
            // 
            // tbDiaChi
            // 
            this.tbDiaChi.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbDiaChi.Location = new System.Drawing.Point(491, 304);
            this.tbDiaChi.Margin = new System.Windows.Forms.Padding(2);
            this.tbDiaChi.Name = "tbDiaChi";
            this.tbDiaChi.Size = new System.Drawing.Size(322, 24);
            this.tbDiaChi.TabIndex = 34;
            // 
            // FQLNhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Bisque;
            this.ClientSize = new System.Drawing.Size(1370, 749);
            this.Controls.Add(this.tbDiaChi);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.btXoa);
            this.Controls.Add(this.btCapNhat);
            this.Controls.Add(this.btThêm);
            this.Controls.Add(this.cbTrangThai);
            this.Controls.Add(this.cbLoaiNV);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.tbSDT);
            this.Controls.Add(this.tb);
            this.Controls.Add(this.tbEmail);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.tbCMND);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.tbGioiTinh);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.dtpNgaySinh);
            this.Controls.Add(this.tbHoTen);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tbTaiKhoan);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dtpNgayVaoLam);
            this.Controls.Add(this.tbMaNV);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btTim);
            this.Controls.Add(this.tbTimKiem);
            this.Controls.Add(this.cbTimKiem);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgDSNV);
            this.Controls.Add(this.btBack);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FQLNhanVien";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản Lý Nhân Viên";
            this.Load += new System.EventHandler(this.FQLNhanVien_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgDSNV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btBack;
        private System.Windows.Forms.DataGridView dgDSNV;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbTimKiem;
        private System.Windows.Forms.TextBox tbTimKiem;
        private System.Windows.Forms.Button btTim;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbMaNV;
        private System.Windows.Forms.DateTimePicker dtpNgayVaoLam;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbTaiKhoan;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbHoTen;
        private System.Windows.Forms.DateTimePicker dtpNgaySinh;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tbGioiTinh;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox tbCMND;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox tbEmail;
        private System.Windows.Forms.Label tb;
        private System.Windows.Forms.TextBox tbSDT;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox cbLoaiNV;
        private System.Windows.Forms.ComboBox cbTrangThai;
        private System.Windows.Forms.Button btThêm;
        private System.Windows.Forms.Button btCapNhat;
        private System.Windows.Forms.Button btXoa;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox tbDiaChi;
    }
}