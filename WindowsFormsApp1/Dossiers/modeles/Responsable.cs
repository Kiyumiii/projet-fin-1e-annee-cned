namespace appli.modele
{
    public class Responsable
    {
        private int idresponsable;
        private string login;
        private string pwd;

        public int Idresponsable { get => idresponsable; }
        public string Login { get => login; }
        public string Pwd { get => pwd; set => pwd = value; }

        /// <summary>
        /// Constructeur : valorise les propriétés
        /// </summary>
        /// <param name="idresponsable"></param>
        /// <param name="login"></param>
        /// <param name="pwd"></param>
        public Responsable(int idresponsable, string login, string pwd)
        {
            this.idresponsable = idresponsable;
            this.login = login;
            this.pwd = pwd;
        }
    }
}
