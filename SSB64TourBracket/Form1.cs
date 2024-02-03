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
using SSB64TournamentBracket;

namespace ColorPickerTest
{
    public partial class Form1 : Form
    {
        public static Form1 Form1Instance;
        public Label lbl2;
        public Label lbl3;
        public Label lbl4;
        public ToolStripMenuItem savestrip;
        public ToolStripMenuItem changestrip;
        public MenuStrip menu;
        public Button cancel;
 
        static List<string> names = new List<string>();

        public Form1()
        {

            InitializeComponent();
            Form1Instance = this;

            lbl2 = player3names;
            lbl3 = Player1;
            lbl4 = Player2;

            savestrip = saveBracketFileToolStripMenuItem1;
            changestrip = changeBackgroundColorToolStripMenuItem;
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            changeIconToolStripMenuItem.Enabled = false;
            button1.Enabled = false;
            button2.Enabled = false;
            panel1.BackColor = Color.Green;
            this.MaximizeBox = false;   
            saveBracketFileToolStripMenuItem1.Enabled = false;
        }
        internal void recieveData(string playernames)
        {
            names.Add(playernames);

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
            var title = ("HotKey Controls");
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
            saveBracketFileToolStripMenuItem1.Enabled = true;
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.Filter = "Smash Bros Bracket Files|*.SBBRAK";
            saveFileDialog1.FilterIndex = 0;

            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                button2.Enabled = true;
            }
        }
        private void openBracketFileToolStripMenuItem_Click(object sender, EventArgs e)
        {

            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.Filter = "Smash Bros Bracket Files|*.SBBRAK|All File Formats (*.*)|*.*";
            {
                
                if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    saveBracketFileToolStripMenuItem1.Enabled = true;
                    string ext = Path.GetExtension(openFileDialog1.FileName);

                    if (ext != ".SBBRAK")
                    {
                        throw new IndexOutOfRangeException();
    
                    //string required_Ext = ".SBBRAK";
                    //string selected_Ext = Path.GetExtension(openFileDialog1.FileName);
                    //int index = required_Ext.IndexOf(selected_Ext);

                    //if (index < 0)
                    //{
                    //    MessageBox.Show("Unsupported file.");
                    //    file.cancel = true;
                    //
                    }     
                }
            }
        }
        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();

            if (form2.ShowDialog() == DialogResult.OK)
            {
                saveBracketFileToolStripMenuItem1.Enabled = true;
            }

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
        private void fileToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
        private void Form1_Activated(object sender, EventArgs e)
        {
            
        }
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}