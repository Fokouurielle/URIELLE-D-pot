namespace algorithme_huffman
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
            this.buttonbroyer = new System.Windows.Forms.Button();
            this.buttoncheminfichier = new System.Windows.Forms.Button();
            this.textBoxcheminfichier = new System.Windows.Forms.TextBox();
            this.labelcheminfichier = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonbroyer
            // 
            this.buttonbroyer.AutoSize = true;
            this.buttonbroyer.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonbroyer.Location = new System.Drawing.Point(112, 129);
            this.buttonbroyer.Name = "buttonbroyer";
            this.buttonbroyer.Size = new System.Drawing.Size(139, 23);
            this.buttonbroyer.TabIndex = 12;
            this.buttonbroyer.Text = "COMPRESSER";
            this.buttonbroyer.UseVisualStyleBackColor = true;
            this.buttonbroyer.Click += new System.EventHandler(this.buttonbroyer_Click);
            // 
            // buttoncheminfichier
            // 
            this.buttoncheminfichier.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttoncheminfichier.Location = new System.Drawing.Point(578, 46);
            this.buttoncheminfichier.Name = "buttoncheminfichier";
            this.buttoncheminfichier.Size = new System.Drawing.Size(36, 23);
            this.buttoncheminfichier.TabIndex = 11;
            this.buttoncheminfichier.Text = "...";
            this.buttoncheminfichier.UseVisualStyleBackColor = true;
            this.buttoncheminfichier.Click += new System.EventHandler(this.buttoncheminfichier_Click);
            // 
            // textBoxcheminfichier
            // 
            this.textBoxcheminfichier.Location = new System.Drawing.Point(108, 49);
            this.textBoxcheminfichier.Name = "textBoxcheminfichier";
            this.textBoxcheminfichier.Size = new System.Drawing.Size(460, 20);
            this.textBoxcheminfichier.TabIndex = 10;
            this.textBoxcheminfichier.Text = "c:\\";
            // 
            // labelcheminfichier
            // 
            this.labelcheminfichier.AutoSize = true;
            this.labelcheminfichier.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelcheminfichier.Location = new System.Drawing.Point(12, 52);
            this.labelcheminfichier.Name = "labelcheminfichier";
            this.labelcheminfichier.Size = new System.Drawing.Size(90, 13);
            this.labelcheminfichier.TabIndex = 9;
            this.labelcheminfichier.Text = "chemin fichier:";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // button1
            // 
            this.button1.AutoSize = true;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(434, 129);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(138, 23);
            this.button1.TabIndex = 13;
            this.button1.Text = "DECOMPRESSER";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(676, 181);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.buttonbroyer);
            this.Controls.Add(this.buttoncheminfichier);
            this.Controls.Add(this.textBoxcheminfichier);
            this.Controls.Add(this.labelcheminfichier);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonbroyer;
        private System.Windows.Forms.Button buttoncheminfichier;
        private System.Windows.Forms.TextBox textBoxcheminfichier;
        private System.Windows.Forms.Label labelcheminfichier;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button button1;
    }
}

