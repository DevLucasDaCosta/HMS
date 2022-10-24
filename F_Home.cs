using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HMS
{
    public partial class F_Home : Form
    {
        public F_Home()
        {
            InitializeComponent();
        }

        private void pb_paciente_Click(object sender, EventArgs e)
        {
            F_Paciente paciente = new F_Paciente();
            paciente.Show();
            this.Hide();
        }

        private void pb_diag_Click(object sender, EventArgs e)
        {
            F_Diagnostico diag = new F_Diagnostico();
            diag.Show();
            this.Hide();
        }

        private void pb_doutor_Click(object sender, EventArgs e)
        {
            F_Doutor doutor = new F_Doutor();
            doutor.Show();
            this.Hide();
        }

        private void pb_sair_Click(object sender, EventArgs e)
        {
            var sair = MessageBox.Show("Tem certeza que deseja sair?", "Logout", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (sair == DialogResult.Yes)
            {
                F_Login login = new F_Login();
                login.Show();
                this.Hide();
            }
        }
    }
}
