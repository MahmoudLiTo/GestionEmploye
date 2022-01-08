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
    public partial class pointage : UserControl
    {
        public pointage()
        {
            InitializeComponent();
        }
        int boxstate = 1;
        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if(boxstate == 1)
            {
                dateBox.Enabled = true;
                boxstate = 0;
                return;
            }
            if (boxstate == 0)
            {
                dateBox.Enabled = false;
                boxstate = 1;
                return;
            }

            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            controllerSaisie dba = new controllerSaisie();
            controllerUsers db = new controllerUsers();
            List<pointageModel> mypointagelist = dba.listPointage();
            List<employeModel> myemployelist = db.listEmploye();


            dataGridView1.Rows.Clear();
            foreach(pointageModel pnt in mypointagelist)
            {
                employeModel emp = db.searchemploye(pnt.IdEmploye);
                dataGridView1.Rows.Add(pnt.Id, pnt.IdEmploye, emp.Nom, emp.Prenom, emp.Matricule, pnt.NbHeur, pnt.TypeHeur, pnt.Date);
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void pointage_Load(object sender, EventArgs e)
        {

            controllerUsers db = new controllerUsers();
            List<employeModel> myemployelist = db.listEmploye();
            comboBox2.Items.Clear();
            foreach (employeModel emp in myemployelist)
            {
                comboBox2.Items.Add(emp.Id);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (!checkinfo())
            {
                return;
            }
            if (!checkValide())
            {
                return;
            }
            controllerSaisie dba = new controllerSaisie();
            dba.addPointage(new pointageModel(0,float.Parse(nbhBox.Text),int.Parse(comboBox1.SelectedItem.ToString()), int.Parse(comboBox2.SelectedItem.ToString())));
            MessageBox.Show("Ligne Ajoutée");
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
            if (nbhBox.Text.Trim().Equals(string.Empty) || dateBox.Text.Trim().Equals(string.Empty) || comboBox1.SelectedItem==null || comboBox2.SelectedItem==null)
            {
                MessageBox.Show("remplissez tout les champs avant d'effectuer une opération");
                return false;
            }
            return true;
        }
        public Boolean checkValide()
        {
            float f;
            if (!float.TryParse(nbhBox.Text, out f))
            {
                MessageBox.Show("le nombre d'heur travaillé doit être un float");
                return false;
            }
            return true;

        }

        private void button5_Click(object sender, EventArgs e)
        {
            idBox.Text = "";
            nbhBox.Text = "";
            dateBox.Text = "";
            comboBox1.SelectedItem = null;

            comboBox2.SelectedItem = null;
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
            if (!checkValide())
            {
                return;
            }
            controllerSaisie dba = new controllerSaisie();
            dba.updatePointage(new pointageModel(int.Parse(idBox.Text), float.Parse(nbhBox.Text), int.Parse(comboBox1.SelectedItem.ToString()), int.Parse(comboBox2.SelectedItem.ToString())));
            MessageBox.Show("Ligne Modifiée");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (!checkid())
            {
                return;
            }
            controllerSaisie dba = new controllerSaisie();
            dba.deletePointage(int.Parse(idBox.Text));
            MessageBox.Show("Ligne Supprimée");
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int position = dataGridView1.CurrentRow.Index;
            idBox.Text = dataGridView1.Rows[position].Cells[0].Value.ToString();
            comboBox2.SelectedItem = int.Parse(dataGridView1.Rows[position].Cells[1].Value.ToString());
            nbhBox.Text = dataGridView1.Rows[position].Cells[5].Value.ToString();
            comboBox2.SelectedItem = int.Parse(dataGridView1.Rows[position].Cells[6].Value.ToString());
            dateBox.Text = dataGridView1.Rows[position].Cells[7].Value.ToString();

        }

        private void button6_Click(object sender, EventArgs e)
        {
            idBox.Text = "";
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
