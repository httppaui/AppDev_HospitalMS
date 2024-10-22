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
    public partial class frmLanding : Form
    {
        public frmLanding()
        {
            InitializeComponent();
        }


        private void btnBack_Click(object sender, EventArgs e)
        {
            frmLogin back = new frmLogin();
            back.ShowDialog();
        }

        private void frmLanding_Load(object sender, EventArgs e)
        {

        }

        private void pbRoom_Click(object sender, EventArgs e)
        {
            frmRoom room = new frmRoom();
            room.ShowDialog();
        }

        private void pbPatient_Click(object sender, EventArgs e)
        {
            frmPatient patient = new frmPatient();
            patient.ShowDialog();
        }

        private void pbDoctor_Click(object sender, EventArgs e)
        {
            frmDoctor patient = new frmDoctor();
            patient.ShowDialog();
        }
    }
}
