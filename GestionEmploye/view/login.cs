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
using GestionEmploye.view.admin;
using GestionEmploye.view.employe;
using GestionEmploye.view.RH;

namespace GestionEmploye.view
{
    public partial class login : Form
    {
        string usertype;
        public login(string usertype)
        {
            this.usertype = usertype;
            InitializeComponent();
        }

        private void login_Load(object sender, EventArgs e)
        {
            label1.Text +=" "+usertype.ToUpper();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            if(textBox2.UseSystemPasswordChar == true) {
                textBox2.UseSystemPasswordChar = false;
            }
            else
            {
                textBox2.UseSystemPasswordChar = true;
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            index i = new index();
            i.Show();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            controllerUsers db = new controllerUsers();
            if (usertype == "admin")
            {
                if(db.loginAdmin(new adminModel(textBox1.Text.Trim(), textBox2.Text.Trim())))
                {
                    indexAdmin adi = new indexAdmin(textBox1.Text.Trim());
                    this.Close();
                    adi.Show();
                }
                else
                {
                    MessageBox.Show("Les Informations Entrées Sont Invalides");
                    textBox2.Text = "";
                }
            }
            if (usertype == "employé")
            {

                if(db.loginEmploye(new employeModel(textBox1.Text.Trim(), textBox2.Text.Trim())))
                {
                    indexEmploye emi = new indexEmploye(textBox1.Text.Trim());
                    this.Close();
                    emi.Show();
                }
                else
                {
                    MessageBox.Show("Les Informations Entrées Sont Invalides");
                    textBox2.Text = "";
                }

            }
            if (usertype == "RH")
            {
                if(db.loginRH(new RHModel(textBox1.Text.Trim(), textBox2.Text.Trim())))
                {
                    RHIndex rhi = new RHIndex(textBox1.Text.Trim());
                    this.Close();
                    rhi.Show();
                }
                else
                {
                    MessageBox.Show("Les Informations Entrées Sont Invalides");
                    textBox2.Text = "";
                }

            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
