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
    public partial class Attandance : Form
    {
        public Attandance()
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
            attandance_employee_id.ValueMember = "employee_id";
            attandance_employee_id.DisplayMember = "employee_id";
            attandance_employee_id.DataSource = dt;

        }

        private void FillDataListing(String searchText = "")
        {
            this.clearForm();
            DBConnection cn = new DBConnection();
            MySqlCommand cmd;
            if (searchText != "")
            {
                cmd = new MySqlCommand("Select * From attandance WHERE attandance_id LIKE '%" + searchText + "%'", cn.con);
            }
            else
            {
                cmd = new MySqlCommand("Select * From attandance", cn.con);
            }
            cmd.CommandType = CommandType.Text;
            MySqlDataAdapter sda = new MySqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            data_listing.DataSource = dt;
            data_listing.Columns[0].HeaderText = "ID";
            data_listing.Columns[1].HeaderText = "Employee ID";
            data_listing.Columns[2].HeaderText = "Date";
            data_listing.Columns[3].HeaderText = "Status";
            data_listing.Columns[4].HeaderText = "Description";
            data_listing.Columns[5].HeaderText = "Month";
        }

        private void clearForm()
        {
            attandance_id.Text = "";
            attandance_employee_id.Text = "";
            attandance_date.Text = "";
            attandance_status.Text = "";
            attandance_description.Text = "";
            attandance_month.Text = "";
        }

        private void save_data_Click(object sender, EventArgs e)
        {
            DBConnection cn = new DBConnection();
            String SQL = "INSERT INTO `attandance` (`attandance_employee_id`, `attandance_date`, `attandance_status`, `attandance_description`, `attandance_month`) VALUES (@0, @1, @2, @3, @4);";
            MySqlCommand insertCommand = new MySqlCommand(SQL, cn.con);
            insertCommand.Parameters.AddWithValue("@0", attandance_employee_id.Text);
            insertCommand.Parameters.AddWithValue("@1", attandance_date.Text);
            insertCommand.Parameters.AddWithValue("@2", attandance_status.Text);
            insertCommand.Parameters.AddWithValue("@3", attandance_description.Text);
            insertCommand.Parameters.AddWithValue("@4", attandance_month.Text);
            insertCommand.ExecuteNonQuery();
            FillDataListing();
            MessageBox.Show("Data Saved Successfully.");
        }

        private void data_listing_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.data_listing.Rows[e.RowIndex];
                attandance_id.Text = row.Cells[0].Value.ToString();
                attandance_employee_id.Text = row.Cells[1].Value.ToString();
                attandance_date.Text = row.Cells[2].Value.ToString();
                attandance_status.Text = row.Cells[3].Value.ToString();
                attandance_description.Text = row.Cells[4].Value.ToString();
                attandance_month.Text = row.Cells[5].Value.ToString();
            }
        }

        private void Car_Load(object sender, EventArgs e)
        {
            attandance_date.Format = DateTimePickerFormat.Custom;
            attandance_date.CustomFormat = "dd-MM-yyyy";
        }

        private void update_data_Click(object sender, EventArgs e)
        {
            if (attandance_id.Text != "")
            {
                DBConnection cn = new DBConnection();
                String SQL = "UPDATE `attandance` SET `attandance_employee_id` = @0, `attandance_date` = @1, `attandance_status` = @2, `attandance_description` = @3, `attandance_month` = @4 WHERE `attandance_id` = @5; ";
                MySqlCommand insertCommand = new MySqlCommand(SQL, cn.con);
                insertCommand.Parameters.AddWithValue("@0", attandance_employee_id.Text);
                insertCommand.Parameters.AddWithValue("@1", attandance_date.Text);
                insertCommand.Parameters.AddWithValue("@2", attandance_status.Text);
                insertCommand.Parameters.AddWithValue("@3", attandance_description.Text);
                insertCommand.Parameters.AddWithValue("@4", attandance_description.Text);
                insertCommand.Parameters.AddWithValue("@5", attandance_id.Text);
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
            if (attandance_id.Text != "")
            {
                String SQL = "DELETE FROM attandance WHERE attandance_id = " + attandance_id.Text;
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

        private void Attandance_Load(object sender, EventArgs e)
        {

        }
    }
}
