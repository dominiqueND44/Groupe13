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
            this.cmbProf = new System.Windows.Forms.ComboBox();
            this.labelNom = new System.Windows.Forms.Label();
            this.dataGridCMPClasse = new System.Windows.Forms.DataGridView();
            this.AjoutàClasse = new System.Windows.Forms.Button();
            this.cmbMatiere = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbCours = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Classe = new System.Windows.Forms.Label();
            this.cmbClasse = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridCMPClasse)).BeginInit();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(186, 47);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(154, 25);
            this.label5.TabIndex = 41;
            this.label5.Text = "Veuillez Choisir";
            // 
            // cmbProf
            // 
            this.cmbProf.FormattingEnabled = true;
            this.cmbProf.Location = new System.Drawing.Point(210, 343);
            this.cmbProf.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmbProf.Name = "cmbProf";
            this.cmbProf.Size = new System.Drawing.Size(180, 28);
            this.cmbProf.TabIndex = 40;
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
            this.dataGridCMPClasse.Location = new System.Drawing.Point(576, 71);
            this.dataGridCMPClasse.Name = "dataGridCMPClasse";
            this.dataGridCMPClasse.RowHeadersWidth = 62;
            this.dataGridCMPClasse.RowTemplate.Height = 28;
            this.dataGridCMPClasse.Size = new System.Drawing.Size(695, 425);
            this.dataGridCMPClasse.TabIndex = 38;
            // 
            // AjoutàClasse
            // 
            this.AjoutàClasse.Location = new System.Drawing.Point(191, 430);
            this.AjoutàClasse.Name = "AjoutàClasse";
            this.AjoutàClasse.Size = new System.Drawing.Size(211, 46);
            this.AjoutàClasse.TabIndex = 35;
            this.AjoutàClasse.Text = "Associer";
            this.AjoutàClasse.UseVisualStyleBackColor = true;
            this.AjoutàClasse.Click += new System.EventHandler(this.AjoutàClasse_Click);
            // 
            // cmbMatiere
            // 
            this.cmbMatiere.FormattingEnabled = true;
            this.cmbMatiere.Location = new System.Drawing.Point(210, 268);
            this.cmbMatiere.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmbMatiere.Name = "cmbMatiere";
            this.cmbMatiere.Size = new System.Drawing.Size(180, 28);
            this.cmbMatiere.TabIndex = 43;
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
            // cmbCours
            // 
            this.cmbCours.FormattingEnabled = true;
            this.cmbCours.Location = new System.Drawing.Point(210, 186);
            this.cmbCours.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmbCours.Name = "cmbCours";
            this.cmbCours.Size = new System.Drawing.Size(180, 28);
            this.cmbCours.TabIndex = 45;
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
            // Classe
            // 
            this.Classe.AutoSize = true;
            this.Classe.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Classe.Location = new System.Drawing.Point(52, 111);
            this.Classe.Name = "Classe";
            this.Classe.Size = new System.Drawing.Size(93, 29);
            this.Classe.TabIndex = 46;
            this.Classe.Text = "Classe";
            this.Classe.Click += new System.EventHandler(this.label3_Click);
            // 
            // cmbClasse
            // 
            this.cmbClasse.FormattingEnabled = true;
            this.cmbClasse.Location = new System.Drawing.Point(210, 111);
            this.cmbClasse.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmbClasse.Name = "cmbClasse";
            this.cmbClasse.Size = new System.Drawing.Size(180, 28);
            this.cmbClasse.TabIndex = 47;
            // 
            // AssociationCoursMatieresProfesseuràClasseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1300, 512);
            this.Controls.Add(this.cmbClasse);
            this.Controls.Add(this.Classe);
            this.Controls.Add(this.cmbCours);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbMatiere);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cmbProf);
            this.Controls.Add(this.labelNom);
            this.Controls.Add(this.dataGridCMPClasse);
            this.Controls.Add(this.AjoutàClasse);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "AssociationCoursMatieresProfesseuràClasseForm";
            this.Text = "Association de Cours -Matières -Professeur à la Classe";
            this.Load += new System.EventHandler(this.AssociationCoursMatieresProfesseuràClasseForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridCMPClasse)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbProf;
        private System.Windows.Forms.Label labelNom;
        private System.Windows.Forms.DataGridView dataGridCMPClasse;
        private System.Windows.Forms.Button AjoutàClasse;
        private System.Windows.Forms.ComboBox cmbMatiere;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbCours;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label Classe;
        private System.Windows.Forms.ComboBox cmbClasse;
    }
}