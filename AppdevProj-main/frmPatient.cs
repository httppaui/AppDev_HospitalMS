using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql;


namespace HOSPITALDB
{
    public partial class frmPatient : Form
    {
        string query;

        DataTable dt = new DataTable();
        string connectionString = "server = localhost; database=hospitaldb; uid=root; pwd=Daenerys@26; port=3306";
        MySqlConnection conn;

        public frmPatient()
        {
            InitializeComponent();
        }

        private void frmPatient_Load(object sender, EventArgs e)
        {

            txtPatientID.Enabled = false;
            txtFname.Enabled = false;
            txtLname.Enabled = false;
            txtAddress.Enabled = false;
            txtAge.Enabled = false;
            cbLicense.Enabled = false;
            cbRoomNo.Enabled = false;


            conn = new MySqlConnection(connectionString);


            string query = "SELECT licenseNo FROM Doctor";
            conn.Open();
            MySqlCommand cmd = new MySqlCommand(query, conn);
            MySqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                cbLicense.Items.Add(dr["licenseNo"].ToString());
            }

            dr.Close();
            conn.Close();

            
            

            selectAll();
            

        }

        private void lblback_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmLanding back = new frmLanding();
            back.Show();

            this.Close();
        }

        private void cbCrud_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbCrud.SelectedIndex == 0) // Insert
            {
                txtPatientID.Enabled = true;
                txtFname.Enabled = true;
                txtLname.Enabled = true;
                txtAddress.Enabled = true;
                txtAge.Enabled = true;
                cbLicense.Enabled = true;
                cbRoomNo.Enabled = true;


            }
            else if (cbCrud.SelectedIndex == 1) // Select
            {
                txtPatientID.Enabled = true;
                txtFname.Enabled = false;
                txtLname.Enabled = false;
                txtAddress.Enabled = false;
                txtAge.Enabled = false;
                cbLicense.Enabled = false;
                cbRoomNo.Enabled = false;
            }
            else if (cbCrud.SelectedIndex == 2) // Update
            {
                txtPatientID.Enabled = true;
                txtFname.Enabled = true;
                txtLname.Enabled = true;
                txtAddress.Enabled = true;
                txtAge.Enabled = true;
                cbLicense.Enabled = true;
                cbRoomNo.Enabled = true;
            }
            else if (cbCrud.SelectedIndex == 3) // Delete
            {
                txtPatientID.Enabled = true;
                txtFname.Enabled = false;
                txtLname.Enabled = false;
                txtAddress.Enabled = false;
                txtAge.Enabled = false;
                cbLicense.Enabled = false;
                cbRoomNo.Enabled = false;
            }
        }

        void insert()
        {
            if (string.IsNullOrEmpty(txtPatientID.Text) || string.IsNullOrEmpty(txtFname.Text) || string.IsNullOrEmpty(txtLname.Text) || string.IsNullOrEmpty(txtAddress.Text) || string.IsNullOrEmpty(txtAge.Text))
            {
                MessageBox.Show("All input fields are required");
            }
            else
            {
                query = (@"INSERT INTO Patient(patientID, firstName, lastName, address, age, doctorLicenseNo, roomNo)
                            VALUES('" + txtPatientID.Text + "', '" + txtFname.Text + "','" + txtLname.Text + "', '" +
                            txtAddress.Text + "', '" + txtAge.Text + "', '" + cbLicense.SelectedItem.ToString() +
                            "', '" + cbRoomNo.SelectedItem.ToString() + "')");
                conn = new MySqlConnection(connectionString);
                conn.Open();
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.ExecuteNonQuery();
                conn.Close();

                selectAll();


                MessageBox.Show("Record Successfully Added!");
            }

        }

        void update()
        {
            if (string.IsNullOrEmpty(txtPatientID.Text) || string.IsNullOrEmpty(txtFname.Text) || string.IsNullOrEmpty(txtLname.Text) || string.IsNullOrEmpty(txtAddress.Text) || string.IsNullOrEmpty(txtAge.Text))
            {
                MessageBox.Show("All fields are required");
            }
            else
            {
                query = ($@"UPDATE Patient SET
                        firstName='{txtFname.Text}', lastName='{txtLname.Text}', 
                        address='{txtAddress.Text}', age={int.Parse(txtAge.Text)}, 
                        doctorLicenseNo='{cbLicense.Text}', 
                        roomNo='{cbRoomNo.Text}' 
                        WHERE patientID='{txtPatientID.Text}'");
                conn = new MySqlConnection(connectionString);
                conn.Open();
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.ExecuteNonQuery();
                conn.Close();

                

                selectAll();
                clearInputFields();
                clearInfo();
            }

        }

        void selectAll()
        {

            dt.Clear();
            dtgPatient.DataSource = null;

            conn = new MySqlConnection(connectionString);
            query = ("SELECT * FROM Patient");
            conn.Open();
            MySqlDataAdapter adapter = new MySqlDataAdapter(query, conn);
            adapter.Fill(dt);
            conn.Close();
            dtgPatient.DataSource = dt;

        }

        void delete()
        {
            if (string.IsNullOrEmpty(txtPatientID.Text))
            {
                MessageBox.Show("All fields are required");
            }
            else
            {
                query = ($@"DELETE FROM Patient WHERE patientID='{txtPatientID.Text}'");
                conn = new MySqlConnection(connectionString);
                conn.Open();
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.ExecuteNonQuery();
                conn.Close();

                selectAll();

            }


        }


        private void btnapply_Click(object sender, EventArgs e)
        {
            if (cbCrud.SelectedIndex == 0)
            {
                insert();
            }
            else if (cbCrud.SelectedIndex == 1)
            {
                selectIndividual();
            }
            else if (cbCrud.SelectedIndex == 2)
            {
                update();
            }
            else if (cbCrud.SelectedIndex == 3)
            {
                delete();
            }

            updateRoomComboBox();
        }

        void clearInputFields()
        {
            txtPatientID.Clear();
            txtFname.Clear();
            txtLname.Clear();
            txtAddress.Clear();
            txtAge.Clear();
            cbLicense.SelectedIndex = -1;
            cbRoomNo.SelectedIndex = -1;
        }

        void selectIndividual()
        {
            dt = new DataTable();
            query = "SELECT * FROM Patient WHERE patientID ='" + txtPatientID.Text + "'";
            conn = new MySqlConnection(connectionString);
            MySqlCommand cmd = new MySqlCommand(query, conn);
            conn.Open();
            MySqlDataAdapter adapter = new MySqlDataAdapter(query, conn);
            adapter.Fill(dt);
            cmd.ExecuteNonQuery();
            conn.Close();
            dtgPatient.DataSource = dt;

            displayDoctorInformation();
            displayRoomInformation();


        }

        void displayDoctorInformation()
        {
            query = ($@"SELECT Doctor.* FROM Doctor INNER JOIN Patient 
                    ON Doctor.licenseNo = Patient.doctorLicenseNo 
                    WHERE Patient.patientID='{txtPatientID.Text}'");
            conn = new MySqlConnection(connectionString);
            conn.Open();
            MySqlCommand cmd = new MySqlCommand(query, conn);
            MySqlDataReader dr = cmd.ExecuteReader();

            dr.Read();
            lblLicenseNumber.Text = ($"License Number: {dr["licenseNo"].ToString()}");
            lblDoctorFirstName.Text = ($"First Name: {dr["firstName"].ToString()}");
            lblDoctorLastName.Text = ($"Last Name: {dr["lastName"].ToString()}");
            lblSpecialization.Text = ($"Specialization: {dr["specializationName"].ToString()}");
            dr.Close();
            conn.Close();
        }

        void displayRoomInformation()
        {
            query = ($@"SELECT Room.* FROM Room INNER JOIN Patient 
                    ON Room.roomNo = Patient.roomNo 
                    WHERE Patient.patientID = '{txtPatientID.Text}'");
            conn = new MySqlConnection(connectionString);
            conn.Open();
            MySqlCommand cmd = new MySqlCommand(query, conn);
            MySqlDataReader dr = cmd.ExecuteReader();

            dr.Read();
            lblRoomNumber.Text = ($"Room Number: {dr["roomNo"].ToString()}");
            lblRoomType.Text = ($"Type: {dr["roomType"].ToString()}");
            lblAvailabilityStatus.Text = ($"Availability status: {dr["roomAvailability"].ToString()}");

            dr.Close();
            conn.Close();

        }

     

        void clearInfo()
        {
            lblLicenseNumber.Text = "";
            lblDoctorFirstName.Text = "";
            lblDoctorLastName.Text = "";
            lblSpecialization.Text = "";
            lblRoomNumber.Text = "";
            lblRoomType.Text = "";
            lblAvailabilityStatus.Text = "";

        }


        private void btnReset_Click(object sender, EventArgs e)
        {
            selectAll();
            clearInfo();
            clearInputFields();
        }

        void updateRoomComboBox()
        {
            cbRoomNo.Items.Clear();
            query = ($"SELECT roomNo FROM Room WHERE roomType='Private' AND roomNo NOT IN (SELECT Patient.roomNo FROM Patient)");
            conn = new MySqlConnection(connectionString);
            conn.Open();

            MySqlCommand cmd = new MySqlCommand(query, conn);
            MySqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                cbRoomNo.Items.Add(dr["roomNo"].ToString());
            }

            dr.Close();
            conn.Close();

        }

        private void cbRoomNo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
