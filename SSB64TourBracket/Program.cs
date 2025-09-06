using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SSB64TournamentBracket;
using System.IO;
using System.Windows.Forms;

namespace SSB64TournamentBracket
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
