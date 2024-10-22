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
    public partial class frmDoctor : Form
    {
        string licenseNo, firstName, lastName, specialization;

        string query;


        DataTable dt = new DataTable();
        DataTable dtPatients = new DataTable();

        string connectionString = "server = localhost; database=hospitaldb; uid=root; pwd=Daenerys@26; port=3306";
        MySqlConnection conn;

        public frmDoctor()
        {
            InitializeComponent();
        }

        private void frmDoctor_Load(object sender, EventArgs e)
        {
            disableAllInputFields();

            selectAll();


            query = "SELECT specializationName FROM Specialization";
            conn.Open();
            MySqlCommand cmd = new MySqlCommand(query, conn);
            MySqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                cbSpecialization.Items.Add(dr["specializationName"].ToString());
            }
            conn.Close();

        }

        private void cbCrud_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (cbCrud.SelectedIndex == 0) // Create
            {
                enableAllInputFields();
            }
            else if (cbCrud.SelectedIndex == 1) // Read
            {
                enablePrimaryKeyInputFieldOnly();
            }
            else if (cbCrud.SelectedIndex == 2) // Update
            {
                enableAllInputFields();
            }
            else if (cbCrud.SelectedIndex == 3) // Delete
            {
                enablePrimaryKeyInputFieldOnly();
            }
        }

        void enableAllInputFields()
        {
            txtLicense.Enabled = true;
            txtFname.Enabled = true;
            txtLname.Enabled = true;
            cbSpecialization.Enabled = true;
        }

        void enablePrimaryKeyInputFieldOnly()
        {
            txtLicense.Enabled = true;
            txtFname.Enabled = false;
            txtLname.Enabled = false;
            cbSpecialization.Enabled = false;
        }

        private void btnapply_Click_1(object sender, EventArgs e)
        {
            if (cbCrud.SelectedIndex == 0) // Create
            {
                insert();
            }
            else if (cbCrud.SelectedIndex == 1) // Read
            {
                selectIndividual();
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

        void selectAll()
        {
            dt.Clear();
            dtgPatientInfo.DataSource = null;

            query = "SELECT * FROM Doctor";
            conn = new MySqlConnection(connectionString);
            conn.Open();
            MySqlDataAdapter adapter = new MySqlDataAdapter(query, conn);
            adapter.Fill(dt);
            conn.Close();
            dtgPatientInfo.DataSource = dt;
        }

        void insert()
        {
            query = ($@"INSERT INTO Doctor(licenseNo, firstName, lastName, specializationName) 
                    VALUES('{txtLicense.Text}', '{txtFname.Text}', '{txtLname.Text}', 
                    '{cbSpecialization.Text}')");
            conn = new MySqlConnection(connectionString);
            conn.Open();
            MySqlCommand cmd = new MySqlCommand(query, conn);
            cmd.ExecuteNonQuery();
            conn.Close();

            selectAll();
            disableAllInputFields();
          
        }

        void selectIndividual()
        {
            dt = new DataTable();
            query = ($"SELECT * FROM Doctor WHERE licenseNo='{txtLicense.Text}'");
            conn = new MySqlConnection(connectionString);
            conn.Open();
            MySqlCommand cmd = new MySqlCommand(query, conn);
            MySqlDataReader dr = cmd.ExecuteReader();

            dr.Read();

            lblLicenseno.Text = ($"License Number: {dr["licenseNo"].ToString()}");
            lblFname.Text = ($"First Name: {dr["firstName"].ToString()}");
            lblLname.Text = ($"Last Name: {dr["lastName"].ToString()}");
            lblSpecialization.Text = ($"Sepcialization: {dr["specializationName"].ToString()}");

            dr.Close();
            conn.Close();

            getPatientsData();
            disableAllInputFields();
            

        }


        void update()
        {
            query = ($@"UPDATE Doctor SET firstName='{txtFname.Text}', lastName='{txtLname.Text}', 
            specializationName='{cbSpecialization.Text}' 
            WHERE licenseNo='{txtLicense.Text}'");
            conn = new MySqlConnection(connectionString);
            conn.Open();
            MySqlCommand cmd = new MySqlCommand(query, conn);
            cmd.ExecuteNonQuery();
            conn.Close();

            selectAll();
            disableAllInputFields();
            
        }
        void delete()
        {
            query = ($@"DELETE FROM Doctor WHERE Doctor.licenseNo='{txtLicense.Text}' 
                    AND Doctor.LicenseNo NOT IN (SELECT Patient.doctorLicenseNo FROM Patient)");
            conn = new MySqlConnection(connectionString);
            conn.Open();
            MySqlCommand cmd = new MySqlCommand(query, conn);
            int affectedRows = cmd.ExecuteNonQuery();
            conn.Close();

            if (affectedRows == 0)
            {
                MessageBox.Show("Deletion failed because it is referenced in another table");
            }

            selectAll();
            disableAllInputFields();
            
        }

        void disableAllInputFields()
        {
            txtLicense.Enabled = false;
            txtFname.Enabled = false;
            txtLname.Enabled = false;
            cbSpecialization.Enabled = false;
        }

        void getPatientsData()
        {
            dtPatients.Clear();

            query = ($"SELECT * FROM Patient WHERE doctorLicenseNo='{txtLicense.Text}'");
            conn = new MySqlConnection(connectionString);
            conn.Open();
            MySqlDataAdapter adapter = new MySqlDataAdapter(query, conn);
            adapter.Fill(dtPatients);
            conn.Close();
            dtgPatientInfo.DataSource = dtPatients;

        }

        void clearAllInputFields()
        {
            txtLicense.Clear();
            txtFname.Clear();
            txtLname.Clear();
            cbCrud.SelectedIndex = -1;
            cbSpecialization.SelectedIndex = -1;
        }

        private void lblback_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmLanding back = new frmLanding();
            back.Show();

            this.Close();
        }

        void clearInfo()
        {
            lblLicenseno.Text = "";
            lblFname.Text = "";
            lblLname.Text = "";
            lblSpecialization.Text = "";
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            selectAll();
            clearInfo();
            clearAllInputFields();
        }
    }
}
