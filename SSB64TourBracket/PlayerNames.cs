using ColorPickerTest;
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
    public partial class PlayerNames : Form
    {
        public static PlayerNames playerform;

        public TextBox txt3;
        public PlayerNames()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            if (Player1Name.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Unable to confirm changes because one of the names are outright blank. Please try again.", "Failed to create names!");

                throw new NullReferenceException();
            }
            else if (Player2Name.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Unable to confirm changes because one of the names are outright blank. Please try again.", "Failed to create names!");

                throw new NullReferenceException();
            }
            else
            {
                Form1.Form1Instance.lbl2.Text = Form2.instance.txt.Text;

                Form1.Form1Instance.lbl3.Text = Player1Name.Text;

                Form1.Form1Instance.lbl4.Text = Player2Name.Text;

                Form1.Form1Instance.savestrip.Enabled = true;

                Form1.Form1Instance.changestrip.Enabled = true;
                this.Close();

                MessageBox.Show("Thank you for creating a Tournament set including player names. They are now live on the main bracket. You can save progress at any time in case you're expereincing power loss, PC crash, etc. You can always load the file back on the main bracket where you left off.");
            }

        }
        private void Button1_Click(object sender, EventArgs e)
        {
            this.Close();
            Form1.Form1Instance.savestrip.Enabled = false;
            Form1.Form1Instance.changestrip.Enabled = false;
            Form1.Form1Instance.lbl4.Text = "";
            throw new OperationCanceledException();
        }

        private void PlayerNames_Load(object sender, EventArgs e)
        {
          
        }
    }
}
