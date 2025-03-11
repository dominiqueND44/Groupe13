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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.SupprimerCours = new System.Windows.Forms.Button();
            this.ModifierCours = new System.Windows.Forms.Button();
            this.AjoutCours = new System.Windows.Forms.Button();
            this.textBoxDescriptionCours = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.AjoutMatiere = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // labelGestionscolaire
            // 
            this.labelGestionscolaire.AutoSize = true;
            this.labelGestionscolaire.Font = new System.Drawing.Font("Times New Roman", 17F, System.Drawing.FontStyle.Bold);
            this.labelGestionscolaire.Location = new System.Drawing.Point(357, 9);
            this.labelGestionscolaire.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelGestionscolaire.Name = "labelGestionscolaire";
            this.labelGestionscolaire.Size = new System.Drawing.Size(425, 25);
            this.labelGestionscolaire.TabIndex = 21;
            this.labelGestionscolaire.Text = " GESTION DES MATIERES ET COURS";
            // 
            // textBoxNomCours
            // 
            this.textBoxNomCours.Location = new System.Drawing.Point(102, 53);
            this.textBoxNomCours.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxNomCours.Multiline = true;
            this.textBoxNomCours.Name = "textBoxNomCours";
            this.textBoxNomCours.Size = new System.Drawing.Size(142, 25);
            this.textBoxNomCours.TabIndex = 33;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(19, 56);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 18);
            this.label1.TabIndex = 32;
            this.label1.Text = "Cours";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(376, 36);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(443, 298);
            this.dataGridView1.TabIndex = 31;
            // 
            // SupprimerCours
            // 
            this.SupprimerCours.Location = new System.Drawing.Point(245, 161);
            this.SupprimerCours.Margin = new System.Windows.Forms.Padding(2);
            this.SupprimerCours.Name = "SupprimerCours";
            this.SupprimerCours.Size = new System.Drawing.Size(89, 30);
            this.SupprimerCours.TabIndex = 30;
            this.SupprimerCours.Text = "Supprimer";
            this.SupprimerCours.UseVisualStyleBackColor = true;
            // 
            // ModifierCours
            // 
            this.ModifierCours.Location = new System.Drawing.Point(132, 161);
            this.ModifierCours.Margin = new System.Windows.Forms.Padding(2);
            this.ModifierCours.Name = "ModifierCours";
            this.ModifierCours.Size = new System.Drawing.Size(96, 30);
            this.ModifierCours.TabIndex = 29;
            this.ModifierCours.Text = "Modifier";
            this.ModifierCours.UseVisualStyleBackColor = true;
            this.ModifierCours.Click += new System.EventHandler(this.button2_Click);
            // 
            // AjoutCours
            // 
            this.AjoutCours.Location = new System.Drawing.Point(17, 161);
            this.AjoutCours.Margin = new System.Windows.Forms.Padding(2);
            this.AjoutCours.Name = "AjoutCours";
            this.AjoutCours.Size = new System.Drawing.Size(96, 30);
            this.AjoutCours.TabIndex = 28;
            this.AjoutCours.Text = "Ajouter";
            this.AjoutCours.UseVisualStyleBackColor = true;
            // 
            // textBoxDescriptionCours
            // 
            this.textBoxDescriptionCours.Location = new System.Drawing.Point(132, 95);
            this.textBoxDescriptionCours.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxDescriptionCours.Multiline = true;
            this.textBoxDescriptionCours.Name = "textBoxDescriptionCours";
            this.textBoxDescriptionCours.Size = new System.Drawing.Size(202, 51);
            this.textBoxDescriptionCours.TabIndex = 39;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(14, 101);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(94, 18);
            this.label5.TabIndex = 38;
            this.label5.Text = "Description";
            // 
            // AjoutMatiere
            // 
            this.AjoutMatiere.Location = new System.Drawing.Point(132, 209);
            this.AjoutMatiere.Margin = new System.Windows.Forms.Padding(2);
            this.AjoutMatiere.Name = "AjoutMatiere";
            this.AjoutMatiere.Size = new System.Drawing.Size(96, 30);
            this.AjoutMatiere.TabIndex = 40;
            this.AjoutMatiere.Text = "Ajouter Matiere";
            this.AjoutMatiere.UseVisualStyleBackColor = true;
            // 
            // CoursForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(830, 345);
            this.Controls.Add(this.AjoutMatiere);
            this.Controls.Add(this.textBoxDescriptionCours);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBoxNomCours);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.SupprimerCours);
            this.Controls.Add(this.ModifierCours);
            this.Controls.Add(this.AjoutCours);
            this.Controls.Add(this.labelGestionscolaire);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "CoursForm";
            this.Text = "Gestion Cours ";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label labelGestionscolaire;
        private System.Windows.Forms.TextBox textBoxNomCours;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button SupprimerCours;
        private System.Windows.Forms.Button ModifierCours;
        private System.Windows.Forms.Button AjoutCours;
        private System.Windows.Forms.TextBox textBoxDescriptionCours;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button AjoutMatiere;
    }
}