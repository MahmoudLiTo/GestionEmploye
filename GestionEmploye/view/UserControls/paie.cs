using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GestionEmploye.controller;
using GestionEmploye.model;

namespace GestionEmploye.view.UserControls
{
    public partial class paie : UserControl
    {
        public paie()
        {
            InitializeComponent();
        }

        public void btnlist_Click(object sender, EventArgs e)
        {
            controllerUsers db = new controllerUsers();
            controllerSaisie dba = new controllerSaisie();
            List<employeModel> myemployelist = db.listEmploye();

            List<gradeModel> mygradelist = db.listGrade();
            List<pointageModel> myempntlist;


            dataGridView1.Rows.Clear();
            foreach (employeModel emp in myemployelist)
            {
                string cmp;
                float f = 0;
                float f2 = 0;
                myempntlist = dba.searchPointage(emp.Id);
                foreach(pointageModel pnt in myempntlist)
                {
                    f += pnt.NbHeur * pnt.TypeHeur;
                }
                if (f >= 40)
                {
                    cmp = "oui";
                    f2 = db.searchgrade(emp.Grade).PaieNormale + (f - 40) * db.searchgrade(emp.Grade).PaieHeurSupp;
                }
                else
                {
                    cmp = "non";
                    f2 = db.searchgrade(emp.Grade).PaieNormale * f / 40;
                }


                dataGridView1.Rows.Add(emp.Id, emp.Nom, emp.Prenom, emp.Matricule, db.searchgrade(emp.Grade).Nom, db.searchDepartement(emp.Departement).Nom,f,cmp,f2 );

            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
