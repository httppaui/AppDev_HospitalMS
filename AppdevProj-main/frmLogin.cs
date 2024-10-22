using MySql.Data;
using MySql.Data.MySqlClient;
using System.Data;


namespace HOSPITALDB;

public partial class frmLogin : Form
{
    string connectionStr = "server=localhost; database=hospitaldb; uid=root; pwd=Daenerys@26; port=3306;";
    MySqlConnection conn;
    public frmLogin()
    {
        
        InitializeComponent();
    }
    private void btnSignup_Click(object sender, EventArgs e)
    {
        frmCreateAcc frm = new frmCreateAcc();
        frm.ShowDialog();
    }

    private void frmLogin_Load(object sender, EventArgs e)
    {
        txtPassword.Text = string.Empty;
        txtPassword.PasswordChar = '*';
    }
    private void btnLogin_Click(object sender, EventArgs e)
    {
        string queryCheck = "select * from user where username='" + txtUsername.Text + "'";
        conn = new MySqlConnection(connectionStr);
        conn.Open();
        MySqlCommand cmdSelect = new MySqlCommand(queryCheck, conn);
        MySqlDataReader dr = cmdSelect.ExecuteReader();

        if(dr.HasRows)
        {
            dr.Read();
            frmLanding frm = new frmLanding();
            frm.ShowDialog();
        }
        else
        {
            MessageBox.Show("Invalid Credentianls");
        }

    }

}
