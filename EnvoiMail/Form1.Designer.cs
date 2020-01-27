namespace EnvoiMail
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
            this.lbl_TitrePage = new System.Windows.Forms.Label();
            this.lbl_Destinataire = new System.Windows.Forms.Label();
            this.lbl_copie = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbl_expediteurs = new System.Windows.Forms.Label();
            this.lbl_Objet = new System.Windows.Forms.Label();
            this.lbl_PiecesJointes = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.lbl_nbcaracSaisie = new System.Windows.Forms.Label();
            this.btn_contact = new System.Windows.Forms.Button();
            this.btn_envoyer = new System.Windows.Forms.Button();
            this.btn_annuler = new System.Windows.Forms.Button();
            this.btn_quitter = new System.Windows.Forms.Button();
            this.tbx_copie = new System.Windows.Forms.TextBox();
            this.tbx_copieCache = new System.Windows.Forms.TextBox();
            this.tbx_Expediteur = new System.Windows.Forms.TextBox();
            this.tbx_pieces = new System.Windows.Forms.TextBox();
            this.tbx_objet = new System.Windows.Forms.TextBox();
            this.btn_ajoutDest = new System.Windows.Forms.Button();
            this.btn_ajoutPieces = new System.Windows.Forms.Button();
            this.btn_ajoutCopie = new System.Windows.Forms.Button();
            this.btn_ajoutCopieCache = new System.Windows.Forms.Button();
            this.cbx_destinataire = new System.Windows.Forms.ComboBox();
            this.cbx_serverSmtp = new System.Windows.Forms.ComboBox();
            this.lbl_serverSmtp = new System.Windows.Forms.Label();
            this.btn_ajtserver = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_TitrePage
            // 
            this.lbl_TitrePage.AutoSize = true;
            this.lbl_TitrePage.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_TitrePage.Location = new System.Drawing.Point(249, 9);
            this.lbl_TitrePage.Name = "lbl_TitrePage";
            this.lbl_TitrePage.Size = new System.Drawing.Size(257, 55);
            this.lbl_TitrePage.TabIndex = 0;
            this.lbl_TitrePage.Text = "Envoi  mail";
            // 
            // lbl_Destinataire
            // 
            this.lbl_Destinataire.AutoSize = true;
            this.lbl_Destinataire.Location = new System.Drawing.Point(50, 91);
            this.lbl_Destinataire.Name = "lbl_Destinataire";
            this.lbl_Destinataire.Size = new System.Drawing.Size(103, 20);
            this.lbl_Destinataire.TabIndex = 1;
            this.lbl_Destinataire.Text = "Destinataire :";
            // 
            // lbl_copie
            // 
            this.lbl_copie.AutoSize = true;
            this.lbl_copie.Location = new System.Drawing.Point(50, 136);
            this.lbl_copie.Name = "lbl_copie";
            this.lbl_copie.Size = new System.Drawing.Size(58, 20);
            this.lbl_copie.TabIndex = 2;
            this.lbl_copie.Text = "Copie :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(50, 181);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Copie caché :";
            // 
            // lbl_expediteurs
            // 
            this.lbl_expediteurs.AutoSize = true;
            this.lbl_expediteurs.Location = new System.Drawing.Point(50, 223);
            this.lbl_expediteurs.Name = "lbl_expediteurs";
            this.lbl_expediteurs.Size = new System.Drawing.Size(101, 20);
            this.lbl_expediteurs.TabIndex = 4;
            this.lbl_expediteurs.Text = "Expéditeurs :";
            // 
            // lbl_Objet
            // 
            this.lbl_Objet.AutoSize = true;
            this.lbl_Objet.Location = new System.Drawing.Point(50, 265);
            this.lbl_Objet.Name = "lbl_Objet";
            this.lbl_Objet.Size = new System.Drawing.Size(59, 20);
            this.lbl_Objet.TabIndex = 5;
            this.lbl_Objet.Text = "Objet : ";
            // 
            // lbl_PiecesJointes
            // 
            this.lbl_PiecesJointes.AutoSize = true;
            this.lbl_PiecesJointes.Location = new System.Drawing.Point(50, 311);
            this.lbl_PiecesJointes.Name = "lbl_PiecesJointes";
            this.lbl_PiecesJointes.Size = new System.Drawing.Size(106, 20);
            this.lbl_PiecesJointes.TabIndex = 6;
            this.lbl_PiecesJointes.Text = "Pièces jointes";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(54, 433);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(636, 230);
            this.richTextBox1.TabIndex = 7;
            this.richTextBox1.Text = "";
            // 
            // lbl_nbcaracSaisie
            // 
            this.lbl_nbcaracSaisie.AutoSize = true;
            this.lbl_nbcaracSaisie.Location = new System.Drawing.Point(50, 410);
            this.lbl_nbcaracSaisie.Name = "lbl_nbcaracSaisie";
            this.lbl_nbcaracSaisie.Size = new System.Drawing.Size(82, 20);
            this.lbl_nbcaracSaisie.TabIndex = 8;
            this.lbl_nbcaracSaisie.Text = "Message :";
            // 
            // btn_contact
            // 
            this.btn_contact.Location = new System.Drawing.Point(219, 669);
            this.btn_contact.Name = "btn_contact";
            this.btn_contact.Size = new System.Drawing.Size(138, 51);
            this.btn_contact.TabIndex = 9;
            this.btn_contact.Text = "Contacts";
            this.btn_contact.UseVisualStyleBackColor = true;
            this.btn_contact.Click += new System.EventHandler(this.btn_contact_Click);
            // 
            // btn_envoyer
            // 
            this.btn_envoyer.Location = new System.Drawing.Point(54, 669);
            this.btn_envoyer.Name = "btn_envoyer";
            this.btn_envoyer.Size = new System.Drawing.Size(138, 51);
            this.btn_envoyer.TabIndex = 10;
            this.btn_envoyer.Text = "Envoyer";
            this.btn_envoyer.UseVisualStyleBackColor = true;
            this.btn_envoyer.Click += new System.EventHandler(this.btn_envoyer_Click);
            // 
            // btn_annuler
            // 
            this.btn_annuler.Location = new System.Drawing.Point(387, 669);
            this.btn_annuler.Name = "btn_annuler";
            this.btn_annuler.Size = new System.Drawing.Size(138, 51);
            this.btn_annuler.TabIndex = 11;
            this.btn_annuler.Text = "Annuler";
            this.btn_annuler.UseVisualStyleBackColor = true;
            this.btn_annuler.Click += new System.EventHandler(this.btn_annuler_Click);
            // 
            // btn_quitter
            // 
            this.btn_quitter.Location = new System.Drawing.Point(552, 669);
            this.btn_quitter.Name = "btn_quitter";
            this.btn_quitter.Size = new System.Drawing.Size(138, 51);
            this.btn_quitter.TabIndex = 12;
            this.btn_quitter.Text = "Quitter";
            this.btn_quitter.UseVisualStyleBackColor = true;
            this.btn_quitter.Click += new System.EventHandler(this.btn_quitter_Click);
            // 
            // tbx_copie
            // 
            this.tbx_copie.Location = new System.Drawing.Point(259, 133);
            this.tbx_copie.Name = "tbx_copie";
            this.tbx_copie.Size = new System.Drawing.Size(245, 26);
            this.tbx_copie.TabIndex = 14;
            // 
            // tbx_copieCache
            // 
            this.tbx_copieCache.Location = new System.Drawing.Point(259, 178);
            this.tbx_copieCache.Name = "tbx_copieCache";
            this.tbx_copieCache.Size = new System.Drawing.Size(245, 26);
            this.tbx_copieCache.TabIndex = 15;
            // 
            // tbx_Expediteur
            // 
            this.tbx_Expediteur.Location = new System.Drawing.Point(259, 217);
            this.tbx_Expediteur.Name = "tbx_Expediteur";
            this.tbx_Expediteur.Size = new System.Drawing.Size(245, 26);
            this.tbx_Expediteur.TabIndex = 16;
            // 
            // tbx_pieces
            // 
            this.tbx_pieces.Location = new System.Drawing.Point(259, 308);
            this.tbx_pieces.Name = "tbx_pieces";
            this.tbx_pieces.Size = new System.Drawing.Size(245, 26);
            this.tbx_pieces.TabIndex = 17;
            // 
            // tbx_objet
            // 
            this.tbx_objet.Location = new System.Drawing.Point(259, 265);
            this.tbx_objet.Name = "tbx_objet";
            this.tbx_objet.Size = new System.Drawing.Size(245, 26);
            this.tbx_objet.TabIndex = 18;
            // 
            // btn_ajoutDest
            // 
            this.btn_ajoutDest.Location = new System.Drawing.Point(552, 82);
            this.btn_ajoutDest.Name = "btn_ajoutDest";
            this.btn_ajoutDest.Size = new System.Drawing.Size(138, 39);
            this.btn_ajoutDest.TabIndex = 19;
            this.btn_ajoutDest.Text = "Ajouter";
            this.btn_ajoutDest.UseVisualStyleBackColor = true;
            this.btn_ajoutDest.Click += new System.EventHandler(this.btn_ajoutDest_Click);
            // 
            // btn_ajoutPieces
            // 
            this.btn_ajoutPieces.Location = new System.Drawing.Point(552, 304);
            this.btn_ajoutPieces.Name = "btn_ajoutPieces";
            this.btn_ajoutPieces.Size = new System.Drawing.Size(138, 35);
            this.btn_ajoutPieces.TabIndex = 20;
            this.btn_ajoutPieces.Text = "Ajouter";
            this.btn_ajoutPieces.UseVisualStyleBackColor = true;
            this.btn_ajoutPieces.Click += new System.EventHandler(this.btn_ajoutPieces_Click);
            // 
            // btn_ajoutCopie
            // 
            this.btn_ajoutCopie.Location = new System.Drawing.Point(552, 128);
            this.btn_ajoutCopie.Name = "btn_ajoutCopie";
            this.btn_ajoutCopie.Size = new System.Drawing.Size(138, 36);
            this.btn_ajoutCopie.TabIndex = 21;
            this.btn_ajoutCopie.Text = "Ajouter";
            this.btn_ajoutCopie.UseVisualStyleBackColor = true;
            this.btn_ajoutCopie.Click += new System.EventHandler(this.btn_ajoutCopie_Click);
            // 
            // btn_ajoutCopieCache
            // 
            this.btn_ajoutCopieCache.Location = new System.Drawing.Point(552, 174);
            this.btn_ajoutCopieCache.Name = "btn_ajoutCopieCache";
            this.btn_ajoutCopieCache.Size = new System.Drawing.Size(138, 35);
            this.btn_ajoutCopieCache.TabIndex = 22;
            this.btn_ajoutCopieCache.Text = "Ajouter";
            this.btn_ajoutCopieCache.UseVisualStyleBackColor = true;
            this.btn_ajoutCopieCache.Click += new System.EventHandler(this.btn_ajoutCopieCache_Click);
            // 
            // cbx_destinataire
            // 
            this.cbx_destinataire.FormattingEnabled = true;
            this.cbx_destinataire.Location = new System.Drawing.Point(259, 88);
            this.cbx_destinataire.Name = "cbx_destinataire";
            this.cbx_destinataire.Size = new System.Drawing.Size(245, 28);
            this.cbx_destinataire.TabIndex = 23;
            // 
            // cbx_serverSmtp
            // 
            this.cbx_serverSmtp.FormattingEnabled = true;
            this.cbx_serverSmtp.Location = new System.Drawing.Point(259, 366);
            this.cbx_serverSmtp.Name = "cbx_serverSmtp";
            this.cbx_serverSmtp.Size = new System.Drawing.Size(247, 28);
            this.cbx_serverSmtp.TabIndex = 24;
            this.cbx_serverSmtp.SelectedIndexChanged += new System.EventHandler(this.cbx_serverSmtp_SelectedIndexChanged);
            // 
            // lbl_serverSmtp
            // 
            this.lbl_serverSmtp.AutoSize = true;
            this.lbl_serverSmtp.Location = new System.Drawing.Point(50, 374);
            this.lbl_serverSmtp.Name = "lbl_serverSmtp";
            this.lbl_serverSmtp.Size = new System.Drawing.Size(111, 20);
            this.lbl_serverSmtp.TabIndex = 25;
            this.lbl_serverSmtp.Text = "Serveur SMTP";
            // 
            // btn_ajtserver
            // 
            this.btn_ajtserver.Location = new System.Drawing.Point(552, 359);
            this.btn_ajtserver.Name = "btn_ajtserver";
            this.btn_ajtserver.Size = new System.Drawing.Size(138, 35);
            this.btn_ajtserver.TabIndex = 26;
            this.btn_ajtserver.Text = "Ajouter";
            this.btn_ajtserver.UseVisualStyleBackColor = true;
            this.btn_ajtserver.Click += new System.EventHandler(this.btn_ajtserver_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(749, 781);
            this.Controls.Add(this.btn_ajtserver);
            this.Controls.Add(this.lbl_serverSmtp);
            this.Controls.Add(this.cbx_serverSmtp);
            this.Controls.Add(this.cbx_destinataire);
            this.Controls.Add(this.btn_ajoutCopieCache);
            this.Controls.Add(this.btn_ajoutCopie);
            this.Controls.Add(this.btn_ajoutPieces);
            this.Controls.Add(this.btn_ajoutDest);
            this.Controls.Add(this.tbx_objet);
            this.Controls.Add(this.tbx_pieces);
            this.Controls.Add(this.tbx_Expediteur);
            this.Controls.Add(this.tbx_copieCache);
            this.Controls.Add(this.tbx_copie);
            this.Controls.Add(this.btn_quitter);
            this.Controls.Add(this.btn_annuler);
            this.Controls.Add(this.btn_envoyer);
            this.Controls.Add(this.btn_contact);
            this.Controls.Add(this.lbl_nbcaracSaisie);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.lbl_PiecesJointes);
            this.Controls.Add(this.lbl_Objet);
            this.Controls.Add(this.lbl_expediteurs);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lbl_copie);
            this.Controls.Add(this.lbl_Destinataire);
            this.Controls.Add(this.lbl_TitrePage);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_TitrePage;
        private System.Windows.Forms.Label lbl_Destinataire;
        private System.Windows.Forms.Label lbl_copie;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbl_expediteurs;
        private System.Windows.Forms.Label lbl_Objet;
        private System.Windows.Forms.Label lbl_PiecesJointes;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Label lbl_nbcaracSaisie;
        private System.Windows.Forms.Button btn_contact;
        private System.Windows.Forms.Button btn_envoyer;
        private System.Windows.Forms.Button btn_annuler;
        private System.Windows.Forms.Button btn_quitter;
        private System.Windows.Forms.TextBox tbx_copie;
        private System.Windows.Forms.TextBox tbx_copieCache;
        private System.Windows.Forms.TextBox tbx_Expediteur;
        private System.Windows.Forms.TextBox tbx_pieces;
        private System.Windows.Forms.TextBox tbx_objet;
        private System.Windows.Forms.Button btn_ajoutDest;
        private System.Windows.Forms.Button btn_ajoutPieces;
        private System.Windows.Forms.Button btn_ajoutCopie;
        private System.Windows.Forms.Button btn_ajoutCopieCache;
        private System.Windows.Forms.ComboBox cbx_destinataire;
        private System.Windows.Forms.ComboBox cbx_serverSmtp;
        private System.Windows.Forms.Label lbl_serverSmtp;
        private System.Windows.Forms.Button btn_ajtserver;
    }
}

