using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RizzCasino.Controllers;

namespace RizzCasino.Views
{
    public partial class StartScherm : Form
    {
        private StartController controller;

        // Constructor
        public StartScherm()
        {
            InitializeComponent();

            controller = new StartController();
            int balans = controller.HaalBalansOp();
            lblBalans.Text = $"{balans} RizzCoins";
        }

        // Functie om de balans bij te werken
        private void UpdateBalans()
        {
            controller = new StartController();
            int balans = controller.HaalBalansOp();
            lblBalans.Text = $"{balans} RizzCoins";
        }

        // Functie voor het openen van de Slotmachine
        private void btnSlotmachine_Click(object sender, EventArgs e)
        {
            using (SlotmachineForm slotForm = new SlotmachineForm()) 
            {
                this.Hide(); 
                slotForm.ShowDialog();
                this.Show(); 

                int nieuwBalans = slotForm.NieuwBalans;
                lblBalans.Text = $"{nieuwBalans} RizzCoins";
            }
        }

        // Functie voor het openen van Blackjack
        private void btnBlackjack_Click(object sender, EventArgs e)
        {
            using (BlackjackForm bjForm = new BlackjackForm()) 
            {
                this.Hide();
                bjForm.ShowDialog(); 
                this.Show();

                UpdateBalans(); 
            }
        }

        // Functie voor het openen van Dobbelsteen Duel
        private void btnDobbelsteen_Click(object sender, EventArgs e)
        {
            using (DobbelsteenDuelForm duelForm = new DobbelsteenDuelForm())
            {
                this.Hide(); 
                duelForm.ShowDialog(); 
                this.Show();

                int nieuwBalans = duelForm.NieuwBalans; 
                lblBalans.Text = $"{nieuwBalans} RizzCoins";
            }
        }

        // Functie voor het openen van Double or Nothing
        private void btnDoubleOrNothing_Click(object sender, EventArgs e)
        {
            using (DoubleOrNothingForm donForm = new DoubleOrNothingForm()) 
            {
                this.Hide(); 
                donForm.ShowDialog();
                this.Show();

                int nieuwBalans = donForm.NieuwBalans;
                lblBalans.Text = $"{nieuwBalans} RizzCoins";
            }
        }
    }
}
