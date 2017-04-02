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
    public partial class EmployeeReport : Form
    {
        public EmployeeReport()
        {
            InitializeComponent();
            FillDataListing();
        }

        private void FillDataListing(String searchText = "")
        {
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
    }
}
