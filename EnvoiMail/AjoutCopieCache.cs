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
    public partial class AjoutCopieCache : Form
    {
        public AjoutCopieCache()
        {
            InitializeComponent();
        }

        private void AjoutCopieCache_Load(object sender, EventArgs e)
        {
            if (File.Exists(@"..\contact.txt"))
            {
                //lie tous les noms de contacts presént dans le fichier contact
                string[] tab = File.ReadAllLines(@"..\contact.txt");
                foreach (string adrrMail in tab)
                {
                    string[] ligne = adrrMail.Split(Convert.ToChar(";"));
                    cbx_choixContact.Items.Add(ligne[0]);
                }
            }

        }

        private void btn_annuler_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_valider_Click(object sender, EventArgs e)
        {
            //transfert entre formulaire
            (this.Owner as Form1).Controls["tbx_copieCache"].Text = cbx_choixContact.Text;
            this.Close();
        }
    }
}
