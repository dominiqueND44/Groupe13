namespace Système_de_Gestion_des_Étudiants
{
    partial class GenererListeEtuClasse
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
            this.GenererEXEL = new System.Windows.Forms.Button();
            this.GenererPDF = new System.Windows.Forms.Button();
            this.comboBoxClasse = new System.Windows.Forms.ComboBox();
            this.labelNom = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelGestionscolaire
            // 
            this.labelGestionscolaire.AutoSize = true;
            this.labelGestionscolaire.Font = new System.Drawing.Font("Times New Roman", 17F, System.Drawing.FontStyle.Bold);
            this.labelGestionscolaire.Location = new System.Drawing.Point(205, 103);
            this.labelGestionscolaire.Name = "labelGestionscolaire";
            this.labelGestionscolaire.Size = new System.Drawing.Size(611, 38);
            this.labelGestionscolaire.TabIndex = 64;
            this.labelGestionscolaire.Text = " Génerer la liste des Etudiants par Classe";
            // 
            // GenererEXEL
            // 
            this.GenererEXEL.BackColor = System.Drawing.Color.Green;
            this.GenererEXEL.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GenererEXEL.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.GenererEXEL.Location = new System.Drawing.Point(585, 335);
            this.GenererEXEL.Name = "GenererEXEL";
            this.GenererEXEL.Size = new System.Drawing.Size(211, 60);
            this.GenererEXEL.TabIndex = 63;
            this.GenererEXEL.Text = "Generer en EXEL";
            this.GenererEXEL.UseVisualStyleBackColor = false;
            this.GenererEXEL.Click += new System.EventHandler(this.GenererEXEL_Click);
            // 
            // GenererPDF
            // 
            this.GenererPDF.BackColor = System.Drawing.Color.Red;
            this.GenererPDF.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GenererPDF.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.GenererPDF.Location = new System.Drawing.Point(140, 335);
            this.GenererPDF.Name = "GenererPDF";
            this.GenererPDF.Size = new System.Drawing.Size(211, 60);
            this.GenererPDF.TabIndex = 62;
            this.GenererPDF.Text = "Generer en PDF";
            this.GenererPDF.UseVisualStyleBackColor = false;
            this.GenererPDF.Click += new System.EventHandler(this.GenererPDF_Click);
            // 
            // comboBoxClasse
            // 
            this.comboBoxClasse.FormattingEnabled = true;
            this.comboBoxClasse.Location = new System.Drawing.Point(441, 236);
            this.comboBoxClasse.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.comboBoxClasse.Name = "comboBoxClasse";
            this.comboBoxClasse.Size = new System.Drawing.Size(180, 28);
            this.comboBoxClasse.TabIndex = 61;
            // 
            // labelNom
            // 
            this.labelNom.AutoSize = true;
            this.labelNom.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNom.Location = new System.Drawing.Point(287, 235);
            this.labelNom.Name = "labelNom";
            this.labelNom.Size = new System.Drawing.Size(93, 29);
            this.labelNom.TabIndex = 60;
            this.labelNom.Text = "Classe";
            // 
            // GenererListeEtuClasse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1046, 589);
            this.Controls.Add(this.labelGestionscolaire);
            this.Controls.Add(this.GenererEXEL);
            this.Controls.Add(this.GenererPDF);
            this.Controls.Add(this.comboBoxClasse);
            this.Controls.Add(this.labelNom);
            this.Name = "GenererListeEtuClasse";
            this.Text = "GenererListeEtuClasse";
            this.Load += new System.EventHandler(this.GenererListeEtuClasse_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelGestionscolaire;
        private System.Windows.Forms.Button GenererEXEL;
        private System.Windows.Forms.Button GenererPDF;
        private System.Windows.Forms.ComboBox comboBoxClasse;
        private System.Windows.Forms.Label labelNom;
    }
}