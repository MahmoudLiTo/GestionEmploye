using GestionEmploye.controller;

using GestionEmploye.model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestionEmploye.view.UserControls
{
    public partial class departement : UserControl
    {


        public departement()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            controllerUsers db = new controllerUsers();
            List<departementModel> mydepartementlist = db.listDepartement();

            dataGridView1.Rows.Clear();
            foreach (departementModel depar in mydepartementlist)
            {

                dataGridView1.Rows.Add(depar.Id, depar.Nom);

            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox5.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (!checkinfo())
            {
                return;
            }
            controllerUsers db = new controllerUsers();
            db.addDepartement(0, textBox5.Text.Trim());
            MessageBox.Show("ligne ajoutée");
        }
        public Boolean checkid()
        {
            if (textBox1.Text.Trim().Equals(string.Empty))
            {
                MessageBox.Show("selectionnez une ligne à modifier/supprimer");
                return false;
            }
            return true;
        }
        public Boolean checkinfo()
        {
            if (textBox5.Text.Trim().Equals(string.Empty))
            {
                MessageBox.Show("remplissez tout les champs avant d'effectuer une opération");
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
            controllerUsers db = new controllerUsers();
            db.updateDepartement(new departementModel(int.Parse(textBox1.Text), textBox5.Text.Trim()));
            MessageBox.Show("ligne modifiée");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            controllerUsers db = new controllerUsers();
            db.deleteDepartement(int.Parse(textBox1.Text));
        }
    }
}
