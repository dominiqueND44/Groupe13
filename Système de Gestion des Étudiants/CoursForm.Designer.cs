namespace Système_de_Gestion_des_Étudiants
{
    partial class CoursForm
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
            this.labelGestionscolaire = new System.Windows.Forms.Label();
            this.textBoxNomCours = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridCours = new System.Windows.Forms.DataGridView();
            this.SupprimerCours = new System.Windows.Forms.Button();
            this.ModifierCours = new System.Windows.Forms.Button();
            this.AjoutCours = new System.Windows.Forms.Button();
            this.textBoxDescriptionCours = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.AjoutMatiere = new System.Windows.Forms.Button();
            this.ViderChamps = new System.Windows.Forms.Button();
            this.FermerFenetre = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridCours)).BeginInit();
            this.SuspendLayout();
            // 
            // labelGestionscolaire
            // 
            this.labelGestionscolaire.AutoSize = true;
            this.labelGestionscolaire.Font = new System.Drawing.Font("Times New Roman", 17F, System.Drawing.FontStyle.Bold);
            this.labelGestionscolaire.Location = new System.Drawing.Point(536, 14);
            this.labelGestionscolaire.Name = "labelGestionscolaire";
            this.labelGestionscolaire.Size = new System.Drawing.Size(628, 38);
            this.labelGestionscolaire.TabIndex = 21;
            this.labelGestionscolaire.Text = " GESTION DES MATIERES ET COURS";
            // 
            // textBoxNomCours
            // 
            this.textBoxNomCours.Location = new System.Drawing.Point(153, 82);
            this.textBoxNomCours.Multiline = true;
            this.textBoxNomCours.Name = "textBoxNomCours";
            this.textBoxNomCours.Size = new System.Drawing.Size(211, 36);
            this.textBoxNomCours.TabIndex = 33;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(28, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 29);
            this.label1.TabIndex = 32;
            this.label1.Text = "Cours";
            // 
            // dataGridCours
            // 
            this.dataGridCours.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridCours.Location = new System.Drawing.Point(564, 55);
            this.dataGridCours.Name = "dataGridCours";
            this.dataGridCours.RowHeadersWidth = 62;
            this.dataGridCours.RowTemplate.Height = 28;
            this.dataGridCours.Size = new System.Drawing.Size(664, 458);
            this.dataGridCours.TabIndex = 31;
            // 
            // SupprimerCours
            // 
            this.SupprimerCours.Location = new System.Drawing.Point(368, 248);
            this.SupprimerCours.Name = "SupprimerCours";
            this.SupprimerCours.Size = new System.Drawing.Size(134, 46);
            this.SupprimerCours.TabIndex = 30;
            this.SupprimerCours.Text = "Supprimer";
            this.SupprimerCours.UseVisualStyleBackColor = true;
            this.SupprimerCours.Click += new System.EventHandler(this.SupprimerCours_Click);
            // 
            // ModifierCours
            // 
            this.ModifierCours.Location = new System.Drawing.Point(198, 248);
            this.ModifierCours.Name = "ModifierCours";
            this.ModifierCours.Size = new System.Drawing.Size(144, 46);
            this.ModifierCours.TabIndex = 29;
            this.ModifierCours.Text = "Modifier";
            this.ModifierCours.UseVisualStyleBackColor = true;
            this.ModifierCours.Click += new System.EventHandler(this.button2_Click);
            // 
            // AjoutCours
            // 
            this.AjoutCours.Location = new System.Drawing.Point(26, 248);
            this.AjoutCours.Name = "AjoutCours";
            this.AjoutCours.Size = new System.Drawing.Size(144, 46);
            this.AjoutCours.TabIndex = 28;
            this.AjoutCours.Text = "Ajouter";
            this.AjoutCours.UseVisualStyleBackColor = true;
            this.AjoutCours.Click += new System.EventHandler(this.AjoutCours_Click);
            // 
            // textBoxDescriptionCours
            // 
            this.textBoxDescriptionCours.Location = new System.Drawing.Point(198, 146);
            this.textBoxDescriptionCours.Multiline = true;
            this.textBoxDescriptionCours.Name = "textBoxDescriptionCours";
            this.textBoxDescriptionCours.Size = new System.Drawing.Size(301, 76);
            this.textBoxDescriptionCours.TabIndex = 39;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(21, 155);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(146, 29);
            this.label5.TabIndex = 38;
            this.label5.Text = "Description";
            // 
            // AjoutMatiere
            // 
            this.AjoutMatiere.Location = new System.Drawing.Point(198, 322);
            this.AjoutMatiere.Name = "AjoutMatiere";
            this.AjoutMatiere.Size = new System.Drawing.Size(144, 46);
            this.AjoutMatiere.TabIndex = 40;
            this.AjoutMatiere.Text = "Ajouter Matiere";
            this.AjoutMatiere.UseVisualStyleBackColor = true;
            this.AjoutMatiere.Click += new System.EventHandler(this.AjoutMatiere_Click);
            // 
            // ViderChamps
            // 
            this.ViderChamps.Location = new System.Drawing.Point(26, 322);
            this.ViderChamps.Name = "ViderChamps";
            this.ViderChamps.Size = new System.Drawing.Size(144, 46);
            this.ViderChamps.TabIndex = 41;
            this.ViderChamps.Text = "Vider les champs";
            this.ViderChamps.UseVisualStyleBackColor = true;
            this.ViderChamps.Click += new System.EventHandler(this.ViderChamps_Click);
            // 
            // FermerFenetre
            // 
            this.FermerFenetre.Location = new System.Drawing.Point(368, 322);
            this.FermerFenetre.Name = "FermerFenetre";
            this.FermerFenetre.Size = new System.Drawing.Size(144, 46);
            this.FermerFenetre.TabIndex = 42;
            this.FermerFenetre.Text = "Fermer";
            this.FermerFenetre.UseVisualStyleBackColor = true;
            this.FermerFenetre.Click += new System.EventHandler(this.FermerFenetre_Click);
            // 
            // CoursForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1245, 531);
            this.Controls.Add(this.FermerFenetre);
            this.Controls.Add(this.ViderChamps);
            this.Controls.Add(this.AjoutMatiere);
            this.Controls.Add(this.textBoxDescriptionCours);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBoxNomCours);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridCours);
            this.Controls.Add(this.SupprimerCours);
            this.Controls.Add(this.ModifierCours);
            this.Controls.Add(this.AjoutCours);
            this.Controls.Add(this.labelGestionscolaire);
            this.Name = "CoursForm";
            this.Text = "Gestion Cours ";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridCours)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label labelGestionscolaire;
        private System.Windows.Forms.TextBox textBoxNomCours;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridCours;
        private System.Windows.Forms.Button SupprimerCours;
        private System.Windows.Forms.Button ModifierCours;
        private System.Windows.Forms.Button AjoutCours;
        private System.Windows.Forms.TextBox textBoxDescriptionCours;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button AjoutMatiere;
        private System.Windows.Forms.Button ViderChamps;
        private System.Windows.Forms.Button FermerFenetre;
    }
}