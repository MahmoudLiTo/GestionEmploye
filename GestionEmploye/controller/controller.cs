using GestionEmploye.model;
using System;
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


        public void addEmploye(employeModel emp)
        {
            string query = string.Format("insert into employe(nom,prenom,login,password,grade,departement,matricule) values('{0}','{1}','{2}','{3}',{4},{5},'{6}');", emp.Nom, emp.Prenom,emp.Login,emp.Password,emp.Grade,emp.Departement,emp.Matricule);
            SqlCommand cmd = new SqlCommand(query, cnx);
            if (cnx.State == System.Data.ConnectionState.Open)
            {
                cnx.Close();
            }
            cnx.Open();
            cmd.ExecuteNonQuery();
            cnx.Close();

        }
        public void addRH(RHModel rh)
        {
            string query = string.Format("insert into RH(nom,prenom,login,password) values('{0}','{1}','{2}','{3}');", rh.Nom, rh.Prenom, rh.Login, rh.Password);
            SqlCommand cmd = new SqlCommand(query, cnx);
            if (cnx.State == System.Data.ConnectionState.Open)
            {
                cnx.Close();
            }
            cnx.Open();
            cmd.ExecuteNonQuery();
            cnx.Close();

        }

        public List<employeModel> listEmploye()
        {

        
            List<employeModel> myList = new List<employeModel>();
            string query = "select  * from employe;";
            SqlCommand cmd = new SqlCommand(query, cnx);

            if (cnx.State == System.Data.ConnectionState.Open)
            {
                cnx.Close();
            }
            cnx.Open();
            SqlDataReader rd = cmd.ExecuteReader();
            if (rd.HasRows)
            {
                while (rd.Read())
                {
                    employeModel emp = new employeModel((int)rd["id"], rd["nom"].ToString(), rd["prenom"].ToString(), rd["login"].ToString(), rd["password"].ToString(), (int)rd["grade"],(int)rd["departement"],rd["matricule"].ToString());
                    myList.Add(emp);
                }
            }
            cnx.Close();
            return myList;

        }

        public List<RHModel> listRH()
        {


            List<RHModel> myList = new List<RHModel>();
            string query = "select  * from RH;";
            SqlCommand cmd = new SqlCommand(query, cnx);

            if (cnx.State == System.Data.ConnectionState.Open)
            {
                cnx.Close();
            }
            cnx.Open();
            SqlDataReader rd = cmd.ExecuteReader();
            if (rd.HasRows)
            {
                while (rd.Read())
                {
                    RHModel rh = new RHModel((int)rd["id"], rd["nom"].ToString(), rd["prenom"].ToString(), rd["login"].ToString(), rd["password"].ToString());
                    myList.Add(rh);
                }
            }
            cnx.Close();
            return myList;

        }

        public void updateEmploye(employeModel emp)
        {
            string query = string.Format("update employe set nom = '{1}' , prenom = '{2}' , login = '{3}' , password = '{4}' , grade = {5} , departement = {6} , matricule = '{7}'  where id = {0}; ",emp.Id,emp.Nom,emp.Prenom,emp.Login,emp.Password,emp.Grade,emp.Departement,emp.Matricule);
            SqlCommand cmd = new SqlCommand(query, cnx);
            if (cnx.State == System.Data.ConnectionState.Open)
            {
                cnx.Close();
            }
            cnx.Open();
            cmd.ExecuteNonQuery();
            cnx.Close();

        }
        public void updateRH(RHModel rh)
        {
            string query = string.Format("update employe set nom = '{1}' , prenom = '{2}' , login = '{3}' , password = '{4}'  where id = {0};", rh.Id, rh.Nom, rh.Prenom, rh.Login, rh.Password);
            SqlCommand cmd = new SqlCommand(query, cnx);
            if (cnx.State == System.Data.ConnectionState.Open)
            {
                cnx.Close();
            }
            cnx.Open();
            cmd.ExecuteNonQuery();
            cnx.Close();

        }
        public void deleteEmploye( int i)
        {
            string query = "delete from employe where id =" + i + ";";
            SqlCommand cmd = new SqlCommand(query, cnx);
            if (cnx.State == System.Data.ConnectionState.Open)
            {
                cnx.Close();
            }
            cnx.Open();
            cmd.ExecuteNonQuery();
            cnx.Close();
        }
        public void deleteRH(int i)
        {
            string query = "delete from RH where id =" + i + ";";
            SqlCommand cmd = new SqlCommand(query, cnx);
            if (cnx.State == System.Data.ConnectionState.Open)
            {
                cnx.Close();
            }
            cnx.Open();
            cmd.ExecuteNonQuery();
            cnx.Close();
        }

        public Boolean loginAdmin(adminModel admin)
        {
            string query = string.Format("select * from admin where login = '{0}' and password ='{1}';",admin.Login,admin.Password);
            SqlCommand cmd = new SqlCommand(query, cnx);
            if (cnx.State == System.Data.ConnectionState.Open)
            {
                cnx.Close();
            }
            cnx.Open();

            SqlDataReader rd = cmd.ExecuteReader();
            if (rd.HasRows)
            {
                return true;
            }
            return false;
        }
        public Boolean loginEmploye(employeModel emp)
        {
            string query = string.Format("select * from employe where login = '{0}' and password ='{1}';", emp.Login, emp.Password);
            SqlCommand cmd = new SqlCommand(query, cnx);
            if (cnx.State == System.Data.ConnectionState.Open)
            {
                cnx.Close();
            }
            cnx.Open();

            SqlDataReader rd = cmd.ExecuteReader();
            if (rd.HasRows)
            {
                return true;
            }
            return false;
        }
        public Boolean loginRH(RHModel rh)
        {
            string query = string.Format("select * from RH where login = '{0}' and password ='{1}';", rh.Login, rh.Password);
            SqlCommand cmd = new SqlCommand(query, cnx);
            if (cnx.State == System.Data.ConnectionState.Open)
            {
                cnx.Close();
            }
            cnx.Open();

            SqlDataReader rd = cmd.ExecuteReader();
            if (rd.HasRows)
            {
                return true;
            }
            return false;
        }

        public void addDepartement(int i,string nom)
        {
            string query = string.Format("insert into departement(nom) values('{1}')",nom);
            SqlCommand cmd = new SqlCommand(query, cnx);
            if (cnx.State == System.Data.ConnectionState.Open)
            {
                cnx.Close();
            }
            cnx.Open();
            cmd.ExecuteNonQuery();
            cnx.Close();
        }
        public List<departementModel> listDepartement()
        {
            List<departementModel> myList = new List<departementModel>();
            string query = "select  * from departement;";
            SqlCommand cmd = new SqlCommand(query, cnx);

            if (cnx.State == System.Data.ConnectionState.Open)
            {
                cnx.Close();
            }
            cnx.Open();
            SqlDataReader rd = cmd.ExecuteReader();
            if (rd.HasRows)
            {
                while (rd.Read())
                {
                    departementModel depar = new departementModel((int)rd["id"], rd["nom"].ToString());

                    myList.Add(depar);
                }
            }
            cnx.Close();
            return myList;

        }
        public void updateDepartement(departementModel depar)
        {
            string query = string.Format("update departement set nom = '{1}'  where id = {0}; ",depar.Id,depar.Nom);
            SqlCommand cmd = new SqlCommand(query, cnx);
            if (cnx.State == System.Data.ConnectionState.Open)
            {
                cnx.Close();
            }
            cnx.Open();
            cmd.ExecuteNonQuery();
            cnx.Close();

        }
        public void deleteDepartement(int i)
        {
            string query = "delete from departement where id =" + i + ";";
            SqlCommand cmd = new SqlCommand(query, cnx);
            if (cnx.State == System.Data.ConnectionState.Open)
            {
                cnx.Close();
            }
            cnx.Open();
            cmd.ExecuteNonQuery();
            cnx.Close();
        }
        public void addGrade(gradeModel grade)
        {
            string query = string.Format("insert into grade(nom,paieNormale,paieHeurSupp) values('{0}','{1}','{2}')", grade.Nom,grade.PaieNormale,grade.PaieHeurSupp);
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
                    grade = new gradeModel((int)rd["id"], rd["nom"].ToString(),(float)rd["paieNormale"],(float)rd["paieHeurSupp"]);

                    myList.Add(grade);
                }
            }
            cnx.Close();
            return myList;

        }
        public void updateGrade(gradeModel grade)
        {
            string query = string.Format("update departement set nom = '{1}' , paieNormale = {2} , paieHeurSupp = {3}  where id = {0}; ", grade.Id, grade.Nom,grade.PaieNormale,grade.PaieHeurSupp);
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
