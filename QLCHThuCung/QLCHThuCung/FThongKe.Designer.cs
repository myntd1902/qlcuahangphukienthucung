
namespace QLCHThuCung
{
    partial class FThongKe
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FThongKe));
            this.dtpNgayBD = new System.Windows.Forms.DateTimePicker();
            this.dtpNgayKT = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btDoanhThu = new System.Windows.Forms.Button();
            this.btChiPhi = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.btBack = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // dtpNgayBD
            // 
            this.dtpNgayBD.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpNgayBD.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpNgayBD.Location = new System.Drawing.Point(526, 230);
            this.dtpNgayBD.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dtpNgayBD.Name = "dtpNgayBD";
            this.dtpNgayBD.Size = new System.Drawing.Size(335, 30);
            this.dtpNgayBD.TabIndex = 0;
            this.dtpNgayBD.ValueChanged += new System.EventHandler(this.dtpNgayBD_ValueChanged);
            // 
            // dtpNgayKT
            // 
            this.dtpNgayKT.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpNgayKT.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpNgayKT.Location = new System.Drawing.Point(526, 323);
            this.dtpNgayKT.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dtpNgayKT.Name = "dtpNgayKT";
            this.dtpNgayKT.Size = new System.Drawing.Size(335, 30);
            this.dtpNgayKT.TabIndex = 1;
            this.dtpNgayKT.ValueChanged += new System.EventHandler(this.dtpNgayKT_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(348, 235);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Ngày bắt đầu:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(348, 323);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(137, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "Ngày kết thúc:";
            // 
            // btDoanhThu
            // 
            this.btDoanhThu.BackColor = System.Drawing.Color.Bisque;
            this.btDoanhThu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btDoanhThu.ForeColor = System.Drawing.Color.Black;
            this.btDoanhThu.Location = new System.Drawing.Point(526, 449);
            this.btDoanhThu.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btDoanhThu.Name = "btDoanhThu";
            this.btDoanhThu.Size = new System.Drawing.Size(132, 89);
            this.btDoanhThu.TabIndex = 4;
            this.btDoanhThu.Text = "Thống kê doanh thu hàng hóa";
            this.btDoanhThu.UseVisualStyleBackColor = false;
            this.btDoanhThu.Click += new System.EventHandler(this.btDoanhThu_Click);
            // 
            // btChiPhi
            // 
            this.btChiPhi.BackColor = System.Drawing.Color.Bisque;
            this.btChiPhi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btChiPhi.ForeColor = System.Drawing.Color.Black;
            this.btChiPhi.Location = new System.Drawing.Point(720, 449);
            this.btChiPhi.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btChiPhi.Name = "btChiPhi";
            this.btChiPhi.Size = new System.Drawing.Size(118, 89);
            this.btChiPhi.TabIndex = 5;
            this.btChiPhi.Text = "Thống kê tổng chi phí";
            this.btChiPhi.UseVisualStyleBackColor = false;
            this.btChiPhi.Click += new System.EventHandler(this.btChiPhi_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.MediumPurple;
            this.label3.Location = new System.Drawing.Point(551, 102);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(236, 46);
            this.label3.TabIndex = 6;
            this.label3.Text = "THỐNG KÊ";
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
            this.btBack.Location = new System.Drawing.Point(11, 20);
            this.btBack.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btBack.Name = "btBack";
            this.btBack.Size = new System.Drawing.Size(107, 31);
            this.btBack.TabIndex = 27;
            this.btBack.Text = "Back";
            this.btBack.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btBack.UseVisualStyleBackColor = false;
            this.btBack.Click += new System.EventHandler(this.btBack_Click);
            // 
            // FThongKe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Bisque;
            this.ClientSize = new System.Drawing.Size(1370, 749);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btChiPhi);
            this.Controls.Add(this.btDoanhThu);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtpNgayKT);
            this.Controls.Add(this.dtpNgayBD);
            this.Controls.Add(this.btBack);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FThongKe";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FThongKe";
            this.Load += new System.EventHandler(this.FThongKe_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtpNgayBD;
        private System.Windows.Forms.DateTimePicker dtpNgayKT;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btDoanhThu;
        private System.Windows.Forms.Button btChiPhi;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btBack;
    }
}