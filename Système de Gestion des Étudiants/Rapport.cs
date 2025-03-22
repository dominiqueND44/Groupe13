using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Système_de_Gestion_des_Étudiants
{
    public partial class Rapport: Form
    {
        public Rapport()
        {
            InitializeComponent();
        }

        private void GenererReleveEtudiant_Click(object sender, EventArgs e)
        {
            GenererReleveEtu form = new GenererReleveEtu();
            form.Show();
        }

        private void GenererListeMeilleure_Click(object sender, EventArgs e)
        {
            GenererListeMeilleureEtu form = new GenererListeMeilleureEtu();
            form.Show();
        }

        private void GenererListeETUCLASSE_Click(object sender, EventArgs e)
        {
            GenererListeEtuClasse form = new GenererListeEtuClasse();
            form.Show();
        }

        private void FermerFenetre_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
