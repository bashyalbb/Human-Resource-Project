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
    public partial class ChangePassword : Form
    {
        public ChangePassword()
        {
            InitializeComponent();
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void ChangePassword_Load(object sender, EventArgs e)
        {
            
        }

        private void changePass_Click(object sender, EventArgs e)
        {
            DBConnection cn = new DBConnection();
            String SQL = "select * from user where user_id = @userID";
            MySqlCommand cmd = new MySqlCommand(SQL, cn.con);
            cmd.Parameters.AddWithValue("@userID", Login.userID);
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                DataRow dr = dt.Rows[0];

                if (new_password.Text != confirm_password.Text)
                {
                    MessageBox.Show("New password and confirm passwords are not same. Try again !!!!");
                }

                if (old_password.Text != Convert.ToString(dr["user_password"]))
                {
                    MessageBox.Show("Invalid old password. Try again !!!");
                }
                else
                {
                    SQL = "UPDATE user set user_password = @0 WHERE user_id = @1";
                    MySqlCommand insertCommand = new MySqlCommand(SQL, cn.con);
                    insertCommand.CommandType = CommandType.Text;

                    insertCommand.Parameters.AddWithValue("@0", new_password.Text);
                    insertCommand.Parameters.AddWithValue("@1", Login.userID);
                    insertCommand.ExecuteNonQuery();
                    cn.con.Close();
                    old_password.Text = "";
                    new_password.Text = "";
                    confirm_password.Text = "";
                    MessageBox.Show("Password changed successfully.");
                }
            }
        }
    }
}
