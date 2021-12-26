using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.IO;
using System.Reflection;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ColorPickerTest
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            
            panel1.BackColor = Color.Green;

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            saveBracketFileToolStripMenuItem1.Enabled = false;
            changeIconToolStripMenuItem.Enabled = false;
            button1.Enabled = false;
            button2.Enabled = false;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        private void changeBackgroundColorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorDialog colorDlg = new ColorDialog();

            if (colorDlg.ShowDialog() == DialogResult.OK)
            {

                panel1.BackColor = colorDlg.Color;
            }
        }

        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var title = ("HotKeys Controls");
            var message = ("Player 1:" + " NUM 1" + "\r\n" +
"Player 2:" + " NUM 2" + "\r\n" +
"Player 3:" + " NUM 3" + "\r\n" +
"Player 4:" + " NUM 4" + "\r\n" + "\r\n" + "Alternately, you can use keyboard arrow controls to move players via control section.");

            System.Windows.Forms.MessageBox.Show(message, title,
                       System.Windows.Forms.MessageBoxButtons.OK,
                       System.Windows.Forms.MessageBoxIcon.Information);


        }

        private void saveBracketFileToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void openBracketFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.Filter = "Smash Bros Bracket Files|*.SBBRAK|All File Formats (*.*)|*.*";
            {
                saveBracketFileToolStripMenuItem1.Enabled = true;
                if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK) return;

                else

                    return;
            }

        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            bool isopen = false;
            foreach (Form f in Application.OpenForms)
            {
                if (f.Text == "test")
                {
                    isopen = true;
                    f.BringToFront();
                    break;
                }
            }

            if (isopen == false)
            {
                Form form2 = new Form2();
                form2.ShowDialog();
            }
        
         }

        private void fileToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }

}