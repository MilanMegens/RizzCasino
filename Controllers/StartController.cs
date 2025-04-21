//███╗░░░███╗██╗██╗░░░░░░█████╗░███╗░░██╗░█████╗░░██████╗░██████╗
//████╗░████║██║██║░░░░░██╔══██╗████╗░██║██╔══██╗██╔════╝██╔════╝
//██╔████╔██║██║██║░░░░░███████║██╔██╗██║██║░░██║╚█████╗░╚█████╗░
//██║╚██╔╝██║██║██║░░░░░██╔══██║██║╚████║██║░░██║░╚═══██╗░╚═══██╗
//██║░╚═╝░██║██║███████╗██║░░██║██║░╚███║╚█████╔╝██████╔╝██████╔╝
//╚═╝░░░░░╚═╝╚═╝╚══════╝╚═╝░░╚═╝╚═╝░░╚══╝░╚════╝░╚═════╝░╚═════╝░

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RizzCasino.Models;

namespace RizzCasino.Controllers
{
    class StartController
    {
        private Speler speler;

        // Constructor
        public StartController()
        {
            speler = new Speler();
            speler.LaadBalans();
        }

        // Haalt het huidige balans op
        public int HaalBalansOp()
        {
            return speler.Balans;
        }

        // Update balans en slaat op
        public void UpdateBalans(int nieuwBalans)
        {
            speler.Balans = nieuwBalans;
            speler.BalansOpslaan();
        }
    }
}