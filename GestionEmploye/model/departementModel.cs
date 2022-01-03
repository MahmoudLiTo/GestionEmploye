using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionEmploye.model
{
    class departementModel
    {
        private int id;
        private string nom;

        public departementModel()
        {
        }

        public departementModel(int id, string nom)
        {
            this.id = id;
            this.nom = nom;
        }

        public int Id { get => id; set => id = value; }
        public string Nom { get => nom; set => nom = value; }
    }
}
