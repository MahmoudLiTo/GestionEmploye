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
        SqlConnection cnx = new SqlConnection("Data Source = DESKTOP - MSJ5T4J; Initial Catalog = GestionEmploye; Integrated Security = True ");

        public controllerSaisie()
        {

        }

        public void addGrade(gradeModel grade)
        {
            string query = string.Format("insert into grade(nom,paieNormale,paieHeurSupp) values('{0}','{1}','{2}')", grade.Nom, grade.PaieNormale, grade.PaieHeurSupp);
            SqlCommand cmd = new SqlCommand(query, cnx);
            if (cnx.State == System.Data.ConnectionState.Open)
            {
                cnx.Close();
            }
            cnx.Open();
            cmd.ExecuteNonQuery();
            cnx.Close();
        }
        public List<gradeModel> listGrade()
        {
            List<gradeModel> myList = new List<gradeModel>();
            string query = "select  * from grade;";
            SqlCommand cmd = new SqlCommand(query, cnx);

            if (cnx.State == System.Data.ConnectionState.Open)
            {
                cnx.Close();
            }
            cnx.Open();
            SqlDataReader rd = cmd.ExecuteReader();
            if (rd.HasRows)
            {
                gradeModel grade;
                while (rd.Read())
                {
                    grade = new gradeModel((int)rd["id"], rd["nom"].ToString(), (float)rd["paieNormale"], (float)rd["paieHeurSupp"]);

                    myList.Add(grade);
                }
            }
            cnx.Close();
            return myList;

        }
        public void updateGrade(gradeModel grade)
        {
            string query = string.Format("update departement set nom = '{1}' , paieNormale = {2} , paieHeurSupp = {3}  where id = {0}; ", grade.Id, grade.Nom, grade.PaieNormale, grade.PaieHeurSupp);
            SqlCommand cmd = new SqlCommand(query, cnx);
            if (cnx.State == System.Data.ConnectionState.Open)
            {
                cnx.Close();
            }
            cnx.Open();
            cmd.ExecuteNonQuery();
            cnx.Close();

        }
        public void deleteGrade(int i)
        {
            string query = "delete from grade where id =" + i + ";";
            SqlCommand cmd = new SqlCommand(query, cnx);
            if (cnx.State == System.Data.ConnectionState.Open)
            {
                cnx.Close();
            }
            cnx.Open();
            cmd.ExecuteNonQuery();
            cnx.Close();
        }
    }
}
