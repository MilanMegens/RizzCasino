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

namespace RizzCasino.Models
{
    class Slotmachine
    {
        // Deze 2 functies maakt een string met alle symbolen en kiest daarna een random symbool
        public string[] symbolen = { "🍒", "🍋", "🔔", "⭐", "💎" };
        private Random random = new Random();

        // Deze functie laat 3 random symbolen draaien
        public string[] Draai()
        {
            string[] resultaat = new string[3];

            for (int i = 0; i < 3; i++)
            {
                int index = random.Next(symbolen.Length);
                resultaat[i] = symbolen[index];
            }

            return resultaat;
        }

        // Hier kijkt hij of er een winst is
        public bool IsWinst(string[] resultaat)
        {
            return resultaat[0] == resultaat[1] || resultaat[1] == resultaat[2] || resultaat[0] == resultaat[2];
        }

        // Hier berekend hij de winst
        public int BerekenWinst(string[] resultaat, int inzet)
        {
            if (resultaat[0] == resultaat[1] && resultaat[1] == resultaat[2])
                return inzet * 5;
            else if (resultaat[0] == resultaat[1] || resultaat[1] == resultaat[2] || resultaat[0] == resultaat[2])
                return inzet * 2;
            else
                return 0;
        }
    }
}
