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
    public partial class Contact : Form
    {
        public Contact()
        {
            InitializeComponent();
        }
        
        int position = 0;
        //Mise de tous les contacts dans la mémoire
        string[] table = File.ReadAllLines(@"..\contact.txt");
        private void Contact_Load(object sender, EventArgs e)
        {
            if (File.Exists(@"..\contact.txt"))
            {
             
                // Position = ligne dans lequel est le contact
                

                if (position == 0)
                {
                    btn_precedent.Enabled = false;
                }
                if (position == table.GetLength(0) - 1)
                {
                    btn_suivant.Enabled = false;                
                }
                string[] ligne = table[position].Split(Convert.ToChar(";"));
                lbl_tel.Text= ligne[3];
                lbl_nom.Text = ligne[1];
                lbl_prenom.Text = ligne[2];
                lbl_mail.Text = ligne[0];

            }


        }



        private void btn_precedent_Click(object sender, EventArgs e)
        {
            if (position != 0)
            {
                position = position - 1;
                string[] ligne = table[position].Split(Convert.ToChar(";"));
                lbl_tel.Text = ligne[3];
                lbl_nom.Text = ligne[1];
                lbl_prenom.Text = ligne[2];
                lbl_mail.Text = ligne[0];
            }
            if (position == 0)
            {
                btn_precedent.Enabled = false;
            }
        }

        private void btn_suivant_Click(object sender, EventArgs e)
        {
            // verifie qu'on ne sorte pas du tableaux
            if (position < table.GetLength(0)-1)
            { 
                position = position + 1;
                string[] ligne = table[position].Split(Convert.ToChar(";"));
                lbl_tel.Text = ligne[3];
                lbl_nom.Text = ligne[1];
                lbl_prenom.Text = ligne[2];
                lbl_mail.Text = ligne[0];
            }
            else 
            {
                btn_suivant.Enabled = false;
            }
            //active et desactve button pour ne pas sortir du tableaux
            if (position > 0)
            {
                btn_precedent.Enabled = true;
            }
            if(position==0)
            {
                btn_precedent.Enabled = false;
            }
        }

        private void btn_ferme_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
