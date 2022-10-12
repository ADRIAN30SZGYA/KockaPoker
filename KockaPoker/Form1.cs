﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using KockaPoker.SajatOsztalyok;

namespace KockaPoker
{
    public partial class Form1 : Form
    {
        List<PictureBox> jatekosKepek = new List<PictureBox>();
        List<PictureBox> gepKepek = new List<PictureBox>();
        Jatekos j;
        Gep g;

        private int OsszesMenet { get; set; }

        public Form1()
        {
            InitializeComponent();
            PictureBoxokBeallitasa();
            //JatekosokBeallitasa();

            VezerlokBeallitasa();

            //Kiertekeles();
        }

        private void Kiertekeles()
        {
            lblJatekosErtek.Text = "1. játékos: " + j.LeosztasErtek;
            lblGepErtek.Text = "2. játékos: " + g.LeosztasErtek;

            if (j.Pont > g.Pont)
            {
                MessageBox.Show("Ember nyert!");
            }
            else if (j.Pont < g.Pont)
            {
                MessageBox.Show("Gép nyert!");
            }
            else
            {
                MessageBox.Show("Döntetlen!");
            }
        }
        private void VezerlokBeallitasa()
        {
            lblGepErtek.Text = "";
            lblJatekosErtek.Text = "";
            lblMenetszam.Text = "";
            lblJGyozelem.Text = "Játékos: 0";
            lblGGyozelem.Text = "Gép: 0";
            lblKijelzo.Text = "";
            OsszesMenet = 0;
        }

        private void JatekosokBeallitasa()
        {
            //List<int> kockak = new List<int>() { 1, 2, 2, 2, 4 };
            j = new Jatekos("Szerencsés Pista", jatekosKepek);
            g = new Gep("Gép", gepKepek);

            j.Nyert = 0;
            g.Nyert = 0;

            j.KepekBeallitasa();
            g.KepekBeallitasa();
        }

        private void PictureBoxokBeallitasa()
        {
            jatekosKepek.Add(pbElsoJatekos1);
            jatekosKepek.Add(pbElsoJatekos2);
            jatekosKepek.Add(pbElsoJatekos3);
            jatekosKepek.Add(pbElsoJatekos4);
            jatekosKepek.Add(pbElsoJatekos5);

            gepKepek.Add(pbMasodikJatekos1);
            gepKepek.Add(pbMasodikJatekos2);
            gepKepek.Add(pbMasodikJatekos3);
            gepKepek.Add(pbMasodikJatekos4);
            gepKepek.Add(pbMasodikJatekos5);
        }

        private void btnKilepes_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnUjJatek_Click(object sender, EventArgs e)
        {
            JatekosokBeallitasa();
            btnKovetkezo.Enabled = true;
        }
    }
}
