﻿using System;
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
    }
}
