using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestionEmploye.view
{
    public partial class index : Form
    {
        public index()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            login a = new login("admin");
            this.Hide();
            a.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            login b = new login("Employé");
            this.Hide();
            b.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            login c = new login("RH");
            this.Hide();
            c.Show();
        }
    }
}
