using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
        public Authentification()
        {
            InitializeComponent();
            
           
        }

        private void Form1_Load(object sender, EventArgs e)
        {
         
        }

        private void btnValiderconnec_Click(object sender, EventArgs e)
        {
            if (txtLogin.Text == "new" && txtPwr.Text == "123")
            {


                VUE.Liste frm = new VUE.Liste();
                frm.Show();
                this.Hide();

                MySqlConnection connexion = new MySqlConnection("Server=localhost;Database=atelier2;Uid=newutilisateur;Pwd=NjJqebA1B53LMGQ8");
                try
                {

                    connexion.Open();
                    string requete = "Select*from personnel ";
                    MySqlCommand cmd = new MySqlCommand(requete, connexion);
                    MySqlDataReader reader = null;
                    reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        frm.Listeperso.Rows.Add(reader[0].ToString(), reader[1].ToString(), reader[2].ToString(), reader[3].ToString(), reader[4].ToString(), reader[5].ToString());
                    }

                }
                catch (Exception ex)
                {
                    connexion.Close();

                }
            }
            else
            {
                MessageBox.Show("Erreur!");
                txtLogin.Clear();
                txtLogin.Focus();
                txtPwr.Clear();

            }

        }

        private void txtLogin_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
