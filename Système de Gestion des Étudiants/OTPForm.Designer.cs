namespace Système_de_Gestion_des_Étudiants
{
    partial class OTPForm
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
            this.textBoxNomCode = new System.Windows.Forms.TextBox();
            this.labelNom = new System.Windows.Forms.Label();
            this.ModifierClasse = new System.Windows.Forms.Button();
            this.AjoutClasse = new System.Windows.Forms.Button();
            this.labelGestionscolaire = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBoxNomCode
            // 
            this.textBoxNomCode.Location = new System.Drawing.Point(398, 214);
            this.textBoxNomCode.Multiline = true;
            this.textBoxNomCode.Name = "textBoxNomCode";
            this.textBoxNomCode.Size = new System.Drawing.Size(211, 35);
            this.textBoxNomCode.TabIndex = 25;
            // 
            // labelNom
            // 
            this.labelNom.AutoSize = true;
            this.labelNom.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNom.Location = new System.Drawing.Point(280, 223);
            this.labelNom.Name = "labelNom";
            this.labelNom.Size = new System.Drawing.Size(76, 29);
            this.labelNom.TabIndex = 24;
            this.labelNom.Text = "Code";
            // 
            // ModifierClasse
            // 
            this.ModifierClasse.Location = new System.Drawing.Point(480, 320);
            this.ModifierClasse.Name = "ModifierClasse";
            this.ModifierClasse.Size = new System.Drawing.Size(144, 46);
            this.ModifierClasse.TabIndex = 23;
            this.ModifierClasse.Text = "Annuler";
            this.ModifierClasse.UseVisualStyleBackColor = true;
            // 
            // AjoutClasse
            // 
            this.AjoutClasse.Location = new System.Drawing.Point(285, 320);
            this.AjoutClasse.Name = "AjoutClasse";
            this.AjoutClasse.Size = new System.Drawing.Size(144, 46);
            this.AjoutClasse.TabIndex = 22;
            this.AjoutClasse.Text = "Valider";
            this.AjoutClasse.UseVisualStyleBackColor = true;
            this.AjoutClasse.Click += new System.EventHandler(this.AjoutClasse_Click);
            // 
            // labelGestionscolaire
            // 
            this.labelGestionscolaire.AutoSize = true;
            this.labelGestionscolaire.Font = new System.Drawing.Font("Times New Roman", 17F, System.Drawing.FontStyle.Bold);
            this.labelGestionscolaire.Location = new System.Drawing.Point(294, 43);
            this.labelGestionscolaire.Name = "labelGestionscolaire";
            this.labelGestionscolaire.Size = new System.Drawing.Size(326, 38);
            this.labelGestionscolaire.TabIndex = 21;
            this.labelGestionscolaire.Text = "Validation Utilisateur";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(280, 162);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(346, 25);
            this.label4.TabIndex = 26;
            this.label4.Text = "Veuillez mettre le code recu par sms !";
            // 
            // OTPForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(945, 497);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxNomCode);
            this.Controls.Add(this.labelNom);
            this.Controls.Add(this.ModifierClasse);
            this.Controls.Add(this.AjoutClasse);
            this.Controls.Add(this.labelGestionscolaire);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "OTPForm";
            this.Text = "OTPForm";
            this.Load += new System.EventHandler(this.OTPForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxNomCode;
        private System.Windows.Forms.Label labelNom;
        private System.Windows.Forms.Button ModifierClasse;
        private System.Windows.Forms.Button AjoutClasse;
        private System.Windows.Forms.Label labelGestionscolaire;
        private System.Windows.Forms.Label label4;
    }
}