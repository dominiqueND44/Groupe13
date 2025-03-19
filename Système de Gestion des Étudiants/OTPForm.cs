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
    public partial class OTPForm : Form
    {
        private string userPhoneNumber;
        private Utilisateur currentUser;

       

        internal OTPForm(string phoneNumber, Utilisateur user) 
        {
            userPhoneNumber = phoneNumber;
            currentUser = user;
            InitializeComponent();
        }

        private void AjoutClasse_Click(object sender, EventArgs e)
        {
            string enteredOtp = textBoxNomCode.Text;  // Code OTP saisi par l'utilisateur

            if (A2FService.VerifyOtp(userPhoneNumber, enteredOtp))
            {
                MessageBox.Show("Code OTP vérifié avec succès !");
                this.Close();
                FormManager.ShowDashboardForm(currentUser);
            }
            else
            {
                MessageBox.Show("Le code OTP est invalide ou expiré !");
            }
        }

        private void OTPForm_Load(object sender, EventArgs e)
        {

        }
    }
}
  