
namespace QLCHThuCung
{
    partial class FQLHangHoa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FQLHangHoa));
            this.dgHangHoa = new System.Windows.Forms.DataGridView();
            this.cbTimKiem = new System.Windows.Forms.ComboBox();
            this.tbTimKiem = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btThem = new System.Windows.Forms.Button();
            this.btCapNhat = new System.Windows.Forms.Button();
            this.btXoa = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbTenHH = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cbLoaiHH = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbThuongHieu = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.cbNhaCC = new System.Windows.Forms.ComboBox();
            this.tbGia = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.tbSoLuongTK = new System.Windows.Forms.TextBox();
            this.cbTinhTrang = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.tbMaHH = new System.Windows.Forms.TextBox();
            this.btTim = new System.Windows.Forms.Button();
            this.btBack = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.tbGiaNhap = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgHangHoa)).BeginInit();
            this.SuspendLayout();
            // 
            // dgHangHoa
            // 
            this.dgHangHoa.BackgroundColor = System.Drawing.Color.Bisque;
            this.dgHangHoa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgHangHoa.GridColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgHangHoa.Location = new System.Drawing.Point(101, 403);
            this.dgHangHoa.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgHangHoa.Name = "dgHangHoa";
            this.dgHangHoa.RowHeadersWidth = 51;
            this.dgHangHoa.RowTemplate.Height = 24;
            this.dgHangHoa.Size = new System.Drawing.Size(1051, 295);
            this.dgHangHoa.TabIndex = 0;
            this.dgHangHoa.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgHangHoa_CellClick);
            this.dgHangHoa.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgHangHoa_CellClick);
            // 
            // cbTimKiem
            // 
            this.cbTimKiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbTimKiem.FormattingEnabled = true;
            this.cbTimKiem.Location = new System.Drawing.Point(373, 116);
            this.cbTimKiem.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbTimKiem.Name = "cbTimKiem";
            this.cbTimKiem.Size = new System.Drawing.Size(157, 24);
            this.cbTimKiem.TabIndex = 1;
            // 
            // tbTimKiem
            // 
            this.tbTimKiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbTimKiem.Location = new System.Drawing.Point(533, 116);
            this.tbTimKiem.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbTimKiem.Name = "tbTimKiem";
            this.tbTimKiem.Size = new System.Drawing.Size(348, 24);
            this.tbTimKiem.TabIndex = 2;
            this.tbTimKiem.TextChanged += new System.EventHandler(this.tbTimKiem_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 33.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.MediumPurple;
            this.label1.Location = new System.Drawing.Point(486, 35);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(490, 52);
            this.label1.TabIndex = 3;
            this.label1.Text = "QUẢN LÝ HÀNG HÓA";
            // 
            // btThem
            // 
            this.btThem.BackColor = System.Drawing.Color.MediumPurple;
            this.btThem.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btThem.ForeColor = System.Drawing.Color.White;
            this.btThem.Location = new System.Drawing.Point(862, 338);
            this.btThem.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btThem.Name = "btThem";
            this.btThem.Size = new System.Drawing.Size(93, 43);
            this.btThem.TabIndex = 4;
            this.btThem.Text = "Thêm";
            this.btThem.UseVisualStyleBackColor = false;
            this.btThem.Click += new System.EventHandler(this.btThem_Click);
            // 
            // btCapNhat
            // 
            this.btCapNhat.BackColor = System.Drawing.Color.MediumPurple;
            this.btCapNhat.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCapNhat.ForeColor = System.Drawing.Color.White;
            this.btCapNhat.Location = new System.Drawing.Point(1078, 338);
            this.btCapNhat.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btCapNhat.Name = "btCapNhat";
            this.btCapNhat.Size = new System.Drawing.Size(113, 43);
            this.btCapNhat.TabIndex = 5;
            this.btCapNhat.Text = "Cập nhật";
            this.btCapNhat.UseVisualStyleBackColor = false;
            this.btCapNhat.Click += new System.EventHandler(this.btCapNhat_Click);
            // 
            // btXoa
            // 
            this.btXoa.BackColor = System.Drawing.Color.MediumPurple;
            this.btXoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btXoa.ForeColor = System.Drawing.Color.White;
            this.btXoa.Location = new System.Drawing.Point(967, 338);
            this.btXoa.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btXoa.Name = "btXoa";
            this.btXoa.Size = new System.Drawing.Size(93, 43);
            this.btXoa.TabIndex = 6;
            this.btXoa.Text = "Xóa";
            this.btXoa.UseVisualStyleBackColor = false;
            this.btXoa.Click += new System.EventHandler(this.btXoa_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(98, 252);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 18);
            this.label2.TabIndex = 7;
            this.label2.Text = "Tên hàng hóa:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(57, 155);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(1391, 25);
            this.label3.TabIndex = 8;
            this.label3.Text = "--------Chi tiết hàng hóa--------------------------------------------------------" +
    "--------------------------------------------------------------------------------" +
    "--------------------------------";
            // 
            // tbTenHH
            // 
            this.tbTenHH.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbTenHH.Location = new System.Drawing.Point(214, 247);
            this.tbTenHH.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbTenHH.Name = "tbTenHH";
            this.tbTenHH.Size = new System.Drawing.Size(264, 24);
            this.tbTenHH.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(97, 306);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(105, 18);
            this.label4.TabIndex = 10;
            this.label4.Text = "Loại hàng hóa:";
            // 
            // cbLoaiHH
            // 
            this.cbLoaiHH.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbLoaiHH.FormattingEnabled = true;
            this.cbLoaiHH.Location = new System.Drawing.Point(214, 302);
            this.cbLoaiHH.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbLoaiHH.Name = "cbLoaiHH";
            this.cbLoaiHH.Size = new System.Drawing.Size(204, 26);
            this.cbLoaiHH.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(531, 200);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(93, 18);
            this.label5.TabIndex = 12;
            this.label5.Text = "Thương hiệu:";
            // 
            // tbThuongHieu
            // 
            this.tbThuongHieu.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbThuongHieu.Location = new System.Drawing.Point(643, 197);
            this.tbThuongHieu.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbThuongHieu.Name = "tbThuongHieu";
            this.tbThuongHieu.Size = new System.Drawing.Size(264, 24);
            this.tbThuongHieu.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(530, 252);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(103, 18);
            this.label6.TabIndex = 14;
            this.label6.Text = "Nhà cung cấp:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(530, 306);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(94, 18);
            this.label7.TabIndex = 15;
            this.label7.Text = "Giá niêm yết:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(933, 242);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(77, 18);
            this.label8.TabIndex = 16;
            this.label8.Text = "Tình trạng:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(943, 200);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(138, 18);
            this.label9.TabIndex = 17;
            this.label9.Text = "Số lượng trong kho:";
            // 
            // cbNhaCC
            // 
            this.cbNhaCC.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbNhaCC.FormattingEnabled = true;
            this.cbNhaCC.Location = new System.Drawing.Point(643, 247);
            this.cbNhaCC.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbNhaCC.Name = "cbNhaCC";
            this.cbNhaCC.Size = new System.Drawing.Size(212, 26);
            this.cbNhaCC.TabIndex = 18;
            // 
            // tbGia
            // 
            this.tbGia.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbGia.Location = new System.Drawing.Point(643, 302);
            this.tbGia.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbGia.Name = "tbGia";
            this.tbGia.Size = new System.Drawing.Size(144, 24);
            this.tbGia.TabIndex = 19;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(790, 302);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(39, 18);
            this.label10.TabIndex = 20;
            this.label10.Text = "VND";
            // 
            // tbSoLuongTK
            // 
            this.tbSoLuongTK.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbSoLuongTK.Location = new System.Drawing.Point(1089, 198);
            this.tbSoLuongTK.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbSoLuongTK.Name = "tbSoLuongTK";
            this.tbSoLuongTK.Size = new System.Drawing.Size(72, 24);
            this.tbSoLuongTK.TabIndex = 21;
            // 
            // cbTinhTrang
            // 
            this.cbTinhTrang.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbTinhTrang.FormattingEnabled = true;
            this.cbTinhTrang.Location = new System.Drawing.Point(1023, 237);
            this.cbTinhTrang.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbTinhTrang.Name = "cbTinhTrang";
            this.cbTinhTrang.Size = new System.Drawing.Size(140, 26);
            this.cbTinhTrang.TabIndex = 22;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(279, 116);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(87, 22);
            this.label11.TabIndex = 23;
            this.label11.Text = "Tìm kiếm:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(102, 205);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(98, 18);
            this.label12.TabIndex = 24;
            this.label12.Text = "Mã hàng hóa:";
            // 
            // tbMaHH
            // 
            this.tbMaHH.BackColor = System.Drawing.Color.Bisque;
            this.tbMaHH.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbMaHH.Location = new System.Drawing.Point(214, 202);
            this.tbMaHH.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbMaHH.Name = "tbMaHH";
            this.tbMaHH.ReadOnly = true;
            this.tbMaHH.Size = new System.Drawing.Size(56, 24);
            this.tbMaHH.TabIndex = 25;
            // 
            // btTim
            // 
            this.btTim.BackColor = System.Drawing.Color.MediumPurple;
            this.btTim.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btTim.ForeColor = System.Drawing.Color.White;
            this.btTim.Location = new System.Drawing.Point(884, 112);
            this.btTim.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btTim.Name = "btTim";
            this.btTim.Size = new System.Drawing.Size(89, 32);
            this.btTim.TabIndex = 26;
            this.btTim.Text = "Tìm";
            this.btTim.UseVisualStyleBackColor = false;
            this.btTim.Click += new System.EventHandler(this.button1_Click);
            // 
            // btBack
            // 
            this.btBack.BackColor = System.Drawing.Color.Bisque;
            this.btBack.FlatAppearance.BorderColor = System.Drawing.Color.LightGray;
            this.btBack.FlatAppearance.BorderSize = 0;
            this.btBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btBack.Image = ((System.Drawing.Image)(resources.GetObject("btBack.Image")));
            this.btBack.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btBack.Location = new System.Drawing.Point(24, 20);
            this.btBack.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btBack.Name = "btBack";
            this.btBack.Size = new System.Drawing.Size(107, 31);
            this.btBack.TabIndex = 27;
            this.btBack.Text = "Back";
            this.btBack.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btBack.UseVisualStyleBackColor = false;
            this.btBack.Click += new System.EventHandler(this.btBack_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(900, 298);
            this.label13.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(71, 18);
            this.label13.TabIndex = 28;
            this.label13.Text = "Giá nhập:";
            // 
            // tbGiaNhap
            // 
            this.tbGiaNhap.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbGiaNhap.Location = new System.Drawing.Point(973, 295);
            this.tbGiaNhap.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbGiaNhap.Name = "tbGiaNhap";
            this.tbGiaNhap.Size = new System.Drawing.Size(159, 24);
            this.tbGiaNhap.TabIndex = 29;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(1135, 298);
            this.label14.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(39, 18);
            this.label14.TabIndex = 30;
            this.label14.Text = "VND";
            // 
            // FQLHangHoa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Bisque;
            this.ClientSize = new System.Drawing.Size(1370, 749);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.tbGiaNhap);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.btBack);
            this.Controls.Add(this.btTim);
            this.Controls.Add(this.tbMaHH);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.cbTinhTrang);
            this.Controls.Add(this.tbSoLuongTK);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.tbGia);
            this.Controls.Add(this.cbNhaCC);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tbThuongHieu);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cbLoaiHH);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbTenHH);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btXoa);
            this.Controls.Add(this.btCapNhat);
            this.Controls.Add(this.btThem);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbTimKiem);
            this.Controls.Add(this.cbTimKiem);
            this.Controls.Add(this.dgHangHoa);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FQLHangHoa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FQLHangHoa";
            this.Load += new System.EventHandler(this.FQLHangHoa_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgHangHoa)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgHangHoa;
        private System.Windows.Forms.ComboBox cbTimKiem;
        private System.Windows.Forms.TextBox tbTimKiem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btThem;
        private System.Windows.Forms.Button btCapNhat;
        private System.Windows.Forms.Button btXoa;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbTenHH;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbLoaiHH;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbThuongHieu;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cbNhaCC;
        private System.Windows.Forms.TextBox tbGia;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox tbSoLuongTK;
        private System.Windows.Forms.ComboBox cbTinhTrang;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox tbMaHH;
        private System.Windows.Forms.Button btTim;
        private System.Windows.Forms.Button btBack;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox tbGiaNhap;
        private System.Windows.Forms.Label label14;
    }
}