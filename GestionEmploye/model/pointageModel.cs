using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionEmploye.model
{
    class pointageModel
    {
        private int id;
        private float nbHeur;
        private int typeHeur;
        private int idEmploye;
        private string date;


        public pointageModel(int id, float nbHeur, int typeHeur, int idEmploye)
        {
            this.id = id;
            this.nbHeur = nbHeur;
            this.typeHeur = typeHeur;
            this.idEmploye = idEmploye;
            DateTime dt = DateTime.Now;
            this.date =dt.ToString("yyyy-MM-dd");
        }

        public pointageModel(int id, float nbHeur, int typeHeur, int idEmploye, string date)
        {
            this.id = id;
            this.nbHeur = nbHeur;
            this.typeHeur = typeHeur;
            this.idEmploye = idEmploye;
            this.date = date;
        }

        public int Id { get => id; set => id = value; }
        public float NbHeur { get => nbHeur; set => nbHeur = value; }
        public int TypeHeur { get => typeHeur; set => typeHeur = value; }
        public int IdEmploye { get => idEmploye; set => idEmploye = value; }
        public string Date { get => date; set => date = value; }
    }
}
