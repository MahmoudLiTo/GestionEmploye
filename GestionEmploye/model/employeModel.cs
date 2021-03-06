using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionEmploye.model
{
    class employeModel
    {
        private int id;
        private string nom;
        private string prenom;
        private string login;
        private string password;
        private int grade;
        private int departement;
        private string matricule;

        public employeModel()
        {
        }

        public employeModel(string login, string password)
        {
            this.login = login;
            this.password = password;
        }

        public employeModel(int id, string nom, string prenom, string login, string password, int grade, int departement, string matricule)
        {
            this.id = id;
            this.nom = nom;
            this.prenom = prenom;
            this.login = login;
            this.password = password;
            this.grade = grade;
            this.departement = departement;
            this.matricule = matricule;
        }

        public int Id { get => id; set => id = value; }
        public string Nom { get => nom; set => nom = value; }
        public string Prenom { get => prenom; set => prenom = value; }
        public string Login { get => login; set => login = value; }
        public string Password { get => password; set => password = value; }
        public int Grade { get => grade; set => grade = value; }
        public int Departement { get => departement; set => departement = value; }
        public string Matricule { get => matricule; set => matricule = value; }
    }
}
