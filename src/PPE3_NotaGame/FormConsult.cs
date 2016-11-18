using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PPE3_NotaGame
{
    public partial class FormConsult : Form
    {
        private String triEffectue = "Aucun tri";

        public FormConsult()
        {
            InitializeComponent();
            fillCbGenre();
            fillCbSupport();
            cbGenre.SelectedIndex = 0;
            cbSupport.SelectedIndex = 0;
            callAucunTri();
        }

        private void fillCbGenre ()
        {
            Controleur.Vmodele.charger_donnees("genres");
            foreach (DataRow dr in Controleur.Vmodele.DT[8].Rows)
            {
                cbGenre.Items.Add(dr["libelle"].ToString());
            }
        }

        private void fillCbSupport ()
        {
            Controleur.Vmodele.charger_donnees("support");
            foreach (DataRow dr in Controleur.Vmodele.DT[3].Rows)
            {
                cbSupport.Items.Add(dr["nomS"].ToString());
            }
        }

        private void cbGenre_SelectedIndexChanged(object sender, EventArgs e)
        {
            tbConsult.Text = "";
            if (cbGenre.Text != "Aucun tri")
            {
                int i = 0;
                Controleur.Vmodele.charger_donnees("consultJeuxGenre", cbGenre.Text);
                foreach (DataRow dr in Controleur.Vmodele.DT[14].Rows)
                {
                    i++;
                    tbConsult.Text += dr["nomjv"].ToString();
                    tbConsult.Text += " - ";
                    tbConsult.Text += dr["note"].ToString();
                    tbConsult.Text += System.Environment.NewLine;

                    if (i >= 5) { break; };
                }

                triEffectue = "Par Genre : " + cbGenre.Text;
            }
            else
            {
                callAucunTri();
                cbSupport.SelectedIndex = 0;
            }
        }

        private void cbSupport_SelectedIndexChanged(object sender, EventArgs e)
        {
            tbConsult.Text = "";
            if (cbSupport.Text != "Aucun tri")
            {
                int i = 0;

                Controleur.Vmodele.charger_donnees("consultJeuxSupport", cbSupport.Text);
                foreach (DataRow dr in Controleur.Vmodele.DT[15].Rows)
                {
                    i++;

                    tbConsult.Text += dr["nomjv"].ToString();
                    tbConsult.Text += " - ";
                    tbConsult.Text += dr["note"].ToString();
                    tbConsult.Text += System.Environment.NewLine;

                    if (i >= 5) { break; }
                }

                triEffectue = "Par Support : " + cbSupport.Text;
            }
            else
            {
                callAucunTri();
                cbGenre.SelectedIndex = 0;
            }
        }

        private void callAucunTri ()
        {
            tbConsult.Text = "";
            Controleur.Vmodele.charger_donnees("consultJeux");
            foreach (DataRow dr in Controleur.Vmodele.DT[13].Rows)
            {
                tbConsult.Text += dr["nomjv"].ToString();
                tbConsult.Text += " - ";
                tbConsult.Text += dr["note"].ToString();
                tbConsult.Text += System.Environment.NewLine;
            }

            triEffectue = "Aucun tri";
        }
    }
}
