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
using MySql.Data.MySqlClient;
using appli.connexion;

namespace appli.Vue
{
    public partial class FormModifPers : Form
    {
        // Déclaration des propriétés
        private int idpersonnel;
        private string nom;
        private string prenom;
        private string tel;
        private string mail;
        private string idservice;

        /// <summary>
        /// Permet de changer la valeur de idpersonnel
        /// </summary>
        /// <param name="idpersonnel"></param>
        public void SetIdPersonnel(int idpersonnel)
        {
            this.idpersonnel = idpersonnel;
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
        /// Permet de changer la valeur de nom
        /// </summary>
        /// <param name="nom"></param>
        public void SetNom(string nom)
        {
            this.nom = nom;
        }
        /// <summary>
        /// Retourne nom
        /// </summary>
        /// <returns></returns>
        public string GetNom()
        {
            return nom;
        }
        /// <summary>
        /// Permet de changer la valeur de prenom
        /// </summary>
        /// <param name="prenom"></param>
        public void SetPrenom(string prenom)
        {
            this.prenom = prenom;
        }
        /// <summary>
        /// Retourne prenom
        /// </summary>
        /// <returns></returns>
        public string Getprenom()
        {
            return prenom;
        }
        /// <summary>
        /// Permet de changer la valeur de tel
        /// </summary>
        /// <param name="tel"></param>
        public void SetTel(string tel)
        {
            this.tel = tel;
        }
        /// <summary>
        /// Retourne tel
        /// </summary>
        /// <returns></returns>
        public string GetTel()
        {
            return tel;
        }
        /// <summary>
        /// Permet de changer la valeur de mail
        /// </summary>
        /// <param name="mail"></param>
        public void SetMail(string mail)
        {
            this.mail = mail;
        }
        /// <summary>
        /// Retourne mail
        /// </summary>
        /// <returns></returns>
        public string GetMail()
        {
            return mail;
        }
        /// <summary>
        /// Permet de changer la valeur de service
        /// </summary>
        /// <param name="idservice"></param>
        public void SetService(string idservice)
        {
            this.idservice = idservice;
        }
        /// <summary>
        /// Retourne service
        /// </summary>
        /// <returns></returns>
        public string GetService()
        {
            return idservice;
        }

        /// <summary>
        /// instance du controleur
        /// </summary>
        private Controle controle;
        /// <summary>
        /// Objet pour gérer la liste des profils
        /// </summary>
        public BindingSource bdgService = new BindingSource();

        /// <summary>
        /// Initialisation des composants graphiques
        /// Récupération du controleur
        /// </summary>
        public FormModifPers(Controle controle)
        {
            this.controle = controle;
            InitializeComponent();
            Init();
        }

        /// <summary>
        /// Initialisation de la frame : remplissage des listes
        /// </summary>
        public void Init()
        {
            RemplirListeService();
        }

        /// <summary>
        /// Affiche les services
        /// </summary>
        public void RemplirListeService()
        {
            comboservice.Items.Insert(0, "Prêt");
            comboservice.Items.Insert(1, "Médiation Culturelle");
            comboservice.Items.Insert(2, "Administratif");
        }

        /// <summary>
        /// Annule les modifications et retourne à la liste des personnel
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAnnu_Click(object sender, EventArgs e)
        {
            controle.AnnulerUpdatePersonnel();
        }

        /// <summary>
        /// Enregistre les modifs dans la base de données
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ENREGISTRE_Click(object sender, EventArgs e)
        {
            if (!txtnom.Text.Equals("") && !txtprenom.Text.Equals("") && !txttel.Text.Equals("") && !txtmail.Text.Equals("") && comboservice.SelectedIndex != -1)
            {
                string req = "update personnel set NOM = @nom, PRENOM = @prenom, TEL = @tel, MAIL = @mail, IDSERVICE = @idservice ";
                req += "where idpersonnel = @idpersonnel;";
                Dictionary<string, object> parameters = new Dictionary<string, object>();
                parameters.Add("@idpersonnel", idpersonnel);
                parameters.Add("@nom", txtnom.Text);
                parameters.Add("@prenom", txtprenom.Text);
                parameters.Add("@tel", txttel.Text);
                parameters.Add("@mail", txtmail.Text);
                parameters.Add("@idservice", comboservice.Text);
                ConnexionBDD conn = ConnexionBDD.GetInstance("server=localhost; port=3306; user id=root; password='';database=bddtest");
                conn.ReqUpdate(req, parameters);

                controle.stopedit();
            }
            else
            {
                MessageBox.Show("Tous les champs doivent être remplis.", "Information");
            }
        }

        private void FormModifPers_Load(object sender, EventArgs e)
        {
            txtnom.Text = nom;
            txtprenom.Text = prenom;
            txttel.Text = tel;
            txtmail.Text = mail;
            comboservice.SelectedIndex = comboservice.FindStringExact(idservice);
        }
    }
}
