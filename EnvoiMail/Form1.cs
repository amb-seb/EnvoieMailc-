using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Mail;
using System.Windows.Forms;
using System.IO;

namespace EnvoiMail
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //lire les contacts enregistre dans contact.txt

            if (File.Exists(@"..\contact.txt"))
            {
                string[] tab = File.ReadAllLines(@"..\contact.txt");
                foreach (string adrrMail in tab)
                {
                    string[] ligne = adrrMail.Split(Convert.ToChar(";"));
                    cbx_destinataire.Items.Add(ligne[0]);
                }
            }
            //Lire les contacts enregistre dans serveur smtp
            if (File.Exists(@"..\serveur.txt"))
            {
                //GLISSE dans la mémoire vive
                string[] tabSmtp = File.ReadAllLines(@"..\serveur.txt");
                foreach (string adrrSmtp in tabSmtp)
                {
                    cbx_serverSmtp.Items.Add(adrrSmtp);
                }
            }
        }

        private void btn_contact_Click(object sender, EventArgs e)
        {
            // redirige vers les contacts
            Contact monForm3 = new Contact();
            monForm3.Owner = this;
            monForm3.ShowDialog();

        }

        private void btn_ajoutDest_Click(object sender, EventArgs e)
        {
            //action boutton pour ajout des destinataire
            Form2 monForm2 = new Form2();
            monForm2.Owner = this;
            monForm2.ShowDialog();

        }

        private void btn_envoyer_Click(object sender, EventArgs e)
        {
          if(tbx_Expediteur.Text.Contains("@") && cbx_serverSmtp.Text.Length>9 && cbx_destinataire.Text
                .Contains("@"))
            { 
                //Paramétrage client smtp 
                SmtpClient client = new SmtpClient(cbx_serverSmtp.Text);
                MailMessage Message = new MailMessage();

                // Message  et objets 
                Message.Body = richTextBox1.Text;
                Message.Subject = tbx_objet.Text;

                //Expediteur
                MailAddress expediteur = new MailAddress(tbx_Expediteur.Text);
                Message.From = expediteur;
                //Destinataire
                MailAddress destinataire = new MailAddress(cbx_destinataire.Text);
                Message.To.Add(destinataire);

          
                //copie
                MailAddress copie = new MailAddress(tbx_copie.Text);
                Message.CC.Add(copie);

                //copie cachée
                MailAddress copiecache = new MailAddress(tbx_copieCache.Text);
                Message.Bcc.Add(copiecache);

                // piece jointe
                //test au cas ou j'envoie pas pièces jointes
                if (tbx_pieces.Text.Length > 20) { 
                Message.Attachments.Add(new Attachment(tbx_pieces.Text));
                }

                // Envoie du message
                try
                {
                    client.Send(Message);
                    MessageBox.Show("Le message a été envoyé");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Echec : " + ex.Message);
                }

            }
            else
            {
                MessageBox.Show("Les champs sont mal remplis");
            }
        }

        private void btn_quitter_Click(object sender, EventArgs e)
        {
            //Fermeture application
            this.Close();
        }

        private void btn_ajoutPieces_Click(object sender, EventArgs e)
        {
            // Ajoute la pièces jointes avec un autre form
            OpenFileDialog piecesJointe = new OpenFileDialog();
            if (piecesJointe.ShowDialog() == DialogResult.OK)
            {
                string path = piecesJointe.FileName.ToString();
                tbx_pieces.Text = path;
                tbx_pieces.Enabled = false;
                //ne peut envoyer q'une pièces jointes;
            }
        }

        private void btn_ajoutCopie_Click(object sender, EventArgs e)
        {
            //action boutton pour ajout  copie
            Form4 monForm4 = new Form4();
            monForm4.Owner = this;
            monForm4.ShowDialog();
        }

        private void btn_ajoutCopieCache_Click(object sender, EventArgs e)
        {
            //action boutton pour ajout  copie
            AjoutCopieCache monForm5 = new AjoutCopieCache();
            monForm5.Owner = this;
            monForm5.ShowDialog();
        }

        private void btn_ajtserver_Click(object sender, EventArgs e)
        {
            //action boutton pour ajout  copie
            AjoutServercs monForm6 = new AjoutServercs();
            monForm6.Owner = this;
            monForm6.ShowDialog();
        }

        private void cbx_serverSmtp_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Reste pour mettre ajour à chaque fois qu'on clique
            
            cbx_serverSmtp.ResetText();
            //re ajout des données
            if (File.Exists(@"..\serveur.txt"))
            {
                //GLISSE dans la mémoire vive
                string[] tabSmtp = File.ReadAllLines(@"..\serveur.txt");
                foreach (string adrrSmtp in tabSmtp)
                {
                    cbx_serverSmtp.Items.Add(adrrSmtp);
                }
            }
        }

        private void btn_annuler_Click(object sender, EventArgs e)
        {
            //remet tout à 0
            tbx_copie.Text = "";
            tbx_copieCache.Text = "";
            richTextBox1.Text = "";
            cbx_destinataire.Text = "";
            cbx_serverSmtp.Text = "";
            tbx_objet.Text= "";
            tbx_pieces.Text = "";
            tbx_Expediteur.Text = "";
        }
    }
}
