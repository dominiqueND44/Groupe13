namespace Système_de_Gestion_des_Étudiants
{
    partial class MatiereForm
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
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxNomMatiere = new System.Windows.Forms.TextBox();
            this.labelNom = new System.Windows.Forms.Label();
            this.dataGridClasse = new System.Windows.Forms.DataGridView();
            this.SupprimerMatiere = new System.Windows.Forms.Button();
            this.ModifierMatiere = new System.Windows.Forms.Button();
            this.AjoutMatiere = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridClasse)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(64, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(313, 26);
            this.label3.TabIndex = 43;
            this.label3.Text = " GESTION DES MATIERES ";
            // 
            // textBoxNomMatiere
            // 
            this.textBoxNomMatiere.Location = new System.Drawing.Point(171, 160);
            this.textBoxNomMatiere.Multiline = true;
            this.textBoxNomMatiere.Name = "textBoxNomMatiere";
            this.textBoxNomMatiere.Size = new System.Drawing.Size(211, 35);
            this.textBoxNomMatiere.TabIndex = 42;
            // 
            // labelNom
            // 
            this.labelNom.AutoSize = true;
            this.labelNom.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNom.Location = new System.Drawing.Point(66, 165);
            this.labelNom.Name = "labelNom";
            this.labelNom.Size = new System.Drawing.Size(101, 29);
            this.labelNom.TabIndex = 41;
            this.labelNom.Text = "Matiere";
            // 
            // dataGridClasse
            // 
            this.dataGridClasse.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridClasse.Location = new System.Drawing.Point(568, 111);
            this.dataGridClasse.Name = "dataGridClasse";
            this.dataGridClasse.RowHeadersWidth = 62;
            this.dataGridClasse.RowTemplate.Height = 28;
            this.dataGridClasse.Size = new System.Drawing.Size(590, 360);
            this.dataGridClasse.TabIndex = 40;
            // 
            // SupprimerMatiere
            // 
            this.SupprimerMatiere.Location = new System.Drawing.Point(386, 232);
            this.SupprimerMatiere.Name = "SupprimerMatiere";
            this.SupprimerMatiere.Size = new System.Drawing.Size(134, 46);
            this.SupprimerMatiere.TabIndex = 39;
            this.SupprimerMatiere.Text = "Supprimer";
            this.SupprimerMatiere.UseVisualStyleBackColor = true;
            // 
            // ModifierMatiere
            // 
            this.ModifierMatiere.Location = new System.Drawing.Point(216, 232);
            this.ModifierMatiere.Name = "ModifierMatiere";
            this.ModifierMatiere.Size = new System.Drawing.Size(144, 46);
            this.ModifierMatiere.TabIndex = 38;
            this.ModifierMatiere.Text = "Modifier";
            this.ModifierMatiere.UseVisualStyleBackColor = true;
            // 
            // AjoutMatiere
            // 
            this.AjoutMatiere.Location = new System.Drawing.Point(44, 232);
            this.AjoutMatiere.Name = "AjoutMatiere";
            this.AjoutMatiere.Size = new System.Drawing.Size(144, 46);
            this.AjoutMatiere.TabIndex = 37;
            this.AjoutMatiere.Text = "Ajouter";
            this.AjoutMatiere.UseVisualStyleBackColor = true;
            this.AjoutMatiere.Click += new System.EventHandler(this.AjoutMatiere_Click);
            // 
            // MatiereForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 692);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxNomMatiere);
            this.Controls.Add(this.labelNom);
            this.Controls.Add(this.dataGridClasse);
            this.Controls.Add(this.SupprimerMatiere);
            this.Controls.Add(this.ModifierMatiere);
            this.Controls.Add(this.AjoutMatiere);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "MatiereForm";
            this.Text = "MatiereForm";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridClasse)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxNomMatiere;
        private System.Windows.Forms.Label labelNom;
        private System.Windows.Forms.DataGridView dataGridClasse;
        private System.Windows.Forms.Button SupprimerMatiere;
        private System.Windows.Forms.Button ModifierMatiere;
        private System.Windows.Forms.Button AjoutMatiere;
    }
}