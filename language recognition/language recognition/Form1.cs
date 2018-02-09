﻿using LanguageIdentification;
using System;
using System.Windows.Forms;
using System.Collections.Generic;

namespace language_recognition
{
    public partial class Form1 : Form
    {
        private LanguageIdentifier lan;
        private Dictionary<string, string> dict;

        public Form1()
        {
            InitializeComponent();     
        }

        private void btnMain_Click(object sender, EventArgs e)
        {
            String id;
            id = lan.Identify(rtbMain.Text);

            lblJezik.Text = dict[id];
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lblJezik.Text = "";
            lan = LanguageIdentifier.New("profil_2.gz", "Rank,sf", -1);
            dict = new Dictionary<string, string>();
            dict["en"] = "English";
            dict["es"] = "Spanish";
            dict["fr"] = "French";
            dict["it"] = "Italian";
            dict["ru"] = "Russian";
            dict["sr"] = "Serbian";
            dict["de"] = "German";
            dict["pt"] = "Portuguese";
        }
    }
}