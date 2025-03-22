namespace Système_de_Gestion_des_Étudiants
{
    partial class UsersForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBoxTelUser = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxmdp = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxNomUser = new System.Windows.Forms.TextBox();
            this.labelNom = new System.Windows.Forms.Label();
            this.dataGridUser = new System.Windows.Forms.DataGridView();
            this.SupprimerUser = new System.Windows.Forms.Button();
            this.ModifierUser = new System.Windows.Forms.Button();
            this.AjoutProfesseur = new System.Windows.Forms.Button();
            this.labelGestionscolaire = new System.Windows.Forms.Label();
            this.comboBoxRole = new System.Windows.Forms.ComboBox();
            this.ViderChamps = new System.Windows.Forms.Button();
            this.FermerFenetre = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridUser)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxTelUser
            // 
            this.textBoxTelUser.Location = new System.Drawing.Point(200, 308);
            this.textBoxTelUser.Multiline = true;
            this.textBoxTelUser.Name = "textBoxTelUser";
            this.textBoxTelUser.Size = new System.Drawing.Size(238, 27);
            this.textBoxTelUser.TabIndex = 65;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(8, 314);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(105, 22);
            this.label6.TabIndex = 64;
            this.label6.Text = "Téléphone";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(16, 240);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 22);
            this.label4.TabIndex = 62;
            this.label4.Text = "Role";
            // 
            // textBoxmdp
            // 
            this.textBoxmdp.Location = new System.Drawing.Point(200, 162);
            this.textBoxmdp.Multiline = true;
            this.textBoxmdp.Name = "textBoxmdp";
            this.textBoxmdp.Size = new System.Drawing.Size(238, 27);
            this.textBoxmdp.TabIndex = 61;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(15, 163);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 22);
            this.label1.TabIndex = 60;
            this.label1.Text = "Mot de passe";
            // 
            // textBoxNomUser
            // 
            this.textBoxNomUser.Location = new System.Drawing.Point(200, 92);
            this.textBoxNomUser.Multiline = true;
            this.textBoxNomUser.Name = "textBoxNomUser";
            this.textBoxNomUser.Size = new System.Drawing.Size(238, 27);
            this.textBoxNomUser.TabIndex = 59;
            // 
            // labelNom
            // 
            this.labelNom.AutoSize = true;
            this.labelNom.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNom.Location = new System.Drawing.Point(15, 92);
            this.labelNom.Name = "labelNom";
            this.labelNom.Size = new System.Drawing.Size(160, 22);
            this.labelNom.TabIndex = 58;
            this.labelNom.Text = "Nom d\'utilisateur";
            // 
            // dataGridUser
            // 
            this.dataGridUser.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridUser.Location = new System.Drawing.Point(565, 51);
            this.dataGridUser.Name = "dataGridUser";
            this.dataGridUser.RowHeadersWidth = 62;
            this.dataGridUser.RowTemplate.Height = 28;
            this.dataGridUser.Size = new System.Drawing.Size(723, 426);
            this.dataGridUser.TabIndex = 57;
            // 
            // SupprimerUser
            // 
            this.SupprimerUser.Location = new System.Drawing.Point(394, 375);
            this.SupprimerUser.Name = "SupprimerUser";
            this.SupprimerUser.Size = new System.Drawing.Size(134, 46);
            this.SupprimerUser.TabIndex = 56;
            this.SupprimerUser.Text = "Supprimer";
            this.SupprimerUser.UseVisualStyleBackColor = true;
            this.SupprimerUser.Click += new System.EventHandler(this.SupprimerUser_Click);
            // 
            // ModifierUser
            // 
            this.ModifierUser.Location = new System.Drawing.Point(200, 375);
            this.ModifierUser.Name = "ModifierUser";
            this.ModifierUser.Size = new System.Drawing.Size(144, 46);
            this.ModifierUser.TabIndex = 55;
            this.ModifierUser.Text = "Modifier";
            this.ModifierUser.UseVisualStyleBackColor = true;
            this.ModifierUser.Click += new System.EventHandler(this.ModifierUser_Click);
            // 
            // AjoutProfesseur
            // 
            this.AjoutProfesseur.Location = new System.Drawing.Point(12, 376);
            this.AjoutProfesseur.Name = "AjoutProfesseur";
            this.AjoutProfesseur.Size = new System.Drawing.Size(144, 46);
            this.AjoutProfesseur.TabIndex = 54;
            this.AjoutProfesseur.Text = "Ajouter";
            this.AjoutProfesseur.UseVisualStyleBackColor = true;
            this.AjoutProfesseur.Click += new System.EventHandler(this.AjoutProfesseur_Click);
            // 
            // labelGestionscolaire
            // 
            this.labelGestionscolaire.AutoSize = true;
            this.labelGestionscolaire.Font = new System.Drawing.Font("Times New Roman", 17F, System.Drawing.FontStyle.Bold);
            this.labelGestionscolaire.Location = new System.Drawing.Point(420, 0);
            this.labelGestionscolaire.Name = "labelGestionscolaire";
            this.labelGestionscolaire.Size = new System.Drawing.Size(518, 38);
            this.labelGestionscolaire.TabIndex = 53;
            this.labelGestionscolaire.Text = " GESTION DES UTILISATEURS";
            // 
            // comboBoxRole
            // 
            this.comboBoxRole.FormattingEnabled = true;
            this.comboBoxRole.Location = new System.Drawing.Point(200, 238);
            this.comboBoxRole.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.comboBoxRole.Name = "comboBoxRole";
            this.comboBoxRole.Size = new System.Drawing.Size(238, 28);
            this.comboBoxRole.TabIndex = 66;
            // 
            // ViderChamps
            // 
            this.ViderChamps.Location = new System.Drawing.Point(110, 447);
            this.ViderChamps.Name = "ViderChamps";
            this.ViderChamps.Size = new System.Drawing.Size(144, 46);
            this.ViderChamps.TabIndex = 67;
            this.ViderChamps.Text = "Vider les Champs";
            this.ViderChamps.UseVisualStyleBackColor = true;
            this.ViderChamps.Click += new System.EventHandler(this.ViderChamps_Click);
            // 
            // FermerFenetre
            // 
            this.FermerFenetre.Location = new System.Drawing.Point(294, 447);
            this.FermerFenetre.Name = "FermerFenetre";
            this.FermerFenetre.Size = new System.Drawing.Size(144, 46);
            this.FermerFenetre.TabIndex = 68;
            this.FermerFenetre.Text = "Fermer";
            this.FermerFenetre.UseVisualStyleBackColor = true;
            this.FermerFenetre.Click += new System.EventHandler(this.FermerFenetre_Click);
            // 
            // UsersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1300, 505);
            this.Controls.Add(this.FermerFenetre);
            this.Controls.Add(this.ViderChamps);
            this.Controls.Add(this.comboBoxRole);
            this.Controls.Add(this.textBoxTelUser);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxmdp);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxNomUser);
            this.Controls.Add(this.labelNom);
            this.Controls.Add(this.dataGridUser);
            this.Controls.Add(this.SupprimerUser);
            this.Controls.Add(this.ModifierUser);
            this.Controls.Add(this.AjoutProfesseur);
            this.Controls.Add(this.labelGestionscolaire);
            this.Name = "UsersForm";
            this.Text = "Utilisateurs";
            this.Load += new System.EventHandler(this.UsersForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridUser)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxTelUser;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxmdp;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxNomUser;
        private System.Windows.Forms.Label labelNom;
        private System.Windows.Forms.DataGridView dataGridUser;
        private System.Windows.Forms.Button SupprimerUser;
        private System.Windows.Forms.Button ModifierUser;
        private System.Windows.Forms.Button AjoutProfesseur;
        private System.Windows.Forms.Label labelGestionscolaire;
        private System.Windows.Forms.ComboBox comboBoxRole;
        private System.Windows.Forms.Button ViderChamps;
        private System.Windows.Forms.Button FermerFenetre;
    }
}