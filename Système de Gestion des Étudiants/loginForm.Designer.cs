namespace Système_de_Gestion_des_Étudiants
{
    partial class loginForm
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelGestionscolaire = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonConnetLogin = new System.Windows.Forms.Button();
            this.textBoxNomUser = new System.Windows.Forms.TextBox();
            this.textBoxMotdepasse = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // labelGestionscolaire
            // 
            this.labelGestionscolaire.AutoSize = true;
            this.labelGestionscolaire.Font = new System.Drawing.Font("Times New Roman", 22F, System.Drawing.FontStyle.Bold);
            this.labelGestionscolaire.Location = new System.Drawing.Point(502, 37);
            this.labelGestionscolaire.Name = "labelGestionscolaire";
            this.labelGestionscolaire.Size = new System.Drawing.Size(753, 51);
            this.labelGestionscolaire.TabIndex = 1;
            this.labelGestionscolaire.Text = "SYSTEME DE GESTION SCOLAIRE";
            this.labelGestionscolaire.Click += new System.EventHandler(this.labelGestionscolaire_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(711, 154);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(310, 34);
            this.label1.TabIndex = 2;
            this.label1.Text = "Veillez-vous Authentifiez";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(534, 209);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(217, 34);
            this.label2.TabIndex = 3;
            this.label2.Text = "Nom d\'utilisateur";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(534, 305);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(172, 34);
            this.label3.TabIndex = 4;
            this.label3.Text = "Mot de passe";
            // 
            // buttonConnetLogin
            // 
            this.buttonConnetLogin.Location = new System.Drawing.Point(802, 358);
            this.buttonConnetLogin.Name = "buttonConnetLogin";
            this.buttonConnetLogin.Size = new System.Drawing.Size(192, 54);
            this.buttonConnetLogin.TabIndex = 5;
            this.buttonConnetLogin.Text = "Se Connecter";
            this.buttonConnetLogin.UseVisualStyleBackColor = true;
            this.buttonConnetLogin.Click += new System.EventHandler(this.buttonConnetLogin_Click);
            // 
            // textBoxNomUser
            // 
            this.textBoxNomUser.Location = new System.Drawing.Point(762, 209);
            this.textBoxNomUser.Multiline = true;
            this.textBoxNomUser.Name = "textBoxNomUser";
            this.textBoxNomUser.Size = new System.Drawing.Size(372, 44);
            this.textBoxNomUser.TabIndex = 7;
            // 
            // textBoxMotdepasse
            // 
            this.textBoxMotdepasse.Location = new System.Drawing.Point(728, 294);
            this.textBoxMotdepasse.Multiline = true;
            this.textBoxMotdepasse.Name = "textBoxMotdepasse";
            this.textBoxMotdepasse.Size = new System.Drawing.Size(406, 44);
            this.textBoxMotdepasse.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(796, 120);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(117, 25);
            this.label4.TabIndex = 9;
            this.label4.Text = "Bienvenue !";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Système_de_Gestion_des_Étudiants.Properties.Resources._152807291678280963;
            this.pictureBox1.Location = new System.Drawing.Point(-2, 37);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(498, 429);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // loginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1284, 545);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxMotdepasse);
            this.Controls.Add(this.textBoxNomUser);
            this.Controls.Add(this.buttonConnetLogin);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelGestionscolaire);
            this.Name = "loginForm";
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label labelGestionscolaire;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonConnetLogin;
        private System.Windows.Forms.TextBox textBoxNomUser;
        private System.Windows.Forms.TextBox textBoxMotdepasse;
        private System.Windows.Forms.Label label4;
    }
}

