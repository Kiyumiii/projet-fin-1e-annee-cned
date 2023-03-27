 
namespace appli.modele
{
    public class Personnel
    {
        private int idpersonnel;
        private string nom;
        private string prenom;
        private string idservice;
        private string mail;
        private string tel;

        public int Idpersonnel { get => idpersonnel; }
        public string Nom { get => nom; }
        public string Prenom { get => prenom; }
        public string Service { get => idservice; }
        public string Tel { get => tel; }
        public string Mail { get => mail; }
        /// <summary>
        /// Constructeur : valorise les propriétés
        /// </summary>
        /// <param name="idpersonnel"></param>
        /// <param name="idservice"></param>
        /// <param name="nom"></param>
        /// <param name="prenom"></param>
        /// <param name="tel"></param>
        /// <param name="mail"></param>
        public Personnel(int idpersonnel, string nom, string prenom, string idservice, string mail, string tel)
        {
            this.idpersonnel = idpersonnel;
            this.nom = nom;
            this.prenom = prenom;
            this.idservice = idservice;
            this.mail = mail;
            this.tel = tel;
        }
    }
}
