namespace EnvoiMail
{
    partial class Form2
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
            this.lbl_titrepage = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_annuler = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.tbx_nom = new System.Windows.Forms.TextBox();
            this.tbx_prenom = new System.Windows.Forms.TextBox();
            this.tbx_tel = new System.Windows.Forms.TextBox();
            this.tbx_mail = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lbl_titrepage
            // 
            this.lbl_titrepage.AutoSize = true;
            this.lbl_titrepage.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_titrepage.Location = new System.Drawing.Point(111, 45);
            this.lbl_titrepage.Name = "lbl_titrepage";
            this.lbl_titrepage.Size = new System.Drawing.Size(225, 40);
            this.lbl_titrepage.TabIndex = 0;
            this.lbl_titrepage.Text = "Ajout contact";
            this.lbl_titrepage.Click += new System.EventHandler(this.lbl_titrepage_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 114);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Mail :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 153);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nom :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 200);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Prénom :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 250);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "Téléphone :";
            // 
            // btn_annuler
            // 
            this.btn_annuler.BackColor = System.Drawing.SystemColors.MenuBar;
            this.btn_annuler.Location = new System.Drawing.Point(27, 334);
            this.btn_annuler.Name = "btn_annuler";
            this.btn_annuler.Size = new System.Drawing.Size(175, 57);
            this.btn_annuler.TabIndex = 5;
            this.btn_annuler.Text = "Annuler";
            this.btn_annuler.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.MenuBar;
            this.button2.Location = new System.Drawing.Point(251, 334);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(175, 57);
            this.button2.TabIndex = 6;
            this.button2.Text = "Enregistrer";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // tbx_nom
            // 
            this.tbx_nom.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbx_nom.Location = new System.Drawing.Point(208, 147);
            this.tbx_nom.Name = "tbx_nom";
            this.tbx_nom.Size = new System.Drawing.Size(218, 26);
            this.tbx_nom.TabIndex = 7;
            // 
            // tbx_prenom
            // 
            this.tbx_prenom.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbx_prenom.Location = new System.Drawing.Point(208, 197);
            this.tbx_prenom.Name = "tbx_prenom";
            this.tbx_prenom.Size = new System.Drawing.Size(218, 26);
            this.tbx_prenom.TabIndex = 8;
            // 
            // tbx_tel
            // 
            this.tbx_tel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbx_tel.Location = new System.Drawing.Point(208, 247);
            this.tbx_tel.Name = "tbx_tel";
            this.tbx_tel.Size = new System.Drawing.Size(218, 26);
            this.tbx_tel.TabIndex = 9;
            // 
            // tbx_mail
            // 
            this.tbx_mail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbx_mail.Location = new System.Drawing.Point(208, 111);
            this.tbx_mail.Name = "tbx_mail";
            this.tbx_mail.Size = new System.Drawing.Size(218, 26);
            this.tbx_mail.TabIndex = 10;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(433, 450);
            this.Controls.Add(this.tbx_mail);
            this.Controls.Add(this.tbx_tel);
            this.Controls.Add(this.tbx_prenom);
            this.Controls.Add(this.tbx_nom);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btn_annuler);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbl_titrepage);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_titrepage;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_annuler;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox tbx_nom;
        private System.Windows.Forms.TextBox tbx_prenom;
        private System.Windows.Forms.TextBox tbx_tel;
        private System.Windows.Forms.TextBox tbx_mail;
    }
}