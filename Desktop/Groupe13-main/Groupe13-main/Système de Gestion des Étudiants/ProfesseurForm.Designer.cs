namespace Système_de_Gestion_des_Étudiants
{
    partial class ProfesseurForm
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
            this.textBoxEmailprof = new System.Windows.Forms.TextBox();
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridProfesseur)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxTelprof
            // 
            this.textBoxTelprof.Location = new System.Drawing.Point(90, 220);
            this.textBoxTelprof.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxTelprof.Multiline = true;
            this.textBoxTelprof.Name = "textBoxTelprof";
            this.textBoxTelprof.Size = new System.Drawing.Size(134, 19);
            this.textBoxTelprof.TabIndex = 52;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(11, 221);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 15);
            this.label6.TabIndex = 51;
            this.label6.Text = "Téléphone";
            // 
            // textBoxEmailprof
            // 
            this.textBoxEmailprof.Location = new System.Drawing.Point(90, 169);
            this.textBoxEmailprof.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxEmailprof.Multiline = true;
            this.textBoxEmailprof.Name = "textBoxEmailprof";
            this.textBoxEmailprof.Size = new System.Drawing.Size(155, 19);
            this.textBoxEmailprof.TabIndex = 50;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(16, 173);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 15);
            this.label4.TabIndex = 49;
            this.label4.Text = "E-mail";
            // 
            // textBoxPrenomprof
            // 
            this.textBoxPrenomprof.Location = new System.Drawing.Point(89, 122);
            this.textBoxPrenomprof.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxPrenomprof.Multiline = true;
            this.textBoxPrenomprof.Name = "textBoxPrenomprof";
            this.textBoxPrenomprof.Size = new System.Drawing.Size(178, 19);
            this.textBoxPrenomprof.TabIndex = 48;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(16, 123);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 15);
            this.label1.TabIndex = 47;
            this.label1.Text = "Prénom";
            // 
            // textBoxNomprof
            // 
            this.textBoxNomprof.Location = new System.Drawing.Point(89, 77);
            this.textBoxNomprof.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxNomprof.Multiline = true;
            this.textBoxNomprof.Name = "textBoxNomprof";
            this.textBoxNomprof.Size = new System.Drawing.Size(134, 19);
            this.textBoxNomprof.TabIndex = 46;
            // 
            // labelNom
            // 
            this.labelNom.AutoSize = true;
            this.labelNom.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNom.Location = new System.Drawing.Point(16, 77);
            this.labelNom.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelNom.Name = "labelNom";
            this.labelNom.Size = new System.Drawing.Size(37, 15);
            this.labelNom.TabIndex = 45;
            this.labelNom.Text = "Nom";
            // 
            // dataGridProfesseur
            // 
            this.dataGridProfesseur.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridProfesseur.Location = new System.Drawing.Point(374, 57);
            this.dataGridProfesseur.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridProfesseur.Name = "dataGridProfesseur";
            this.dataGridProfesseur.RowHeadersWidth = 62;
            this.dataGridProfesseur.RowTemplate.Height = 28;
            this.dataGridProfesseur.Size = new System.Drawing.Size(482, 288);
            this.dataGridProfesseur.TabIndex = 44;
            // 
            // SupprimerProfesseur
            // 
            this.SupprimerProfesseur.Location = new System.Drawing.Point(269, 276);
            this.SupprimerProfesseur.Margin = new System.Windows.Forms.Padding(2);
            this.SupprimerProfesseur.Name = "SupprimerProfesseur";
            this.SupprimerProfesseur.Size = new System.Drawing.Size(89, 30);
            this.SupprimerProfesseur.TabIndex = 43;
            this.SupprimerProfesseur.Text = "Supprimer";
            this.SupprimerProfesseur.UseVisualStyleBackColor = true;
            // 
            // ModifierProfesseur
            // 
            this.ModifierProfesseur.Location = new System.Drawing.Point(139, 276);
            this.ModifierProfesseur.Margin = new System.Windows.Forms.Padding(2);
            this.ModifierProfesseur.Name = "ModifierProfesseur";
            this.ModifierProfesseur.Size = new System.Drawing.Size(96, 30);
            this.ModifierProfesseur.TabIndex = 42;
            this.ModifierProfesseur.Text = "Modifier";
            this.ModifierProfesseur.UseVisualStyleBackColor = true;
            // 
            // AjoutProfesseur
            // 
            this.AjoutProfesseur.Location = new System.Drawing.Point(8, 276);
            this.AjoutProfesseur.Margin = new System.Windows.Forms.Padding(2);
            this.AjoutProfesseur.Name = "AjoutProfesseur";
            this.AjoutProfesseur.Size = new System.Drawing.Size(96, 30);
            this.AjoutProfesseur.TabIndex = 41;
            this.AjoutProfesseur.Text = "Ajouter";
            this.AjoutProfesseur.UseVisualStyleBackColor = true;
            // 
            // labelGestionscolaire
            // 
            this.labelGestionscolaire.AutoSize = true;
            this.labelGestionscolaire.Font = new System.Drawing.Font("Times New Roman", 17F, System.Drawing.FontStyle.Bold);
            this.labelGestionscolaire.Location = new System.Drawing.Point(286, 17);
            this.labelGestionscolaire.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelGestionscolaire.Name = "labelGestionscolaire";
            this.labelGestionscolaire.Size = new System.Drawing.Size(348, 25);
            this.labelGestionscolaire.TabIndex = 40;
            this.labelGestionscolaire.Text = " GESTION DES PROFESSEURS";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(8, 321);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(164, 30);
            this.button1.TabIndex = 53;
            this.button1.Text = "Associer à une ou des matières";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(193, 321);
            this.button2.Margin = new System.Windows.Forms.Padding(2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(165, 30);
            this.button2.TabIndex = 54;
            this.button2.Text = "Associer à une ou des classe";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // ProfesseurForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(881, 362);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBoxTelprof);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBoxEmailprof);
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
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "ProfesseurForm";
            this.Text = "Professeurs";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridProfesseur)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxTelprof;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxEmailprof;
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
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}