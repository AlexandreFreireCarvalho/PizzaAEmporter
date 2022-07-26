using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PizzaAEmporter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        int troisMax = 0;
        private void button2_Click(object sender, EventArgs e)
        {
                        
            if (textBox1.Text != "chef" && textBox2.Text != "pizza")
            {
                troisMax++;
                if (troisMax == 1)
                {
                    MessageBox.Show("Mauvais identifiant ou mot de passe");

                }
                else if (troisMax == 2)
                {
                    MessageBox.Show("Plus qu'une dernière chance avant que le programme ne se ferme");
                }
                else if (troisMax == 3)
                {
                    this.Close();
                }                

            }
            else
            {
                Form2 cmdPizza = new Form2(this);
                this.Hide();
                cmdPizza.ShowDialog();
                this.Close();



            }

        }
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }


}

