﻿using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionEmploye.controller
{
    class controller
    {

        SqlConnection cnx = new SqlConnection("Data Source = DESKTOP - MSJ5T4J; Initial Catalog = GestionEmploye; Integrated Security = True ");

        private object obj;

        controller()
        {
      

        }

        public void add(object obj)
        {
            string attributes = "(";
            string values
            foreach (var prop in obj.GetType().GetProperties())
            {
                if (prop.Name != "id")
                {
                    attributes = attributes + prop.Name + ",";
                }
            }
            attributes = attributes.Substring(0, attributes.Length - 1);
            attributes += ")";

        } 





    }
}
