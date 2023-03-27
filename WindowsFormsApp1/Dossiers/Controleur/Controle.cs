using System;
using System.Collections.Generic;
using appli.dal;
using appli.modele;
using appli.vue;
using appli.Vue;

namespace appli.controleur
{
    /// <summary>
    /// Gère les interractions entre la vue et le modèle
    /// </summary>
    public class Controle
    {
        /// <summary>
        /// fenêtre d'authentification
        /// </summary>
        private FormLog formlog;
        private FormPers formpers;
        private FormModifPers formmodifpers;
        private FormAbs formabs;
        private FormModifAbs formmodifabs;

        /// <summary>
        /// Ouverture de la fenêtre
        /// </summary>
        public Controle()
        {
            formlog = new FormLog(this);
            formlog.ShowDialog();
        }

        /// <summary>
        /// Demande la vérification de l'authentification
        /// Si correct, alors ouvre la fenêtre principale
        /// </summary>
        /// <param name="login"></param>
        /// <param name="pwd"></param>
        /// <returns></returns>
        public Boolean ControleAuthentification(string login, string pwd)
        {
            if (AccesDonnees.ControleAuthentification(login, pwd))
            {
                formlog.Hide();
                formpers = new FormPers(this);
                formpers.ShowDialog();
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// Récupère et retourne les infos des développeurs provenant de la BDD
        /// </summary>
        /// <returns>liste des développeurs</returns>
        public List<Personnel> GetLesPersonnels()
        {
            return AccesDonnees.GetLesPersonnels();
        }

        /// <summary>
        /// Récupère et retourne les infos des absences provenant de la BDD
        /// </summary>
        /// <returns>liste des développeurs</returns>
        public List<Absence> GetLesAbs()
        {
            return AccesDonnees.GetLesAbs();
        }

        /// <summary>
        /// Demande de suppression d'un personnel
        /// </summary>
        /// <param name="personnel"></param>
        public void DelPersonnel(Personnel personnel)
        {
            AccesDonnees.DelPersonnel(personnel);
        }

        /// <summary>
        /// Demande de suppression d'une absence
        /// </summary>
        /// <param name="personnel"></param>
        public void DelAbs(Absence absence)
        {
            AccesDonnees.DelAbs(absence);
        }
        /// <summary>
        /// Demande pour annuler la modification d'un personnel 
        /// </summary>
        public void AnnulerUpdatePersonnel()
        {
            formmodifpers.Hide();
            formpers = new FormPers(this);
            formpers.ShowDialog();
        }
        /// <summary>
        /// Demande pour annuler la modification d'une absence 
        /// </summary>
        public void AnnulerUpdateAbs()
        {
            formmodifabs.Hide();
            formabs = new FormAbs(this);
            formabs.ShowDialog();
        }

        /// <summary>
        /// Demande pour acceder à la modification d'un personnel
        /// </summary>
        public void DemandeUpdatePersonnel()
        {
            // Ferme la fenêtre ouverte
            formpers.Hide();
            formmodifpers = new FormModifPers(this);
            Personnel personnel = (Personnel)formpers.bdgPers.List[formpers.bdgPers.Position];
            formmodifpers.SetIdPersonnel(personnel.Idpersonnel);
            formmodifpers.SetNom(personnel.Nom);
            formmodifpers.SetPrenom(personnel.Prenom);
            formmodifpers.SetTel(personnel.Tel);
            formmodifpers.SetMail(personnel.Mail);
            formmodifpers.SetService(personnel.Service);
            // Ouvre la fenêtre frmModificationPersonnel
            formmodifpers.ShowDialog();
        }
        /// <summary>
        /// Demande pour acceder à la modification d'un personnel
        /// </summary>
        public void DemandeUpdateAbsence()
        {
            // Ferme la fenêtre ouverte
            formabs.Hide();
            formmodifabs = new FormModifAbs(this);
            Absence absence = (Absence)formabs.bdgAbs.List[formabs.bdgAbs.Position];
            formmodifabs.SetIdPersonnel(absence.Idpersonnel);
            formmodifabs.SetNom(absence.Nom);
            formmodifabs.SetPrenom(absence.Prenom);
            formmodifabs.SetMotif(absence.Motif);
            formmodifabs.SetDateDebut(absence.Date_de_debut);
            formmodifabs.SetDateFin(absence.Date_de_fin);
            // Ouvre la fenêtre frmModificationPersonnel
            formmodifabs.ShowDialog();
        }
        /// <summary>
        /// Fermer fenetre d'edit, afficher fenetre des personnels
        /// </summary>
        public void stopedit()
        {
            // Ferme la fenêtre ouverte
            formmodifpers.Hide();
            formpers = new FormPers(this);
            // Ouvre la fenêtre frmModificationPersonnel
            formpers.ShowDialog();
        }
        /// <summary>
        /// Fermer fenetre d'edit, afficher fenetre des absences
        /// </summary>
        public void stopeditabs()
        {
            // Ferme la fenêtre ouverte
            formmodifabs.Hide();
            formabs = new FormAbs(this);
            // Ouvre la fenêtre frmModificationPersonnel
            formabs.ShowDialog();
        }
        /// <summary>
        /// Fermer fenetre des personnels, ouvre absences
        /// </summary>
        public void absfenetre()
        {
            // Ferme la fenêtre ouverte
            formpers.Hide();
            formabs = new FormAbs(this);
            // Ouvre la fenêtre FormAbs
            formabs.ShowDialog();
        }
        /// <summary>
        /// Fermer fenetre des absences, ouvre personnels
        /// </summary>
        public void persfenetre()
        {
            // Ferme la fenêtre ouverte
            formabs.Hide();
            formpers = new FormPers(this);
            // Ouvre la fenêtre FormAbs
            formpers.ShowDialog();
        }
    }
}
