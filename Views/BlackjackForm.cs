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
    public partial class BlackjackForm : Form
    {
        private BlackjackController controller;
        private StartController startController;

        // Houdt het nieuwe balans bij bij het verlaten van het formulier
        public int NieuwBalans { get; private set; }

        // Constructro
        public BlackjackForm()
        {
            InitializeComponent();
            this.Text = "Blackjack";
            controller = new BlackjackController();
            startController = new StartController();

            flpSpelerKaarten.Resize += (s, e) => CenterKaartenInPanel(flpSpelerKaarten);
            flpDealerKaarten.Resize += (s, e) => CenterKaartenInPanel(flpDealerKaarten);

            nudInzet.Minimum = 1;
            nudInzet.Maximum = startController.HaalBalansOp();

            lblBalans.Text = $"{startController.HaalBalansOp()} RizzCoins";
        }

        // Start een nieuw spel met de gekozen inzet
        private void StartNieuwSpel()
        {
            int inzet = (int)nudInzet.Value;
            int huidigBalans = startController.HaalBalansOp();

            btnStand.Enabled = true;
            btnHit.Enabled = true;

            if (inzet > huidigBalans)
            {
                MessageBox.Show("Je hebt niet genoeg RizzCoins!", "Fout", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            controller.StartNieuwSpel(inzet);
            LaadKaartenOpScherm();
            UpdateStatus();
        }

        // Laadt de kaarten en scores van speler en dealer op het scherm
        private void LaadKaartenOpScherm()
        {
            flpSpelerKaarten.Controls.Clear();
            flpDealerKaarten.Controls.Clear();

            var spelerKaarten = controller.GetSpelerKaarten();
            var dealerKaarten = controller.GetDealerKaarten();

            int spelerScore = controller.GetSpelerScore();
            int dealerScore = controller.GetDealerScore();

            foreach (var kaart in spelerKaarten)
            {
                string afbeelding = KaartNaamNaarBestandsnaam(kaart);
                PictureBox pb = new PictureBox();
                pb.ImageLocation = $"Resources/Kaarten/{afbeelding}";
                pb.SizeMode = PictureBoxSizeMode.StretchImage;
                pb.Width = 60;
                pb.Height = 90;
                flpSpelerKaarten.Controls.Add(pb);
            }

            foreach (var kaart in dealerKaarten)
            {
                string afbeelding = KaartNaamNaarBestandsnaam(kaart);
                PictureBox pb = new PictureBox();
                pb.ImageLocation = $"Resources/Kaarten/{afbeelding}";
                pb.SizeMode = PictureBoxSizeMode.StretchImage;
                pb.Width = 60;
                pb.Height = 90;
                flpDealerKaarten.Controls.Add(pb);
            }

            CenterKaartenInPanel(flpSpelerKaarten);
            CenterKaartenInPanel(flpDealerKaarten);

            lblSpelerScore.Text = $"Totaal: {spelerScore}";
            lblDealerScore.Text = $"Totaal: {dealerScore}";
        }

        // Zorgt dat de bestandsnaam klopt van de kaart
        private string KaartNaamNaarBestandsnaam(string kaart)
        {
            string[] delen = kaart.Split(' ');
            string waarde = delen[0].ToLower();
            string soort = delen[2].ToLower();

            waarde = waarde switch
            {
                "boer" => "jack",
                "vrouw" => "queen",
                "heer" => "king",
                "aas" => "ace",
                _ => waarde
            };

            soort = soort switch
            {
                "harten" => "hearts",
                "ruiten" => "diamonds",
                "klaveren" => "clubs",
                "schoppen" => "spades",
                _ => soort
            };

            return $"{waarde}_of_{soort}.png";
        }

        // Centered kaarten in de panel
        private void CenterKaartenInPanel(FlowLayoutPanel flp)
        {
            int totalKaartBreedte = 0;

            foreach (Control ctrl in flp.Controls)
                totalKaartBreedte += ctrl.Width + ctrl.Margin.Horizontal;

            int leftPadding = Math.Max((flp.ClientSize.Width - totalKaartBreedte) / 2, 0);
            flp.Padding = new Padding(leftPadding, 0, 0, 0);
        }

        // Update de balans op het scherm
        private void UpdateStatus()
        {
            lblBalans.Text = $"{controller.GetBalans()} RizzCoins";
        }

        // Knop als speler op "Hit" klikt
        private void btnHit_Click(object sender, EventArgs e)
        {
            controller.SpelerHit();
            LaadKaartenOpScherm();

            if (controller.IsBusted(controller.GetSpelerKaarten()))
            {
                MessageBox.Show("Bust!", "Verloren");
                UpdateStatus();
                btnHit.Enabled = false;
                btnStand.Enabled = false;
            }

            UpdateStatus();
            nudInzet.Maximum = startController.HaalBalansOp();
        }

        // Knop voor als speler op "Stand" klikt
        private void btnStand_Click(object sender, EventArgs e)
        {
            controller.DealerSpeelt();
            LaadKaartenOpScherm();

            string resultaat = controller.BepaalWinnaar();
            MessageBox.Show(resultaat);

            UpdateStatus();
            btnHit.Enabled = false;
            btnStand.Enabled = false;
            nudInzet.Maximum = startController.HaalBalansOp();
        }

        // Knop voor een nieuw potje
        private void btnNieuwSpel_Click(object sender, EventArgs e)
        {
            btnHit.Enabled = true;
            btnStand.Enabled = true;
            StartNieuwSpel();
        }

        // Sluit het formulier en geef het huidige balans mee
        private void btnTerug_Click(object sender, EventArgs e)
        {
            NieuwBalans = startController.HaalBalansOp();
            this.Close();
        }

        // Bij sluiten van het formulier, bewaar het balans
        private void BlackjackForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            NieuwBalans = startController.HaalBalansOp();
        }
    }
}
