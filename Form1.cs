using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Rufnamen
{
    public partial class btnFzgenerieren : Form
    {
        public btnFzgenerieren()
        {
            InitializeComponent();
        }

        

        private void Form1_Load(object sender, EventArgs e)
        {


        }

        private void lblFzgwahl_Click(object sender, EventArgs e)
        {
            
        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnFznamegen_Click(object sender, EventArgs e)
        {
            

         // Inpt des Fahrzeug-Namens
         foreach (string fz in fzliste.CheckedItems)
         {
            string s = "error";
            s.Replace(s, fz);


                // Funkrufnamen
                string fz2;
                fz2 = "error";
                if (fz == "LF 10")
                {
                    fz2 = "43";
                }
                if (fz == "LF 20")
                {
                    fz2 = "46";
                }
                if (fz == "LF 8/6")
                {
                    fz2 = "42";
                }
                if (fz == "LF 20/16")
                {
                    fz2 = "46";
                }
                if (fz == "10/6")
                {
                    fz2 = "43";
                }
                if (fz == "LF 16-TS")
                {
                    fz2 = "45";
                }
                if (fz == "HLF 20")
                {
                    fz2 = "46";
                }
                if (fz == "HLF 10")
                {
                    fz2 = "43";
                }
                if (fz == "TSF-W")
                {
                    fz2 = "48";
                }
                if (fz == "KLF")
                {
                    fz2 = "20";
                }
                if (fz == "MLF")
                {
                    fz2 = "40";
                }
                if (fz == "TLF 2000")
                {
                    fz2 = "21";
                }
                if (fz == "TLF 3000")
                {
                    fz2 = "21";
                }
                if (fz == "TLF 8/8")
                {
                    fz2 = "21";
                }
                if (fz == "TLF 8/18")
                {
                    fz2 = "21";
                }
                if (fz == "TLF 16/24-Tr")
                {
                    fz2 = "21";
                }
                if (fz == "TLF 16/25")
                {
                    fz2 = "22";
                }
                if (fz == "TLF 16/45")
                {
                    fz2 = "25";
                }
                if (fz == "TLF 20/40")
                {
                    fz2 = "25";
                }
                if (fz == "TLF 20/40-SL")
                {
                    fz2 = "24";
                }
                if (fz == "TLF 16")
                {
                    fz2 = "21";
                }
                if (fz == "ELW 1")
                {
                    fz2 = "11";
                }
                if (fz == "ELW 2")
                {
                    fz2 = "12";
                }
                if (fz == "DLK")
                {
                    fz2 = "30";
                }
                if (fz == "RW")
                {
                    fz2 = "52";
                }
                if (fz == "SW 1000")
                {
                    fz2 = "61";
                }
                if (fz == "SW 2000")
                {
                    fz2 = "62";
                }
                if (fz == "SW 2000-Tr")
                {
                    fz2 = "62";
                }
                if (fz == "SW-KatS")
                {
                    fz2 = "62";
                }
                if (fz == "GW-L2-Wasser")
                {
                    fz2 = "68";
                }
                if (fz == "GW-A")
                {
                    fz2 = "56";
                }
                if (fz == "GW-G")
                {
                    fz2 = "55";
                }
                if (fz == "GW-Mess")
                {
                    fz2 = "70";
                }
                if (fz == "GW-ÖL")
                {
                    fz2 = "59";
                }
                if (fz == "GW-H")
                {
                    fz2 = "59";
                }
                if (fz == "GW Dekon-P")
                {
                    fz2 = "74";
                }
                if (fz == "MTF")
                {
                    fz2 = "19";
                }
                if (fz == "WLF")
                {
                    fz2 = "65";
                }
                if (fz == "FwK")
                {
                    fz2 = "53";
                }
                

                // Input der "Stadtname" Textbox            
                string stadtname;            
                stadtname = inputStadtname.Text;
            

                // Fahrzeuge gleicher Typ           
                string fzzahl;            
                fzzahl = inputFzgleichertyp.Text;           
                int fzzahlint;
                fzzahlint = Int32.Parse(fzzahl);

            
                // Fahrzeuganzahl auf Funkrufnamen anwenden           
                fzzahlint++;            
                string fzzahlstring;            
                fzzahlstring = Convert.ToString(fzzahlint);

            
                // Ortsteil Nummer            
                string ot;          
                ot = inputOtziffer.Text;

            
                // Fertigen Namen zusammenfügen            
                string florian = "Florian";            
                string fertig = florian + (" ") + stadtname + ("-") + ot + ("-") + fz2 + ("-") + fzzahlstring;
                lblFznamefertig.Text = fertig;


                // Namen in Zwischenablage speichern
                Clipboard.SetText(fertig);
            }
            
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void fzgewählt_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void inputOtziffer_TextChanged(object sender, EventArgs e)
        {

        }

        private void btncopy_Click(object sender, EventArgs e)
        {
            
        }
    }
}
