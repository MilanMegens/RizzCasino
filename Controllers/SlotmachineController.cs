//███╗░░░███╗██╗██╗░░░░░░█████╗░███╗░░██╗░█████╗░░██████╗░██████╗
//████╗░████║██║██║░░░░░██╔══██╗████╗░██║██╔══██╗██╔════╝██╔════╝
//██╔████╔██║██║██║░░░░░███████║██╔██╗██║██║░░██║╚█████╗░╚█████╗░
//██║╚██╔╝██║██║██║░░░░░██╔══██║██║╚████║██║░░██║░╚═══██╗░╚═══██╗
//██║░╚═╝░██║██║███████╗██║░░██║██║░╚███║╚█████╔╝██████╔╝██████╔╝
//╚═╝░░░░░╚═╝╚═╝╚══════╝╚═╝░░╚═╝╚═╝░░╚══╝░╚════╝░╚═════╝░╚═════╝░

using RizzCasino.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RizzCasino.Controllers
{
    class SlotmachineController
    {
        private Slotmachine slotmachine;

        // Constructor
        public SlotmachineController()
        {
            slotmachine = new Slotmachine();
        }

        // Draait de slotmachine en geeft de symbolen terug
        public string[] DraaiSlot()
        {
            return slotmachine.Draai();
        }

        // Controleert of de gedraaide symbolen een win zijn
        public bool ControleerWinst(string[] symbolen)
        {
            return slotmachine.IsWinst(symbolen);
        }

        // Berekent de winst
        public int BerekenWinst(string[] symbolen, int inzet)
        {
            return slotmachine.BerekenWinst(symbolen, inzet);
        }
    }
}
