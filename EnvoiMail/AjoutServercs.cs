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
    public partial class AjoutServercs : Form
    {
        public AjoutServercs()
        {
            InitializeComponent();
        }

        private void btn_enregistrer_Click(object sender, EventArgs e)
        {
            if (tbx_serveur.Text.Length > 3) { 
            string fichierserveur = @"..\serveur.txt";
            StreamWriter serveurSw;

            if (!File.Exists(fichierserveur))
            {
                serveurSw = new StreamWriter(fichierserveur);
                serveurSw.WriteLine(tbx_serveur.Text);
                serveurSw.Close();
                serveurSw.Dispose();
                MessageBox.Show("Serveur enregistré");
                this.Close();


                }
            else
            {
                serveurSw = File.AppendText(fichierserveur);
                serveurSw.WriteLine(tbx_serveur.Text);
                serveurSw.Close();
                serveurSw.Dispose();
                MessageBox.Show("Serveur enregistré");
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
