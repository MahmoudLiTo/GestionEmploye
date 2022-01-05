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
        controllerUsers db;


        public departement()
        {
            db = new controllerUsers();
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
