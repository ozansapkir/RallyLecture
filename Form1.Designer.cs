namespace Alimentation
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblRepertoire = new System.Windows.Forms.Label();
            this.lblFichierCSV = new System.Windows.Forms.Label();
            this.lblScolaire = new System.Windows.Forms.Label();
            this.lblNiveau = new System.Windows.Forms.Label();
            this.lblMDP = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.cbListNiveau = new System.Windows.Forms.ComboBox();
            this.clb1 = new System.Windows.Forms.CheckedListBox();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.checkBox1 = new System.Windows.Forms.RadioButton();
            this.checkBox2 = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // lblRepertoire
            // 
            this.lblRepertoire.AutoSize = true;
            this.lblRepertoire.Location = new System.Drawing.Point(12, 23);
            this.lblRepertoire.Name = "lblRepertoire";
            this.lblRepertoire.Size = new System.Drawing.Size(118, 13);
            this.lblRepertoire.TabIndex = 0;
            this.lblRepertoire.Text = "Repertoire des fichiers :";
            // 
            // lblFichierCSV
            // 
            this.lblFichierCSV.AutoSize = true;
            this.lblFichierCSV.Location = new System.Drawing.Point(12, 56);
            this.lblFichierCSV.Name = "lblFichierCSV";
            this.lblFichierCSV.Size = new System.Drawing.Size(111, 13);
            this.lblFichierCSV.TabIndex = 1;
            this.lblFichierCSV.Text = "Fichier csc a integrer :";
            // 
            // lblScolaire
            // 
            this.lblScolaire.AutoSize = true;
            this.lblScolaire.Location = new System.Drawing.Point(12, 142);
            this.lblScolaire.Name = "lblScolaire";
            this.lblScolaire.Size = new System.Drawing.Size(83, 13);
            this.lblScolaire.TabIndex = 2;
            this.lblScolaire.Text = "Annee scolaire :";
            // 
            // lblNiveau
            // 
            this.lblNiveau.AutoSize = true;
            this.lblNiveau.Location = new System.Drawing.Point(12, 173);
            this.lblNiveau.Name = "lblNiveau";
            this.lblNiveau.Size = new System.Drawing.Size(47, 13);
            this.lblNiveau.TabIndex = 3;
            this.lblNiveau.Text = "Niveau :";
            // 
            // lblMDP
            // 
            this.lblMDP.AutoSize = true;
            this.lblMDP.Location = new System.Drawing.Point(12, 210);
            this.lblMDP.Name = "lblMDP";
            this.lblMDP.Size = new System.Drawing.Size(77, 13);
            this.lblMDP.TabIndex = 4;
            this.lblMDP.Text = "Mot de passe :";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(181, 15);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 5;

            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(202, 139);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 7;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(161, 232);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(170, 23);
            this.button1.TabIndex = 10;
            this.button1.Text = "Lancer l\'integration";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // cbListNiveau
            // 
            this.cbListNiveau.FormattingEnabled = true;
            this.cbListNiveau.Location = new System.Drawing.Point(181, 165);
            this.cbListNiveau.Name = "cbListNiveau";
            this.cbListNiveau.Size = new System.Drawing.Size(121, 21);
            this.cbListNiveau.TabIndex = 11;
            this.cbListNiveau.Text = "Choisir le niveau";
            this.cbListNiveau.Click += new System.EventHandler(this.cbListNiveau_Click);
            // 
            // clb1
            // 
            this.clb1.FormattingEnabled = true;
            this.clb1.Location = new System.Drawing.Point(161, 39);
            this.clb1.Name = "clb1";
            this.clb1.Size = new System.Drawing.Size(253, 94);
            this.clb1.TabIndex = 12;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(161, 206);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(66, 17);
            this.checkBox1.TabIndex = 13;
            this.checkBox1.TabStop = true;
            this.checkBox1.Text = "Aleatoire";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(236, 206);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(66, 17);
            this.checkBox2.TabIndex = 14;
            this.checkBox2.TabStop = true;
            this.checkBox2.Text = "Construit";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(498, 262);
            this.Controls.Add(this.checkBox2);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.clb1);
            this.Controls.Add(this.cbListNiveau);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.lblMDP);
            this.Controls.Add(this.lblNiveau);
            this.Controls.Add(this.lblScolaire);
            this.Controls.Add(this.lblFichierCSV);
            this.Controls.Add(this.lblRepertoire);
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblRepertoire;
        private System.Windows.Forms.Label lblFichierCSV;
        private System.Windows.Forms.Label lblScolaire;
        private System.Windows.Forms.Label lblNiveau;
        private System.Windows.Forms.Label lblMDP;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox cbListNiveau;
        private System.Windows.Forms.CheckedListBox clb1;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.RadioButton checkBox1;
        private System.Windows.Forms.RadioButton checkBox2;
    }
}

