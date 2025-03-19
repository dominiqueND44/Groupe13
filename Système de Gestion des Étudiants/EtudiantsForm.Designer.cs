namespace Système_de_Gestion_des_Étudiants
{
    partial class EtudiantsForm
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
            this.txtnom = new System.Windows.Forms.TextBox();
            this.labelNom = new System.Windows.Forms.Label();
            this.dataGridEtudiant = new System.Windows.Forms.DataGridView();
            this.SupprimerEtudiant = new System.Windows.Forms.Button();
            this.ModifierEtudiant = new System.Windows.Forms.Button();
            this.AjoutEtudiant = new System.Windows.Forms.Button();
            this.labelGestionscolaire = new System.Windows.Forms.Label();
            this.txtprenom = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtmatricule = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtemail = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtadresse = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txttelephone = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.cmbclasse = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.dtpdatenaissance = new System.Windows.Forms.DateTimePicker();
            this.textBoxRechercheetu = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.btnclose = new System.Windows.Forms.Button();
            this.cmbsexe = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridEtudiant)).BeginInit();
            this.SuspendLayout();
            // 
            // txtnom
            // 
            this.txtnom.Location = new System.Drawing.Point(121, 43);
            this.txtnom.Multiline = true;
            this.txtnom.Name = "txtnom";
            this.txtnom.Size = new System.Drawing.Size(189, 27);
            this.txtnom.TabIndex = 27;
            // 
            // labelNom
            // 
            this.labelNom.AutoSize = true;
            this.labelNom.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNom.Location = new System.Drawing.Point(16, 43);
            this.labelNom.Name = "labelNom";
            this.labelNom.Size = new System.Drawing.Size(50, 22);
            this.labelNom.TabIndex = 26;
            this.labelNom.Text = "Nom";
            // 
            // dataGridEtudiant
            // 
            this.dataGridEtudiant.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridEtudiant.Location = new System.Drawing.Point(649, 62);
            this.dataGridEtudiant.Name = "dataGridEtudiant";
            this.dataGridEtudiant.RowHeadersWidth = 62;
            this.dataGridEtudiant.RowTemplate.Height = 28;
            this.dataGridEtudiant.Size = new System.Drawing.Size(731, 457);
            this.dataGridEtudiant.TabIndex = 25;
            // 
            // SupprimerEtudiant
            // 
            this.SupprimerEtudiant.Location = new System.Drawing.Point(352, 472);
            this.SupprimerEtudiant.Name = "SupprimerEtudiant";
            this.SupprimerEtudiant.Size = new System.Drawing.Size(134, 46);
            this.SupprimerEtudiant.TabIndex = 24;
            this.SupprimerEtudiant.Text = "Supprimer";
            this.SupprimerEtudiant.UseVisualStyleBackColor = true;
            this.SupprimerEtudiant.Click += new System.EventHandler(this.SupprimerEtudiant_Click);
            // 
            // ModifierEtudiant
            // 
            this.ModifierEtudiant.Location = new System.Drawing.Point(182, 473);
            this.ModifierEtudiant.Name = "ModifierEtudiant";
            this.ModifierEtudiant.Size = new System.Drawing.Size(144, 46);
            this.ModifierEtudiant.TabIndex = 23;
            this.ModifierEtudiant.Text = "Modifier";
            this.ModifierEtudiant.UseVisualStyleBackColor = true;
            this.ModifierEtudiant.Click += new System.EventHandler(this.ModifierEtudiant_Click);
            // 
            // AjoutEtudiant
            // 
            this.AjoutEtudiant.Location = new System.Drawing.Point(16, 472);
            this.AjoutEtudiant.Name = "AjoutEtudiant";
            this.AjoutEtudiant.Size = new System.Drawing.Size(144, 46);
            this.AjoutEtudiant.TabIndex = 22;
            this.AjoutEtudiant.Text = "Ajouter";
            this.AjoutEtudiant.UseVisualStyleBackColor = true;
            this.AjoutEtudiant.Click += new System.EventHandler(this.AjoutEtudiant_Click);
            // 
            // labelGestionscolaire
            // 
            this.labelGestionscolaire.AutoSize = true;
            this.labelGestionscolaire.Font = new System.Drawing.Font("Times New Roman", 17F, System.Drawing.FontStyle.Bold);
            this.labelGestionscolaire.Location = new System.Drawing.Point(393, 9);
            this.labelGestionscolaire.Name = "labelGestionscolaire";
            this.labelGestionscolaire.Size = new System.Drawing.Size(466, 38);
            this.labelGestionscolaire.TabIndex = 21;
            this.labelGestionscolaire.Text = " GESTION DES ETUDIANTS";
            // 
            // txtprenom
            // 
            this.txtprenom.Location = new System.Drawing.Point(121, 103);
            this.txtprenom.Multiline = true;
            this.txtprenom.Name = "txtprenom";
            this.txtprenom.Size = new System.Drawing.Size(189, 27);
            this.txtprenom.TabIndex = 29;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 103);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 22);
            this.label1.TabIndex = 28;
            this.label1.Text = "Prénom";
            // 
            // txtmatricule
            // 
            this.txtmatricule.Location = new System.Drawing.Point(121, 160);
            this.txtmatricule.Multiline = true;
            this.txtmatricule.Name = "txtmatricule";
            this.txtmatricule.Size = new System.Drawing.Size(189, 27);
            this.txtmatricule.TabIndex = 31;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 160);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 22);
            this.label2.TabIndex = 30;
            this.label2.Text = "Matricule";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 218);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(176, 22);
            this.label3.TabIndex = 32;
            this.label3.Text = "Date de naissance";
            // 
            // txtemail
            // 
            this.txtemail.Location = new System.Drawing.Point(121, 282);
            this.txtemail.Multiline = true;
            this.txtemail.Name = "txtemail";
            this.txtemail.Size = new System.Drawing.Size(189, 27);
            this.txtemail.TabIndex = 35;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(14, 278);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 22);
            this.label4.TabIndex = 34;
            this.label4.Text = "E-mail";
            // 
            // txtadresse
            // 
            this.txtadresse.Location = new System.Drawing.Point(121, 343);
            this.txtadresse.Multiline = true;
            this.txtadresse.Name = "txtadresse";
            this.txtadresse.Size = new System.Drawing.Size(189, 27);
            this.txtadresse.TabIndex = 37;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(14, 343);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 22);
            this.label5.TabIndex = 36;
            this.label5.Text = "Adresse";
            // 
            // txttelephone
            // 
            this.txttelephone.Location = new System.Drawing.Point(121, 400);
            this.txttelephone.Multiline = true;
            this.txttelephone.Name = "txttelephone";
            this.txttelephone.Size = new System.Drawing.Size(189, 27);
            this.txttelephone.TabIndex = 39;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(12, 405);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(105, 22);
            this.label6.TabIndex = 38;
            this.label6.Text = "Téléphone";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(348, 343);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(55, 22);
            this.label7.TabIndex = 40;
            this.label7.Text = "Sexe";
            // 
            // cmbclasse
            // 
            this.cmbclasse.FormattingEnabled = true;
            this.cmbclasse.Location = new System.Drawing.Point(441, 399);
            this.cmbclasse.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmbclasse.Name = "cmbclasse";
            this.cmbclasse.Size = new System.Drawing.Size(126, 28);
            this.cmbclasse.TabIndex = 44;
            this.cmbclasse.SelectedIndexChanged += new System.EventHandler(this.cmbclasse_SelectedIndexChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(348, 405);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(71, 22);
            this.label8.TabIndex = 43;
            this.label8.Text = "Classe";
            // 
            // dtpdatenaissance
            // 
            this.dtpdatenaissance.Location = new System.Drawing.Point(202, 218);
            this.dtpdatenaissance.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dtpdatenaissance.Name = "dtpdatenaissance";
            this.dtpdatenaissance.Size = new System.Drawing.Size(259, 26);
            this.dtpdatenaissance.TabIndex = 45;
            // 
            // textBoxRechercheetu
            // 
            this.textBoxRechercheetu.Location = new System.Drawing.Point(1113, 17);
            this.textBoxRechercheetu.Multiline = true;
            this.textBoxRechercheetu.Name = "textBoxRechercheetu";
            this.textBoxRechercheetu.Size = new System.Drawing.Size(253, 33);
            this.textBoxRechercheetu.TabIndex = 47;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(986, 25);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(113, 22);
            this.label9.TabIndex = 46;
            this.label9.Text = "Rechercher";
            // 
            // btnclose
            // 
            this.btnclose.Location = new System.Drawing.Point(507, 471);
            this.btnclose.Name = "btnclose";
            this.btnclose.Size = new System.Drawing.Size(122, 47);
            this.btnclose.TabIndex = 50;
            this.btnclose.Text = "Fermer";
            this.btnclose.UseVisualStyleBackColor = true;
            this.btnclose.Click += new System.EventHandler(this.btnclose_Click);
            // 
            // cmbsexe
            // 
            this.cmbsexe.FormattingEnabled = true;
            this.cmbsexe.Items.AddRange(new object[] {
            "Feminin",
            "Masculin"});
            this.cmbsexe.Location = new System.Drawing.Point(441, 343);
            this.cmbsexe.Name = "cmbsexe";
            this.cmbsexe.Size = new System.Drawing.Size(126, 28);
            this.cmbsexe.TabIndex = 51;
            // 
            // EtudiantsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1384, 551);
            this.Controls.Add(this.cmbsexe);
            this.Controls.Add(this.btnclose);
            this.Controls.Add(this.textBoxRechercheetu);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.dtpdatenaissance);
            this.Controls.Add(this.cmbclasse);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txttelephone);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtadresse);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtemail);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtmatricule);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtprenom);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtnom);
            this.Controls.Add(this.labelNom);
            this.Controls.Add(this.dataGridEtudiant);
            this.Controls.Add(this.SupprimerEtudiant);
            this.Controls.Add(this.ModifierEtudiant);
            this.Controls.Add(this.AjoutEtudiant);
            this.Controls.Add(this.labelGestionscolaire);
            this.Name = "EtudiantsForm";
            this.Text = "Etudiants";
            this.Load += new System.EventHandler(this.EtudiantsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridEtudiant)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtnom;
        private System.Windows.Forms.Label labelNom;
        private System.Windows.Forms.DataGridView dataGridEtudiant;
        private System.Windows.Forms.Button SupprimerEtudiant;
        private System.Windows.Forms.Button ModifierEtudiant;
        private System.Windows.Forms.Button AjoutEtudiant;
        private System.Windows.Forms.Label labelGestionscolaire;
        private System.Windows.Forms.TextBox txtprenom;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtmatricule;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtemail;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtadresse;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txttelephone;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cmbclasse;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker dtpdatenaissance;
        private System.Windows.Forms.TextBox textBoxRechercheetu;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnclose;
        private System.Windows.Forms.ComboBox cmbsexe;
    }
}