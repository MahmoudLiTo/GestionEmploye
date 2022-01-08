using GestionEmploye.model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionEmploye.controller
{
    class controllerSaisie
    {
        SqlConnection cnx = new SqlConnection("Data Source=DESKTOP-MSJ5T4J;Initial Catalog=GestionEmploye;Integrated Security=True");

        public controllerSaisie()
        {

        }

        public void addPointage(pointageModel pointage)
        {
            string query = string.Format("insert into pointage(nbHeur,typeHeures,idEmploye,date) values('{0}','{1}','{2}','{3}');", pointage.NbHeur, pointage.TypeHeur, pointage.IdEmploye,pointage.Date);
            SqlCommand cmd = new SqlCommand(query, cnx);
            if (cnx.State == System.Data.ConnectionState.Open)
            {
                cnx.Close();
            }
            cnx.Open();
            cmd.ExecuteNonQuery();
            cnx.Close();
        }
        public List<pointageModel> listPointage()
        {
            List<pointageModel> myList = new List<pointageModel>();
            string query = "select  * from pointage;";
            SqlCommand cmd = new SqlCommand(query, cnx);

            if (cnx.State == System.Data.ConnectionState.Open)
            {
                cnx.Close();
            }
            cnx.Open();
            SqlDataReader rd = cmd.ExecuteReader();
            if (rd.HasRows)
            {
                pointageModel pointage;
                while (rd.Read())
                {
                    pointage = new pointageModel((int)rd[0], float.Parse(rd[1].ToString()), int.Parse(rd[2].ToString()), int.Parse(rd[3].ToString()),rd[4].ToString());

                    myList.Add(pointage);
                }
            }
            cnx.Close();
            return myList;

        }
        public void updatePointage(pointageModel pointage)
        {
            string query = string.Format("update pointage set nbHeur = {1} , typeHeures = {2} , idEmploye = {3} , date = '{4}'  where id = {0}; ", pointage.Id, pointage.NbHeur, pointage.TypeHeur, pointage.IdEmploye,pointage.Date);
            SqlCommand cmd = new SqlCommand(query, cnx);
            if (cnx.State == System.Data.ConnectionState.Open)
            {
                cnx.Close();
            }
            cnx.Open();
            cmd.ExecuteNonQuery();
            cnx.Close();

        }
        public void deletePointage(int i)
        {
            string query = "delete from pointage where id =" + i + ";";
            SqlCommand cmd = new SqlCommand(query, cnx);
            if (cnx.State == System.Data.ConnectionState.Open)
            {
                cnx.Close();
            }
            cnx.Open();
            cmd.ExecuteNonQuery();
            cnx.Close();
        }
        public List<pointageModel> searchPointage(int i)
        {
            List<pointageModel> myList = new List<pointageModel>();
            string query = "select * from pointage where idEmploye = "+ i +";";
            SqlCommand cmd = new SqlCommand(query, cnx);

            if (cnx.State == System.Data.ConnectionState.Open)
            {
                cnx.Close();
            }
            cnx.Open();
            SqlDataReader rd = cmd.ExecuteReader();
            if (rd.HasRows)
            {
                pointageModel pointage;
                while (rd.Read())
                {
                    pointage = new pointageModel((int)rd[0], float.Parse(rd[1].ToString()), int.Parse(rd[2].ToString()), int.Parse(rd[3].ToString()), rd[4].ToString());

                    myList.Add(pointage);
                }
            }
            cnx.Close();
            return myList;
        }
    }

}
