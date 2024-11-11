namespace Csharp
{
    partial class Jeu
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
            this.btnPierre = new System.Windows.Forms.Button();
            this.btnFeuille = new System.Windows.Forms.Button();
            this.btnCiseau = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnPierre
            // 
            this.btnPierre.Location = new System.Drawing.Point(107, 336);
            this.btnPierre.Name = "btnPierre";
            this.btnPierre.Size = new System.Drawing.Size(100, 50);
            this.btnPierre.TabIndex = 1;
            this.btnPierre.Text = "button1";
            this.btnPierre.UseVisualStyleBackColor = true;
            // 
            // btnFeuille
            // 
            this.btnFeuille.Location = new System.Drawing.Point(351, 336);
            this.btnFeuille.Name = "btnFeuille";
            this.btnFeuille.Size = new System.Drawing.Size(100, 50);
            this.btnFeuille.TabIndex = 2;
            this.btnFeuille.Text = "button2";
            this.btnFeuille.UseVisualStyleBackColor = true;
            // 
            // btnCiseau
            // 
            this.btnCiseau.Location = new System.Drawing.Point(614, 336);
            this.btnCiseau.Name = "btnCiseau";
            this.btnCiseau.Size = new System.Drawing.Size(100, 50);
            this.btnCiseau.TabIndex = 3;
            this.btnCiseau.Text = "button3";
            this.btnCiseau.UseVisualStyleBackColor = true;
            // 
            // Jeu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(828, 444);
            this.Controls.Add(this.btnCiseau);
            this.Controls.Add(this.btnFeuille);
            this.Controls.Add(this.btnPierre);
            this.Name = "Jeu";
            this.Text = "Jeu";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnPierre;
        private System.Windows.Forms.Button btnFeuille;
        private System.Windows.Forms.Button btnCiseau;
    }
}

