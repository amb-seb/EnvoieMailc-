namespace EnvoiMail
{
    partial class Form4
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
            this.label1 = new System.Windows.Forms.Label();
            this.cbx_choixContact = new System.Windows.Forms.ComboBox();
            this.btn_valider = new System.Windows.Forms.Button();
            this.btn_quitter = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(173, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(211, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Choix contact";
            // 
            // cbx_choixContact
            // 
            this.cbx_choixContact.FormattingEnabled = true;
            this.cbx_choixContact.Location = new System.Drawing.Point(40, 99);
            this.cbx_choixContact.Name = "cbx_choixContact";
            this.cbx_choixContact.Size = new System.Drawing.Size(483, 28);
            this.cbx_choixContact.TabIndex = 1;
            // 
            // btn_valider
            // 
            this.btn_valider.Location = new System.Drawing.Point(355, 179);
            this.btn_valider.Name = "btn_valider";
            this.btn_valider.Size = new System.Drawing.Size(168, 58);
            this.btn_valider.TabIndex = 2;
            this.btn_valider.Text = "Valider";
            this.btn_valider.UseVisualStyleBackColor = true;
            this.btn_valider.Click += new System.EventHandler(this.btn_valider_Click);
            // 
            // btn_quitter
            // 
            this.btn_quitter.Location = new System.Drawing.Point(40, 179);
            this.btn_quitter.Name = "btn_quitter";
            this.btn_quitter.Size = new System.Drawing.Size(168, 58);
            this.btn_quitter.TabIndex = 3;
            this.btn_quitter.Text = "Quitter";
            this.btn_quitter.UseVisualStyleBackColor = true;
            this.btn_quitter.Click += new System.EventHandler(this.btn_quitter_Click);
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(581, 265);
            this.Controls.Add(this.btn_quitter);
            this.Controls.Add(this.btn_valider);
            this.Controls.Add(this.cbx_choixContact);
            this.Controls.Add(this.label1);
            this.Name = "Form4";
            this.Text = "Choix contact";
            this.Load += new System.EventHandler(this.Form4_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbx_choixContact;
        private System.Windows.Forms.Button btn_valider;
        private System.Windows.Forms.Button btn_quitter;
    }
}