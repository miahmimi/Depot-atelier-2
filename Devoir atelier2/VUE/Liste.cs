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
            btnAjouter.Focus();
            VUE.Ajout frm = new VUE.Ajout();
            frm.Show();
        }

        private void btnSupprimer_Click(object sender, EventArgs e)
        {
            Int32 selectedCellCount =Listeperso .GetCellCount(DataGridViewElementStates.Selected);
            if (selectedCellCount == 1)
            {
                Listeperso.Rows.RemoveAt(selectedCellCount);
            }
            else
            {
                MessageBox.Show("Veuillez selectionner une ligne ");
            }
        }
    }
}
