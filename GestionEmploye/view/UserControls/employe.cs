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
    public partial class employe : UserControl
    {


        public employe()
        {
            

            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (!checkid())
            {
                return;
            }
            controllerUsers db = new controllerUsers();
            db.deleteEmploye(int.Parse(idBox.Text));
            MessageBox.Show("ligne supprimée");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (!checkid())
            {
                return;
            }
            if (!checkinfo())
            {
                return;
            }

            controllerUsers db = new controllerUsers();
            List<employeModel> myemployelist = db.listEmploye();

            List<gradeModel> mygradelist = db.listGrade();
            List<departementModel> mydepartementlist = db.listDepartement();



            db.updateEmploye(new employeModel(int.Parse(idBox.Text.Trim()), nomBox.Text.Trim(), prenomBox.Text.Trim(), loginBox.Text.Trim(), passwordBox.Text.Trim(), mygradelist[gradeBox.SelectedIndex-1].Id, mydepartementlist[departementBox.SelectedIndex-1].Id, matriculeBox.Text.Trim()));
            MessageBox.Show("ligne modifiée");
        }


        private void button2_Click(object sender, EventArgs e)
        {
            if (!checkinfo())
            {
                return;
            }
            controllerUsers db = new controllerUsers();
            List<employeModel> myemployelist = db.listEmploye();

            List<gradeModel> mygradelist = db.listGrade();
            List<departementModel> mydepartementlist = db.listDepartement();



            db.addEmploye(new employeModel(0, nomBox.Text.Trim(), prenomBox.Text.Trim(), loginBox.Text.Trim(), passwordBox.Text.Trim(), mygradelist[gradeBox.SelectedIndex].Id, mydepartementlist[departementBox.SelectedIndex].Id, matriculeBox.Text.Trim()));
            MessageBox.Show("ligne ajoutée");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            controllerUsers db = new controllerUsers();
            List<employeModel> myemployelist = db.listEmploye();

            List<gradeModel> mygradelist = db.listGrade();

            dataGridView1.Rows.Clear();
            foreach (employeModel emp in myemployelist)
            {

                dataGridView1.Rows.Add(emp.Id, emp.Nom, emp.Prenom, emp.Matricule, db.searchgrade(emp.Grade).Nom, db.searchDepartement(emp.Departement).Nom,emp.Login,emp.Password);

            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
          

        }
        
        private void employe_Load(object sender, EventArgs e)
        {
            controllerUsers db = new controllerUsers();
            List<gradeModel> mygradelist = db.listGrade();
            List<departementModel> mydepartementlist = db.listDepartement();
            gradeBox.Items.Clear();
            foreach (gradeModel grade in mygradelist)
            {
                gradeBox.Items.Add(grade.Nom);
            }
            departementBox.Items.Clear();
            foreach (departementModel depar in mydepartementlist)
            {
                departementBox.Items.Add(depar.Nom);
            }


        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int position = dataGridView1.CurrentRow.Index;
            idBox.Text = dataGridView1.Rows[position].Cells[0].Value.ToString();
            nomBox.Text = dataGridView1.Rows[position].Cells[1].Value.ToString();
            prenomBox.Text = dataGridView1.Rows[position].Cells[2].Value.ToString();
            matriculeBox.Text = dataGridView1.Rows[position].Cells[3].Value.ToString();
            gradeBox.SelectedItem= dataGridView1.Rows[position].Cells[4].Value.ToString();
            departementBox.SelectedItem = dataGridView1.Rows[position].Cells[5].Value.ToString();
            loginBox.Text = dataGridView1.Rows[position].Cells[6].Value.ToString();
            passwordBox.Text = dataGridView1.Rows[position].Cells[7].Value.ToString();

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnclrid_Click(object sender, EventArgs e)
        {
            idBox.Text = "";
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            idBox.Text = "";
            nomBox.Text = "";
            prenomBox.Text = "";
            matriculeBox.Text = "";
            loginBox.Text = "";
            passwordBox.Text = "";
            gradeBox.SelectedItem = null;
            departementBox.SelectedItem = null;
        }
        public Boolean checkid()
        {
            if (idBox.Text.Trim().Equals(string.Empty))
            {
                MessageBox.Show("selectionnez une ligne à modifier/supprimer");
                return false;
            }
            return true;
        }
        public Boolean checkinfo()
        {
            if (nomBox.Text.Trim().Equals(string.Empty) || prenomBox.Text.Trim().Equals(string.Empty) || matriculeBox.Text.Trim().Equals(string.Empty) || loginBox.Text.Trim().Equals(string.Empty) || passwordBox.Text.Trim().Equals(string.Empty) || gradeBox.SelectedItem==null || departementBox.SelectedItem==null)
            {
                MessageBox.Show("remplissez tout les champs avant d'effectuer une opération");
                return false;
            }
            return true;
        }
    }
}
