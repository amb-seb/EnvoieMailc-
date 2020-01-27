namespace EnvoiMail
{
    partial class AjoutCopieCache
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
            this.btn_valider = new System.Windows.Forms.Button();
            this.btn_annuler = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cbx_choixContact = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // btn_valider
            // 
            this.btn_valider.Location = new System.Drawing.Point(467, 202);
            this.btn_valider.Name = "btn_valider";
            this.btn_valider.Size = new System.Drawing.Size(180, 71);
            this.btn_valider.TabIndex = 0;
            this.btn_valider.Text = "Valider";
            this.btn_valider.UseVisualStyleBackColor = true;
            this.btn_valider.Click += new System.EventHandler(this.btn_valider_Click);
            // 
            // btn_annuler
            // 
            this.btn_annuler.Location = new System.Drawing.Point(66, 202);
            this.btn_annuler.Name = "btn_annuler";
            this.btn_annuler.Size = new System.Drawing.Size(180, 71);
            this.btn_annuler.TabIndex = 1;
            this.btn_annuler.Text = "Quitter";
            this.btn_annuler.UseVisualStyleBackColor = true;
            this.btn_annuler.Click += new System.EventHandler(this.btn_annuler_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(267, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(187, 32);
            this.label1.TabIndex = 2;
            this.label1.Text = "Choix contact";
            // 
            // cbx_choixContact
            // 
            this.cbx_choixContact.FormattingEnabled = true;
            this.cbx_choixContact.Location = new System.Drawing.Point(66, 101);
            this.cbx_choixContact.Name = "cbx_choixContact";
            this.cbx_choixContact.Size = new System.Drawing.Size(581, 28);
            this.cbx_choixContact.TabIndex = 3;
            // 
            // AjoutCopieCache
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(724, 311);
            this.Controls.Add(this.cbx_choixContact);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_annuler);
            this.Controls.Add(this.btn_valider);
            this.Name = "AjoutCopieCache";
            this.Text = "AjoutCopieCache";
            this.Load += new System.EventHandler(this.AjoutCopieCache_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_valider;
        private System.Windows.Forms.Button btn_annuler;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbx_choixContact;
    }
}