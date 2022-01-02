﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionEmploye.model
{
    class adminModel
    {
        private int id;
        private string login;
        private string password;

        public adminModel()
        {
        }

        public adminModel(string login, string password)
        {
            this.login = login;
            this.password = password;
        }

        public adminModel(int id, string login, string password)
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
