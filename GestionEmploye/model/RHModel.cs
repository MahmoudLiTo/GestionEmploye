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
        private string login;
        private string password;

        public RHModel()
        {
        }

        public RHModel(int id, string login, string password)
        {
            this.id = id;
            this.login = login;
            this.password = password;
        }

        public int Id { get => id; set => id = value; }
        public string Login { get => login; set => login = value; }
        public string Password { get => password; set => password = value; }
    }

}
