
namespace QLCHThuCung
{
    partial class FCTDonHang
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
            this.lbQLKH = new System.Windows.Forms.Label();
            this.dgvCTDH = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCTDH)).BeginInit();
            this.SuspendLayout();
            // 
            // lbQLKH
            // 
            this.lbQLKH.AutoSize = true;
            this.lbQLKH.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbQLKH.ForeColor = System.Drawing.Color.MediumPurple;
            this.lbQLKH.Location = new System.Drawing.Point(442, 72);
            this.lbQLKH.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbQLKH.Name = "lbQLKH";
            this.lbQLKH.Size = new System.Drawing.Size(428, 46);
            this.lbQLKH.TabIndex = 5;
            this.lbQLKH.Text = "CHI TIẾT ĐƠN HÀNG";
            // 
            // dgvCTDH
            // 
            this.dgvCTDH.BackgroundColor = System.Drawing.Color.Bisque;
            this.dgvCTDH.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCTDH.Location = new System.Drawing.Point(183, 168);
            this.dgvCTDH.Name = "dgvCTDH";
            this.dgvCTDH.Size = new System.Drawing.Size(1004, 428);
            this.dgvCTDH.TabIndex = 7;
            // 
            // FCTDonHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Bisque;
            this.ClientSize = new System.Drawing.Size(1370, 749);
            this.Controls.Add(this.dgvCTDH);
            this.Controls.Add(this.lbQLKH);
            this.Name = "FCTDonHang";
            this.Text = "FCTDonHang";
            this.Load += new System.EventHandler(this.FCTDonHang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCTDH)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbQLKH;
        private System.Windows.Forms.DataGridView dgvCTDH;
    }
}