using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SSB64TournamentBracket;
using System.IO;

namespace SSB64TournamentBracket
{
    public partial class Form2 : Form
    {
        public static Form2 instance;
        public Label lbl;
        public TextBox txt;
        public Form2()
        {
            InitializeComponent();
            instance = this;
            txt = textBox1;
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            numericUpDown1.Value = 4;
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if (numericUpDown1.Value < 4)
            {
                MessageBox.Show("Cannot be less than 4 players in the bracket. Please try again.");
                
                throw new NotFiniteNumberException();
            }

            if (textBox1.Text.Trim() == string.Empty)
            {
                throw new IndexOutOfRangeException();
            }
            else if (textBox1.TextLength > 2)
            {
                this.Close();

                //MessageBox.Show("Congrats! You have created a Tournament Set!");

                MessageBox.Show("Please enter their names.");

                PlayerNames playerNames = new PlayerNames();

                playerNames.ShowDialog();


                if (playerNames.DialogResult == DialogResult.OK)
                {
                    Form1.Form1Instance.savestrip.Enabled = true;
                    Form1.Form1Instance.changestrip.Enabled = true;
                    this.Close();
                }

                { 
                bool isopen = false;
                foreach (Form f in Application.OpenForms)
                {
                    if (f.Text == "form")
                    {
                        isopen = true;
                        f.BringToFront();
                        break;
                    }
                }

                if (isopen == false)
                {

                }
            }                
        }

            if (textBox1.TextLength < 3)
            {
                //If not entered a name of a tournament set, you'll recieve a error message.
                throw new ArgumentOutOfRangeException();
            }
            else if (textBox1.TextLength > 60)

                throw new IndexOutOfRangeException();

            if (numericUpDown1.Value < 4)
            {
                MessageBox.Show("Cannot be less than 4 players in the bracket. Please try again.");

                 throw new NotFiniteNumberException();
             }
        }
        private void Button2_Click(object sender, EventArgs e)
        {
            this.Close();

            MessageBox.Show("The operation is cancelled.");
            return;
        }
        private void NumericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            
            if (numericUpDown1.Value > 16)
            {
                button1.Enabled = false;

                MessageBox.Show("Number of players cannot exceeded more than 16 on this first release. Stay tuned for more information!", "Error");
                numericUpDown1.Value = 16;
            }
            else

                button1.Enabled=true;
        }
        private void TextBox1_TextChanged(object sender, EventArgs e)
        {
            
            //Form1.Form1Instance.label.Text = textBox1.Text;
        }
    }
}
