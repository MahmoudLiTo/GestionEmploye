using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using GestionEmploye.model;
using GestionEmploye.controller;
using GestionEmploye.view.UserControls;

namespace GestionEmploye.view.admin
{
    public partial class indexAdmin : Form
    {
        string user;
        public indexAdmin()
        {
            
            InitializeComponent();

        }
        public indexAdmin(string user)
        {
            this.user = user;
            InitializeComponent();
            employe1.Hide();
            departement1.Hide();
            grade1.Hide();
            rh1.Hide();
        }


        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            employe1.employe_Load(sender,e);
            employe1.Show();
            departement1.Hide();
            grade1.Hide();
            rh1.Hide();
            employe1.BringToFront();
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            employe1.Hide();
            departement1.Hide();
            grade1.Hide();
            rh1.Show();
            rh1.BringToFront();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            employe1.Hide();
            departement1.Hide();
            grade1.Show();
            rh1.Hide();
            grade1.BringToFront();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            employe1.Hide();
            departement1.Show();
            grade1.Hide();
            rh1.Hide();
            departement1.BringToFront();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void indexAdmin_Load(object sender, EventArgs e)
        {
            
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Close();
            index i = new index();
            i.Show();
        }
    }
}
