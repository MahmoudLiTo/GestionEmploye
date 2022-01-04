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
        List<gradeModel> mylist = new List<gradeModel>();
        List<departementModel> mylist2 = new List<departementModel>();

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int id_combobox = comboBox1.SelectedIndex;
            int id_grad = mylist[0];

        }
        
        private void employe_Load(object sender, EventArgs e)
        {
            controllerUsers db = new controllerUsers();
            mylist = db.listGrade();
            comboBox1.Items.Clear();
            foreach (gradeModel g in mylist)
            {
                comboBox1.Items.Add(g.Nom);
            }



            controllerUsers dba = new controllerUsers();
            mylist2 = dba.listDepartement();
            comboBox2.Items.Clear();
            foreach (departementModel g in mylist2)
            {
                comboBox2.Items.Add(g.Nom);
            }

        }
    }
}
