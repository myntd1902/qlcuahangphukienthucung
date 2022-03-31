
namespace QLCHThuCung
{
    partial class FChiPhi
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
            this.crChiPhi = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // crChiPhi
            // 
            this.crChiPhi.ActiveViewIndex = -1;
            this.crChiPhi.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crChiPhi.Cursor = System.Windows.Forms.Cursors.Default;
            this.crChiPhi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crChiPhi.Location = new System.Drawing.Point(0, 0);
            this.crChiPhi.Name = "crChiPhi";
            this.crChiPhi.Size = new System.Drawing.Size(800, 450);
            this.crChiPhi.TabIndex = 0;
            // 
            // FChiPhi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.crChiPhi);
            this.Name = "FChiPhi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FChiPhi";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);

        }

        #endregion

        public CrystalDecisions.Windows.Forms.CrystalReportViewer crChiPhi;
    }
}