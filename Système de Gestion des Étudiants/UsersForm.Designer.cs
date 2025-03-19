namespace Système_de_Gestion_des_Étudiants
{
    partial class UsersForm
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
            this.textBoxTelprof = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxPrenomprof = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxNomprof = new System.Windows.Forms.TextBox();
            this.labelNom = new System.Windows.Forms.Label();
            this.dataGridProfesseur = new System.Windows.Forms.DataGridView();
            this.SupprimerProfesseur = new System.Windows.Forms.Button();
            this.ModifierProfesseur = new System.Windows.Forms.Button();
            this.AjoutProfesseur = new System.Windows.Forms.Button();
            this.labelGestionscolaire = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridProfesseur)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxTelprof
            // 
            this.textBoxTelprof.Location = new System.Drawing.Point(200, 308);
            this.textBoxTelprof.Multiline = true;
            this.textBoxTelprof.Name = "textBoxTelprof";
            this.textBoxTelprof.Size = new System.Drawing.Size(238, 27);
            this.textBoxTelprof.TabIndex = 65;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(8, 314);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(105, 22);
            this.label6.TabIndex = 64;
            this.label6.Text = "Téléphone";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(16, 240);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 22);
            this.label4.TabIndex = 62;
            this.label4.Text = "Role";
            // 
            // textBoxPrenomprof
            // 
            this.textBoxPrenomprof.Location = new System.Drawing.Point(200, 162);
            this.textBoxPrenomprof.Multiline = true;
            this.textBoxPrenomprof.Name = "textBoxPrenomprof";
            this.textBoxPrenomprof.Size = new System.Drawing.Size(238, 27);
            this.textBoxPrenomprof.TabIndex = 61;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(15, 163);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 22);
            this.label1.TabIndex = 60;
            this.label1.Text = "Mot de passe";
            // 
            // textBoxNomprof
            // 
            this.textBoxNomprof.Location = new System.Drawing.Point(200, 92);
            this.textBoxNomprof.Multiline = true;
            this.textBoxNomprof.Name = "textBoxNomprof";
            this.textBoxNomprof.Size = new System.Drawing.Size(238, 27);
            this.textBoxNomprof.TabIndex = 59;
            // 
            // labelNom
            // 
            this.labelNom.AutoSize = true;
            this.labelNom.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNom.Location = new System.Drawing.Point(15, 92);
            this.labelNom.Name = "labelNom";
            this.labelNom.Size = new System.Drawing.Size(160, 22);
            this.labelNom.TabIndex = 58;
            this.labelNom.Text = "Nom d\'utilisateur";
            // 
            // dataGridProfesseur
            // 
            this.dataGridProfesseur.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridProfesseur.Location = new System.Drawing.Point(552, 62);
            this.dataGridProfesseur.Name = "dataGridProfesseur";
            this.dataGridProfesseur.RowHeadersWidth = 62;
            this.dataGridProfesseur.RowTemplate.Height = 28;
            this.dataGridProfesseur.Size = new System.Drawing.Size(723, 426);
            this.dataGridProfesseur.TabIndex = 57;
            // 
            // SupprimerProfesseur
            // 
            this.SupprimerProfesseur.Location = new System.Drawing.Point(394, 398);
            this.SupprimerProfesseur.Name = "SupprimerProfesseur";
            this.SupprimerProfesseur.Size = new System.Drawing.Size(134, 46);
            this.SupprimerProfesseur.TabIndex = 56;
            this.SupprimerProfesseur.Text = "Supprimer";
            this.SupprimerProfesseur.UseVisualStyleBackColor = true;
            // 
            // ModifierProfesseur
            // 
            this.ModifierProfesseur.Location = new System.Drawing.Point(200, 398);
            this.ModifierProfesseur.Name = "ModifierProfesseur";
            this.ModifierProfesseur.Size = new System.Drawing.Size(144, 46);
            this.ModifierProfesseur.TabIndex = 55;
            this.ModifierProfesseur.Text = "Modifier";
            this.ModifierProfesseur.UseVisualStyleBackColor = true;
            this.ModifierProfesseur.Click += new System.EventHandler(this.ModifierProfesseur_Click);
            // 
            // AjoutProfesseur
            // 
            this.AjoutProfesseur.Location = new System.Drawing.Point(3, 398);
            this.AjoutProfesseur.Name = "AjoutProfesseur";
            this.AjoutProfesseur.Size = new System.Drawing.Size(144, 46);
            this.AjoutProfesseur.TabIndex = 54;
            this.AjoutProfesseur.Text = "Ajouter";
            this.AjoutProfesseur.UseVisualStyleBackColor = true;
            this.AjoutProfesseur.Click += new System.EventHandler(this.AjoutProfesseur_Click);
            // 
            // labelGestionscolaire
            // 
            this.labelGestionscolaire.AutoSize = true;
            this.labelGestionscolaire.Font = new System.Drawing.Font("Times New Roman", 17F, System.Drawing.FontStyle.Bold);
            this.labelGestionscolaire.Location = new System.Drawing.Point(420, 0);
            this.labelGestionscolaire.Name = "labelGestionscolaire";
            this.labelGestionscolaire.Size = new System.Drawing.Size(518, 38);
            this.labelGestionscolaire.TabIndex = 53;
            this.labelGestionscolaire.Text = " GESTION DES UTILISATEURS";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(200, 238);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(238, 28);
            this.comboBox1.TabIndex = 66;
            // 
            // UsersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1300, 505);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.textBoxTelprof);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxPrenomprof);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxNomprof);
            this.Controls.Add(this.labelNom);
            this.Controls.Add(this.dataGridProfesseur);
            this.Controls.Add(this.SupprimerProfesseur);
            this.Controls.Add(this.ModifierProfesseur);
            this.Controls.Add(this.AjoutProfesseur);
            this.Controls.Add(this.labelGestionscolaire);
            this.Name = "UsersForm";
            this.Text = "Utilisateurs";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridProfesseur)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxTelprof;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxPrenomprof;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxNomprof;
        private System.Windows.Forms.Label labelNom;
        private System.Windows.Forms.DataGridView dataGridProfesseur;
        private System.Windows.Forms.Button SupprimerProfesseur;
        private System.Windows.Forms.Button ModifierProfesseur;
        private System.Windows.Forms.Button AjoutProfesseur;
        private System.Windows.Forms.Label labelGestionscolaire;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}