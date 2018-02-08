using LanguageIdentification;
using System;
using System.Windows.Forms;

namespace language_recognition
{
    public partial class Form1 : Form
    {
        private LanguageIdentifier lan;

        public Form1()
        {
            InitializeComponent();
            lan = LanguageIdentifier.New("langprofiles-char-1_5-nfc-all.bin.gz", "Rank,sf", -1);
        }

        private void btnMain_Click(object sender, EventArgs e)
        {
            label1.Text = lan.Identify(rtbMain.Text);
        }
    }
}