using MySql.Data.MySqlClient;
using Mysqlx.Crud;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.ComponentModel.Design.ObjectSelectorEditor;

namespace HOSPITALDB
{
    public partial class frmRoom : Form
    {
        DataTable dt = new DataTable();


        string connectionString = "server = localhost; database=hospitaldb; uid=root; pwd=Daenerys@26; port=3306";
        MySqlConnection conn;

        public frmRoom()
        {
            InitializeComponent();
        }
        private void frmRoom_Load(object sender, EventArgs e)
        {
            selectAll();
        }

        void selectAll()
        {
            dt.Clear();
            dtgPatientInfo.DataSource = null;

            string query = "SELECT * FROM Room";
            conn = new MySqlConnection(connectionString);
            conn.Open();
            MySqlDataAdapter adapter = new MySqlDataAdapter(query, conn);
            adapter.Fill(dt);
            conn.Close();
            dtgPatientInfo.DataSource = dt;
        }

        void selectRoom()
        {
            dt = new DataTable();
            string query = ($@"SELECT * FROM Patient p JOIN Room r ON p.roomNo = r.roomNo WHERE r.roomNo='{txtRoomNo.Text}'");
            conn = new MySqlConnection(connectionString);
            conn.Open();
            MySqlCommand cmd = new MySqlCommand(query, conn);
            MySqlDataReader dr = cmd.ExecuteReader();

            dr.Read();


            lblRoomNum.Text = ($"Room Number: {dr["roomNo"].ToString()}");
            lblRoomType.Text = ($"Room Type: {dr["roomType"].ToString()}");
            lblRoomAvail.Text = ($"Room Availability: {dr["roomAvailability"].ToString()}");

            dr.Close();
            conn.Close();

            getPatientData();

        }


        void update()
        {
            string query = ($@"UPDATE Room SET roomType='{txtRoomtype.Text}', 
            roomAvailability='{cboRoomAvailability.Text}' 
            WHERE roomNo='{txtRoomNo.Text}'");
            conn = new MySqlConnection(connectionString);
            conn.Open();
            MySqlCommand cmd = new MySqlCommand(query, conn);
            cmd.ExecuteNonQuery();
            conn.Close();

            selectAll();
        }

        void insert()
        {
            if (string.IsNullOrEmpty(txtRoomNo.Text) || string.IsNullOrEmpty(txtRoomtype.Text) || string.IsNullOrEmpty(cboRoomAvailability.Text))
            {
                MessageBox.Show("All input fields are required");
            }
            else
            {

                string query = "INSERT INTO Room(roomNo, roomType, roomAvailability) VALUES('" + txtRoomNo.Text + "', '" + txtRoomtype.Text + "', '" + cboRoomAvailability.Text + "')";
                conn = new MySqlConnection(connectionString);
                conn.Open();
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.ExecuteNonQuery();
                conn.Close();

                selectAll();
            }
        }
        void getPatientData()
        {
            dt = new DataTable();
            string query = ($"SELECT * FROM Patient WHERE roomNo='{txtRoomNo.Text}'");
            conn = new MySqlConnection(connectionString);
            conn.Open();
            MySqlDataAdapter adapter = new MySqlDataAdapter(query, conn);
            adapter.Fill(dt);
            conn.Close();
            dtgPatientInfo.DataSource = dt;
        }
        void delete()
        {
            string query = ($@"DELETE FROM Room WHERE Room.roomNo='{txtRoomNo.Text}'");
            conn = new MySqlConnection(connectionString);
            conn.Open();
            MySqlCommand cmd = new MySqlCommand(query, conn);
            cmd.ExecuteNonQuery();

            selectAll();
        }
        private void btnApply_Click_1(object sender, EventArgs e)
        {

            if (cbCrud.SelectedIndex == 0) // Create
            {
                insert();
            }
            else if (cbCrud.SelectedIndex == 1) // Read
            {
                selectRoom();
            }
            else if (cbCrud.SelectedIndex == 2) // Update
            {
                update();
            }
            else if (cbCrud.SelectedIndex == 3) // Delete
            {
                delete();
            }
        }

        private void lblback_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmLanding frm = new frmLanding();
            frm.Show();

            this.Close();
        }
        void clearInfo()
        {
            lblRoomNum.Text = "";
            lblRoomType.Text = "";
            lblRoomAvail.Text = "";
          
        }
        void clearAllInputFields()
        {
            txtRoomNo.Clear();
            txtRoomtype.Clear();
            cbCrud.SelectedIndex = -1;
            cboRoomAvailability.SelectedIndex = -1;
        }

        void clearTable()
        {
            dt = new DataTable();
            string query = ($"SELECT * FROM Room");
            conn = new MySqlConnection(connectionString);
            conn.Open();
            MySqlDataAdapter adapter = new MySqlDataAdapter(query, conn);
            adapter.Fill(dt);
            conn.Close();
            dtgPatientInfo.DataSource = dt;
        }
     
        private void btnReset_Click(object sender, EventArgs e)
        {
            clearTable();
            clearInfo();
            clearAllInputFields();
        }
    }
}
