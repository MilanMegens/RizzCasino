//███╗░░░███╗██╗██╗░░░░░░█████╗░███╗░░██╗░█████╗░░██████╗░██████╗
//████╗░████║██║██║░░░░░██╔══██╗████╗░██║██╔══██╗██╔════╝██╔════╝
//██╔████╔██║██║██║░░░░░███████║██╔██╗██║██║░░██║╚█████╗░╚█████╗░
//██║╚██╔╝██║██║██║░░░░░██╔══██║██║╚████║██║░░██║░╚═══██╗░╚═══██╗
//██║░╚═╝░██║██║███████╗██║░░██║██║░╚███║╚█████╔╝██████╔╝██████╔╝
//╚═╝░░░░░╚═╝╚═╝╚══════╝╚═╝░░╚═╝╚═╝░░╚══╝░╚════╝░╚═════╝░╚═════╝░

using System;
using System.Drawing;
using System.Windows.Forms;
using System.Threading.Tasks;
using RizzCasino.Controllers;

namespace RizzCasino.Views
{
    public partial class DobbelsteenDuelForm : Form
    {
        private Random random = new Random();
        private StartController startController;

        public int NieuwBalans { get; private set; }

        // Constructor
        public DobbelsteenDuelForm()
        {
            InitializeComponent();
            startController = new StartController();
            NieuwBalans = startController.HaalBalansOp();
            lblBalans.Text = $"{NieuwBalans} RizzCoins";

            nudInzet.Minimum = 1;
            nudInzet.Maximum = NieuwBalans;
        }

        // Gooi knop
        // Computer kiest een random nummer en die image laat hij zien met delays er tussen voor overzichtelijkheid
        private async void btnGooi_Click(object sender, EventArgs e)
        {
            lblResultaat.Visible = false;
            picBot.Image = null;
            picSpeler.Image = null;

            int inzet = (int)nudInzet.Value;

            if (inzet > NieuwBalans)
            {
                MessageBox.Show("Niet genoeg RizzCoins!");
                return;
            }

            await Task.Delay(500);

            int botWorp = random.Next(1, 7);
            picBot.Image = Image.FromFile($"Resources/dobbel{botWorp}.png");

            await Task.Delay(1000);

            int spelerWorp = random.Next(1, 7);
            picSpeler.Image = Image.FromFile($"Resources/dobbel{spelerWorp}.png");

            await Task.Delay(500);

            string resultaat;
            if (spelerWorp > botWorp)
            {
                NieuwBalans += inzet;
                resultaat = $"Je wint! +{inzet} RizzCoins";
                lblResultaat.ForeColor = Color.Green;
            }
            else if (spelerWorp < botWorp)
            {
                NieuwBalans -= inzet;
                resultaat = $"Je verliest! -{inzet} RizzCoins";
                lblResultaat.ForeColor = Color.Red;
            }
            else
            {
                resultaat = "Gelijkspel! Geen winst of verlies.";
                lblResultaat.ForeColor = Color.Black;
            }

            startController.UpdateBalans(NieuwBalans);
            lblBalans.Text = $"{NieuwBalans} RizzCoins";
            nudInzet.Maximum = NieuwBalans;

            lblResultaat.Text = resultaat;
            lblResultaat.Visible = true;
        }

        // Knop om terug te gaan naar het hoofdmenu
        private void btnTerug_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // Bij sluiten van het spel wordt het laatste balans opgehaald
        private void DobbelsteenDuelForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            NieuwBalans = startController.HaalBalansOp();
        }
    }
}
