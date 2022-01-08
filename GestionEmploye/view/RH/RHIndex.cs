using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestionEmploye.view.RH
{
    public partial class RHIndex : Form
    {
        string user;
        public RHIndex()
        {
            InitializeComponent();

        }
        public RHIndex(string user)
        {
            this.user = user;
            InitializeComponent();
            pointage1.Hide();
            paie1.Hide();
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            pointage1.Show();
            paie1.Hide();
            pointage1.BringToFront();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            pointage1.Hide();
            paie1.btnlist_Click(sender, e);
            paie1.Show();
            paie1.BringToFront();
            
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Close();
            index i = new index();
            i.Show();
        }
    }
}
