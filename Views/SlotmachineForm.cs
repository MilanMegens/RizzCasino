//███╗░░░███╗██╗██╗░░░░░░█████╗░███╗░░██╗░█████╗░░██████╗░██████╗
//████╗░████║██║██║░░░░░██╔══██╗████╗░██║██╔══██╗██╔════╝██╔════╝
//██╔████╔██║██║██║░░░░░███████║██╔██╗██║██║░░██║╚█████╗░╚█████╗░
//██║╚██╔╝██║██║██║░░░░░██╔══██║██║╚████║██║░░██║░╚═══██╗░╚═══██╗
//██║░╚═╝░██║██║███████╗██║░░██║██║░╚███║╚█████╔╝██████╔╝██████╔╝
//╚═╝░░░░░╚═╝╚═╝╚══════╝╚═╝░░╚═╝╚═╝░░╚══╝░╚════╝░╚═════╝░╚═════╝░

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;
using RizzCasino.Controllers;
using RizzCasino.Views;

namespace RizzCasino.Views
{
    public partial class SlotmachineForm : Form
    {
        private SlotmachineController slotController;
        private StartController startController;
        public int NieuwBalans { get; private set; }

        // Constructor
        public SlotmachineForm()
        {
            InitializeComponent();
            slotController = new SlotmachineController();
            startController = new StartController();

            lblBalans.Text = $"{startController.HaalBalansOp()} RizzCoins";
            nudInzet.Minimum = 1;
            nudInzet.Maximum = startController.HaalBalansOp();
        }

        // Draai de slotmachine
        private async void btnDraai_Click(object sender, EventArgs e)
        {
            int inzet = (int)nudInzet.Value;
            int huidigBalans = startController.HaalBalansOp();

            if (inzet > huidigBalans)
            {
                MessageBox.Show("Je hebt niet genoeg RizzCoins!", "Fout", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string[] resultaat = slotController.DraaiSlot();
            lblSymbool1.Text = "";
            lblSymbool2.Text = "";
            lblSymbool3.Text = "";

            await Task.Delay(500);
            lblSymbool1.Text = resultaat[0];

            await Task.Delay(500);
            lblSymbool2.Text = resultaat[1];

            await Task.Delay(500);
            lblSymbool3.Text = resultaat[2];

            bool isWinst = slotController.ControleerWinst(resultaat);
            int winst = slotController.BerekenWinst(resultaat, inzet);

            int nieuwBalans = huidigBalans - inzet + winst;
            startController.UpdateBalans(nieuwBalans); 
            NieuwBalans = nieuwBalans;
            lblBalans.Text = $"{nieuwBalans} RizzCoins";

            if (isWinst)
            {
                MessageBox.Show($"🎉 Je hebt gewonnen! +{winst - inzet} RizzCoins!", "Gewonnen!", MessageBoxButtons.OK);
            }
            else
            {
                MessageBox.Show($"Helaas, je verloor {inzet} RizzCoins 😢", "Verloren!", MessageBoxButtons.OK);
            }

            nudInzet.Maximum = nieuwBalans > 0 ? nieuwBalans : 1;
        }

        // Terug naar het hoofdmenu
        private void BackHomeBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // Bij sluiten van het formulier balans bijwerken
        private void SlotmachineForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            NieuwBalans = startController.HaalBalansOp();
        }
    }
}
