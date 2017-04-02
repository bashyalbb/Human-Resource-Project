namespace HRMS
{
    partial class BenefitsReport
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
            this.data_listing = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.data_listing)).BeginInit();
            this.SuspendLayout();
            // 
            // data_listing
            // 
            this.data_listing.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.data_listing.Location = new System.Drawing.Point(12, 23);
            this.data_listing.Name = "data_listing";
            this.data_listing.ReadOnly = true;
            this.data_listing.Size = new System.Drawing.Size(714, 418);
            this.data_listing.TabIndex = 2;
            // 
            // BenefitsReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(738, 469);
            this.Controls.Add(this.data_listing);
            this.Name = "BenefitsReport";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Employee Benefits Report";
            this.Load += new System.EventHandler(this.BenefitsReport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.data_listing)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView data_listing;
    }
}