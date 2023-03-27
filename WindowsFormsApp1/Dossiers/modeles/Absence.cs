using System;

namespace appli.modele
{
    /// <summary>
    /// Création d'une absence
    /// </summary>
    public class Absence
    {
        // Déclaration des propriétés
        private int idpersonnel;
        private string nom;
        private string prenom;
        private string idmotif;
        private DateTime datedebut;
        private DateTime datefin;

        /// <summary>
        /// Retourne idpersonnel
        /// </summary>
        public int Idpersonnel { get => idpersonnel; }
        /// <summary>
        /// Retourne nom
        /// </summary>
        public string Nom { get => nom; }
        /// <summary>
        /// Retourne prenom
        /// </summary>
        public string Prenom { get => prenom; }
        /// <summary>
        /// Retourne idmotif
        /// </summary>
        public string Motif { get => idmotif; }
        /// <summary>
        /// Retourne datedebut
        /// </summary>
        public DateTime Date_de_debut { get => datedebut; }
        /// <summary>
        /// Retourne datefin
        /// </summary>
        public DateTime Date_de_fin { get => datefin; }

        /// <summary>
        /// Constructeur : valorise les propriétés
        /// </summary>
        /// <param name="idpersonnel"></param>
        /// <param name="nom"></param>
        /// <param name="prenom"></param>
        /// <param name="idmotif"></param>
        /// <param name="datedebut"></param>
        /// <param name="datefin"></param>
        public Absence(int idpersonnel, string nom, string prenom, string idmotif, DateTime datedebut, DateTime datefin)
        {
            this.idpersonnel = idpersonnel;
            this.nom = nom;
            this.prenom = prenom;
            this.idmotif = idmotif;
            this.datedebut = datedebut;
            this.datefin = datefin;
        }
    }
}
