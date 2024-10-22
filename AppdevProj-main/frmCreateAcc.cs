using MySql.Data;
using MySql.Data.MySqlClient;
using System.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HOSPITALDB
{
    public partial class frmCreateAcc : Form
    {
        string connectionStr = "server=localhost; database=hospitaldb; uid=root; pwd=Daenerys@26; port=3306;";
        MySqlConnection conn;
        public frmCreateAcc()
        {
            InitializeComponent();
        }

        private void frmCreateAcc_Load(object sender, EventArgs e)
        {
            txtPassword.Text = "";
            txtPassword.PasswordChar = '*';
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {

            string queryCheck = "SELECT 1 FROM user WHERE username = '" + txtUsername.Text + "'"; ;
            conn = new MySqlConnection(connectionStr);
            conn.Open();
            MySqlCommand cmdSelect = new MySqlCommand(queryCheck, conn);
            MySqlDataReader dr = cmdSelect.ExecuteReader();

            
            if (dr.HasRows)
            {
                MessageBox.Show("Duplicated Username");
            }
            
            else
            {
                if(string.IsNullOrEmpty(txtUsername.Text) || string.IsNullOrEmpty(txtPassword.Text))
                {
                    MessageBox.Show("All input fields are required");
                }
                else
                {
                    dr.Close();

                    string query = "INSERT INTO user(username, userPass) VALUES('" + txtUsername.Text + "', '" + txtPassword.Text + "')";
                    conn = new MySqlConnection(connectionStr);
                    conn.Open();
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Account Created Successfully!");
                }
                conn.Close();

            }

           

            

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            frmLogin frm = new frmLogin();
            frm.ShowDialog();
        }
    }
}
