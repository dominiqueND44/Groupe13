namespace Système_de_Gestion_des_Étudiants
{
    partial class AjoutMatieresCoursForm
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
            this.FermerFenetre = new System.Windows.Forms.Button();
            this.ViderChamps = new System.Windows.Forms.Button();
            this.comboBoxCours = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SupprimerMatCours = new System.Windows.Forms.Button();
            this.ModifierMatCours = new System.Windows.Forms.Button();
            this.AjoutMatCours = new System.Windows.Forms.Button();
            this.comboBoxMatiere = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridMatCours = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridMatCours)).BeginInit();
            this.SuspendLayout();
            // 
            // labelGestionscolaire
            // 
            this.labelGestionscolaire.AutoSize = true;
            this.labelGestionscolaire.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelGestionscolaire.Location = new System.Drawing.Point(174, 9);
            this.labelGestionscolaire.Name = "labelGestionscolaire";
            this.labelGestionscolaire.Size = new System.Drawing.Size(365, 32);
            this.labelGestionscolaire.TabIndex = 54;
            this.labelGestionscolaire.Text = "AJOUT MATIERES COURS";
            // 
            // FermerFenetre
            // 
            this.FermerFenetre.Location = new System.Drawing.Point(311, 367);
            this.FermerFenetre.Name = "FermerFenetre";
            this.FermerFenetre.Size = new System.Drawing.Size(144, 46);
            this.FermerFenetre.TabIndex = 75;
            this.FermerFenetre.Text = "Fermer";
            this.FermerFenetre.UseVisualStyleBackColor = true;
            this.FermerFenetre.Click += new System.EventHandler(this.FermerFenetre_Click);
            // 
            // ViderChamps
            // 
            this.ViderChamps.Location = new System.Drawing.Point(127, 367);
            this.ViderChamps.Name = "ViderChamps";
            this.ViderChamps.Size = new System.Drawing.Size(144, 46);
            this.ViderChamps.TabIndex = 74;
            this.ViderChamps.Text = "Vider les Champs";
            this.ViderChamps.UseVisualStyleBackColor = true;
            this.ViderChamps.Click += new System.EventHandler(this.ViderChamps_Click);
            // 
            // comboBoxCours
            // 
            this.comboBoxCours.FormattingEnabled = true;
            this.comboBoxCours.Location = new System.Drawing.Point(217, 158);
            this.comboBoxCours.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.comboBoxCours.Name = "comboBoxCours";
            this.comboBoxCours.Size = new System.Drawing.Size(238, 28);
            this.comboBoxCours.TabIndex = 73;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(33, 160);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 22);
            this.label4.TabIndex = 72;
            this.label4.Text = "Cours";
            // 
            // SupprimerMatCours
            // 
            this.SupprimerMatCours.Location = new System.Drawing.Point(411, 295);
            this.SupprimerMatCours.Name = "SupprimerMatCours";
            this.SupprimerMatCours.Size = new System.Drawing.Size(134, 46);
            this.SupprimerMatCours.TabIndex = 71;
            this.SupprimerMatCours.Text = "Supprimer";
            this.SupprimerMatCours.UseVisualStyleBackColor = true;
            this.SupprimerMatCours.Click += new System.EventHandler(this.SupprimerMatCours_Click);
            // 
            // ModifierMatCours
            // 
            this.ModifierMatCours.Location = new System.Drawing.Point(217, 295);
            this.ModifierMatCours.Name = "ModifierMatCours";
            this.ModifierMatCours.Size = new System.Drawing.Size(144, 46);
            this.ModifierMatCours.TabIndex = 70;
            this.ModifierMatCours.Text = "Modifier";
            this.ModifierMatCours.UseVisualStyleBackColor = true;
            this.ModifierMatCours.Click += new System.EventHandler(this.ModifierMatCours_Click);
            // 
            // AjoutMatCours
            // 
            this.AjoutMatCours.Location = new System.Drawing.Point(29, 296);
            this.AjoutMatCours.Name = "AjoutMatCours";
            this.AjoutMatCours.Size = new System.Drawing.Size(144, 46);
            this.AjoutMatCours.TabIndex = 69;
            this.AjoutMatCours.Text = "Ajouter";
            this.AjoutMatCours.UseVisualStyleBackColor = true;
            this.AjoutMatCours.Click += new System.EventHandler(this.AjoutMatCours_Click);
            // 
            // comboBoxMatiere
            // 
            this.comboBoxMatiere.FormattingEnabled = true;
            this.comboBoxMatiere.Location = new System.Drawing.Point(217, 221);
            this.comboBoxMatiere.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.comboBoxMatiere.Name = "comboBoxMatiere";
            this.comboBoxMatiere.Size = new System.Drawing.Size(238, 28);
            this.comboBoxMatiere.TabIndex = 77;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(33, 223);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 22);
            this.label1.TabIndex = 76;
            this.label1.Text = "Matieres";
            // 
            // dataGridMatCours
            // 
            this.dataGridMatCours.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridMatCours.Location = new System.Drawing.Point(606, 36);
            this.dataGridMatCours.Name = "dataGridMatCours";
            this.dataGridMatCours.RowHeadersWidth = 62;
            this.dataGridMatCours.RowTemplate.Height = 28;
            this.dataGridMatCours.Size = new System.Drawing.Size(580, 494);
            this.dataGridMatCours.TabIndex = 78;
            // 
            // AjoutMatieresCoursForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1228, 562);
            this.Controls.Add(this.dataGridMatCours);
            this.Controls.Add(this.comboBoxMatiere);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.FermerFenetre);
            this.Controls.Add(this.ViderChamps);
            this.Controls.Add(this.comboBoxCours);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.SupprimerMatCours);
            this.Controls.Add(this.ModifierMatCours);
            this.Controls.Add(this.AjoutMatCours);
            this.Controls.Add(this.labelGestionscolaire);
            this.Name = "AjoutMatieresCoursForm";
            this.Text = "AjoutMatieresCours";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridMatCours)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelGestionscolaire;
        private System.Windows.Forms.Button FermerFenetre;
        private System.Windows.Forms.Button ViderChamps;
        private System.Windows.Forms.ComboBox comboBoxCours;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button SupprimerMatCours;
        private System.Windows.Forms.Button ModifierMatCours;
        private System.Windows.Forms.Button AjoutMatCours;
        private System.Windows.Forms.ComboBox comboBoxMatiere;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridMatCours;
    }
}