using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Trenches_of_Gallipoli
{
    public partial class LauncherForm : Form
    {
        public static string inputLanguage;

        public LauncherForm()
        {
            InitializeComponent();
        }

        private void LangEnglish_Click(object sender, EventArgs e)
        {
            this.Hide();
            inputLanguage = "ENG";
            MainMenuForm Form = new MainMenuForm(inputLanguage);
            Form.Closed += (s, args) => this.Close();
            Form.Show();            
        }

        private void LangTurkish_Click(object sender, EventArgs e)
        {
            this.Hide();
            inputLanguage = "TR";
            MainMenuForm Form = new MainMenuForm(inputLanguage);
            Form.Closed += (s, args) => this.Close();
            Form.Show();
        }

        private void LabelQuit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
