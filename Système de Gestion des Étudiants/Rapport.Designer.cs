namespace Système_de_Gestion_des_Étudiants
{
    partial class Rapport
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
            this.GenererReleveEtudiant = new System.Windows.Forms.Button();
            this.GenererListeETUCLASSE = new System.Windows.Forms.Button();
            this.GenererListeMeilleure = new System.Windows.Forms.Button();
            this.labelGestionscolaire = new System.Windows.Forms.Label();
            this.FermerFenetre = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // GenererReleveEtudiant
            // 
            this.GenererReleveEtudiant.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.GenererReleveEtudiant.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GenererReleveEtudiant.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.GenererReleveEtudiant.Location = new System.Drawing.Point(26, 196);
            this.GenererReleveEtudiant.Name = "GenererReleveEtudiant";
            this.GenererReleveEtudiant.Size = new System.Drawing.Size(344, 129);
            this.GenererReleveEtudiant.TabIndex = 55;
            this.GenererReleveEtudiant.Text = " Générer les relevés de notes d’un étudiant.";
            this.GenererReleveEtudiant.UseVisualStyleBackColor = false;
            this.GenererReleveEtudiant.Click += new System.EventHandler(this.GenererReleveEtudiant_Click);
            // 
            // GenererListeETUCLASSE
            // 
            this.GenererListeETUCLASSE.BackColor = System.Drawing.Color.Red;
            this.GenererListeETUCLASSE.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GenererListeETUCLASSE.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.GenererListeETUCLASSE.Location = new System.Drawing.Point(830, 196);
            this.GenererListeETUCLASSE.Name = "GenererListeETUCLASSE";
            this.GenererListeETUCLASSE.Size = new System.Drawing.Size(424, 129);
            this.GenererListeETUCLASSE.TabIndex = 56;
            this.GenererListeETUCLASSE.Text = " Générer la liste des étudiants par classe ";
            this.GenererListeETUCLASSE.UseVisualStyleBackColor = false;
            this.GenererListeETUCLASSE.Click += new System.EventHandler(this.GenererListeETUCLASSE_Click);
            // 
            // GenererListeMeilleure
            // 
            this.GenererListeMeilleure.BackColor = System.Drawing.SystemColors.Highlight;
            this.GenererListeMeilleure.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GenererListeMeilleure.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.GenererListeMeilleure.Location = new System.Drawing.Point(409, 196);
            this.GenererListeMeilleure.Name = "GenererListeMeilleure";
            this.GenererListeMeilleure.Size = new System.Drawing.Size(391, 129);
            this.GenererListeMeilleure.TabIndex = 57;
            this.GenererListeMeilleure.Text = " Générer la liste des meilleurs étudiants par classe.";
            this.GenererListeMeilleure.UseVisualStyleBackColor = false;
            this.GenererListeMeilleure.Click += new System.EventHandler(this.GenererListeMeilleure_Click);
            // 
            // labelGestionscolaire
            // 
            this.labelGestionscolaire.AutoSize = true;
            this.labelGestionscolaire.Font = new System.Drawing.Font("Times New Roman", 17F, System.Drawing.FontStyle.Bold);
            this.labelGestionscolaire.Location = new System.Drawing.Point(384, 91);
            this.labelGestionscolaire.Name = "labelGestionscolaire";
            this.labelGestionscolaire.Size = new System.Drawing.Size(449, 38);
            this.labelGestionscolaire.TabIndex = 58;
            this.labelGestionscolaire.Text = " GESTION DES RAPPORTS";
            // 
            // FermerFenetre
            // 
            this.FermerFenetre.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FermerFenetre.Location = new System.Drawing.Point(503, 406);
            this.FermerFenetre.Name = "FermerFenetre";
            this.FermerFenetre.Size = new System.Drawing.Size(214, 67);
            this.FermerFenetre.TabIndex = 69;
            this.FermerFenetre.Text = "Fermer";
            this.FermerFenetre.UseVisualStyleBackColor = true;
            this.FermerFenetre.Click += new System.EventHandler(this.FermerFenetre_Click);
            // 
            // Rapport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1280, 565);
            this.Controls.Add(this.FermerFenetre);
            this.Controls.Add(this.labelGestionscolaire);
            this.Controls.Add(this.GenererListeMeilleure);
            this.Controls.Add(this.GenererListeETUCLASSE);
            this.Controls.Add(this.GenererReleveEtudiant);
            this.Name = "Rapport";
            this.Text = "Rapport";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button GenererReleveEtudiant;
        private System.Windows.Forms.Button GenererListeETUCLASSE;
        private System.Windows.Forms.Button GenererListeMeilleure;
        private System.Windows.Forms.Label labelGestionscolaire;
        private System.Windows.Forms.Button FermerFenetre;
    }
}