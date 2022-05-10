
namespace Devoir_atelier2
{
    partial class Authentification
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
            this.btnValiderconnec = new System.Windows.Forms.Button();
            this.lblConnec = new System.Windows.Forms.Label();
            this.lblPwr = new System.Windows.Forms.Label();
            this.lblLogin = new System.Windows.Forms.Label();
            this.txtPwr = new System.Windows.Forms.TextBox();
            this.txtLogin = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnValiderconnec
            // 
            this.btnValiderconnec.Location = new System.Drawing.Point(135, 237);
            this.btnValiderconnec.Name = "btnValiderconnec";
            this.btnValiderconnec.Size = new System.Drawing.Size(75, 23);
            this.btnValiderconnec.TabIndex = 11;
            this.btnValiderconnec.Text = "Valider";
            this.btnValiderconnec.UseVisualStyleBackColor = true;
            this.btnValiderconnec.Click += new System.EventHandler(this.btnValiderconnec_Click);
            // 
            // lblConnec
            // 
            this.lblConnec.AutoSize = true;
            this.lblConnec.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConnec.Location = new System.Drawing.Point(61, 28);
            this.lblConnec.Name = "lblConnec";
            this.lblConnec.Size = new System.Drawing.Size(137, 24);
            this.lblConnec.TabIndex = 10;
            this.lblConnec.Text = "Authentification";
            // 
            // lblPwr
            // 
            this.lblPwr.AutoSize = true;
            this.lblPwr.Location = new System.Drawing.Point(21, 156);
            this.lblPwr.Name = "lblPwr";
            this.lblPwr.Size = new System.Drawing.Size(93, 17);
            this.lblPwr.TabIndex = 9;
            this.lblPwr.Text = "Mot de passe";
            // 
            // lblLogin
            // 
            this.lblLogin.AutoSize = true;
            this.lblLogin.Location = new System.Drawing.Point(21, 77);
            this.lblLogin.Name = "lblLogin";
            this.lblLogin.Size = new System.Drawing.Size(43, 17);
            this.lblLogin.TabIndex = 8;
            this.lblLogin.Text = "Login";
            // 
            // txtPwr
            // 
            this.txtPwr.Location = new System.Drawing.Point(24, 185);
            this.txtPwr.Name = "txtPwr";
            this.txtPwr.Size = new System.Drawing.Size(186, 22);
            this.txtPwr.TabIndex = 7;
            // 
            // txtLogin
            // 
            this.txtLogin.Location = new System.Drawing.Point(24, 97);
            this.txtLogin.Name = "txtLogin";
            this.txtLogin.Size = new System.Drawing.Size(186, 22);
            this.txtLogin.TabIndex = 6;
            this.txtLogin.TextChanged += new System.EventHandler(this.txtLogin_TextChanged);
            // 
            // Authentification
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(260, 285);
            this.Controls.Add(this.btnValiderconnec);
            this.Controls.Add(this.lblConnec);
            this.Controls.Add(this.lblPwr);
            this.Controls.Add(this.lblLogin);
            this.Controls.Add(this.txtPwr);
            this.Controls.Add(this.txtLogin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Authentification";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Application de gestion";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnValiderconnec;
        private System.Windows.Forms.Label lblConnec;
        private System.Windows.Forms.Label lblPwr;
        private System.Windows.Forms.Label lblLogin;
        private System.Windows.Forms.TextBox txtPwr;
        private System.Windows.Forms.TextBox txtLogin;
    }
}

