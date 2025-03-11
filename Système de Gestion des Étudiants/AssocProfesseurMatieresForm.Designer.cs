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
            this.comboBoxMatiereProf = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridMatiereProf)).BeginInit();
            this.SuspendLayout();
            // 
            // labelNom
            // 
            this.labelNom.AutoSize = true;
            this.labelNom.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNom.Location = new System.Drawing.Point(50, 147);
            this.labelNom.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelNom.Name = "labelNom";
            this.labelNom.Size = new System.Drawing.Size(64, 18);
            this.labelNom.TabIndex = 25;
            this.labelNom.Text = "Matiere";
            // 
            // dataGridMatiereProf
            // 
            this.dataGridMatiereProf.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridMatiereProf.Location = new System.Drawing.Point(380, 61);
            this.dataGridMatiereProf.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridMatiereProf.Name = "dataGridMatiereProf";
            this.dataGridMatiereProf.RowHeadersWidth = 62;
            this.dataGridMatiereProf.RowTemplate.Height = 28;
            this.dataGridMatiereProf.Size = new System.Drawing.Size(409, 276);
            this.dataGridMatiereProf.TabIndex = 24;
            this.dataGridMatiereProf.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridClasse_CellContentClick);
            // 
            // SupprimerMatiereProf
            // 
            this.SupprimerMatiereProf.Location = new System.Drawing.Point(259, 202);
            this.SupprimerMatiereProf.Margin = new System.Windows.Forms.Padding(2);
            this.SupprimerMatiereProf.Name = "SupprimerMatiereProf";
            this.SupprimerMatiereProf.Size = new System.Drawing.Size(89, 30);
            this.SupprimerMatiereProf.TabIndex = 23;
            this.SupprimerMatiereProf.Text = "Supprimer";
            this.SupprimerMatiereProf.UseVisualStyleBackColor = true;
            // 
            // ModifierMatiereProf
            // 
            this.ModifierMatiereProf.Location = new System.Drawing.Point(142, 202);
            this.ModifierMatiereProf.Margin = new System.Windows.Forms.Padding(2);
            this.ModifierMatiereProf.Name = "ModifierMatiereProf";
            this.ModifierMatiereProf.Size = new System.Drawing.Size(96, 30);
            this.ModifierMatiereProf.TabIndex = 22;
            this.ModifierMatiereProf.Text = "Modifier";
            this.ModifierMatiereProf.UseVisualStyleBackColor = true;
            // 
            // AjoutMatiereProf
            // 
            this.AjoutMatiereProf.Location = new System.Drawing.Point(33, 202);
            this.AjoutMatiereProf.Margin = new System.Windows.Forms.Padding(2);
            this.AjoutMatiereProf.Name = "AjoutMatiereProf";
            this.AjoutMatiereProf.Size = new System.Drawing.Size(96, 30);
            this.AjoutMatiereProf.TabIndex = 21;
            this.AjoutMatiereProf.Text = "Ajouter";
            this.AjoutMatiereProf.UseVisualStyleBackColor = true;
            // 
            // comboBoxMatiereProf
            // 
            this.comboBoxMatiereProf.FormattingEnabled = true;
            this.comboBoxMatiereProf.Location = new System.Drawing.Point(142, 147);
            this.comboBoxMatiereProf.Name = "comboBoxMatiereProf";
            this.comboBoxMatiereProf.Size = new System.Drawing.Size(121, 21);
            this.comboBoxMatiereProf.TabIndex = 27;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(110, 101);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(98, 17);
            this.label5.TabIndex = 35;
            this.label5.Text = "Veillez chosir !";
            // 
            // AssocProfesseurMatieresForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.comboBoxMatiereProf);
            this.Controls.Add(this.labelNom);
            this.Controls.Add(this.dataGridMatiereProf);
            this.Controls.Add(this.SupprimerMatiereProf);
            this.Controls.Add(this.ModifierMatiereProf);
            this.Controls.Add(this.AjoutMatiereProf);
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
        private System.Windows.Forms.ComboBox comboBoxMatiereProf;
        private System.Windows.Forms.Label label5;
    }
}