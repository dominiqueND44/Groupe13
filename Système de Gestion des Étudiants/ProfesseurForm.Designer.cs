namespace Système_de_Gestion_des_Étudiants
{
    partial class ProfesseurForm
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
            this.textBoxTelprof = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxEmailprof = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxPrenomprof = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxNomprof = new System.Windows.Forms.TextBox();
            this.labelNom = new System.Windows.Forms.Label();
            this.dataGridProfesseur = new System.Windows.Forms.DataGridView();
            this.SupprimerProfesseur = new System.Windows.Forms.Button();
            this.ModifierProfesseur = new System.Windows.Forms.Button();
            this.AjoutProfesseur = new System.Windows.Forms.Button();
            this.labelGestionscolaire = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.ViderChamps = new System.Windows.Forms.Button();
            this.FermerFenetre = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridProfesseur)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxTelprof
            // 
            this.textBoxTelprof.Location = new System.Drawing.Point(135, 338);
            this.textBoxTelprof.Multiline = true;
            this.textBoxTelprof.Name = "textBoxTelprof";
            this.textBoxTelprof.Size = new System.Drawing.Size(199, 27);
            this.textBoxTelprof.TabIndex = 52;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(16, 340);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(105, 22);
            this.label6.TabIndex = 51;
            this.label6.Text = "Téléphone";
            // 
            // textBoxEmailprof
            // 
            this.textBoxEmailprof.Location = new System.Drawing.Point(135, 260);
            this.textBoxEmailprof.Multiline = true;
            this.textBoxEmailprof.Name = "textBoxEmailprof";
            this.textBoxEmailprof.Size = new System.Drawing.Size(230, 27);
            this.textBoxEmailprof.TabIndex = 50;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(24, 266);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 22);
            this.label4.TabIndex = 49;
            this.label4.Text = "E-mail";
            // 
            // textBoxPrenomprof
            // 
            this.textBoxPrenomprof.Location = new System.Drawing.Point(134, 188);
            this.textBoxPrenomprof.Multiline = true;
            this.textBoxPrenomprof.Name = "textBoxPrenomprof";
            this.textBoxPrenomprof.Size = new System.Drawing.Size(265, 27);
            this.textBoxPrenomprof.TabIndex = 48;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(24, 189);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 22);
            this.label1.TabIndex = 47;
            this.label1.Text = "Prénom";
            // 
            // textBoxNomprof
            // 
            this.textBoxNomprof.Location = new System.Drawing.Point(134, 118);
            this.textBoxNomprof.Multiline = true;
            this.textBoxNomprof.Name = "textBoxNomprof";
            this.textBoxNomprof.Size = new System.Drawing.Size(199, 27);
            this.textBoxNomprof.TabIndex = 46;
            // 
            // labelNom
            // 
            this.labelNom.AutoSize = true;
            this.labelNom.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNom.Location = new System.Drawing.Point(24, 118);
            this.labelNom.Name = "labelNom";
            this.labelNom.Size = new System.Drawing.Size(50, 22);
            this.labelNom.TabIndex = 45;
            this.labelNom.Text = "Nom";
            // 
            // dataGridProfesseur
            // 
            this.dataGridProfesseur.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridProfesseur.Location = new System.Drawing.Point(561, 88);
            this.dataGridProfesseur.Name = "dataGridProfesseur";
            this.dataGridProfesseur.RowHeadersWidth = 62;
            this.dataGridProfesseur.RowTemplate.Height = 28;
            this.dataGridProfesseur.Size = new System.Drawing.Size(723, 443);
            this.dataGridProfesseur.TabIndex = 44;
            // 
            // SupprimerProfesseur
            // 
            this.SupprimerProfesseur.Location = new System.Drawing.Point(404, 425);
            this.SupprimerProfesseur.Name = "SupprimerProfesseur";
            this.SupprimerProfesseur.Size = new System.Drawing.Size(134, 46);
            this.SupprimerProfesseur.TabIndex = 43;
            this.SupprimerProfesseur.Text = "Supprimer";
            this.SupprimerProfesseur.UseVisualStyleBackColor = true;
            this.SupprimerProfesseur.Click += new System.EventHandler(this.SupprimerProfesseur_Click);
            // 
            // ModifierProfesseur
            // 
            this.ModifierProfesseur.Location = new System.Drawing.Point(208, 425);
            this.ModifierProfesseur.Name = "ModifierProfesseur";
            this.ModifierProfesseur.Size = new System.Drawing.Size(144, 46);
            this.ModifierProfesseur.TabIndex = 42;
            this.ModifierProfesseur.Text = "Modifier";
            this.ModifierProfesseur.UseVisualStyleBackColor = true;
            this.ModifierProfesseur.Click += new System.EventHandler(this.ModifierProfesseur_Click);
            // 
            // AjoutProfesseur
            // 
            this.AjoutProfesseur.Location = new System.Drawing.Point(12, 425);
            this.AjoutProfesseur.Name = "AjoutProfesseur";
            this.AjoutProfesseur.Size = new System.Drawing.Size(144, 46);
            this.AjoutProfesseur.TabIndex = 41;
            this.AjoutProfesseur.Text = "Ajouter";
            this.AjoutProfesseur.UseVisualStyleBackColor = true;
            this.AjoutProfesseur.Click += new System.EventHandler(this.AjoutProfesseur_Click);
            // 
            // labelGestionscolaire
            // 
            this.labelGestionscolaire.AutoSize = true;
            this.labelGestionscolaire.Font = new System.Drawing.Font("Times New Roman", 17F, System.Drawing.FontStyle.Bold);
            this.labelGestionscolaire.Location = new System.Drawing.Point(429, 26);
            this.labelGestionscolaire.Name = "labelGestionscolaire";
            this.labelGestionscolaire.Size = new System.Drawing.Size(512, 38);
            this.labelGestionscolaire.TabIndex = 40;
            this.labelGestionscolaire.Text = " GESTION DES PROFESSEURS";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 494);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(246, 46);
            this.button1.TabIndex = 53;
            this.button1.Text = "Associer à une ou des matières";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(290, 494);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(248, 46);
            this.button2.TabIndex = 54;
            this.button2.Text = "Associer à une ou des classe";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // ViderChamps
            // 
            this.ViderChamps.Location = new System.Drawing.Point(28, 39);
            this.ViderChamps.Name = "ViderChamps";
            this.ViderChamps.Size = new System.Drawing.Size(144, 46);
            this.ViderChamps.TabIndex = 68;
            this.ViderChamps.Text = "Vider les Champs";
            this.ViderChamps.UseVisualStyleBackColor = true;
            this.ViderChamps.Click += new System.EventHandler(this.ViderChamps_Click);
            // 
            // FermerFenetre
            // 
            this.FermerFenetre.Location = new System.Drawing.Point(221, 39);
            this.FermerFenetre.Name = "FermerFenetre";
            this.FermerFenetre.Size = new System.Drawing.Size(144, 46);
            this.FermerFenetre.TabIndex = 69;
            this.FermerFenetre.Text = "Fermer";
            this.FermerFenetre.UseVisualStyleBackColor = true;
            this.FermerFenetre.Click += new System.EventHandler(this.FermerFenetre_Click);
            // 
            // ProfesseurForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1322, 557);
            this.Controls.Add(this.FermerFenetre);
            this.Controls.Add(this.ViderChamps);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBoxTelprof);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBoxEmailprof);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxPrenomprof);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxNomprof);
            this.Controls.Add(this.labelNom);
            this.Controls.Add(this.dataGridProfesseur);
            this.Controls.Add(this.SupprimerProfesseur);
            this.Controls.Add(this.ModifierProfesseur);
            this.Controls.Add(this.AjoutProfesseur);
            this.Controls.Add(this.labelGestionscolaire);
            this.Name = "ProfesseurForm";
            this.Text = "Professeurs";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridProfesseur)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxTelprof;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxEmailprof;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxPrenomprof;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxNomprof;
        private System.Windows.Forms.Label labelNom;
        private System.Windows.Forms.DataGridView dataGridProfesseur;
        private System.Windows.Forms.Button SupprimerProfesseur;
        private System.Windows.Forms.Button ModifierProfesseur;
        private System.Windows.Forms.Button AjoutProfesseur;
        private System.Windows.Forms.Label labelGestionscolaire;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button ViderChamps;
        private System.Windows.Forms.Button FermerFenetre;
    }
}