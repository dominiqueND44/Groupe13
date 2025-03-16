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
            this.textBoxNomclasse = new System.Windows.Forms.TextBox();
            this.labelNom = new System.Windows.Forms.Label();
            this.AssociationClasse = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridClasse)).BeginInit();
            this.SuspendLayout();
            // 
            // labelGestionscolaire
            // 
            this.labelGestionscolaire.AutoSize = true;
            this.labelGestionscolaire.Font = new System.Drawing.Font("Times New Roman", 17F, System.Drawing.FontStyle.Bold);
            this.labelGestionscolaire.Location = new System.Drawing.Point(253, 9);
            this.labelGestionscolaire.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelGestionscolaire.Name = "labelGestionscolaire";
            this.labelGestionscolaire.Size = new System.Drawing.Size(282, 25);
            this.labelGestionscolaire.TabIndex = 6;
            this.labelGestionscolaire.Text = " GESTION DES CLASSES";
            // 
            // AjoutClasse
            // 
            this.AjoutClasse.Location = new System.Drawing.Point(20, 171);
            this.AjoutClasse.Margin = new System.Windows.Forms.Padding(2);
            this.AjoutClasse.Name = "AjoutClasse";
            this.AjoutClasse.Size = new System.Drawing.Size(96, 30);
            this.AjoutClasse.TabIndex = 7;
            this.AjoutClasse.Text = "Ajouter";
            this.AjoutClasse.UseVisualStyleBackColor = true;
            // 
            // ModifierClasse
            // 
            this.ModifierClasse.Location = new System.Drawing.Point(129, 171);
            this.ModifierClasse.Margin = new System.Windows.Forms.Padding(2);
            this.ModifierClasse.Name = "ModifierClasse";
            this.ModifierClasse.Size = new System.Drawing.Size(96, 30);
            this.ModifierClasse.TabIndex = 8;
            this.ModifierClasse.Text = "Modifier";
            this.ModifierClasse.UseVisualStyleBackColor = true;
            // 
            // SupprimerClasse
            // 
            this.SupprimerClasse.Location = new System.Drawing.Point(246, 171);
            this.SupprimerClasse.Margin = new System.Windows.Forms.Padding(2);
            this.SupprimerClasse.Name = "SupprimerClasse";
            this.SupprimerClasse.Size = new System.Drawing.Size(89, 30);
            this.SupprimerClasse.TabIndex = 9;
            this.SupprimerClasse.Text = "Supprimer";
            this.SupprimerClasse.UseVisualStyleBackColor = true;
            // 
            // dataGridClasse
            // 
            this.dataGridClasse.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridClasse.Location = new System.Drawing.Point(361, 50);
            this.dataGridClasse.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridClasse.Name = "dataGridClasse";
            this.dataGridClasse.RowHeadersWidth = 62;
            this.dataGridClasse.RowTemplate.Height = 28;
            this.dataGridClasse.Size = new System.Drawing.Size(393, 276);
            this.dataGridClasse.TabIndex = 17;
            // 
            // textBoxNomclasse
            // 
            this.textBoxNomclasse.Location = new System.Drawing.Point(179, 110);
            this.textBoxNomclasse.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxNomclasse.Multiline = true;
            this.textBoxNomclasse.Name = "textBoxNomclasse";
            this.textBoxNomclasse.Size = new System.Drawing.Size(142, 24);
            this.textBoxNomclasse.TabIndex = 20;
            // 
            // labelNom
            // 
            this.labelNom.AutoSize = true;
            this.labelNom.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNom.Location = new System.Drawing.Point(17, 112);
            this.labelNom.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelNom.Name = "labelNom";
            this.labelNom.Size = new System.Drawing.Size(142, 18);
            this.labelNom.TabIndex = 18;
            this.labelNom.Text = "Nom de la Classe";
            this.labelNom.Click += new System.EventHandler(this.label2_Click);
            // 
            // AssociationClasse
            // 
            this.AssociationClasse.Location = new System.Drawing.Point(45, 228);
            this.AssociationClasse.Margin = new System.Windows.Forms.Padding(2);
            this.AssociationClasse.Name = "AssociationClasse";
            this.AssociationClasse.Size = new System.Drawing.Size(266, 30);
            this.AssociationClasse.TabIndex = 21;
            this.AssociationClasse.Text = "Associer Cours, Matieres et Professeurs ";
            this.AssociationClasse.UseVisualStyleBackColor = true;
            // 
            // ClassesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(765, 337);
            this.Controls.Add(this.AssociationClasse);
            this.Controls.Add(this.textBoxNomclasse);
            this.Controls.Add(this.labelNom);
            this.Controls.Add(this.dataGridClasse);
            this.Controls.Add(this.SupprimerClasse);
            this.Controls.Add(this.ModifierClasse);
            this.Controls.Add(this.AjoutClasse);
            this.Controls.Add(this.labelGestionscolaire);
            this.Margin = new System.Windows.Forms.Padding(2);
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
        private System.Windows.Forms.TextBox textBoxNomclasse;
        private System.Windows.Forms.Label labelNom;
        private System.Windows.Forms.Button AssociationClasse;
    }
}