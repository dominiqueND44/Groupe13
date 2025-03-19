namespace Système_de_Gestion_des_Étudiants
{
    partial class ClassesForm
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
            this.AjoutClasse = new System.Windows.Forms.Button();
            this.ModifierClasse = new System.Windows.Forms.Button();
            this.SupprimerClasse = new System.Windows.Forms.Button();
            this.dataGridClasse = new System.Windows.Forms.DataGridView();
            this.txtNomClasse = new System.Windows.Forms.TextBox();
            this.labelNom = new System.Windows.Forms.Label();
            this.AssociationClasse = new System.Windows.Forms.Button();
            this.btnclose = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridClasse)).BeginInit();
            this.SuspendLayout();
            // 
            // labelGestionscolaire
            // 
            this.labelGestionscolaire.AutoSize = true;
            this.labelGestionscolaire.Font = new System.Drawing.Font("Times New Roman", 17F, System.Drawing.FontStyle.Bold);
            this.labelGestionscolaire.Location = new System.Drawing.Point(380, 14);
            this.labelGestionscolaire.Name = "labelGestionscolaire";
            this.labelGestionscolaire.Size = new System.Drawing.Size(418, 38);
            this.labelGestionscolaire.TabIndex = 6;
            this.labelGestionscolaire.Text = " GESTION DES CLASSES";
            // 
            // AjoutClasse
            // 
            this.AjoutClasse.Location = new System.Drawing.Point(12, 343);
            this.AjoutClasse.Name = "AjoutClasse";
            this.AjoutClasse.Size = new System.Drawing.Size(144, 46);
            this.AjoutClasse.TabIndex = 7;
            this.AjoutClasse.Text = "Ajouter";
            this.AjoutClasse.UseVisualStyleBackColor = true;
            this.AjoutClasse.Click += new System.EventHandler(this.AjoutClasse_Click);
            // 
            // ModifierClasse
            // 
            this.ModifierClasse.Location = new System.Drawing.Point(193, 343);
            this.ModifierClasse.Name = "ModifierClasse";
            this.ModifierClasse.Size = new System.Drawing.Size(144, 46);
            this.ModifierClasse.TabIndex = 8;
            this.ModifierClasse.Text = "Modifier";
            this.ModifierClasse.UseVisualStyleBackColor = true;
            this.ModifierClasse.Click += new System.EventHandler(this.ModifierClasse_Click);
            // 
            // SupprimerClasse
            // 
            this.SupprimerClasse.Location = new System.Drawing.Point(366, 343);
            this.SupprimerClasse.Name = "SupprimerClasse";
            this.SupprimerClasse.Size = new System.Drawing.Size(134, 46);
            this.SupprimerClasse.TabIndex = 9;
            this.SupprimerClasse.Text = "Supprimer";
            this.SupprimerClasse.UseVisualStyleBackColor = true;
            this.SupprimerClasse.Click += new System.EventHandler(this.SupprimerClasse_Click);
            // 
            // dataGridClasse
            // 
            this.dataGridClasse.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridClasse.Location = new System.Drawing.Point(542, 69);
            this.dataGridClasse.Name = "dataGridClasse";
            this.dataGridClasse.RowHeadersWidth = 62;
            this.dataGridClasse.RowTemplate.Height = 28;
            this.dataGridClasse.Size = new System.Drawing.Size(766, 471);
            this.dataGridClasse.TabIndex = 17;
            // 
            // txtNomClasse
            // 
            this.txtNomClasse.Location = new System.Drawing.Point(289, 180);
            this.txtNomClasse.Multiline = true;
            this.txtNomClasse.Name = "txtNomClasse";
            this.txtNomClasse.Size = new System.Drawing.Size(211, 35);
            this.txtNomClasse.TabIndex = 20;
            this.txtNomClasse.TextChanged += new System.EventHandler(this.textBoxNomclasse_TextChanged);
            // 
            // labelNom
            // 
            this.labelNom.AutoSize = true;
            this.labelNom.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNom.Location = new System.Drawing.Point(7, 186);
            this.labelNom.Name = "labelNom";
            this.labelNom.Size = new System.Drawing.Size(220, 29);
            this.labelNom.TabIndex = 18;
            this.labelNom.Text = "Nom de la Classe";
            this.labelNom.Click += new System.EventHandler(this.label2_Click);
            // 
            // AssociationClasse
            // 
            this.AssociationClasse.Location = new System.Drawing.Point(64, 494);
            this.AssociationClasse.Name = "AssociationClasse";
            this.AssociationClasse.Size = new System.Drawing.Size(399, 46);
            this.AssociationClasse.TabIndex = 21;
            this.AssociationClasse.Text = "Associer Cours, Matieres et Professeurs ";
            this.AssociationClasse.UseVisualStyleBackColor = true;
            this.AssociationClasse.Click += new System.EventHandler(this.AssociationClasse_Click);
            // 
            // btnclose
            // 
            this.btnclose.Location = new System.Drawing.Point(193, 425);
            this.btnclose.Name = "btnclose";
            this.btnclose.Size = new System.Drawing.Size(144, 46);
            this.btnclose.TabIndex = 22;
            this.btnclose.Text = "Fermer";
            this.btnclose.UseVisualStyleBackColor = true;
            this.btnclose.Click += new System.EventHandler(this.btnclose_Click);
            // 
            // ClassesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1320, 600);
            this.Controls.Add(this.btnclose);
            this.Controls.Add(this.AssociationClasse);
            this.Controls.Add(this.txtNomClasse);
            this.Controls.Add(this.labelNom);
            this.Controls.Add(this.dataGridClasse);
            this.Controls.Add(this.SupprimerClasse);
            this.Controls.Add(this.ModifierClasse);
            this.Controls.Add(this.AjoutClasse);
            this.Controls.Add(this.labelGestionscolaire);
            this.Name = "ClassesForm";
            this.Text = "Classes";
            this.Load += new System.EventHandler(this.ClassesForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridClasse)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelGestionscolaire;
        private System.Windows.Forms.Button AjoutClasse;
        private System.Windows.Forms.Button ModifierClasse;
        private System.Windows.Forms.Button SupprimerClasse;
        private System.Windows.Forms.DataGridView dataGridClasse;
        private System.Windows.Forms.TextBox txtNomClasse;
        private System.Windows.Forms.Label labelNom;
        private System.Windows.Forms.Button AssociationClasse;
        private System.Windows.Forms.Button btnclose;
    }
}