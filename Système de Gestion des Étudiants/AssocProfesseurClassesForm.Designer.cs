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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.labelNom = new System.Windows.Forms.Label();
            this.dataGridProfClasse = new System.Windows.Forms.DataGridView();
            this.SupprimerClasseProf = new System.Windows.Forms.Button();
            this.ModifierClasseProf = new System.Windows.Forms.Button();
            this.AjoutClasseProf = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridProfClasse)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(131, 142);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 33;
            // 
            // labelNom
            // 
            this.labelNom.AutoSize = true;
            this.labelNom.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNom.Location = new System.Drawing.Point(39, 142);
            this.labelNom.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelNom.Name = "labelNom";
            this.labelNom.Size = new System.Drawing.Size(60, 18);
            this.labelNom.TabIndex = 32;
            this.labelNom.Text = "Classe";
            // 
            // dataGridProfClasse
            // 
            this.dataGridProfClasse.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridProfClasse.Location = new System.Drawing.Point(371, 50);
            this.dataGridProfClasse.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridProfClasse.Name = "dataGridProfClasse";
            this.dataGridProfClasse.RowHeadersWidth = 62;
            this.dataGridProfClasse.RowTemplate.Height = 28;
            this.dataGridProfClasse.Size = new System.Drawing.Size(409, 276);
            this.dataGridProfClasse.TabIndex = 31;
            // 
            // SupprimerClasseProf
            // 
            this.SupprimerClasseProf.Location = new System.Drawing.Point(248, 197);
            this.SupprimerClasseProf.Margin = new System.Windows.Forms.Padding(2);
            this.SupprimerClasseProf.Name = "SupprimerClasseProf";
            this.SupprimerClasseProf.Size = new System.Drawing.Size(89, 30);
            this.SupprimerClasseProf.TabIndex = 30;
            this.SupprimerClasseProf.Text = "Supprimer";
            this.SupprimerClasseProf.UseVisualStyleBackColor = true;
            // 
            // ModifierClasseProf
            // 
            this.ModifierClasseProf.Location = new System.Drawing.Point(131, 197);
            this.ModifierClasseProf.Margin = new System.Windows.Forms.Padding(2);
            this.ModifierClasseProf.Name = "ModifierClasseProf";
            this.ModifierClasseProf.Size = new System.Drawing.Size(96, 30);
            this.ModifierClasseProf.TabIndex = 29;
            this.ModifierClasseProf.Text = "Modifier";
            this.ModifierClasseProf.UseVisualStyleBackColor = true;
            // 
            // AjoutClasseProf
            // 
            this.AjoutClasseProf.Location = new System.Drawing.Point(22, 197);
            this.AjoutClasseProf.Margin = new System.Windows.Forms.Padding(2);
            this.AjoutClasseProf.Name = "AjoutClasseProf";
            this.AjoutClasseProf.Size = new System.Drawing.Size(96, 30);
            this.AjoutClasseProf.TabIndex = 28;
            this.AjoutClasseProf.Text = "Ajouter";
            this.AjoutClasseProf.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(107, 99);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(98, 17);
            this.label5.TabIndex = 34;
            this.label5.Text = "Veillez chosir !";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // AssocProfesseurClassesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.labelNom);
            this.Controls.Add(this.dataGridProfClasse);
            this.Controls.Add(this.SupprimerClasseProf);
            this.Controls.Add(this.ModifierClasseProf);
            this.Controls.Add(this.AjoutClasseProf);
            this.Name = "AssocProfesseurClassesForm";
            this.Text = "AssocProfesseurClassesForm";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridProfClasse)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label labelNom;
        private System.Windows.Forms.DataGridView dataGridProfClasse;
        private System.Windows.Forms.Button SupprimerClasseProf;
        private System.Windows.Forms.Button ModifierClasseProf;
        private System.Windows.Forms.Button AjoutClasseProf;
        private System.Windows.Forms.Label label5;
    }
}