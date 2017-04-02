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
    public partial class AttandanceReport : Form
    {
        public AttandanceReport()
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
    }
}
