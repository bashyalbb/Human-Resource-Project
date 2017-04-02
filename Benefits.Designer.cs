namespace HRMS
{
    partial class Benefits
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
            this.findData = new System.Windows.Forms.GroupBox();
            this.searchData = new System.Windows.Forms.Button();
            this.search_text = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.benefits_name = new System.Windows.Forms.TextBox();
            this.benefits_employee_id = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.benefits_id = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.benefits_description = new System.Windows.Forms.TextBox();
            this.data_listing = new System.Windows.Forms.DataGridView();
            this.find_data = new System.Windows.Forms.Button();
            this.delete_data = new System.Windows.Forms.Button();
            this.update_data = new System.Windows.Forms.Button();
            this.save_data = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.findData.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.data_listing)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // findData
            // 
            this.findData.BackColor = System.Drawing.Color.Silver;
            this.findData.Controls.Add(this.searchData);
            this.findData.Controls.Add(this.search_text);
            this.findData.Controls.Add(this.label7);
            this.findData.Location = new System.Drawing.Point(108, 20);
            this.findData.Name = "findData";
            this.findData.Size = new System.Drawing.Size(276, 57);
            this.findData.TabIndex = 14;
            this.findData.TabStop = false;
            this.findData.Text = " Search Benefits";
            this.findData.Visible = false;
            // 
            // searchData
            // 
            this.searchData.Location = new System.Drawing.Point(193, 23);
            this.searchData.Name = "searchData";
            this.searchData.Size = new System.Drawing.Size(75, 23);
            this.searchData.TabIndex = 2;
            this.searchData.Text = "Search Data";
            this.searchData.UseVisualStyleBackColor = true;
            this.searchData.Click += new System.EventHandler(this.searchData_Click);
            // 
            // search_text
            // 
            this.search_text.Location = new System.Drawing.Point(87, 21);
            this.search_text.Name = "search_text";
            this.search_text.Size = new System.Drawing.Size(100, 20);
            this.search_text.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(22, 24);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(59, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "Benefits ID";
            // 
            // benefits_name
            // 
            this.benefits_name.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.benefits_name.Location = new System.Drawing.Point(85, 51);
            this.benefits_name.Name = "benefits_name";
            this.benefits_name.Size = new System.Drawing.Size(131, 25);
            this.benefits_name.TabIndex = 23;
            // 
            // benefits_employee_id
            // 
            this.benefits_employee_id.FormattingEnabled = true;
            this.benefits_employee_id.Location = new System.Drawing.Point(228, 11);
            this.benefits_employee_id.Name = "benefits_employee_id";
            this.benefits_employee_id.Size = new System.Drawing.Size(132, 21);
            this.benefits_employee_id.TabIndex = 22;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(130, 19);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(86, 13);
            this.label11.TabIndex = 19;
            this.label11.Text = "Select Employee";
            // 
            // benefits_id
            // 
            this.benefits_id.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.benefits_id.Location = new System.Drawing.Point(376, 11);
            this.benefits_id.Name = "benefits_id";
            this.benefits_id.Size = new System.Drawing.Size(46, 25);
            this.benefits_id.TabIndex = 13;
            this.benefits_id.Visible = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(249, 52);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Description";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 60);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Status";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // benefits_description
            // 
            this.benefits_description.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.benefits_description.Location = new System.Drawing.Point(341, 50);
            this.benefits_description.Name = "benefits_description";
            this.benefits_description.Size = new System.Drawing.Size(131, 25);
            this.benefits_description.TabIndex = 28;
            // 
            // data_listing
            // 
            this.data_listing.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.data_listing.Location = new System.Drawing.Point(21, 180);
            this.data_listing.Name = "data_listing";
            this.data_listing.ReadOnly = true;
            this.data_listing.Size = new System.Drawing.Size(482, 148);
            this.data_listing.TabIndex = 7;
            this.data_listing.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.data_listing_CellContentClick);
            // 
            // find_data
            // 
            this.find_data.Location = new System.Drawing.Point(309, 14);
            this.find_data.Name = "find_data";
            this.find_data.Size = new System.Drawing.Size(75, 29);
            this.find_data.TabIndex = 3;
            this.find_data.Text = "Find";
            this.find_data.UseVisualStyleBackColor = true;
            this.find_data.Click += new System.EventHandler(this.find_data_Click);
            // 
            // delete_data
            // 
            this.delete_data.Location = new System.Drawing.Point(228, 14);
            this.delete_data.Name = "delete_data";
            this.delete_data.Size = new System.Drawing.Size(75, 29);
            this.delete_data.TabIndex = 2;
            this.delete_data.Text = "Delete";
            this.delete_data.UseVisualStyleBackColor = true;
            this.delete_data.Click += new System.EventHandler(this.delete_data_Click);
            // 
            // update_data
            // 
            this.update_data.Location = new System.Drawing.Point(147, 14);
            this.update_data.Name = "update_data";
            this.update_data.Size = new System.Drawing.Size(75, 29);
            this.update_data.TabIndex = 1;
            this.update_data.Text = "Update";
            this.update_data.UseVisualStyleBackColor = true;
            this.update_data.Click += new System.EventHandler(this.update_data_Click);
            // 
            // save_data
            // 
            this.save_data.Location = new System.Drawing.Point(66, 14);
            this.save_data.Name = "save_data";
            this.save_data.Size = new System.Drawing.Size(75, 29);
            this.save_data.TabIndex = 0;
            this.save_data.Text = "Save";
            this.save_data.UseVisualStyleBackColor = true;
            this.save_data.Click += new System.EventHandler(this.save_data_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.find_data);
            this.groupBox2.Controls.Add(this.delete_data);
            this.groupBox2.Controls.Add(this.update_data);
            this.groupBox2.Controls.Add(this.save_data);
            this.groupBox2.Location = new System.Drawing.Point(21, 114);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(482, 54);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.findData);
            this.groupBox1.Controls.Add(this.benefits_name);
            this.groupBox1.Controls.Add(this.benefits_employee_id);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.benefits_id);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.benefits_description);
            this.groupBox1.Location = new System.Drawing.Point(21, 11);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(482, 95);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            // 
            // Benefits
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(517, 343);
            this.Controls.Add(this.data_listing);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Benefits";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Benefits Management";
            this.Load += new System.EventHandler(this.Benefits_Load);
            this.findData.ResumeLayout(false);
            this.findData.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.data_listing)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox findData;
        private System.Windows.Forms.Button searchData;
        private System.Windows.Forms.TextBox search_text;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox benefits_name;
        private System.Windows.Forms.ComboBox benefits_employee_id;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox benefits_id;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox benefits_description;
        private System.Windows.Forms.DataGridView data_listing;
        private System.Windows.Forms.Button find_data;
        private System.Windows.Forms.Button delete_data;
        private System.Windows.Forms.Button update_data;
        private System.Windows.Forms.Button save_data;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}