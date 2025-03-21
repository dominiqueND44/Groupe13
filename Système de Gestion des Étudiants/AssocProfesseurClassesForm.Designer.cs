namespace Système_de_Gestion_des_Étudiants
{
    partial class AssocProfesseurClassesForm
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
            this.comboBoxClasse = new System.Windows.Forms.ComboBox();
            this.labelNom = new System.Windows.Forms.Label();
            this.dataGridProfClasse = new System.Windows.Forms.DataGridView();
            this.SupprimerAssocProf = new System.Windows.Forms.Button();
            this.ModifierAssocProf = new System.Windows.Forms.Button();
            this.AjoutAssocProf = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBoxProfesseur = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridProfClasse)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBoxClasse
            // 
            this.comboBoxClasse.FormattingEnabled = true;
            this.comboBoxClasse.Location = new System.Drawing.Point(196, 218);
            this.comboBoxClasse.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.comboBoxClasse.Name = "comboBoxClasse";
            this.comboBoxClasse.Size = new System.Drawing.Size(180, 28);
            this.comboBoxClasse.TabIndex = 33;
            // 
            // labelNom
            // 
            this.labelNom.AutoSize = true;
            this.labelNom.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNom.Location = new System.Drawing.Point(58, 218);
            this.labelNom.Name = "labelNom";
            this.labelNom.Size = new System.Drawing.Size(93, 29);
            this.labelNom.TabIndex = 32;
            this.labelNom.Text = "Classe";
            // 
            // dataGridProfClasse
            // 
            this.dataGridProfClasse.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridProfClasse.Location = new System.Drawing.Point(556, 77);
            this.dataGridProfClasse.Name = "dataGridProfClasse";
            this.dataGridProfClasse.RowHeadersWidth = 62;
            this.dataGridProfClasse.RowTemplate.Height = 28;
            this.dataGridProfClasse.Size = new System.Drawing.Size(614, 425);
            this.dataGridProfClasse.TabIndex = 31;
            this.dataGridProfClasse.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridProfClasse_CellContentClick);
            // 
            // SupprimerAssocProf
            // 
            this.SupprimerAssocProf.Location = new System.Drawing.Point(372, 303);
            this.SupprimerAssocProf.Name = "SupprimerAssocProf";
            this.SupprimerAssocProf.Size = new System.Drawing.Size(134, 46);
            this.SupprimerAssocProf.TabIndex = 30;
            this.SupprimerAssocProf.Text = "Supprimer";
            this.SupprimerAssocProf.UseVisualStyleBackColor = true;
            this.SupprimerAssocProf.Click += new System.EventHandler(this.SupprimerAssocProf_Click);
            // 
            // ModifierAssocProf
            // 
            this.ModifierAssocProf.Location = new System.Drawing.Point(196, 303);
            this.ModifierAssocProf.Name = "ModifierAssocProf";
            this.ModifierAssocProf.Size = new System.Drawing.Size(144, 46);
            this.ModifierAssocProf.TabIndex = 29;
            this.ModifierAssocProf.Text = "Modifier";
            this.ModifierAssocProf.UseVisualStyleBackColor = true;
            this.ModifierAssocProf.Click += new System.EventHandler(this.ModifierAssocProf_Click);
            // 
            // AjoutAssocProf
            // 
            this.AjoutAssocProf.Location = new System.Drawing.Point(33, 303);
            this.AjoutAssocProf.Name = "AjoutAssocProf";
            this.AjoutAssocProf.Size = new System.Drawing.Size(144, 46);
            this.AjoutAssocProf.TabIndex = 28;
            this.AjoutAssocProf.Text = "Ajouter";
            this.AjoutAssocProf.UseVisualStyleBackColor = true;
            this.AjoutAssocProf.Click += new System.EventHandler(this.AjoutAssocProf_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(162, 44);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(144, 25);
            this.label5.TabIndex = 34;
            this.label5.Text = "Veillez chosir !";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // comboBoxProfesseur
            // 
            this.comboBoxProfesseur.FormattingEnabled = true;
            this.comboBoxProfesseur.Location = new System.Drawing.Point(196, 132);
            this.comboBoxProfesseur.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.comboBoxProfesseur.Name = "comboBoxProfesseur";
            this.comboBoxProfesseur.Size = new System.Drawing.Size(180, 28);
            this.comboBoxProfesseur.TabIndex = 36;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(58, 132);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 29);
            this.label1.TabIndex = 35;
            this.label1.Text = "Professeur";
            // 
            // AssocProfesseurClassesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 692);
            this.Controls.Add(this.comboBoxProfesseur);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.comboBoxClasse);
            this.Controls.Add(this.labelNom);
            this.Controls.Add(this.dataGridProfClasse);
            this.Controls.Add(this.SupprimerAssocProf);
            this.Controls.Add(this.ModifierAssocProf);
            this.Controls.Add(this.AjoutAssocProf);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "AssocProfesseurClassesForm";
            this.Text = "AssocProfesseurClassesForm";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridProfClasse)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxClasse;
        private System.Windows.Forms.Label labelNom;
        private System.Windows.Forms.DataGridView dataGridProfClasse;
        private System.Windows.Forms.Button SupprimerAssocProf;
        private System.Windows.Forms.Button ModifierAssocProf;
        private System.Windows.Forms.Button AjoutAssocProf;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBoxProfesseur;
        private System.Windows.Forms.Label label1;
    }
}