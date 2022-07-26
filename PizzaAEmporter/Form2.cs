using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PizzaAEmporter
{
    public partial class Form2 : Form
    {
        int prixPizzaSelectionnee;
        int qttCapres = 0;
        int qttOlives = 0;
        int qttAnchois = 0;
        int qttOeuf = 0;
        int numeroCommande;
        double prixQttCapres;
        double prixQttOlives;
        double prixQttAnchois;
        double prixQttOeuf;
        double prixTotalIngredients;
        double prixBoisson;
        double prixFinal;
        string typePizza = "";
        string boisson = "";
        string choixPizza = "";
        string ingredientsc = "";
        string ingredientso = "";
        string ingredientsa = "";
        string ingredientsf = "";
        string prixFinalCommande = "";



        public Form2(Form parentForm)
        {
            InitializeComponent();
        }

        private void CloseButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void effacerSelectionChoixButton_Click(object sender, EventArgs e)
        {
            listeDeChoixListBox.Items.Clear();
            PrixFinalListBox.Items.Clear();
        }

        private void validationChoixButton_Click(object sender, EventArgs e)
        {
            ChoixTypePizza();
            ChoixTaillePizza();
            ChoixBoisson();
            ChoixIngredientsSupplementairesEtQuantite();
            prixTotalIngredients = prixQttCapres + prixQttOlives + prixQttAnchois + prixQttOeuf;
            prixFinal = prixPizzaSelectionnee + prixTotalIngredients + prixBoisson;
            PrixFinalListBox.Items.Add($"Prix TTC = {prixFinal} euros");
            prixFinalCommande = $"Prix TTC = {prixFinal} euros";

        }

        private void ChoixTaillePizza()
        {
            if (pizzaSmallRadioButton.Checked == true)
            {
                //ChoixTypePizza();
                listeDeChoixListBox.Items.Add($"Pizza {typePizza} Taille Small 6€");
                prixPizzaSelectionnee = 6;
                choixPizza = $"Pizza {typePizza} Taille Small 6€";
            }
            else if (pizzaMediumRadioButton.Checked == true)
            {
                //ChoixTypePizza();
                listeDeChoixListBox.Items.Add($"Pizza {typePizza} Taille Medium 9€");
                prixPizzaSelectionnee = 9;
                choixPizza = $"Pizza {typePizza} Taille Medium 9€";
            }
            else if (pizzaLargeRadioButton.Checked == true)
            {
                //ChoixTypePizza();
                listeDeChoixListBox.Items.Add($"Pizza {typePizza} Taille Large 12€");
                prixPizzaSelectionnee = 12;
                choixPizza = $"Pizza {typePizza} Taille Large 12€";
            }
        }

        public void ChoixTypePizza()
        {
            if (margueriteRadioButton.Checked == true)
            {
                typePizza = "Marguerite";
            }
            else if (napolitaineRadioButton.Checked == true)
            {
                typePizza = "Napolitaine";
            }
            else if (royaleRadioButton.Checked == true)
            {
                typePizza = "Royale";
            }
            else if (marineRadioButton.Checked == true)
            {
                typePizza = "Marine";
            }
        }

        private void ChoixBoisson()
        {
            if (cocaRadioButton.Checked == true)
            {
                prixBoisson = 1.5;
                listeDeChoixListBox.Items.Add($"1 Coca : {prixBoisson} €");
                boisson = "Coca 1.5€";

            }
            else if (spriteRadioButton.Checked == true)
            {
                prixBoisson = 1.5;
                listeDeChoixListBox.Items.Add($"1 Sprite : {prixBoisson} €");
                boisson = "Sprite 1.5€";
            }
            else if (liptonIceTeaPecheRadioButton.Checked == true)
            {
                prixBoisson = 1.5;
                listeDeChoixListBox.Items.Add($"1 Lipton Ice Tea Pêche : {prixBoisson} €");
                boisson = "Lipton Ice Tea Pêche 1.5€";
            }
            else if (fantaOrangeRadioButton.Checked == true)
            {
                prixBoisson = 1.5;
                listeDeChoixListBox.Items.Add($"1 Fanta Orange : {prixBoisson} €");
                boisson = "Fanta Orange 1.5€";
            }
            else if (fantaCitronRadioButton.Checked == true)
            {
                prixBoisson = 1.5;
                listeDeChoixListBox.Items.Add($"1 Fanta Citron : {prixBoisson} €");
                boisson = "Fanta Citron 1.5€";
            }
            else if (fantaGrenadineRadioButton.Checked == true)
            {
                prixBoisson = 1.5;
                listeDeChoixListBox.Items.Add($"1 Fanta Grenadine : {prixBoisson} €");
                boisson = "Fanta Grenadine 1.5€";
            }
        }

        private void ChoixIngredientsSupplementairesEtQuantite()
        {
            if (capresCheckBox.Checked == true && qttAnchoisTextBox.Text != null)
            {
                qttCapres = int.Parse(qttCapresTextBox.Text);
                prixQttCapres = qttCapres * 0.5;
                listeDeChoixListBox.Items.Add($"{qttCapres} Capres : {prixQttCapres} €");
                ingredientsc = $"{qttCapres} Capres : {prixQttCapres} €";
            }

            if (olivesCheckBox.Checked == true && qttOlivesTextBox.Text != null)
            {
                qttOlives = int.Parse(qttOlivesTextBox.Text);
                prixQttOlives = qttOlives * 0.5;
                listeDeChoixListBox.Items.Add($"{qttOlives} Olives : {prixQttOlives} €");
                ingredientso = $"{qttOlives} Olives : {prixQttOlives} €";
            }

            if (anchoisCheckBox.Checked == true && qttAnchoisTextBox.Text != null)
            {
                qttAnchois = int.Parse(qttAnchoisTextBox.Text);
                prixQttAnchois = qttAnchois * 0.5;
                listeDeChoixListBox.Items.Add($"{qttAnchois} Anchois : {prixQttAnchois} €");
                ingredientsa = $"{qttAnchois} Anchois : {prixQttAnchois} €";
            }

            if (oeufCheckBox.Checked == true && qttOeufTextBox.Text != null)
            {
                qttOeuf = int.Parse(qttOeufTextBox.Text);
                prixQttOeuf = qttOeuf * 0.5;
                listeDeChoixListBox.Items.Add($"{qttOeuf} Oeuf : {prixQttOeuf} €");
                ingredientsf = $"{qttOeuf} Oeuf : {prixQttOeuf} €";
            }
        }

        private void emailTextBox_Validating(object sender,
                System.ComponentModel.CancelEventArgs e)
        {
            if (!AdressseEMailValide(emailTextBox.Text, out string messageDErreur))
            {
                // Cancel the event and select the text to be corrected by the user.
                e.Cancel = true;
                emailTextBox.Select(0, emailTextBox.Text.Length);

                // Set the ErrorProvider error with the text to display. 
                MessageBox.Show(emailTextBox, messageDErreur);

            }
        }

        private void emailTextBox_Validated(object sender, System.EventArgs e)
        {

            MessageBox.Show(emailTextBox, "");
        }

        public bool AdressseEMailValide(string adresseEmail, out string messageDErreur)
        {

            if (adresseEmail.Length == 0)
            {
                messageDErreur = "Adresse E-mail requise.";
                return false;
            }

            // Confirm that there is an "@" and a "." in the email address, and in the correct order.
            if (adresseEmail.IndexOf("@") > -1)
            {
                if (adresseEmail.IndexOf(".", adresseEmail.IndexOf("@")) > adresseEmail.IndexOf("@"))
                {
                    messageDErreur = "";
                    return true;
                }
            }

            messageDErreur = "L'adresse E-mail doit être une adresse valide au bon format.\n" +
               "par exemple 'par@exemple.com' ";
            return false;
        }

        public void ValidationCommande()
        {
            if (listeDeChoixListBox.Items.Count != 0)
            {
                numeroCommande++;
                commandesListBox.Items.Add($"Commandes numéro : {numeroCommande}");
            }
            
            if (nomTextBox.Text != "")
                commandesListBox.Items.Add(nomTextBox.Text);
            if (prenomTextBox.Text != "")
                commandesListBox.Items.Add(prenomTextBox.Text);
            if (adresseTextBox.Text != "")
                commandesListBox.Items.Add(adresseTextBox.Text);
            if (codepostalTextBox.Text != "")
                commandesListBox.Items.Add(codepostalTextBox.Text);
            if (villeTextBox.Text != "")
                commandesListBox.Items.Add(villeTextBox.Text);
            if (telephoneTextBox.Text != "")
                commandesListBox.Items.Add(telephoneTextBox.Text);
            if (emailTextBox.Text != "")
                commandesListBox.Items.Add(emailTextBox.Text);
            if (choixPizza != "")
                commandesListBox.Items.Add(choixPizza);
            if (ingredientsc != "")
                commandesListBox.Items.Add(ingredientsc);
            if (ingredientso != "")
                commandesListBox.Items.Add(ingredientso);
            if (ingredientsa != "")
                commandesListBox.Items.Add(ingredientsa);
            if (ingredientsf != "")
                commandesListBox.Items.Add(ingredientsf);
            if (boisson != "")
                commandesListBox.Items.Add(boisson);
            if (prixFinalCommande != "")
                commandesListBox.Items.Add(prixFinalCommande);

        }

        private void validationCommandeButton_Click(object sender, EventArgs e)
        {
            
            ValidationCommande();
        }

        private void ClearChoixApresAchat()
        {
            pizzaSmallRadioButton.Checked = false;
            pizzaMediumRadioButton.Checked = false;
            pizzaLargeRadioButton.Checked = false;
            margueriteRadioButton.Checked = false;
            napolitaineRadioButton.Checked = false;
            royaleRadioButton.Checked = false;
            marineRadioButton.Checked = false;
            cocaRadioButton.Checked = false;
            spriteRadioButton.Checked = false;
            liptonIceTeaPecheRadioButton.Checked = false;
            fantaOrangeRadioButton.Checked = false;
            fantaCitronRadioButton.Checked = false;
            fantaGrenadineRadioButton.Checked = false;
        }
    }
}
