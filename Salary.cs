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
    public partial class Salary : Form
    {
        public Salary()
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
            salary_employee_id.ValueMember = "employee_id";
            salary_employee_id.DisplayMember = "employee_id";
            salary_employee_id.DataSource = dt;

        }

        private void FillDataListing(String searchText = "")
        {
            this.clearForm();
            DBConnection cn = new DBConnection();
            MySqlCommand cmd;
            if (searchText != "")
            {
                cmd = new MySqlCommand("Select * From salary WHERE salary_id LIKE '%" + searchText + "%'", cn.con);
            }
            else
            {
                cmd = new MySqlCommand("Select * From salary", cn.con);
            }
            cmd.CommandType = CommandType.Text;
            MySqlDataAdapter sda = new MySqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            data_listing.DataSource = dt;
            data_listing.Columns[0].HeaderText = "ID";
            data_listing.Columns[1].HeaderText = "Employee ID";
            data_listing.Columns[2].HeaderText = "Month";
            data_listing.Columns[3].HeaderText = "Amount";
            data_listing.Columns[4].HeaderText = "Date";
            data_listing.Columns[5].HeaderText = "Description";
        }

        private void clearForm()
        {
            salary_id.Text = "";
            salary_employee_id.Text = "";
            salary_month.Text = "";
            salary_amount.Text = "";
            salary_date.Text = "";
            salary_description.Text = "";
        }

        private void save_data_Click(object sender, EventArgs e)
        {
            DBConnection cn = new DBConnection();
            String SQL = "INSERT INTO `salary` (`salary_employee_id`, `salary_month`, `salary_amount`, `salary_date`, `salary_description`) VALUES (@0, @1, @2, @3, @4);";
            MySqlCommand insertCommand = new MySqlCommand(SQL, cn.con);
            insertCommand.Parameters.AddWithValue("@0", salary_employee_id.Text);
            insertCommand.Parameters.AddWithValue("@1", salary_month.Text);
            insertCommand.Parameters.AddWithValue("@2", salary_amount.Text);
            insertCommand.Parameters.AddWithValue("@3", salary_date.Text);
            insertCommand.Parameters.AddWithValue("@4", salary_description.Text);
            insertCommand.ExecuteNonQuery();
            FillDataListing();
            MessageBox.Show("Data Saved Successfully.");
        }

        private void data_listing_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.data_listing.Rows[e.RowIndex];
                salary_id.Text = row.Cells[0].Value.ToString();
                salary_employee_id.Text = row.Cells[1].Value.ToString();
                salary_month.Text = row.Cells[2].Value.ToString();
                salary_amount.Text = row.Cells[3].Value.ToString();
                salary_date.Text = row.Cells[4].Value.ToString();
                salary_description.Text = row.Cells[5].Value.ToString();
            }
        }

        private void update_data_Click(object sender, EventArgs e)
        {
            if (salary_id.Text != "")
            {
                DBConnection cn = new DBConnection();
                String SQL = "UPDATE `salary` SET `salary_employee_id` = @0, `salary_month` = @1, `salary_amount` = @2, `salary_date` = @3, `salary_description` = @4 WHERE `salary_id` = @5; ";
                MySqlCommand insertCommand = new MySqlCommand(SQL, cn.con);
                insertCommand.Parameters.AddWithValue("@0", salary_employee_id.Text);
                insertCommand.Parameters.AddWithValue("@1", salary_month.Text);
                insertCommand.Parameters.AddWithValue("@2", salary_amount.Text);
                insertCommand.Parameters.AddWithValue("@3", salary_date.Text);
                insertCommand.Parameters.AddWithValue("@4", salary_description.Text);
                insertCommand.Parameters.AddWithValue("@5", salary_id.Text);
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
            if (salary_id.Text != "")
            {
                String SQL = "DELETE FROM salary WHERE salary_id = " + salary_id.Text;
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

        private void Salary_Load(object sender, EventArgs e)
        {

        }
    }
}
