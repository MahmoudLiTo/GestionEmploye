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
    public partial class grade : UserControl
    {
        public grade()
        {
            InitializeComponent();
        }

        private void grade_Load(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            controllerUsers db = new controllerUsers();
            List<gradeModel> mygradelist = db.listGrade();
            dataGridView1.Rows.Clear();
            foreach(gradeModel grade in mygradelist)
            {
                dataGridView1.Rows.Add(grade.Id, grade.Nom, grade.PaieNormale, grade.PaieHeurSupp);
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (!checkinfo())
            {
                return;
            }
            if (!checkfloat())
            {
                return;
            }
            controllerUsers db = new controllerUsers();
            db.addGrade(new gradeModel(0, nomBox.Text.Trim(), float.Parse(paienormaleBox.Text), float.Parse(paiesuppBox.Text)));
            MessageBox.Show("ligne ajoutée");

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
            if (nomBox.Text.Trim().Equals(string.Empty) || paienormaleBox.Text.Trim().Equals(string.Empty) || paiesuppBox.Text.Trim().Equals(string.Empty))
            {
                MessageBox.Show("remplissez tout les champs avant d'effectuer une opération");
                return false;
            }
            return true;
         } 
        public Boolean checkfloat()
        {
            float f;
            if (!float.TryParse(paienormaleBox.Text,out f) || !float.TryParse(paiesuppBox.Text,out f)){
                MessageBox.Show("les valeurs entrées pour la paie normale et la paie par heur supp doit être un float");
                return false;
            }
            return true;

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
            if (!checkfloat())
            {
                return;
            }
            controllerUsers db = new controllerUsers();
            db.updateGrade(new gradeModel(int.Parse(idBox.Text), nomBox.Text.Trim(), float.Parse(paienormaleBox.Text), float.Parse(paiesuppBox.Text)));
            MessageBox.Show("Ligne Modifiée");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (!checkid())
            {
                return;
            }
            controllerUsers db = new controllerUsers();
            db.deleteGrade(int.Parse(idBox.Text));
        }

        private void button6_Click(object sender, EventArgs e)
        {
            idBox.Text = "";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            idBox.Text = "";
            nomBox.Text = "";
            paienormaleBox.Text = "";
            paiesuppBox.Text = "";
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int position = dataGridView1.CurrentRow.Index;
            idBox.Text = dataGridView1.Rows[position].Cells[0].Value.ToString();
            nomBox.Text = dataGridView1.Rows[position].Cells[1].Value.ToString();
            paienormaleBox.Text = dataGridView1.Rows[position].Cells[2].Value.ToString();
            paiesuppBox.Text = dataGridView1.Rows[position].Cells[3].Value.ToString();

        }
    }
}
