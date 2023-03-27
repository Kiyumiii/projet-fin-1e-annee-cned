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
using appli.connexion;

namespace appli.Vue
{
    public partial class FormModifAbs : Form
    {
        // Déclaration des propriétés
        private int idpersonnel;
        private string nom;
        private string prenom;
        private DateTime datedebut;
        private DateTime datefin;
        private string idmotif;

        /// <summary>
        /// Permet de changer la valeur de idpersonnel
        /// </summary>
        /// <param name="idpersonnel"></param>
        public void SetIdPersonnel(int idpersonnel)
        {
            this.idpersonnel = idpersonnel;
        }
        /// <summary>
        /// Permet de changer la valeur du nom
        /// </summary>
        /// <param name="nom"></param>
        public void SetNom(string nom)
        {
            this.nom = nom;
        }
        /// <summary>
        /// Permet de changer la valeur du prenom
        /// </summary>
        /// <param name="prenom"></param>
        public void SetPrenom(string prenom)
        {
            this.prenom = prenom;
        }
        /// <summary>
        /// Permet de changer la valeur de datedebut
        /// </summary>
        /// <param name="datedebut"></param>
        public void SetDateDebut(DateTime datedebut)
        {
            this.datedebut = datedebut;
        }
        /// <summary>
        /// Permet de changer la valeur de datefin
        /// </summary>
        /// <param name="datefin"></param>
        public void SetDateFin(DateTime datefin)
        {
            this.datefin = datefin;
        }
        /// <summary>
        /// Permet de changer la valeur du motif
        /// </summary>
        /// <param name="idmotif"></param>
        public void SetMotif(string idmotif)
        {
            this.idmotif = idmotif;
        }
        /// <summary>
        /// Retourne idpersonnel
        /// </summary>
        /// <returns></returns>
        public int GetIdPersonnel()
        {
            return idpersonnel;
        }
        /// <summary>
        /// Retourne le nom
        /// </summary>
        /// <returns></returns>
        public string GetNom()
        {
            return nom;
        }
        /// <summary>
        /// Retourne le prenom
        /// </summary>
        /// <returns></returns>
        public string GetPrenom()
        {
            return prenom;
        }
        /// <summary>
        /// Retourne datedebut
        /// </summary>
        /// <returns></returns>
        public DateTime GetDateDebut()
        {
            return datedebut;
        }
        /// <summary>
        /// Retourne datefin
        /// </summary>
        /// <returns></returns>
        public DateTime GetDateFin()
        {
            return datefin;
        }
        /// <summary>
        /// Retourne le motif
        /// </summary>
        /// <returns></returns>
        public string GetMotif()
        {
            return idmotif;
        }

        /// <summary>
        /// Objet pour gérer la liste des motifs
        /// </summary>
        public BindingSource bdgMotif = new BindingSource();

        /// <summary>
        /// instance du controleur
        /// </summary>
        private Controle controle;

        /// <summary>
        /// Initialisation des composants graphiques
        /// Récupération du controleur
        /// </summary>
        public FormModifAbs(Controle controle)
        {
            InitializeComponent();
            this.controle = controle;
            Init();
        }
        public void Init()
        {
            RemplirList();
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
        /// Enregistre les modifications
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnenregistrer_Click(object sender, EventArgs e)
        {

            if (!txtnom.Text.Equals("") && !txtprenom.Text.Equals("") && combomotif.SelectedIndex != -1)
            {
                DateTime datedebut = datedeb.Value;
                DateTime datefinii = datefini.Value;
                int result = DateTime.Compare(datedebut, datefinii);

                if (result < 0)
                {
                    string dated = datedeb.Value.ToString("yyyy-MM-dd HH:mm:ss");
                    string datef = datefini.Value.ToString("yyyy-MM-dd HH:mm:ss");

                    string req = "update absence set NOM = @nom, PRENOM = @prenom, IDMOTIF = @idmotif, DATEDEBUT = @datedeb, DATEFIN = @datefin ";
                    req += "where IDPERSONNEL = @idpersonnel;";
                    Dictionary<string, object> parameters = new Dictionary<string, object>();
                    parameters.Add("@idpersonnel", idpersonnel);
                    parameters.Add("@nom", txtnom.Text);
                    parameters.Add("@prenom", txtprenom.Text);
                    parameters.Add("@idmotif", combomotif.Text);
                    parameters.Add("@datedeb", dated);
                    parameters.Add("@datefin", datef);
                    ConnexionBDD conn = ConnexionBDD.GetInstance("server=localhost; port=3306; user id=root; password='';database=bddtest");
                    conn.ReqUpdate(req, parameters);

                    controle.stopeditabs();
                } else {
                    MessageBox.Show("La date de fin est inferieure a la date de début.", "Information");
                }
            }
            else
            {
                MessageBox.Show("Tous les champs doivent être remplis.", "Information");
            }
        }

        /// <summary>
        /// Remplis les champs avec les infos de l'absence souhaitée
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FormModifAbs_Load(object sender, EventArgs e)
        {
            txtnom.Text = nom;
            txtprenom.Text = prenom;
            datedeb.Value = datedebut;
            datefini.Value = datefin;
            combomotif.SelectedIndex = combomotif.FindStringExact(idmotif);
        }

        /// <summary>
        /// Annule les modifications et retourne à la liste des absences
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnannuler_Click(object sender, EventArgs e)
        {
            controle.AnnulerUpdateAbs();
        }
    }
}
