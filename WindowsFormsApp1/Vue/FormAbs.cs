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
using appli.modele;
using MySql.Data.MySqlClient;

namespace appli.Vue
{
    public partial class FormAbs : Form
    {
        private Controle controle;
        /// <summary>
        /// Objet pour gérer la liste des absences
        /// </summary>
        public BindingSource bdgAbs = new BindingSource();
        public FormAbs(Controle controle)
        {
            InitializeComponent();
            this.controle = controle;
            Init();
        }
        public void Init()
        {
            RemplirListeAbs();
            RemplirList();
            ViderAbs();
            grbabs.Enabled = false;
        }

        /// <summary>
        /// Remplissage combobox
        /// </summary>
        public void RemplirList()
        {
            combomotif.Items.Insert(0, "Vacances");
            combomotif.Items.Insert(1, "Maladie");
            combomotif.Items.Insert(2, "Motif familial");
            combomotif.Items.Insert(3, "Congé parental"); 
        }

        /// <summary>
        /// Vider les zones de saisie d'une absence
        /// </summary>
        private void ViderAbs()
        {
            txtnom.Text = "";
            txtprenom.Text = "";
            combomotif.SelectedIndex = 0;
        }


        /// <summary>
        /// Affiche les absences
        /// </summary>
        public void RemplirListeAbs()
        {
            List<Absence> lesAbs = controle.GetLesAbs();
            bdgAbs.DataSource = lesAbs;
            databloc.DataSource = bdgAbs;
            databloc.Columns["IDPERSONNEL"].Visible = false;
            databloc.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void pers_Click(object sender, EventArgs e)
        {
            controle.persfenetre();
        }

        private void btnAjouter_Click(object sender, EventArgs e)
        {
            grbabs.Enabled = true;
        }

        private void btnEnregistrer_Click(object sender, EventArgs e)
        {
            if (!txtnom.Text.Equals("") && !txtprenom.Text.Equals("") && combomotif.SelectedIndex != -1)
            {
                DateTime datedebut = datedeb.Value;
                DateTime datefini = datefin.Value;
                int result = DateTime.Compare(datedebut, datefini);

                if (result < 0)
                {
                    string motif;

                    if (combomotif.SelectedIndex == 0)
                    {
                        motif = "Vacances";
                    }
                    else if (combomotif.SelectedIndex == 1)
                    {
                        motif = "Maladie";
                    }
                    else if (combomotif.SelectedIndex == 2)
                    {
                        motif = "Motif familial";
                    }
                    else
                    {
                        motif = "Congé parental";
                    }
                    string dated = datedeb.Value.ToString("yyyy-MM-dd HH:mm:ss");
                    string datef = datefin.Value.ToString("yyyy-MM-dd HH:mm:ss");
                    MySqlConnection con = new MySqlConnection("server=localhost; port=3306; user id=root; password='';database=bddtest");
                    string req = "insert into absence(IDMOTIF, NOM, PRENOM, DATEDEBUT, DATEFIN) values ('" + motif + "','" + txtnom.Text + "','" + txtprenom.Text + "','" + dated + "','" + datef + "')";
                    MySqlCommand command = new MySqlCommand(req, con);
                    con.Open();

                    if (command.ExecuteNonQuery() == 1)
                    {
                        MessageBox.Show("Absence crée avec succès", "Information");
                        RemplirListeAbs();
                        ViderAbs();

                    }
                    con.Close();
                    grbabs.Enabled = false;
                }
                else
                {
                    MessageBox.Show("La date de fin est inferieure a la date de début.", "Information");
                }
            }
            else
            {
                MessageBox.Show("Tous les champs doivent être remplis.", "Information");
            }
        }

        private void Btndel_Click(object sender, EventArgs e)
        {
            if (databloc.SelectedRows.Count > 0)
            {
                Absence absence = (Absence)bdgAbs.List[bdgAbs.Position];
                if (MessageBox.Show("Voulez-vous vraiment supprimer " + absence.Nom + " " + absence.Prenom + " ?", "Confirmation de suppression", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    controle.DelAbs(absence);
                    RemplirListeAbs();
                }
            }
            else
            {
                MessageBox.Show("Une ligne doit être sélectionnée.", "Information");
            }
        }

        private void btnannuler_Click(object sender, EventArgs e)
        {
            ViderAbs();
            grbabs.Enabled = false;
        }

        private void BOUTONMODIF_Click(object sender, EventArgs e)
        {
            if (databloc.SelectedRows.Count > 0)
            {
                controle.DemandeUpdateAbsence();
            }
            else
            {
                MessageBox.Show("Une ligne doit être sélectionnée.", "Information");
            }
        }
    }
}
