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
    public partial class loginForm: Form
    {
        public loginForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void labelGestionscolaire_Click(object sender, EventArgs e)
        {

        }

        private void buttonConnetLogin_Click(object sender, EventArgs e)
        {
       
            using (var db = new DBGestionContext()) 
            {
                Utilisateur utilisateur = db.Utilisateurs.FirstOrDefault(u => u.NomUtilisateur == textBoxNomUser.Text);

                if (utilisateur != null && BCrypt.Net.BCrypt.Verify(textBoxMotdepasse.Text, utilisateur.MotDePasse))
                {
                    // Générer et envoyer OTP
                    A2FService.SendOtp(utilisateur.Telephone);

                    // Ouvrir la fenêtre OTP
                    var otpForm = new OTPForm (utilisateur.Telephone,utilisateur);
                    otpForm.Show();
                    this.Hide(); // Masquer la fenêtre de connexion
                }
                else
                {
                    MessageBox.Show("Nom d'utilisateur ou mot de passe incorrect !");
                }
            }
        }

    }
}
