﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Devoir_atelier2
{
    public partial class Authentification : Form
    {
      

        private void Form1_Load(object sender, EventArgs e)
        {
            

        }

        private void btnValiderconnec_Click(object sender, EventArgs e)
        {
            if (txtLogin.Text == "new" && txtPwr.Text == "123")
            {

                btnValiderconnec.Focus();
                VUE.Liste frm = new VUE.Liste();
                frm.Show();
                this.Hide();

            }



            else
            {
                MessageBox.Show("Erreur!");
                txtLogin.Clear();
                txtLogin.Focus();
            }
                txtPwr.Clear();

            

        }

        private void txtLogin_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
