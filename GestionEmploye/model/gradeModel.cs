using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionEmploye.model
{
    class gradeModel
    {
        private int id;
        private string nom;
        private float paieNormale;
        private float paieHeurSupp;

        public gradeModel(int id, string nom, float paieNormale, float paieHeurSupp)
        {
            this.id = id;
            this.nom = nom;
            this.paieNormale = paieNormale;
            this.paieHeurSupp = paieHeurSupp;
        }

        public int Id { get => id; set => id = value; }
        public string Nom { get => nom; set => nom = value; }
        public float PaieNormale { get => paieNormale; set => paieNormale = value; }
        public float PaieHeurSupp { get => paieHeurSupp; set => paieHeurSupp = value; }
    }
}
