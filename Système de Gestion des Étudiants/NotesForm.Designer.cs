namespace Système_de_Gestion_des_Étudiants
{
    partial class NotesForm
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
            this.textBoxNote = new System.Windows.Forms.TextBox();
            this.labelNom = new System.Windows.Forms.Label();
            this.dataGridNote = new System.Windows.Forms.DataGridView();
            this.SupprimerNote = new System.Windows.Forms.Button();
            this.ModifierNote = new System.Windows.Forms.Button();
            this.AjoutNote = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBoxEtuNote = new System.Windows.Forms.ComboBox();
            this.comboBoxMatNote = new System.Windows.Forms.ComboBox();
            this.CalculerMoyenne = new System.Windows.Forms.Button();
            this.AfficheReleveNotes = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridNote)).BeginInit();
            this.SuspendLayout();
            // 
            // labelGestionscolaire
            // 
            this.labelGestionscolaire.AutoSize = true;
            this.labelGestionscolaire.Font = new System.Drawing.Font("Times New Roman", 17F, System.Drawing.FontStyle.Bold);
            this.labelGestionscolaire.Location = new System.Drawing.Point(363, 14);
            this.labelGestionscolaire.Name = "labelGestionscolaire";
            this.labelGestionscolaire.Size = new System.Drawing.Size(382, 38);
            this.labelGestionscolaire.TabIndex = 21;
            this.labelGestionscolaire.Text = " GESTION DES NOTES";
            // 
            // textBoxNote
            // 
            this.textBoxNote.Location = new System.Drawing.Point(210, 277);
            this.textBoxNote.Multiline = true;
            this.textBoxNote.Name = "textBoxNote";
            this.textBoxNote.Size = new System.Drawing.Size(180, 35);
            this.textBoxNote.TabIndex = 27;
            // 
            // labelNom
            // 
            this.labelNom.AutoSize = true;
            this.labelNom.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNom.Location = new System.Drawing.Point(57, 112);
            this.labelNom.Name = "labelNom";
            this.labelNom.Size = new System.Drawing.Size(108, 29);
            this.labelNom.TabIndex = 26;
            this.labelNom.Text = "Etudiant";
            // 
            // dataGridNote
            // 
            this.dataGridNote.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridNote.Location = new System.Drawing.Point(574, 69);
            this.dataGridNote.Name = "dataGridNote";
            this.dataGridNote.RowHeadersWidth = 62;
            this.dataGridNote.RowTemplate.Height = 28;
            this.dataGridNote.Size = new System.Drawing.Size(721, 425);
            this.dataGridNote.TabIndex = 25;
            // 
            // SupprimerNote
            // 
            this.SupprimerNote.Location = new System.Drawing.Point(410, 342);
            this.SupprimerNote.Name = "SupprimerNote";
            this.SupprimerNote.Size = new System.Drawing.Size(134, 46);
            this.SupprimerNote.TabIndex = 24;
            this.SupprimerNote.Text = "Supprimer";
            this.SupprimerNote.UseVisualStyleBackColor = true;
            this.SupprimerNote.Click += new System.EventHandler(this.SupprimerClasse_Click);
            // 
            // ModifierNote
            // 
            this.ModifierNote.Location = new System.Drawing.Point(210, 342);
            this.ModifierNote.Name = "ModifierNote";
            this.ModifierNote.Size = new System.Drawing.Size(144, 46);
            this.ModifierNote.TabIndex = 23;
            this.ModifierNote.Text = "Modifier";
            this.ModifierNote.UseVisualStyleBackColor = true;
            // 
            // AjoutNote
            // 
            this.AjoutNote.Location = new System.Drawing.Point(16, 342);
            this.AjoutNote.Name = "AjoutNote";
            this.AjoutNote.Size = new System.Drawing.Size(144, 46);
            this.AjoutNote.TabIndex = 22;
            this.AjoutNote.Text = "Ajouter";
            this.AjoutNote.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(57, 200);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 29);
            this.label1.TabIndex = 28;
            this.label1.Text = "Matiere";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(62, 283);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 29);
            this.label2.TabIndex = 29;
            this.label2.Text = "Note";
            // 
            // comboBoxEtuNote
            // 
            this.comboBoxEtuNote.FormattingEnabled = true;
            this.comboBoxEtuNote.Location = new System.Drawing.Point(210, 114);
            this.comboBoxEtuNote.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.comboBoxEtuNote.Name = "comboBoxEtuNote";
            this.comboBoxEtuNote.Size = new System.Drawing.Size(180, 28);
            this.comboBoxEtuNote.TabIndex = 30;
            // 
            // comboBoxMatNote
            // 
            this.comboBoxMatNote.FormattingEnabled = true;
            this.comboBoxMatNote.Location = new System.Drawing.Point(210, 198);
            this.comboBoxMatNote.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.comboBoxMatNote.Name = "comboBoxMatNote";
            this.comboBoxMatNote.Size = new System.Drawing.Size(180, 28);
            this.comboBoxMatNote.TabIndex = 31;
            // 
            // CalculerMoyenne
            // 
            this.CalculerMoyenne.Location = new System.Drawing.Point(16, 412);
            this.CalculerMoyenne.Name = "CalculerMoyenne";
            this.CalculerMoyenne.Size = new System.Drawing.Size(180, 46);
            this.CalculerMoyenne.TabIndex = 32;
            this.CalculerMoyenne.Text = "Calculer Moyenne";
            this.CalculerMoyenne.UseVisualStyleBackColor = true;
            // 
            // AfficheReleveNotes
            // 
            this.AfficheReleveNotes.Location = new System.Drawing.Point(230, 412);
            this.AfficheReleveNotes.Name = "AfficheReleveNotes";
            this.AfficheReleveNotes.Size = new System.Drawing.Size(288, 82);
            this.AfficheReleveNotes.TabIndex = 33;
            this.AfficheReleveNotes.Text = "Afficher les relevés de notes (moyennes générales et par matière)";
            this.AfficheReleveNotes.UseVisualStyleBackColor = true;
            // 
            // NotesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1307, 511);
            this.Controls.Add(this.AfficheReleveNotes);
            this.Controls.Add(this.CalculerMoyenne);
            this.Controls.Add(this.comboBoxMatNote);
            this.Controls.Add(this.comboBoxEtuNote);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxNote);
            this.Controls.Add(this.labelNom);
            this.Controls.Add(this.dataGridNote);
            this.Controls.Add(this.SupprimerNote);
            this.Controls.Add(this.ModifierNote);
            this.Controls.Add(this.AjoutNote);
            this.Controls.Add(this.labelGestionscolaire);
            this.Name = "NotesForm";
            this.Text = "Notes";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridNote)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label labelGestionscolaire;
        private System.Windows.Forms.TextBox textBoxNote;
        private System.Windows.Forms.Label labelNom;
        private System.Windows.Forms.DataGridView dataGridNote;
        private System.Windows.Forms.Button SupprimerNote;
        private System.Windows.Forms.Button ModifierNote;
        private System.Windows.Forms.Button AjoutNote;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBoxEtuNote;
        private System.Windows.Forms.ComboBox comboBoxMatNote;
        private System.Windows.Forms.Button CalculerMoyenne;
        private System.Windows.Forms.Button AfficheReleveNotes;
    }
}