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
    public partial class Login : Form
    {
        public static string userID;
        public Login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DBConnection cn = new DBConnection();
            MySqlCommand cmd;
            cmd = new MySqlCommand("Select * From user WHERE user_username = @username AND user_password = @password", cn.con);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.AddWithValue("@username", users_username.Text);
            cmd.Parameters.AddWithValue("@password", users_password.Text);
            MySqlDataAdapter sda = new MySqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                DataRow dr = dt.Rows[0];
                Login.userID = Convert.ToString(dr["user_id"]);
                MDIForm mdi = new MDIForm();
                this.Hide();
                mdi.Show();
            }
            else
            {
                MessageBox.Show("Invalid Username and Password. Try again !!!");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.StartPosition = FormStartPosition.CenterScreen; 
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
