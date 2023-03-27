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
    public partial class FormPers : Form
    {
        private Controle controle;
        /// <summary>
        /// Objet pour gérer la liste des développeurs
        /// </summary>
        public BindingSource bdgPers = new BindingSource();
        /// <summary>
        /// Objet pour gérer la liste des profils
        /// </summary>
        public BindingSource bdgService = new BindingSource();

        public FormPers(Controle controle)
        {
            InitializeComponent();
            this.controle = controle; 
            Init();
        }

        /// <summary>
        /// Initialisation de la frame : remplissage des listes
        /// </summary>
        public void Init()
        {
            RemplirListePersonnels();
            RemplirList();
            ViderPersonnels();
            grbpersonnel.Enabled = false;
        }

        /// <summary>
        /// Remplissage combobox
        /// </summary>
        public void RemplirList()
        {
            comboservice.Items.Insert(0, "Prêt");
            comboservice.Items.Insert(1, "Médiation Culturelle");
            comboservice.Items.Insert(2, "Administratif");
        }

        /// <summary>
        /// Affiche les personnels
        /// </summary>
        public void RemplirListePersonnels()
        {
            List<Personnel> lesPers = controle.GetLesPersonnels();
            bdgPers.DataSource = lesPers;
            databloc.DataSource = bdgPers;
            databloc.Columns["IDPERSONNEL"].Visible = false;
            databloc.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
        /// <summary>
        /// Vider les zones de saisie d'un personnel
        /// </summary>
        private void ViderPersonnels()
        {
            txtnom.Text = "";
            txtprenom.Text = "";
            txttel.Text = "";
            txtmail.Text = "";
            comboservice.SelectedIndex = 0;
        }

        /// <summary>
        /// Demande de suppression d'un personnel
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Btndel_Click(object sender, EventArgs e)
        {
            if (databloc.SelectedRows.Count > 0)
            {
                Personnel personnel = (Personnel)bdgPers.List[bdgPers.Position];
                if (MessageBox.Show("Voulez-vous vraiment supprimer " + personnel.Nom + " " + personnel.Prenom + " ?", "Confirmation de suppression", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    controle.DelPersonnel(personnel);
                    RemplirListePersonnels();
                }
            }
            else
            {
                MessageBox.Show("Une ligne doit être sélectionnée.", "Information");
            }
        }

        /// <summary>
        /// Vide les zones de saisie
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Btnannuler_Click(object sender, EventArgs e)
        {
            ViderPersonnels();
            grbpersonnel.Enabled = false;
        }

        /// <summary>
        /// Demande d'ajout ou de modification d'un personnel
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnEnregistrer_Click(object sender, EventArgs e)
        {
            if (!txtnom.Text.Equals("") && !txtprenom.Text.Equals("") && !txttel.Text.Equals("") && !txtmail.Text.Equals("") && comboservice.SelectedIndex != -1)
            {
                string service;

                if (comboservice.SelectedIndex == 0)
                {
                    service = "Prêt";
                } else if (comboservice.SelectedIndex == 1)
                {
                    service = "Médiation Culturelle";
                } else
                {
                    service = "Administratif";
                }

                MySqlConnection con = new MySqlConnection("server=localhost; port=3306; user id=root; password='';database=bddtest");
                string req = "insert into personnel(IDSERVICE, NOM, PRENOM, MAIL, TEL) values ('" + service + "','" + txtnom.Text + "','" + txtprenom.Text +"','" + txtmail.Text +"','" + txttel.Text +"')";
                MySqlCommand command = new MySqlCommand(req, con);
                con.Open();

                if(command.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("Personnel crée avec succès", "Information");
                    RemplirListePersonnels();
                    ViderPersonnels();

                }
                con.Close();
                grbpersonnel.Enabled = false;
            }
            else
            {
                MessageBox.Show("Tous les champs doivent être remplis.", "Information");
            }
        }

        private void BOUTONMODIF_Click(object sender, EventArgs e)
        {
            if (databloc.SelectedRows.Count > 0)
            {
                controle.DemandeUpdatePersonnel();
            }
            else
            {
                MessageBox.Show("Une ligne doit être sélectionnée.", "Information");
            }
        }

        private void btnAjouter_Click(object sender, EventArgs e)
        {
            grbpersonnel.Enabled = true;
        }

        private void BtnAbs_Click(object sender, EventArgs e)
        {
            controle.absfenetre();
        }

        private void btnAjouter_Click_1(object sender, EventArgs e)
        {
            grbpersonnel.Enabled = true;
        }
    }
}
