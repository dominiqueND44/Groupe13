namespace Système_de_Gestion_des_Étudiants
{
    partial class EtudiantsForm
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
            this.textBoxNometu = new System.Windows.Forms.TextBox();
            this.labelNom = new System.Windows.Forms.Label();
            this.dataGridEtudiant = new System.Windows.Forms.DataGridView();
            this.SupprimerEtudiant = new System.Windows.Forms.Button();
            this.ModifierEtudiant = new System.Windows.Forms.Button();
            this.AjoutEtudiant = new System.Windows.Forms.Button();
            this.labelGestionscolaire = new System.Windows.Forms.Label();
            this.textBoxPrenometu = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxMatriculeetu = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxEmailetu = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxAdresseetu = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxTeletu = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.comboBoxSexeetu = new System.Windows.Forms.ComboBox();
            this.comboBoxClasseetu = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.dateTimePickeretu = new System.Windows.Forms.DateTimePicker();
            this.textBoxRechercheetu = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridEtudiant)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxNometu
            // 
            this.textBoxNometu.Location = new System.Drawing.Point(71, 27);
            this.textBoxNometu.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxNometu.Multiline = true;
            this.textBoxNometu.Name = "textBoxNometu";
            this.textBoxNometu.Size = new System.Drawing.Size(178, 19);
            this.textBoxNometu.TabIndex = 27;
            // 
            // labelNom
            // 
            this.labelNom.AutoSize = true;
            this.labelNom.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNom.Location = new System.Drawing.Point(11, 28);
            this.labelNom.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelNom.Name = "labelNom";
            this.labelNom.Size = new System.Drawing.Size(37, 15);
            this.labelNom.TabIndex = 26;
            this.labelNom.Text = "Nom";
            // 
            // dataGridEtudiant
            // 
            this.dataGridEtudiant.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridEtudiant.Location = new System.Drawing.Point(367, 40);
            this.dataGridEtudiant.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridEtudiant.Name = "dataGridEtudiant";
            this.dataGridEtudiant.RowHeadersWidth = 62;
            this.dataGridEtudiant.RowTemplate.Height = 28;
            this.dataGridEtudiant.Size = new System.Drawing.Size(553, 297);
            this.dataGridEtudiant.TabIndex = 25;
            // 
            // SupprimerEtudiant
            // 
            this.SupprimerEtudiant.Location = new System.Drawing.Point(257, 307);
            this.SupprimerEtudiant.Margin = new System.Windows.Forms.Padding(2);
            this.SupprimerEtudiant.Name = "SupprimerEtudiant";
            this.SupprimerEtudiant.Size = new System.Drawing.Size(89, 30);
            this.SupprimerEtudiant.TabIndex = 24;
            this.SupprimerEtudiant.Text = "Supprimer";
            this.SupprimerEtudiant.UseVisualStyleBackColor = true;
            // 
            // ModifierEtudiant
            // 
            this.ModifierEtudiant.Location = new System.Drawing.Point(130, 307);
            this.ModifierEtudiant.Margin = new System.Windows.Forms.Padding(2);
            this.ModifierEtudiant.Name = "ModifierEtudiant";
            this.ModifierEtudiant.Size = new System.Drawing.Size(96, 30);
            this.ModifierEtudiant.TabIndex = 23;
            this.ModifierEtudiant.Text = "Modifier";
            this.ModifierEtudiant.UseVisualStyleBackColor = true;
            // 
            // AjoutEtudiant
            // 
            this.AjoutEtudiant.Location = new System.Drawing.Point(11, 307);
            this.AjoutEtudiant.Margin = new System.Windows.Forms.Padding(2);
            this.AjoutEtudiant.Name = "AjoutEtudiant";
            this.AjoutEtudiant.Size = new System.Drawing.Size(96, 30);
            this.AjoutEtudiant.TabIndex = 22;
            this.AjoutEtudiant.Text = "Ajouter";
            this.AjoutEtudiant.UseVisualStyleBackColor = true;
            // 
            // labelGestionscolaire
            // 
            this.labelGestionscolaire.AutoSize = true;
            this.labelGestionscolaire.Font = new System.Drawing.Font("Times New Roman", 17F, System.Drawing.FontStyle.Bold);
            this.labelGestionscolaire.Location = new System.Drawing.Point(262, 6);
            this.labelGestionscolaire.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelGestionscolaire.Name = "labelGestionscolaire";
            this.labelGestionscolaire.Size = new System.Drawing.Size(314, 25);
            this.labelGestionscolaire.TabIndex = 21;
            this.labelGestionscolaire.Text = " GESTION DES ETUDIANTS";
            // 
            // textBoxPrenometu
            // 
            this.textBoxPrenometu.Location = new System.Drawing.Point(71, 66);
            this.textBoxPrenometu.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxPrenometu.Multiline = true;
            this.textBoxPrenometu.Name = "textBoxPrenometu";
            this.textBoxPrenometu.Size = new System.Drawing.Size(178, 19);
            this.textBoxPrenometu.TabIndex = 29;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(8, 67);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 15);
            this.label1.TabIndex = 28;
            this.label1.Text = "Prénom";
            // 
            // textBoxMatriculeetu
            // 
            this.textBoxMatriculeetu.Location = new System.Drawing.Point(71, 103);
            this.textBoxMatriculeetu.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxMatriculeetu.Multiline = true;
            this.textBoxMatriculeetu.Name = "textBoxMatriculeetu";
            this.textBoxMatriculeetu.Size = new System.Drawing.Size(134, 19);
            this.textBoxMatriculeetu.TabIndex = 31;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(4, 104);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 15);
            this.label2.TabIndex = 30;
            this.label2.Text = "Matricule";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(4, 142);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(126, 15);
            this.label3.TabIndex = 32;
            this.label3.Text = "Date de naissance";
            // 
            // textBoxEmailetu
            // 
            this.textBoxEmailetu.Location = new System.Drawing.Point(68, 183);
            this.textBoxEmailetu.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxEmailetu.Multiline = true;
            this.textBoxEmailetu.Name = "textBoxEmailetu";
            this.textBoxEmailetu.Size = new System.Drawing.Size(155, 19);
            this.textBoxEmailetu.TabIndex = 35;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(9, 181);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 15);
            this.label4.TabIndex = 34;
            this.label4.Text = "E-mail";
            // 
            // textBoxAdresseetu
            // 
            this.textBoxAdresseetu.Location = new System.Drawing.Point(69, 222);
            this.textBoxAdresseetu.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxAdresseetu.Multiline = true;
            this.textBoxAdresseetu.Name = "textBoxAdresseetu";
            this.textBoxAdresseetu.Size = new System.Drawing.Size(134, 19);
            this.textBoxAdresseetu.TabIndex = 37;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(9, 223);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 15);
            this.label5.TabIndex = 36;
            this.label5.Text = "Adresse";
            // 
            // textBoxTeletu
            // 
            this.textBoxTeletu.Location = new System.Drawing.Point(88, 263);
            this.textBoxTeletu.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxTeletu.Multiline = true;
            this.textBoxTeletu.Name = "textBoxTeletu";
            this.textBoxTeletu.Size = new System.Drawing.Size(134, 19);
            this.textBoxTeletu.TabIndex = 39;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(8, 263);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 15);
            this.label6.TabIndex = 38;
            this.label6.Text = "Téléphone";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(232, 184);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(39, 15);
            this.label7.TabIndex = 40;
            this.label7.Text = "Sexe";
            // 
            // comboBoxSexeetu
            // 
            this.comboBoxSexeetu.FormattingEnabled = true;
            this.comboBoxSexeetu.Location = new System.Drawing.Point(288, 184);
            this.comboBoxSexeetu.Name = "comboBoxSexeetu";
            this.comboBoxSexeetu.Size = new System.Drawing.Size(74, 21);
            this.comboBoxSexeetu.TabIndex = 42;
            // 
            // comboBoxClasseetu
            // 
            this.comboBoxClasseetu.FormattingEnabled = true;
            this.comboBoxClasseetu.Location = new System.Drawing.Point(288, 222);
            this.comboBoxClasseetu.Name = "comboBoxClasseetu";
            this.comboBoxClasseetu.Size = new System.Drawing.Size(74, 21);
            this.comboBoxClasseetu.TabIndex = 44;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(226, 224);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(50, 15);
            this.label8.TabIndex = 43;
            this.label8.Text = "Classe";
            // 
            // dateTimePickeretu
            // 
            this.dateTimePickeretu.Location = new System.Drawing.Point(135, 142);
            this.dateTimePickeretu.Name = "dateTimePickeretu";
            this.dateTimePickeretu.Size = new System.Drawing.Size(174, 20);
            this.dateTimePickeretu.TabIndex = 45;
            // 
            // textBoxRechercheetu
            // 
            this.textBoxRechercheetu.Location = new System.Drawing.Point(742, 11);
            this.textBoxRechercheetu.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxRechercheetu.Multiline = true;
            this.textBoxRechercheetu.Name = "textBoxRechercheetu";
            this.textBoxRechercheetu.Size = new System.Drawing.Size(170, 23);
            this.textBoxRechercheetu.TabIndex = 47;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(657, 16);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(81, 15);
            this.label9.TabIndex = 46;
            this.label9.Text = "Rechercher";
            // 
            // EtudiantsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(923, 358);
            this.Controls.Add(this.textBoxRechercheetu);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.dateTimePickeretu);
            this.Controls.Add(this.comboBoxClasseetu);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.comboBoxSexeetu);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBoxTeletu);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBoxAdresseetu);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBoxEmailetu);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxMatriculeetu);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxPrenometu);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxNometu);
            this.Controls.Add(this.labelNom);
            this.Controls.Add(this.dataGridEtudiant);
            this.Controls.Add(this.SupprimerEtudiant);
            this.Controls.Add(this.ModifierEtudiant);
            this.Controls.Add(this.AjoutEtudiant);
            this.Controls.Add(this.labelGestionscolaire);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "EtudiantsForm";
            this.Text = "Etudiants";
            this.Load += new System.EventHandler(this.EtudiantsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridEtudiant)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxNometu;
        private System.Windows.Forms.Label labelNom;
        private System.Windows.Forms.DataGridView dataGridEtudiant;
        private System.Windows.Forms.Button SupprimerEtudiant;
        private System.Windows.Forms.Button ModifierEtudiant;
        private System.Windows.Forms.Button AjoutEtudiant;
        private System.Windows.Forms.Label labelGestionscolaire;
        private System.Windows.Forms.TextBox textBoxPrenometu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxMatriculeetu;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxEmailetu;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxAdresseetu;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxTeletu;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox comboBoxSexeetu;
        private System.Windows.Forms.ComboBox comboBoxClasseetu;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker dateTimePickeretu;
        private System.Windows.Forms.TextBox textBoxRechercheetu;
        private System.Windows.Forms.Label label9;
    }
}