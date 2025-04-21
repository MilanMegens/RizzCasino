//███╗░░░███╗██╗██╗░░░░░░█████╗░███╗░░██╗░█████╗░░██████╗░██████╗
//████╗░████║██║██║░░░░░██╔══██╗████╗░██║██╔══██╗██╔════╝██╔════╝
//██╔████╔██║██║██║░░░░░███████║██╔██╗██║██║░░██║╚█████╗░╚█████╗░
//██║╚██╔╝██║██║██║░░░░░██╔══██║██║╚████║██║░░██║░╚═══██╗░╚═══██╗
//██║░╚═╝░██║██║███████╗██║░░██║██║░╚███║╚█████╔╝██████╔╝██████╔╝
//╚═╝░░░░░╚═╝╚═╝╚══════╝╚═╝░░╚═╝╚═╝░░╚══╝░╚════╝░╚═════╝░╚═════╝░

using System;
using System.Windows.Forms;
using RizzCasino.Controllers;

namespace RizzCasino.Views
{
    public partial class DoubleOrNothingForm : Form
    {
        private int huidigeWinst = 0;
        private int origineleInzet = 0;
        private int huidigBalans = 0;
        private Random random = new Random();
        private StartController startController;

        // Houdt het bijgewerkte balans bij
        public int NieuwBalans { get; private set; }

        // Constructor
        public DoubleOrNothingForm()
        {
            InitializeComponent();
            startController = new StartController();
            huidigBalans = startController.HaalBalansOp();
            lblBalans.Text = $"{huidigBalans} RizzCoins";

            nudInzet.Minimum = 1;
            nudInzet.Maximum = huidigBalans;

            ResetSpel();
        }

        // Reset het spel naar de beginstatus
        private void ResetSpel()
        {
            huidigeWinst = 0;
            origineleInzet = 0;
            btnVerdubbel.Enabled = false;
            btnUitcashen.Enabled = false;
            lblResultaat.Visible = false;
        }

        // Start het spel met de gekozen inzet
        private void btnStart_Click(object sender, EventArgs e)
        {
            int inzet = (int)nudInzet.Value;

            if (inzet > huidigBalans)
            {
                MessageBox.Show("Je hebt niet genoeg RizzCoins!");
                return;
            }

            origineleInzet = inzet;
            huidigeWinst = inzet;

            huidigBalans -= inzet;
            startController.UpdateBalans(huidigBalans);
            lblBalans.Text = $"{huidigBalans} RizzCoins";

            lblResultaat.Text = $"Gestart met inzet van {inzet} RizzCoins!";
            lblResultaat.Visible = true;

            btnVerdubbel.Enabled = true;
            btnUitcashen.Enabled = true;
        }

        // Verdubbel-knop: 50% kans om winst te verdubbelen of alles te verliezen
        private void btnVerdubbel_Click(object sender, EventArgs e)
        {
            bool winst = random.Next(2) == 0;

            if (winst)
            {
                huidigeWinst *= 2;
                lblResultaat.Text = $"Verdubbeld! Je hebt nu {huidigeWinst} RizzCoins.";
            }
            else
            {
                huidigeWinst = 0;
                lblResultaat.Text = "Helaas! Alles verloren...";
                btnVerdubbel.Enabled = false;
                btnUitcashen.Enabled = false;
            }

            lblResultaat.Visible = true;
        }

        // Uitcashen-knop
        private void btnUitcashen_Click(object sender, EventArgs e)
        {
            huidigBalans += huidigeWinst;
            startController.UpdateBalans(huidigBalans);
            lblBalans.Text = $"{huidigBalans} RizzCoins";

            lblResultaat.Text = $"Je hebt {huidigeWinst} RizzCoins gecasht!";
            lblResultaat.Visible = true;

            ResetSpel();
        }

        // Terug naar het hoofdmenu
        private void btnTerug_Click(object sender, EventArgs e)
        {
            NieuwBalans = startController.HaalBalansOp();
            this.Close();
        }

        // Bij sluiten van het formulier balans bijwerken
        private void DoubleOrNothingForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            NieuwBalans = startController.HaalBalansOp();
        }
    }
}
