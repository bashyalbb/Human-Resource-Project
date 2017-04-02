using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace HRMS
{
    public partial class Employee : Form
    {
        public Employee()
        {
            InitializeComponent();
            FillDataListing();
            FillCategoryListing();
        }

        private void FillCategoryListing()
        {
            DBConnection cn = new DBConnection();
            MySqlCommand cmd;
            cmd = new MySqlCommand("Select * From designation", cn.con);
            cmd.CommandType = CommandType.Text;
            MySqlDataAdapter sda = new MySqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            employee_designation_id.ValueMember = "designation_id";
            employee_designation_id.DisplayMember = "designation_title";
            employee_designation_id.DataSource = dt;
            
        }

        private void FillDataListing(String searchText = "")
        {
            this.clearForm();
            DBConnection cn = new DBConnection();
            MySqlCommand cmd;
            if (searchText != "")
            {
                cmd = new MySqlCommand("Select * From employee WHERE employee_name LIKE '%" + searchText + "%'", cn.con);
            }
            else
            {
                cmd = new MySqlCommand("Select * From employee", cn.con);
            }
            cmd.CommandType = CommandType.Text;
            MySqlDataAdapter sda = new MySqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            data_listing.DataSource = dt;
            data_listing.Columns[0].HeaderText = "ID";
            data_listing.Columns[1].HeaderText = "Name";
            data_listing.Columns[2].HeaderText = "Designation";
            data_listing.Columns[3].HeaderText = "Mobile";
            data_listing.Columns[4].HeaderText = "Email";
            data_listing.Columns[5].HeaderText = "Salary";
            data_listing.Columns[6].HeaderText = "Color";
            data_listing.Columns[7].HeaderText = "Date of Birth";
            data_listing.Columns[8].HeaderText = "Address 1";
            data_listing.Columns[9].HeaderText = "Address 2";
            data_listing.Columns[10].HeaderText = "City";
            data_listing.Columns[10].HeaderText = "State";
            data_listing.Columns[10].HeaderText = "Pincode";
            data_listing.Columns[10].HeaderText = "Country";
        }

        private void clearForm()
        {
            employee_designation_id.Text = "";
            employee_name.Text = "";
            employee_mobile.Text = "";
            employee_salary.Text = "";
            
            employee_add1.Text = "";
            employee_dob.Text = "";
            employee_city.Text = "";
            employee_email.Text = "";
            employee_state.Text = "";
            employee_id.Text = "";

        }

        private void save_data_Click(object sender, EventArgs e)
        {
            DBConnection cn = new DBConnection();
            String SQL = "INSERT INTO `employee` (`employee_name`, `employee_designation_id`, `employee_mobile`, `employee_email`, `employee_salary`, `employee_dob`, `employee_add1`, `employee_add2`, `employee_city`, `employee_state`, `employee_pincode`, `employee_country`) VALUES (@0, @1, @2, @3, @4, @5, @6, @7, @8, @9, @10, @11);";
            MySqlCommand insertCommand = new MySqlCommand(SQL, cn.con);
            insertCommand.Parameters.AddWithValue("@0", employee_name.Text);
            insertCommand.Parameters.AddWithValue("@1", employee_designation_id.Text);
            insertCommand.Parameters.AddWithValue("@2", employee_mobile.Text);
            insertCommand.Parameters.AddWithValue("@3", employee_email.Text);
            insertCommand.Parameters.AddWithValue("@4", employee_salary.Text);
            insertCommand.Parameters.AddWithValue("@5", employee_dob.Text);
            insertCommand.Parameters.AddWithValue("@6", employee_add1.Text);
            insertCommand.Parameters.AddWithValue("@7", employee_add2.Text);
            insertCommand.Parameters.AddWithValue("@8", employee_city.Text);
            insertCommand.Parameters.AddWithValue("@9", employee_state.Text);
            insertCommand.Parameters.AddWithValue("@10", employee_pincode.Text);
            insertCommand.Parameters.AddWithValue("@11", employee_country.Text);
            insertCommand.ExecuteNonQuery();
            FillDataListing();
            MessageBox.Show("Data Saved Successfully.");
        }

        private void data_listing_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.data_listing.Rows[e.RowIndex];
                employee_id.Text = row.Cells[0].Value.ToString();
                employee_name.Text = row.Cells[1].Value.ToString();
                employee_designation_id.Text = row.Cells[2].Value.ToString();
                employee_mobile.Text = row.Cells[3].Value.ToString();
                employee_email.Text = row.Cells[4].Value.ToString();
                employee_salary.Text = row.Cells[5].Value.ToString();
                employee_dob.Text = row.Cells[6].Value.ToString();
                employee_add1.Text = row.Cells[7].Value.ToString();
                employee_add2.Text = row.Cells[8].Value.ToString();
                employee_city.Text = row.Cells[9].Value.ToString();
                employee_state.Text = row.Cells[10].Value.ToString();
                employee_pincode.Text = row.Cells[11].Value.ToString();
                employee_country.Text = row.Cells[12].Value.ToString();
            }
        }

        private void Car_Load(object sender, EventArgs e)
        {
            
        }

        private void update_data_Click(object sender, EventArgs e)
        {
            if (employee_id.Text != "")
            {
                DBConnection cn = new DBConnection();
                String SQL = "UPDATE `employee` SET `employee_name` = @0, `employee_designation_id` = @1, `employee_mobile` = @2, `employee_email` = @3, `employee_salary` = @4, `employee_dob` = @5, `employee_add1` = @6, `employee_add2` = @7, `employee_city` = @8, `employee_state` = @9, `employee_pincode` = @10, `employee_country` = @11 WHERE `employee_id` = @12; ";
                MySqlCommand insertCommand = new MySqlCommand(SQL, cn.con);
                insertCommand.Parameters.AddWithValue("@0", employee_name.Text);
                insertCommand.Parameters.AddWithValue("@1", employee_designation_id.Text);
                insertCommand.Parameters.AddWithValue("@2", employee_mobile.Text);
                insertCommand.Parameters.AddWithValue("@3", employee_email.Text);
                insertCommand.Parameters.AddWithValue("@4", employee_salary.Text);
                insertCommand.Parameters.AddWithValue("@5", employee_dob.Text);
                insertCommand.Parameters.AddWithValue("@6", employee_add1.Text);
                insertCommand.Parameters.AddWithValue("@7", employee_add2.Text);
                insertCommand.Parameters.AddWithValue("@8", employee_city.Text);
                insertCommand.Parameters.AddWithValue("@9", employee_state.Text);
                insertCommand.Parameters.AddWithValue("@10", employee_pincode.Text);
                insertCommand.Parameters.AddWithValue("@11", employee_country.Text);
                insertCommand.Parameters.AddWithValue("@12", employee_id.Text);
                insertCommand.ExecuteNonQuery();
                FillDataListing();
                clearForm();

                MessageBox.Show("Data Updated Successfully.");
            }
            else
            {
                MessageBox.Show("Select the record to update.");
            }
        }

        private void delete_data_Click(object sender, EventArgs e)
        {
            DBConnection cn = new DBConnection();
            if (employee_id.Text != "")
            {
                String SQL = "DELETE FROM employee WHERE employee_id = " + employee_id.Text;
                MySqlCommand command = new MySqlCommand(SQL, cn.con);
                command.ExecuteNonQuery();
                FillDataListing();
                MessageBox.Show("Data Deleted Successfully.");
            }
            else
            {
                MessageBox.Show("Select the record to delete.");
            }
        }

        private void find_data_Click(object sender, EventArgs e)
        {
            findData.Visible = true;
        }

        private void searchData_Click(object sender, EventArgs e)
        {
            findData.Visible = false;
            FillDataListing(search_text.Text);
            search_text.Text = "";
        }
    }
}
