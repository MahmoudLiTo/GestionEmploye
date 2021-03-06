using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionEmploye.model
{
    class RHModel
    {
        private int id;
        private string nom;
        private string prenom;
        private string login;
        private string password;

        public RHModel()
        {
        }

        public RHModel(string login, string password)
        {
            this.login = login;
            this.password = password;
        }

        public RHModel(int id, string nom, string prenom, string login, string password)
        {
            this.id = id;
            this.nom = nom;
            this.prenom = prenom;
            this.login = login;
            this.password = password;
        }



        public int Id { get => id; set => id = value; }
        public string Login { get => login; set => login = value; }
        public string Password { get => password; set => password = value; }
        public string Nom { get => nom; set => nom = value; }
        public string Prenom { get => prenom; set => prenom = value; }
    }

}
