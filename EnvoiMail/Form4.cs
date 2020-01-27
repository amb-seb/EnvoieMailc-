using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace EnvoiMail
{
    // Pour copie non caché
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }
       
        private void Form4_Load(object sender, EventArgs e)
        {
            if (File.Exists(@"..\contact.txt"))
            {
                //lie tous les noms de contacts presént dans le fichier contact
                string[] tab = File.ReadAllLines(@"..\contact.txt");
                foreach (string adrrMail in tab)
                {
                    string[] ligne = adrrMail.Split(Convert.ToChar(";"));
                    cbx_choixContact .Items.Add(ligne[0]);
                }
            }
        }

        private void btn_quitter_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void btn_valider_Click(object sender, EventArgs e)
        {
            //transfert entre formulaire
            (this.Owner as Form1).Controls["tbx_copie"].Text = cbx_choixContact.Text;
            this.Close();
        }
    }
}
