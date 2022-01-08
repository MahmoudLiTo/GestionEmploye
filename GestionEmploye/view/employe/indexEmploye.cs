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

namespace GestionEmploye.view.employe
{
    public partial class indexEmploye : Form
    {
        string user;
        public indexEmploye()
        {
            InitializeComponent();
        }
        public indexEmploye(string user)
        {
            this.user = user;
            InitializeComponent();
            label1.Text += user;
        }


        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void indexEmploye_Load(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            controllerUsers db = new controllerUsers();
            employeModel emp = db.searchemploye2(user);
            controllerSaisie dba = new controllerSaisie();
            label2.Text = "Votre Département : " + db.searchDepartement(emp.Departement).Nom;
            label3.Text = "Votre Grade :" + db.searchgrade(emp.Grade).Nom;
            float f = 0;
            float f2 = 0;
            List<pointageModel> myempntlist = dba.searchPointage(emp.Id);
            foreach (pointageModel pnt in myempntlist)
            {
                f += pnt.NbHeur * pnt.TypeHeur;
            }
            if (f >= 40)
            {
                label6.Text= "Vous Avez Complété Vos Heures Pour Ce Mois";
                f2 = db.searchgrade(emp.Grade).PaieNormale + (f - 40) * db.searchgrade(emp.Grade).PaieHeurSupp;
            }
            else
            {
                label6.Text= "Vous N'Avez Pas Encore Complété Vos Heures Pour Ce Mois";
                f2 = db.searchgrade(emp.Grade).PaieNormale * f / 40;
            }
            label4.Text = "Heures Travaillées : " + f;
            label5.Text = "Paie :" + f2;

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
