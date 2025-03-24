namespace Système_de_Gestion_des_Étudiants
{
    partial class GenererReleveEtu
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
            this.GenererPDF = new System.Windows.Forms.Button();
            this.comboBoxEtudiant = new System.Windows.Forms.ComboBox();
            this.labelNom = new System.Windows.Forms.Label();
            this.GenererEXEL = new System.Windows.Forms.Button();
            this.labelGestionscolaire = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // GenererPDF
            // 
            this.GenererPDF.BackColor = System.Drawing.Color.Red;
            this.GenererPDF.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GenererPDF.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.GenererPDF.Location = new System.Drawing.Point(177, 330);
            this.GenererPDF.Name = "GenererPDF";
            this.GenererPDF.Size = new System.Drawing.Size(211, 60);
            this.GenererPDF.TabIndex = 35;
            this.GenererPDF.Text = "Generer en PDF";
            this.GenererPDF.UseVisualStyleBackColor = false;
            this.GenererPDF.Click += new System.EventHandler(this.GenererPDF_Click);
            // 
            // comboBoxEtudiant
            // 
            this.comboBoxEtudiant.FormattingEnabled = true;
            this.comboBoxEtudiant.Location = new System.Drawing.Point(478, 231);
            this.comboBoxEtudiant.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.comboBoxEtudiant.Name = "comboBoxEtudiant";
            this.comboBoxEtudiant.Size = new System.Drawing.Size(180, 28);
            this.comboBoxEtudiant.TabIndex = 34;
            // 
            // labelNom
            // 
            this.labelNom.AutoSize = true;
            this.labelNom.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNom.Location = new System.Drawing.Point(324, 230);
            this.labelNom.Name = "labelNom";
            this.labelNom.Size = new System.Drawing.Size(108, 29);
            this.labelNom.TabIndex = 33;
            this.labelNom.Text = "Etudiant";
            // 
            // GenererEXEL
            // 
            this.GenererEXEL.BackColor = System.Drawing.Color.Green;
            this.GenererEXEL.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GenererEXEL.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.GenererEXEL.Location = new System.Drawing.Point(622, 330);
            this.GenererEXEL.Name = "GenererEXEL";
            this.GenererEXEL.Size = new System.Drawing.Size(211, 60);
            this.GenererEXEL.TabIndex = 37;
            this.GenererEXEL.Text = "Generer en EXEL";
            this.GenererEXEL.UseVisualStyleBackColor = false;
            this.GenererEXEL.Click += new System.EventHandler(this.GenererEXEL_Click);
            // 
            // labelGestionscolaire
            // 
            this.labelGestionscolaire.AutoSize = true;
            this.labelGestionscolaire.Font = new System.Drawing.Font("Times New Roman", 17F, System.Drawing.FontStyle.Bold);
            this.labelGestionscolaire.Location = new System.Drawing.Point(242, 98);
            this.labelGestionscolaire.Name = "labelGestionscolaire";
            this.labelGestionscolaire.Size = new System.Drawing.Size(614, 38);
            this.labelGestionscolaire.TabIndex = 59;
            this.labelGestionscolaire.Text = " Génerer le Relevé de Note d\'un Etudiant";
            // 
            // GenererReleveEtu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1081, 579);
            this.Controls.Add(this.labelGestionscolaire);
            this.Controls.Add(this.GenererEXEL);
            this.Controls.Add(this.GenererPDF);
            this.Controls.Add(this.comboBoxEtudiant);
            this.Controls.Add(this.labelNom);
            this.Name = "GenererReleveEtu";
            this.Text = "GenererReleveEtu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button GenererPDF;
        private System.Windows.Forms.ComboBox comboBoxEtudiant;
        private System.Windows.Forms.Label labelNom;
        private System.Windows.Forms.Button GenererEXEL;
        private System.Windows.Forms.Label labelGestionscolaire;
    }
}