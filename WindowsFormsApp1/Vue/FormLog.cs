using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using appli.controleur;

namespace appli.vue
{
    public partial class FormLog : Form
    {
        private Controle controle;

        public FormLog(Controle controle)
        {
            InitializeComponent();
            this.controle = controle;
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            if (!txtLogin.Text.Equals("") && !txtPsw.Text.Equals(""))
            {
                if (!controle.ControleAuthentification(txtLogin.Text, txtPsw.Text))
                {
                    MessageBox.Show("Authentification incorrecte ou vous n'êtes pas responsable", "Alerte");
                    txtLogin.Text = "";
                    txtPsw.Text = "";
                    txtLogin.Focus();
                }
            }
            else
            {
                MessageBox.Show("Tous les champs doivent être remplis.", "Information");
            }
        }
    }
}
