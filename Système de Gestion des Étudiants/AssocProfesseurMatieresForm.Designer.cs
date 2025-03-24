namespace Système_de_Gestion_des_Étudiants
{
    partial class AssocProfesseurMatieresForm
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
            this.labelNom = new System.Windows.Forms.Label();
            this.dataGridMatiereProf = new System.Windows.Forms.DataGridView();
            this.SupprimerMatiereProf = new System.Windows.Forms.Button();
            this.ModifierMatiereProf = new System.Windows.Forms.Button();
            this.AjoutMatiereProf = new System.Windows.Forms.Button();
            this.comboBoxMatiere = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBoxProfesseur = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridMatiereProf)).BeginInit();
            this.SuspendLayout();
            // 
            // labelNom
            // 
            this.labelNom.AutoSize = true;
            this.labelNom.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNom.Location = new System.Drawing.Point(75, 226);
            this.labelNom.Name = "labelNom";
            this.labelNom.Size = new System.Drawing.Size(101, 29);
            this.labelNom.TabIndex = 25;
            this.labelNom.Text = "Matiere";
            // 
            // dataGridMatiereProf
            // 
            this.dataGridMatiereProf.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridMatiereProf.Location = new System.Drawing.Point(525, 43);
            this.dataGridMatiereProf.Name = "dataGridMatiereProf";
            this.dataGridMatiereProf.RowHeadersWidth = 62;
            this.dataGridMatiereProf.RowTemplate.Height = 28;
            this.dataGridMatiereProf.Size = new System.Drawing.Size(663, 425);
            this.dataGridMatiereProf.TabIndex = 24;
            this.dataGridMatiereProf.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridClasse_CellContentClick);
            // 
            // SupprimerMatiereProf
            // 
            this.SupprimerMatiereProf.Location = new System.Drawing.Point(388, 311);
            this.SupprimerMatiereProf.Name = "SupprimerMatiereProf";
            this.SupprimerMatiereProf.Size = new System.Drawing.Size(134, 46);
            this.SupprimerMatiereProf.TabIndex = 23;
            this.SupprimerMatiereProf.Text = "Supprimer";
            this.SupprimerMatiereProf.UseVisualStyleBackColor = true;
            this.SupprimerMatiereProf.Click += new System.EventHandler(this.SupprimerMatiereProf_Click);
            // 
            // ModifierMatiereProf
            // 
            this.ModifierMatiereProf.Location = new System.Drawing.Point(213, 311);
            this.ModifierMatiereProf.Name = "ModifierMatiereProf";
            this.ModifierMatiereProf.Size = new System.Drawing.Size(144, 46);
            this.ModifierMatiereProf.TabIndex = 22;
            this.ModifierMatiereProf.Text = "Modifier";
            this.ModifierMatiereProf.UseVisualStyleBackColor = true;
            this.ModifierMatiereProf.Click += new System.EventHandler(this.ModifierMatiereProf_Click);
            // 
            // AjoutMatiereProf
            // 
            this.AjoutMatiereProf.Location = new System.Drawing.Point(50, 311);
            this.AjoutMatiereProf.Name = "AjoutMatiereProf";
            this.AjoutMatiereProf.Size = new System.Drawing.Size(144, 46);
            this.AjoutMatiereProf.TabIndex = 21;
            this.AjoutMatiereProf.Text = "Ajouter";
            this.AjoutMatiereProf.UseVisualStyleBackColor = true;
            this.AjoutMatiereProf.Click += new System.EventHandler(this.AjoutMatiereProf_Click);
            // 
            // comboBoxMatiere
            // 
            this.comboBoxMatiere.FormattingEnabled = true;
            this.comboBoxMatiere.Location = new System.Drawing.Point(213, 226);
            this.comboBoxMatiere.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.comboBoxMatiere.Name = "comboBoxMatiere";
            this.comboBoxMatiere.Size = new System.Drawing.Size(180, 28);
            this.comboBoxMatiere.TabIndex = 27;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(168, 72);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(144, 25);
            this.label5.TabIndex = 35;
            this.label5.Text = "Veillez chosir !";
            // 
            // comboBoxProfesseur
            // 
            this.comboBoxProfesseur.FormattingEnabled = true;
            this.comboBoxProfesseur.Location = new System.Drawing.Point(213, 151);
            this.comboBoxProfesseur.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.comboBoxProfesseur.Name = "comboBoxProfesseur";
            this.comboBoxProfesseur.Size = new System.Drawing.Size(180, 28);
            this.comboBoxProfesseur.TabIndex = 37;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(75, 151);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 29);
            this.label1.TabIndex = 36;
            this.label1.Text = "Professeur";
            // 
            // AssocProfesseurMatieresForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 692);
            this.Controls.Add(this.comboBoxProfesseur);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.comboBoxMatiere);
            this.Controls.Add(this.labelNom);
            this.Controls.Add(this.dataGridMatiereProf);
            this.Controls.Add(this.SupprimerMatiereProf);
            this.Controls.Add(this.ModifierMatiereProf);
            this.Controls.Add(this.AjoutMatiereProf);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "AssocProfesseurMatieresForm";
            this.Text = "AssocProfesseurMariereForm";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridMatiereProf)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label labelNom;
        private System.Windows.Forms.DataGridView dataGridMatiereProf;
        private System.Windows.Forms.Button SupprimerMatiereProf;
        private System.Windows.Forms.Button ModifierMatiereProf;
        private System.Windows.Forms.Button AjoutMatiereProf;
        private System.Windows.Forms.ComboBox comboBoxMatiere;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBoxProfesseur;
        private System.Windows.Forms.Label label1;
    }
}