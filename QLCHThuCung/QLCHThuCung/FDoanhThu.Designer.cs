
namespace QLCHThuCung
{
    partial class FDoanhThu
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
            this.crDoanhThu = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // crDoanhThu
            // 
            this.crDoanhThu.ActiveViewIndex = -1;
            this.crDoanhThu.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crDoanhThu.Cursor = System.Windows.Forms.Cursors.Default;
            this.crDoanhThu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crDoanhThu.Location = new System.Drawing.Point(0, 0);
            this.crDoanhThu.Name = "crDoanhThu";
            this.crDoanhThu.Size = new System.Drawing.Size(800, 632);
            this.crDoanhThu.TabIndex = 0;
            // 
            // FDoanhThu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 632);
            this.Controls.Add(this.crDoanhThu);
            this.Name = "FDoanhThu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FDoanhThu";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);

        }

        #endregion

        public CrystalDecisions.Windows.Forms.CrystalReportViewer crDoanhThu;
    }
}