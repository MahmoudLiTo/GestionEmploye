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
    public partial class RH : UserControl
    {
        public RH()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            controllerUsers db = new controllerUsers();
            List < RHModel > myrhlist = db.listRH();
            dataGridView1.Rows.Clear();
            foreach(RHModel rh in myrhlist)
            {
                dataGridView1.Rows.Add(rh.Id, rh.Nom, rh.Prenom, rh.Login, rh.Password);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (!checkinfo())
            {
                return;
            }
            controllerUsers db = new controllerUsers();
            db.addRH(new RHModel(0, nomBox.Text.Trim(), prenomBox.Text.Trim(), loginBox.Text.Trim(), passwordBox.Text.Trim()));
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
            if (nomBox.Text.Trim().Equals(string.Empty) || prenomBox.Text.Trim().Equals(string.Empty) || loginBox.Text.Trim().Equals(string.Empty) || passwordBox.Text.Trim().Equals(string.Empty))
            {
                MessageBox.Show("remplissez tout les champs avant d'effectuer une opération");
                return false;
            }
            return true;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            idBox.Text = "";
            nomBox.Text = "";
            prenomBox.Text = "";
            loginBox.Text = "";
            passwordBox.Text = "";
        }

        private void idBox_TextChanged(object sender, EventArgs e)
        {

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
            db.addRH(new RHModel(int.Parse(idBox.Text.Trim()), nomBox.Text.Trim(), prenomBox.Text.Trim(), loginBox.Text.Trim(), passwordBox.Text.Trim()));
            MessageBox.Show("ligne modifiée");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            idBox.Text = "";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (!checkid())
            {
                return;
            }
            controllerUsers db = new controllerUsers();
            db.deleteRH(int.Parse(idBox.Text));
            MessageBox.Show("ligne supprimée");
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int position = dataGridView1.CurrentCell.RowIndex;
            idBox.Text = dataGridView1.Rows[position].Cells[0].Value.ToString();
            nomBox.Text = dataGridView1.Rows[position].Cells[1].Value.ToString();
            prenomBox.Text = dataGridView1.Rows[position].Cells[2].Value.ToString();
            loginBox.Text = dataGridView1.Rows[position].Cells[3].Value.ToString();
            passwordBox.Text = dataGridView1.Rows[position].Cells[4].Value.ToString();
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void passwordBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void loginBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void prenomBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void nomBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
