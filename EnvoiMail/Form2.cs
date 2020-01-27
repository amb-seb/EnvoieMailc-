using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace EnvoiMail
{


    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void lbl_titrepage_Click(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            

        }

        private void button2_Click(object sender, EventArgs e)
        {
            //verification information et ajout contact 
            if(tbx_mail.Text.Length > 8 && tbx_nom.Text.Length > 2
                && tbx_prenom.Text.Length>2 && tbx_tel.Text.Length == 10)
            {
                string fichierContact = @"..\contact.txt";
                string ligne = tbx_mail.Text + ";" + tbx_nom.Text + ";" + tbx_prenom.Text + ";" + tbx_tel.Text;
                StreamWriter contactSw;
                // Si mon fichier existe si il n'existe pas 
                if (!File.Exists(fichierContact))
                {
                    contactSw =new StreamWriter(fichierContact);
                    contactSw.WriteLine(ligne);
                    contactSw.Close();
                    contactSw.Dispose();
                    MessageBox.Show("Contact enregistré");
                    this.Close();


                }
                else
                {
                    contactSw = File.AppendText(fichierContact);
                    contactSw.WriteLine(ligne);
                    contactSw.Close();
                    contactSw.Dispose();
                    MessageBox.Show("Contact enregistré");
                    this.Close();
                }
            }
            else
            {
                MessageBox.Show("Erreur saisie");
            }
            
        }
    }

  
    
}
