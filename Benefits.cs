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
    public partial class Benefits : Form
    {
        public Benefits()
        {
            InitializeComponent();
            FillDataListing();
            FillEmployeeListing();
        }

        private void FillEmployeeListing()
        {
            DBConnection cn = new DBConnection();
            MySqlCommand cmd;
            cmd = new MySqlCommand("Select * From employee", cn.con);
            cmd.CommandType = CommandType.Text;
            MySqlDataAdapter sda = new MySqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            benefits_employee_id.ValueMember = "employee_id";
            benefits_employee_id.DisplayMember = "employee_id";
            benefits_employee_id.DataSource = dt;

        }

        private void FillDataListing(String searchText = "")
        {
            this.clearForm();
            DBConnection cn = new DBConnection();
            MySqlCommand cmd;
            if (searchText != "")
            {
                cmd = new MySqlCommand("Select * From benefits WHERE benefits_id LIKE '%" + searchText + "%'", cn.con);
            }
            else
            {
                cmd = new MySqlCommand("Select * From benefits", cn.con);
            }
            cmd.CommandType = CommandType.Text;
            MySqlDataAdapter sda = new MySqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            data_listing.DataSource = dt;
            data_listing.Columns[0].HeaderText = "ID";
            data_listing.Columns[1].HeaderText = "Employee ID";
            data_listing.Columns[2].HeaderText = "Benefit Name";
            data_listing.Columns[3].HeaderText = "Description";
        }

        private void clearForm()
        {
            benefits_id.Text = "";
            benefits_employee_id.Text = "";
            benefits_name.Text = "";
            benefits_description.Text = "";
        }

        private void save_data_Click(object sender, EventArgs e)
        {
            DBConnection cn = new DBConnection();
            String SQL = "INSERT INTO `benefits` (`benefits_employee_id`, `benefits_name`, `benefits_description`) VALUES (@0, @1, @2);";
            MySqlCommand insertCommand = new MySqlCommand(SQL, cn.con);
            insertCommand.Parameters.AddWithValue("@0", benefits_employee_id.Text);
            insertCommand.Parameters.AddWithValue("@1", benefits_name.Text);
            insertCommand.Parameters.AddWithValue("@2", benefits_description.Text);
            insertCommand.ExecuteNonQuery();
            FillDataListing();
            MessageBox.Show("Data Saved Successfully.");
        }

        private void data_listing_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.data_listing.Rows[e.RowIndex];
                benefits_id.Text = row.Cells[0].Value.ToString();
                benefits_employee_id.Text = row.Cells[1].Value.ToString();
                benefits_name.Text = row.Cells[2].Value.ToString();
                benefits_description.Text = row.Cells[3].Value.ToString();
            }
        }

        private void update_data_Click(object sender, EventArgs e)
        {
            if (benefits_id.Text != "")
            {
                DBConnection cn = new DBConnection();
                String SQL = "UPDATE `benefits` SET `benefits_employee_id` = @0, `benefits_name` = @1, `benefits_description` = @2 WHERE `benefits_id` = @3; ";
                MySqlCommand insertCommand = new MySqlCommand(SQL, cn.con);
                insertCommand.Parameters.AddWithValue("@0", benefits_employee_id.Text);
                insertCommand.Parameters.AddWithValue("@1", benefits_name.Text);
                insertCommand.Parameters.AddWithValue("@2", benefits_description.Text);
                insertCommand.Parameters.AddWithValue("@3", benefits_id.Text);
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
            if (benefits_id.Text != "")
            {
                String SQL = "DELETE FROM benefits WHERE benefits_id = " + benefits_id.Text;
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

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void benefits_description_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void Benefits_Load(object sender, EventArgs e)
        {

        }
    }
}
