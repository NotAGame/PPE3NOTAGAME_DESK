using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Data;

namespace PPE3_NotaGame
{
    /// <summary>
    /// classe Controleur : classe statique de lien entre Modele et les vues
    /// </summary>
    public static class Controleur
    {
        #region propriétés
        private static Modele vmodele;
        #endregion

        #region accesseurs
        /// <summary>
        /// propriété Vmodele
        /// </summary>
        public static Modele Vmodele
        {
            get { return vmodele; }
            set { vmodele = value; }
        }
        #endregion

        #region methodes
        /// <summary>
        /// instanciation du modele
        /// </summary>
        public static void init()
        {
            Vmodele = new Modele();
        }

        /// <summary>
        /// permet le crud sur la table Constructeur
        /// </summary>
        /// <param name="c">définit l'action : c:create, u update, d delete</param>
        /// <param name="indice">indice de l'élément sélectionné à modifier ou supprimer, -1 si ajout</param>
        public static void crud_constructeur(Char c, int indice)
        {
            if (c == 'd') // cas de la suppression
            {
             //   DialogResult rep = MessageBox.Show("Etes-vous sûr de vouloir supprimer ce constructeur "+ vmodele.DTConstructeur.Rows[indice][1].ToString()+ " ? ", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                DialogResult rep = MessageBox.Show("Etes-vous sûr de vouloir supprimer ce constructeur " + vmodele.DT[1].Rows[indice][1].ToString() + " ? ", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (rep == DialogResult.Yes)
                {
                    // on supprime l’élément du DataTable
                    vmodele.DT[1].Rows[indice].Delete();		// suppression dans le DataTable
                    vmodele.DA[1].Update(vmodele.DT[1]);			// mise à jour du DataAdapter
                }
            }
            else
            {
                // cas de l'ajout et modification
                FormCRUDConstructeur formCRUD = new FormCRUDConstructeur();  // création de la nouvelle forme
                if (c == 'c')  // mode ajout donc pas de valeur à passer à la nouvelle forme
                {
                    formCRUD.TbNom.Clear();
                }

                if (c == 'u')   // mode update donc on récupère les champs
                {
                    // on remplit les zones par les valeurs du dataGridView correspondantes
                    formCRUD.TbNom.Text = vmodele.DT[1].Rows[indice][1].ToString();

                }
                // on affiche la nouvelle form
                formCRUD.ShowDialog();

                // si l’utilisateur clique sur OK
                if (formCRUD.DialogResult == DialogResult.OK)
                {
                    if (c == 'c') // ajout
                    {
                        // on crée une nouvelle ligne dans le dataView
                        if (formCRUD.TbNom.Text != "")
                        {
                            DataRow NouvLigne = vmodele.DT[1].NewRow();
                            NouvLigne["NomC"] = formCRUD.TbNom.Text;
                            vmodele.DT[1].Rows.Add(NouvLigne);
                            vmodele.DA[1].Update(vmodele.DT[1]);
                        }
                    }

                    if (c == 'u')  // modif
                    {
                        // on met à jour le dataTable avec les nouvelles valeurs
                        vmodele.DT[1].Rows[indice]["NomC"] = formCRUD.TbNom.Text;
                        vmodele.DA[1].Update(vmodele.DT[1]);
                    }
                   
                    // MessageBox.Show("OK : données enregistrées Constructeur");
                    formCRUD.Dispose();  // on ferme la form
                }
                else
                {
                    MessageBox.Show("Annulation : aucune donnée enregistrée");
                    formCRUD.Dispose();
                }
            }
        }

        /// <summary>
        /// permet le crud sur la table Support
        /// </summary>
        /// <param name="c">définit l'action : c:create, u update, d delete </param>
        /// <param name="indice">indice de l'élément sélectionné à modifier ou supprimer, -1 si ajout</param>
        public static void crud_support(Char c, int indice)
        {
            if (c == 'd')  // suppression
            {
                DialogResult rep = MessageBox.Show("Etes-vous sûr de vouloir supprimer ce support " + vmodele.DT[2].Rows[indice][1].ToString() + " ? ", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (rep == DialogResult.Yes)
                {
                    // on supprime l’élément du DataTable
                    vmodele.DT[3].Rows[indice].Delete();		// suppression dans le DataTable
                    vmodele.DA[3].Update(vmodele.DT[3]);			// mise à jour du DataAdapter
                }
            }
            else
            {
                FormCRUDSupport formCRUD = new FormCRUDSupport(c, indice);  // création de la nouvelle forme
                if (c == 'c')  // mode ajout donc pas de valeur à passer à la nouvelle forme
                {
                    // à écrire : mettre les contrôles de formCRUD à vide
                    formCRUD.TbNom.Clear();
                    formCRUD.NumAnnee.Value = 2016;
                    formCRUD.CbConstructeur.SelectedIndex = -1;
                    formCRUD.TbCaract.Clear();
                }

                if (c == 'u')   // mode update donc on récupère les champs
                {
                    // on remplit les zones par les valeurs du dataGridView correspondantes
                    formCRUD.TbNom.Text = vmodele.DT[2].Rows[indice][1].ToString();
                    formCRUD.NumAnnee.Value = Convert.ToInt32(vmodele.DT[2].Rows[indice][3]);
                    formCRUD.TbCaract.Text = vmodele.DT[2].Rows[indice][2].ToString();
                    // mise à jour de la comboBox faite avec le nom du constructeur dans le Load de la formCRUD
                }

            eti:
                // on affiche la nouvelle form
                formCRUD.ShowDialog();

                // si l’utilisateur clique sur OK
                if (formCRUD.DialogResult == DialogResult.OK)
                {
                    if (c == 'c') // ajout
                    {
                        // on crée une nouvelle ligne dans le dataView
                        if (formCRUD.TbNom.Text != "" && formCRUD.CbConstructeur.SelectedIndex != -1)
                        {
                            DataRow NouvLigne = vmodele.DT[3].NewRow();
                            NouvLigne["NomS"] = formCRUD.TbNom.Text;
                            NouvLigne["AnneeSortie"] = formCRUD.NumAnnee.Value;
                            if (formCRUD.TbCaract.Text != "") NouvLigne["caracteristiques"] = formCRUD.TbCaract.Text;
                            else NouvLigne["caracteristiques"] = Convert.DBNull;

                            // récupération de l'IDC de la table constructeur correspondant au nom du constructeur sélectionné dans la comboBox
                            NouvLigne["IdC"] = Convert.ToInt32(vmodele.DT[1].Rows[formCRUD.CbConstructeur.SelectedIndex][0]);

                            vmodele.DT[3].Rows.Add(NouvLigne);
                            vmodele.DA[3].Update(vmodele.DT[3]);
                        }
                        else
                        {
                            MessageBox.Show("Sélectionner un nom et un constructeur au minimum", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            // ne pas fermer la form : revenir avant le bouton OK
                            goto eti;
                        }
                    }

                    if (c == 'u')  // modif
                    {
                        // on met à jour le dataTable avec les nouvelles valeurs
                        vmodele.DT[3].Rows[indice]["NomS"] = formCRUD.TbNom.Text;
                        vmodele.DT[3].Rows[indice]["AnneeSortie"] = formCRUD.NumAnnee.Value;
                        if (formCRUD.TbCaract.Text != "") vmodele.DT[3].Rows[indice]["caracteristiques"] = formCRUD.TbCaract.Text;
                        else vmodele.DT[3].Rows[indice]["caracteristiques"] = Convert.DBNull;
                        vmodele.DT[3].Rows[indice]["IdC"] = Convert.ToInt32(vmodele.DT[1].Rows[formCRUD.CbConstructeur.SelectedIndex][0]);
                        vmodele.DA[3].Update(vmodele.DT[3]);
                    }

                    // MessageBox.Show("OK : données enregistrées Constructeur");
                    formCRUD.Dispose();  // on ferme la form
                }
                else
                {
                    MessageBox.Show("Annulation : aucune donnée enregistrée");
                    formCRUD.Dispose();
                }
            }
        }
        #endregion


        /// <summary>
        /// permet le crud sur la table Constructeur
        /// </summary>
        /// <param name="c">définit l'action : c:create, u update, d delete</param>
        /// <param name="indice">indice de l'élément sélectionné à modifier ou supprimer, -1 si ajout</param>
        public static void crud_Jeuxvideo(Char c, int indice)
        {
            if (c == 'd') // cas de la suppression
            {
                //   DialogResult rep = MessageBox.Show("Etes-vous sûr de vouloir supprimer ce constructeur "+ vmodele.DTConstructeur.Rows[indice][1].ToString()+ " ? ", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                DialogResult rep = MessageBox.Show("Etes-vous sûr de vouloir supprimer ce constructeur " + vmodele.DT[5].Rows[indice][1].ToString() + " ? ", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (rep == DialogResult.Yes)
                {
                    // on supprime l’élément du DataTable
                    vmodele.DT[5].Rows[indice].Delete();		// suppression dans le DataTable
                    vmodele.DA[5].Update(vmodele.DT[5]);			// mise à jour du DataAdapter
                }
            }
            else
            {
                // cas de l'ajout et modification
                FormCRUDJeuxvideox formCRUD = new FormCRUDJeuxvideox();  // création de la nouvelle forme
                if (c == 'c')  // mode ajout donc pas de valeur à passer à la nouvelle forme
                {
                    formCRUD.TbNom.Clear();
                    formCRUD.numAnnee.Value = 1900;
                    formCRUD.comboBoxClass.SelectedIndex = 0;
                    formCRUD.TbEditeur.Clear();
                    formCRUD.TbDesc.Clear();
                }

                if (c == 'u')   // mode update donc on récupère les champs
                {
                    // on remplit les zones par les valeurs du dataGridView correspondantes
                    formCRUD.TbNom.Text = vmodele.DT[5].Rows[indice][1].ToString();
                    formCRUD.numAnnee.Value = Convert.ToInt32(vmodele.DT[5].Rows[indice][2]);
                    formCRUD.comboBoxClass.SelectedValue = Convert.ToInt32(vmodele.DT[5].Rows[indice][3]);
                    formCRUD.TbEditeur.Text = vmodele.DT[5].Rows[indice][4].ToString();
                    formCRUD.TbDesc.Text = vmodele.DT[5].Rows[indice][5].ToString();

                }
                // on affiche la nouvelle form
                formCRUD.ShowDialog();

                // si l’utilisateur clique sur OK
                if (formCRUD.DialogResult == DialogResult.OK)
                {
                    if (c == 'c') // ajout
                    {
                        // on crée une nouvelle ligne dans le dataView
                        if (formCRUD.TbNom.Text != "" && Convert.ToInt32(formCRUD.comboBoxClass.SelectedItem) != 0 && formCRUD.TbEditeur.Text != "" && formCRUD.TbDesc.Text != "")
                        {
                            DataRow NouvLigne = vmodele.DT[5].NewRow();
                            NouvLigne["NomJV"] = formCRUD.TbNom.Text;
                            NouvLigne["anneeSortie"] = formCRUD.numAnnee.Value;
                            NouvLigne["classification"] = Convert.ToInt32(formCRUD.comboBoxClass.SelectedItem);
                            NouvLigne["editeur"] = formCRUD.TbEditeur.Text;
                            NouvLigne["description"] = formCRUD.TbDesc.Text;
                            vmodele.DT[5].Rows.Add(NouvLigne);
                            vmodele.DA[5].Update(vmodele.DT[5]);
                        }

                    }

                    if (c == 'u')  // modif
                    {
                        // on met à jour le dataTable avec les nouvelles valeurs
                        vmodele.DT[5].Rows[indice]["NomJV"] = formCRUD.TbNom.Text;
                        vmodele.DT[5].Rows[indice]["anneeSortie"] = formCRUD.numAnnee.Value;
                        vmodele.DT[5].Rows[indice]["classification"] = Convert.ToInt32(formCRUD.comboBoxClass.SelectedItem);
                        vmodele.DT[5].Rows[indice]["editeur"] = formCRUD.TbEditeur.Text;
                        vmodele.DT[5].Rows[indice]["description"] = formCRUD.TbDesc.Text;
                        vmodele.DA[5].Update(vmodele.DT[5]);
                    }

                    // MessageBox.Show("OK : données enregistrées Constructeur");
                    formCRUD.Dispose();  // on ferme la form
                }
                else
                {
                    MessageBox.Show("Annulation : aucune donnée enregistrée");
                    formCRUD.Dispose();
                }
            }
        }



        /// <summary>
        /// permet le crud sur la table Constructeur
        /// </summary>
        /// <param name="c">définit l'action : c:create, u update, d delete</param>
        /// <param name="indice">indice de l'élément sélectionné à modifier ou supprimer, -1 si ajout</param>
        public static void crud_Users(Char c, int indice)
        {
            if (c == 'd') // cas de la suppression
            {
                //   DialogResult rep = MessageBox.Show("Etes-vous sûr de vouloir supprimer ce constructeur "+ vmodele.DTConstructeur.Rows[indice][1].ToString()+ " ? ", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                DialogResult rep = MessageBox.Show("Etes-vous sûr de vouloir supprimer ce constructeur " + vmodele.DT[4].Rows[indice][1].ToString() + " ? ", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (rep == DialogResult.Yes)
                {
                    // on supprime l’élément du DataTable
                    vmodele.DT[4].Rows[indice].Delete();		// suppression dans le DataTable
                    vmodele.DA[4].Update(vmodele.DT[4]);			// mise à jour du DataAdapter
                }
            }
            else
            {
                // cas de l'ajout et modification
                FormCRUDUsers formCRUD = new FormCRUDUsers(); // création de la nouvelle forme
                if (c == 'c')  // mode ajout donc pas de valeur à passer à la nouvelle forme
                {
                    formCRUD.TbEmail.Clear();
                    formCRUD.TbPseudo.Clear();
                    formCRUD.TbComm.Clear();
                }

                if (c == 'u')   // mode update donc on récupère les champs
                {
                    // on remplit les zones par les valeurs du dataGridView correspondantes
                    formCRUD.TbEmail.Text = vmodele.DT[4].Rows[indice][1].ToString();
                    formCRUD.TbPseudo.Text = vmodele.DT[4].Rows[indice][2].ToString();
                    formCRUD.TbComm.Text = vmodele.DT[4].Rows[indice][3].ToString();

                }
                // on affiche la nouvelle form
                formCRUD.ShowDialog();

                // si l’utilisateur clique sur OK
                if (formCRUD.DialogResult == DialogResult.OK)
                {
                    if (c == 'c') // ajout
                    {
                        // on crée une nouvelle ligne dans le dataView
                        if (formCRUD.TbEmail.Text != "" && formCRUD.TbPseudo.Text != "" && formCRUD.TbComm.Text != "")
                        {
                            DataRow NouvLigne = vmodele.DT[4].NewRow();
                            NouvLigne["email"] = formCRUD.TbEmail.Text;
                            NouvLigne["pseudo"] = formCRUD.TbPseudo.Text;
                            NouvLigne["communaute"] = formCRUD.TbComm.Text;
                            vmodele.DT[4].Rows.Add(NouvLigne);
                            vmodele.DA[4].Update(vmodele.DT[4]);
                        }

                    }

                    if (c == 'u')  // modif
                    {
                        // on met à jour le dataTable avec les nouvelles valeurs
                        vmodele.DT[4].Rows[indice]["email"] = formCRUD.TbEmail.Text;
                        vmodele.DT[4].Rows[indice]["pseudo"] = formCRUD.TbPseudo.Text;
                        vmodele.DT[4].Rows[indice]["communaute"] = formCRUD.TbComm.Text;
                        vmodele.DA[4].Update(vmodele.DT[4]);
                    }

                    // MessageBox.Show("OK : données enregistrées Constructeur");
                    formCRUD.Dispose();  // on ferme la form
                }
                else
                {
                    MessageBox.Show("Annulation : aucune donnée enregistrée");
                    formCRUD.Dispose();
                }
            }
        }



        /// <summary>
        /// permet le crud sur la table Constructeur
        /// </summary>
        /// <param name="c">définit l'action : c:create, u update, d delete</param>
        /// <param name="indice">indice de l'élément sélectionné à modifier ou supprimer, -1 si ajout</param>
        public static void crud_compatible(Char c, int indice)
        {
            if (c == 'd') // cas de la suppression
            {
                //   DialogResult rep = MessageBox.Show("Etes-vous sûr de vouloir supprimer ce constructeur "+ vmodele.DTConstructeur.Rows[indice][1].ToString()+ " ? ", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                DialogResult rep = MessageBox.Show("Etes-vous sûr de vouloir supprimer ce constructeur " + vmodele.DT[6].Rows[indice][1].ToString() + " ? ", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (rep == DialogResult.Yes)
                {
                    // on supprime l’élément du DataTable
                    vmodele.DT[6].Rows[indice].Delete();		// suppression dans le DataTable
                    vmodele.DA[6].Update(vmodele.DT[6]);			// mise à jour du DataAdapter
                }
            }
            else
            {
                // cas de l'ajout et modification
                FormCRUDCompatible formCRUD = new FormCRUDCompatible(); // création de la nouvelle forme
                if (c == 'c')  // mode ajout donc pas de valeur à passer à la nouvelle forme
                {
                    formCRUD.TbSupport.Clear();
                    formCRUD.TbJeux.Clear();
                }

                if (c == 'u')   // mode update donc on récupère les champs
                {
                    // on remplit les zones par les valeurs du dataGridView correspondantes
                    formCRUD.TbJeux.Text = vmodele.DT[6].Rows[indice][0].ToString();
                    formCRUD.TbSupport.Text = vmodele.DT[6].Rows[indice][1].ToString();

                }
                // on affiche la nouvelle form
                formCRUD.ShowDialog();

                // si l’utilisateur clique sur OK
                if (formCRUD.DialogResult == DialogResult.OK)
                {

                    if (c == 'c') // ajout
                    {
                        // on crée une nouvelle ligne dans le dataView
                        if (formCRUD.TbSupport.Text != "" && formCRUD.TbJeux.Text != "")
                        {
                            DataRow NouvLigne = vmodele.DT[6].NewRow();
                            NouvLigne["idJV"] = Convert.ToInt32(formCRUD.TbJeux.Text);
                            NouvLigne["idS"] = Convert.ToInt32(formCRUD.TbSupport.Text);
                            vmodele.DT[6].Rows.Add(NouvLigne);
                            vmodele.DA[6].Update(vmodele.DT[6]);
                        }

                    }

                    if (c == 'u')  // modif
                    {
                        // on met à jour le dataTable avec les nouvelles valeurs
                        vmodele.DT[6].Rows[indice]["idJV"] = Convert.ToInt32(formCRUD.TbJeux.Text);
                        vmodele.DT[6].Rows[indice]["idS"] = Convert.ToInt32(formCRUD.TbSupport.Text);
                        vmodele.DA[6].Update(vmodele.DT[6]);
                    }

                    // MessageBox.Show("OK : données enregistrées Constructeur");
                    formCRUD.Dispose();  // on ferme la form
                }
                else
                {
                    MessageBox.Show("Annulation : aucune donnée enregistrée");
                    formCRUD.Dispose();
                }
            }
        }




    }
}
