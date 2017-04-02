namespace HRMS
{
    partial class Employee
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
            this.employee_id = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.find_data = new System.Windows.Forms.Button();
            this.delete_data = new System.Windows.Forms.Button();
            this.update_data = new System.Windows.Forms.Button();
            this.save_data = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.findData = new System.Windows.Forms.GroupBox();
            this.searchData = new System.Windows.Forms.Button();
            this.search_text = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.Salary = new System.Windows.Forms.Label();
            this.data_listing = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.employee_country = new System.Windows.Forms.TextBox();
            this.employee_pincode = new System.Windows.Forms.TextBox();
            this.employee_add1 = new System.Windows.Forms.TextBox();
            this.employee_designation_id = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.employee_email = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.employee_state = new System.Windows.Forms.TextBox();
            this.employee_city = new System.Windows.Forms.TextBox();
            this.employee_dob = new System.Windows.Forms.DateTimePicker();
            this.employee_mobile = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.employee_salary = new System.Windows.Forms.TextBox();
            this.employee_name = new System.Windows.Forms.TextBox();
            this.employee_add2 = new System.Windows.Forms.TextBox();
            this.groupBox2.SuspendLayout();
            this.findData.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.data_listing)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // employee_id
            // 
            this.employee_id.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.employee_id.Location = new System.Drawing.Point(211, 19);
            this.employee_id.Name = "employee_id";
            this.employee_id.Size = new System.Drawing.Size(46, 25);
            this.employee_id.TabIndex = 13;
            this.employee_id.Visible = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(256, 132);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Address 2";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 132);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Address 1";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.find_data);
            this.groupBox2.Controls.Add(this.delete_data);
            this.groupBox2.Controls.Add(this.update_data);
            this.groupBox2.Controls.Add(this.save_data);
            this.groupBox2.Location = new System.Drawing.Point(24, 270);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(482, 54);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            // 
            // find_data
            // 
            this.find_data.Location = new System.Drawing.Point(309, 16);
            this.find_data.Name = "find_data";
            this.find_data.Size = new System.Drawing.Size(75, 29);
            this.find_data.TabIndex = 3;
            this.find_data.Text = "Find";
            this.find_data.UseVisualStyleBackColor = true;
            this.find_data.Click += new System.EventHandler(this.find_data_Click);
            // 
            // delete_data
            // 
            this.delete_data.Location = new System.Drawing.Point(228, 16);
            this.delete_data.Name = "delete_data";
            this.delete_data.Size = new System.Drawing.Size(75, 29);
            this.delete_data.TabIndex = 2;
            this.delete_data.Text = "Delete";
            this.delete_data.UseVisualStyleBackColor = true;
            this.delete_data.Click += new System.EventHandler(this.delete_data_Click);
            // 
            // update_data
            // 
            this.update_data.Location = new System.Drawing.Point(147, 16);
            this.update_data.Name = "update_data";
            this.update_data.Size = new System.Drawing.Size(75, 29);
            this.update_data.TabIndex = 1;
            this.update_data.Text = "Update";
            this.update_data.UseVisualStyleBackColor = true;
            this.update_data.Click += new System.EventHandler(this.update_data_Click);
            // 
            // save_data
            // 
            this.save_data.Location = new System.Drawing.Point(66, 16);
            this.save_data.Name = "save_data";
            this.save_data.Size = new System.Drawing.Size(75, 29);
            this.save_data.TabIndex = 0;
            this.save_data.Text = "Save";
            this.save_data.UseVisualStyleBackColor = true;
            this.save_data.Click += new System.EventHandler(this.save_data_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(255, 100);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Date of Birth";
            // 
            // findData
            // 
            this.findData.BackColor = System.Drawing.Color.Silver;
            this.findData.Controls.Add(this.searchData);
            this.findData.Controls.Add(this.search_text);
            this.findData.Controls.Add(this.label7);
            this.findData.Location = new System.Drawing.Point(95, 59);
            this.findData.Name = "findData";
            this.findData.Size = new System.Drawing.Size(276, 134);
            this.findData.TabIndex = 14;
            this.findData.TabStop = false;
            this.findData.Text = " Search Employee";
            this.findData.Visible = false;
            // 
            // searchData
            // 
            this.searchData.Location = new System.Drawing.Point(110, 94);
            this.searchData.Name = "searchData";
            this.searchData.Size = new System.Drawing.Size(75, 23);
            this.searchData.TabIndex = 2;
            this.searchData.Text = "Search Data";
            this.searchData.UseVisualStyleBackColor = true;
            this.searchData.Click += new System.EventHandler(this.searchData_Click);
            // 
            // search_text
            // 
            this.search_text.Location = new System.Drawing.Point(151, 48);
            this.search_text.Name = "search_text";
            this.search_text.Size = new System.Drawing.Size(100, 20);
            this.search_text.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(52, 50);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(84, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "Employee Name";
            // 
            // Salary
            // 
            this.Salary.AutoSize = true;
            this.Salary.Location = new System.Drawing.Point(4, 98);
            this.Salary.Name = "Salary";
            this.Salary.Size = new System.Drawing.Size(36, 13);
            this.Salary.TabIndex = 9;
            this.Salary.Text = "Salary";
            // 
            // data_listing
            // 
            this.data_listing.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.data_listing.Location = new System.Drawing.Point(24, 331);
            this.data_listing.Name = "data_listing";
            this.data_listing.ReadOnly = true;
            this.data_listing.Size = new System.Drawing.Size(482, 149);
            this.data_listing.TabIndex = 4;
            this.data_listing.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.data_listing_CellContentClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(255, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Contact No.";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.employee_country);
            this.groupBox1.Controls.Add(this.employee_pincode);
            this.groupBox1.Controls.Add(this.findData);
            this.groupBox1.Controls.Add(this.employee_add1);
            this.groupBox1.Controls.Add(this.employee_designation_id);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.employee_email);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.employee_state);
            this.groupBox1.Controls.Add(this.employee_city);
            this.groupBox1.Controls.Add(this.employee_id);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.Salary);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.employee_dob);
            this.groupBox1.Controls.Add(this.employee_mobile);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.employee_salary);
            this.groupBox1.Controls.Add(this.employee_name);
            this.groupBox1.Controls.Add(this.employee_add2);
            this.groupBox1.Location = new System.Drawing.Point(24, 18);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(482, 246);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(256, 200);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(43, 13);
            this.label12.TabIndex = 27;
            this.label12.Text = "Country";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(4, 197);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(46, 13);
            this.label13.TabIndex = 26;
            this.label13.Text = "Pincode";
            // 
            // employee_country
            // 
            this.employee_country.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.employee_country.Location = new System.Drawing.Point(330, 191);
            this.employee_country.Name = "employee_country";
            this.employee_country.Size = new System.Drawing.Size(131, 25);
            this.employee_country.TabIndex = 25;
            // 
            // employee_pincode
            // 
            this.employee_pincode.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.employee_pincode.Location = new System.Drawing.Point(75, 191);
            this.employee_pincode.Name = "employee_pincode";
            this.employee_pincode.Size = new System.Drawing.Size(131, 25);
            this.employee_pincode.TabIndex = 24;
            // 
            // employee_add1
            // 
            this.employee_add1.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.employee_add1.Location = new System.Drawing.Point(75, 123);
            this.employee_add1.Name = "employee_add1";
            this.employee_add1.Size = new System.Drawing.Size(131, 25);
            this.employee_add1.TabIndex = 23;
            // 
            // employee_designation_id
            // 
            this.employee_designation_id.FormattingEnabled = true;
            this.employee_designation_id.Location = new System.Drawing.Point(74, 62);
            this.employee_designation_id.Name = "employee_designation_id";
            this.employee_designation_id.Size = new System.Drawing.Size(132, 21);
            this.employee_designation_id.TabIndex = 22;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(255, 66);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(32, 13);
            this.label10.TabIndex = 21;
            this.label10.Text = "Email";
            // 
            // employee_email
            // 
            this.employee_email.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.employee_email.Location = new System.Drawing.Point(330, 60);
            this.employee_email.Name = "employee_email";
            this.employee_email.Size = new System.Drawing.Size(131, 25);
            this.employee_email.TabIndex = 20;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(3, 65);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(63, 13);
            this.label11.TabIndex = 19;
            this.label11.Text = "Designation";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(256, 167);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(32, 13);
            this.label8.TabIndex = 17;
            this.label8.Text = "State";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(4, 164);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(24, 13);
            this.label9.TabIndex = 16;
            this.label9.Text = "City";
            // 
            // employee_state
            // 
            this.employee_state.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.employee_state.Location = new System.Drawing.Point(330, 160);
            this.employee_state.Name = "employee_state";
            this.employee_state.Size = new System.Drawing.Size(131, 25);
            this.employee_state.TabIndex = 15;
            // 
            // employee_city
            // 
            this.employee_city.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.employee_city.Location = new System.Drawing.Point(75, 158);
            this.employee_city.Name = "employee_city";
            this.employee_city.Size = new System.Drawing.Size(131, 25);
            this.employee_city.TabIndex = 14;
            // 
            // employee_dob
            // 
            this.employee_dob.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.employee_dob.Location = new System.Drawing.Point(330, 98);
            this.employee_dob.Name = "employee_dob";
            this.employee_dob.Size = new System.Drawing.Size(131, 25);
            this.employee_dob.TabIndex = 7;
            // 
            // employee_mobile
            // 
            this.employee_mobile.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.employee_mobile.Location = new System.Drawing.Point(330, 28);
            this.employee_mobile.Name = "employee_mobile";
            this.employee_mobile.Size = new System.Drawing.Size(131, 25);
            this.employee_mobile.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Name";
            // 
            // employee_salary
            // 
            this.employee_salary.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.employee_salary.Location = new System.Drawing.Point(75, 91);
            this.employee_salary.Name = "employee_salary";
            this.employee_salary.Size = new System.Drawing.Size(131, 25);
            this.employee_salary.TabIndex = 1;
            // 
            // employee_name
            // 
            this.employee_name.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.employee_name.Location = new System.Drawing.Point(74, 28);
            this.employee_name.Name = "employee_name";
            this.employee_name.Size = new System.Drawing.Size(131, 25);
            this.employee_name.TabIndex = 0;
            // 
            // employee_add2
            // 
            this.employee_add2.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.employee_add2.Location = new System.Drawing.Point(330, 130);
            this.employee_add2.Name = "employee_add2";
            this.employee_add2.Size = new System.Drawing.Size(131, 25);
            this.employee_add2.TabIndex = 28;
            // 
            // Employee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(526, 496);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.data_listing);
            this.Controls.Add(this.groupBox1);
            this.Name = "Employee";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " Employee Management";
            this.Load += new System.EventHandler(this.Car_Load);
            this.groupBox2.ResumeLayout(false);
            this.findData.ResumeLayout(false);
            this.findData.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.data_listing)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox employee_id;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button find_data;
        private System.Windows.Forms.Button delete_data;
        private System.Windows.Forms.Button update_data;
        private System.Windows.Forms.Button save_data;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox findData;
        private System.Windows.Forms.Button searchData;
        private System.Windows.Forms.TextBox search_text;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label Salary;
        private System.Windows.Forms.DataGridView data_listing;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker employee_dob;
        private System.Windows.Forms.TextBox employee_mobile;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox employee_salary;
        private System.Windows.Forms.TextBox employee_name;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox employee_state;
        private System.Windows.Forms.TextBox employee_city;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox employee_email;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox employee_designation_id;
        private System.Windows.Forms.TextBox employee_add1;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox employee_country;
        private System.Windows.Forms.TextBox employee_pincode;
        private System.Windows.Forms.TextBox employee_add2;
    }
}