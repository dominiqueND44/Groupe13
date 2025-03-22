namespace Système_de_Gestion_des_Étudiants
{
    partial class AssociationCoursMatieresProfesseuràClasseForm
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
            this.label5 = new System.Windows.Forms.Label();
            this.comboBoxProfesseur = new System.Windows.Forms.ComboBox();
            this.labelNom = new System.Windows.Forms.Label();
            this.dataGridCMPClasse = new System.Windows.Forms.DataGridView();
            this.SupprimerPourClasse = new System.Windows.Forms.Button();
            this.ModifierPourClasse = new System.Windows.Forms.Button();
            this.AjoutPourClasse = new System.Windows.Forms.Button();
            this.comboBoxMatiere = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxCours = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBoxClasse = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridCMPClasse)).BeginInit();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(205, 62);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(144, 25);
            this.label5.TabIndex = 41;
            this.label5.Text = "Veillez chosir !";
            // 
            // comboBoxProfesseur
            // 
            this.comboBoxProfesseur.FormattingEnabled = true;
            this.comboBoxProfesseur.Location = new System.Drawing.Point(190, 343);
            this.comboBoxProfesseur.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.comboBoxProfesseur.Name = "comboBoxProfesseur";
            this.comboBoxProfesseur.Size = new System.Drawing.Size(180, 28);
            this.comboBoxProfesseur.TabIndex = 40;
            // 
            // labelNom
            // 
            this.labelNom.AutoSize = true;
            this.labelNom.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNom.Location = new System.Drawing.Point(52, 343);
            this.labelNom.Name = "labelNom";
            this.labelNom.Size = new System.Drawing.Size(140, 29);
            this.labelNom.TabIndex = 39;
            this.labelNom.Text = "Professeur";
            // 
            // dataGridCMPClasse
            // 
            this.dataGridCMPClasse.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridCMPClasse.Location = new System.Drawing.Point(546, 71);
            this.dataGridCMPClasse.Name = "dataGridCMPClasse";
            this.dataGridCMPClasse.RowHeadersWidth = 62;
            this.dataGridCMPClasse.RowTemplate.Height = 28;
            this.dataGridCMPClasse.Size = new System.Drawing.Size(642, 425);
            this.dataGridCMPClasse.TabIndex = 38;
            // 
            // SupprimerPourClasse
            // 
            this.SupprimerPourClasse.Location = new System.Drawing.Point(386, 429);
            this.SupprimerPourClasse.Name = "SupprimerPourClasse";
            this.SupprimerPourClasse.Size = new System.Drawing.Size(134, 46);
            this.SupprimerPourClasse.TabIndex = 37;
            this.SupprimerPourClasse.Text = "Supprimer";
            this.SupprimerPourClasse.UseVisualStyleBackColor = true;
            this.SupprimerPourClasse.Click += new System.EventHandler(this.SupprimerPourClasse_Click);
            // 
            // ModifierPourClasse
            // 
            this.ModifierPourClasse.Location = new System.Drawing.Point(210, 429);
            this.ModifierPourClasse.Name = "ModifierPourClasse";
            this.ModifierPourClasse.Size = new System.Drawing.Size(144, 46);
            this.ModifierPourClasse.TabIndex = 36;
            this.ModifierPourClasse.Text = "Modifier";
            this.ModifierPourClasse.UseVisualStyleBackColor = true;
            this.ModifierPourClasse.Click += new System.EventHandler(this.ModifierPourClasse_Click);
            // 
            // AjoutPourClasse
            // 
            this.AjoutPourClasse.Location = new System.Drawing.Point(46, 429);
            this.AjoutPourClasse.Name = "AjoutPourClasse";
            this.AjoutPourClasse.Size = new System.Drawing.Size(144, 46);
            this.AjoutPourClasse.TabIndex = 35;
            this.AjoutPourClasse.Text = "Ajouter";
            this.AjoutPourClasse.UseVisualStyleBackColor = true;
            this.AjoutPourClasse.Click += new System.EventHandler(this.AjoutPourClasse_Click);
            // 
            // comboBoxMatiere
            // 
            this.comboBoxMatiere.FormattingEnabled = true;
            this.comboBoxMatiere.Location = new System.Drawing.Point(190, 268);
            this.comboBoxMatiere.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.comboBoxMatiere.Name = "comboBoxMatiere";
            this.comboBoxMatiere.Size = new System.Drawing.Size(180, 28);
            this.comboBoxMatiere.TabIndex = 43;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(52, 268);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 29);
            this.label1.TabIndex = 42;
            this.label1.Text = "Matiere";
            // 
            // comboBoxCours
            // 
            this.comboBoxCours.FormattingEnabled = true;
            this.comboBoxCours.Location = new System.Drawing.Point(190, 186);
            this.comboBoxCours.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.comboBoxCours.Name = "comboBoxCours";
            this.comboBoxCours.Size = new System.Drawing.Size(180, 28);
            this.comboBoxCours.TabIndex = 45;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(52, 186);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 29);
            this.label2.TabIndex = 44;
            this.label2.Text = "Cours";
            // 
            // comboBoxClasse
            // 
            this.comboBoxClasse.FormattingEnabled = true;
            this.comboBoxClasse.Location = new System.Drawing.Point(190, 111);
            this.comboBoxClasse.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.comboBoxClasse.Name = "comboBoxClasse";
            this.comboBoxClasse.Size = new System.Drawing.Size(180, 28);
            this.comboBoxClasse.TabIndex = 47;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(52, 111);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 29);
            this.label3.TabIndex = 46;
            this.label3.Text = "Classe";
            // 
            // AssociationCoursMatieresProfesseuràClasseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 692);
            this.Controls.Add(this.comboBoxClasse);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboBoxCours);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBoxMatiere);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.comboBoxProfesseur);
            this.Controls.Add(this.labelNom);
            this.Controls.Add(this.dataGridCMPClasse);
            this.Controls.Add(this.SupprimerPourClasse);
            this.Controls.Add(this.ModifierPourClasse);
            this.Controls.Add(this.AjoutPourClasse);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "AssociationCoursMatieresProfesseuràClasseForm";
            this.Text = "Association de Cours -Matières -Professeur à la Classe";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridCMPClasse)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBoxProfesseur;
        private System.Windows.Forms.Label labelNom;
        private System.Windows.Forms.DataGridView dataGridCMPClasse;
        private System.Windows.Forms.Button SupprimerPourClasse;
        private System.Windows.Forms.Button ModifierPourClasse;
        private System.Windows.Forms.Button AjoutPourClasse;
        private System.Windows.Forms.ComboBox comboBoxMatiere;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxCours;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBoxClasse;
        private System.Windows.Forms.Label label3;
    }
}