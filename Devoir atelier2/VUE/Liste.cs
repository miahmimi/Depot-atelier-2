using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Devoir_atelier2.VUE
{
    public partial class Liste : Form
    {
        public Liste()
        {
            InitializeComponent();

            
        }

        private void Listeperso_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void btnAjouter_Click(object sender, EventArgs e)
        {
           
        }

        private void btnSupprimer_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult rep = MessageBox.Show("voulez vous vraiment supprimer ?", "Confirmation", MessageBoxButtons.OKCancel);
                if (rep == DialogResult.OK)
                {
                    int index = this.Listeperso.CurrentRow.Index;
                    this.Listeperso.Rows.RemoveAt(index);
                }
                else
                {
                    MessageBox.Show("suppression annulée ");
                }
            }catch(Exception)
            {
                MessageBox.Show ("Liste vide ");
            }
        
        }

        private void Liste_Load(object sender, EventArgs e)
        {

        }
    }
}
