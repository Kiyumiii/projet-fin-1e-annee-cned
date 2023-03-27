namespace appli.modele
{
    /// <summary>
    /// Classe Service
    /// </summary>
    public class Service
    {
        private string idservice;
        private string nom;

        /// <summary>
        /// Retourne idservice
        /// </summary>
        public string Idservice { get => idservice; }
        /// <summary>
        /// Retourne nom
        /// </summary>
        public string Nom { get => nom; }

        /// <summary>
        /// Constructeur : valorise les propriétés
        /// </summary>
        /// <param name="idservice"></param>
        /// <param name="nom"></param>
        public Service(string idservice, string nom)
        {
            this.idservice = idservice;
            this.nom = nom;
        }

        /// <summary>
        /// Définit l'information à afficher (juste le nom)
        /// </summary>
        /// <returns>nom du profil</returns>
        public override string ToString()
        {
            return this.nom;
        }

    }
}
