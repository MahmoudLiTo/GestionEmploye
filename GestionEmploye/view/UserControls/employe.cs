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
        controllerUsers db;
        List<gradeModel> mygradelist;
        List<departementModel> mydepartmentlist;

        public employe()
        {
            db = new controllerUsers();
            mygradelist = db.listGrade();
            mydepartmentlist = new List<departementModel>();
            InitializeComponent();
        }

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
            int index = comboBox1.SelectedIndex;
            gradeModel selectedGrade = mygradelist[index];

        }
        
        private void employe_Load(object sender, EventArgs e)
        {
            comboBox1.Items.Clear();
            foreach (gradeModel g in mygradelist)
            {
                comboBox1.Items.Add(g.Nom);
            }



            comboBox2.Items.Clear();
            foreach (departementModel d in mydepartmentlist)
            {
                comboBox2.Items.Add(d.Nom);
            }




        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
