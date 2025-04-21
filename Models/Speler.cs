//███╗░░░███╗██╗██╗░░░░░░█████╗░███╗░░██╗░█████╗░░██████╗░██████╗
//████╗░████║██║██║░░░░░██╔══██╗████╗░██║██╔══██╗██╔════╝██╔════╝
//██╔████╔██║██║██║░░░░░███████║██╔██╗██║██║░░██║╚█████╗░╚█████╗░
//██║╚██╔╝██║██║██║░░░░░██╔══██║██║╚████║██║░░██║░╚═══██╗░╚═══██╗
//██║░╚═╝░██║██║███████╗██║░░██║██║░╚███║╚█████╔╝██████╔╝██████╔╝
//╚═╝░░░░░╚═╝╚═╝╚══════╝╚═╝░░╚═╝╚═╝░░╚══╝░╚════╝░╚═════╝░╚═════╝░

using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RizzCasino.Models
{
    class Speler
    {
        // Variabele voor balans
        public int Balans = 0;

        // Pad naar balansbestand
        private readonly string bestandPad = "balans.txt";

        // Functie om de balans van de speler op te halen uit versleuteld balans.txt
        public void LaadBalans()
        {
            if (File.Exists(bestandPad))
            {
                try
                {
                    string encrypted = File.ReadAllText(bestandPad);
                    string decrypted = Encoding.UTF8.GetString(Convert.FromBase64String(encrypted));
                    Balans = int.Parse(decrypted);
                }
                catch
                {
                    Balans = 1000;
                }
            }
            else
            {
                Balans = 1000;
            }
        }

        // Functie om de balans op te slaan in balans.txt
        public void BalansOpslaan()
        {
            string plainText = Balans.ToString();
            string encrypted = Convert.ToBase64String(Encoding.UTF8.GetBytes(plainText));
            File.WriteAllText(bestandPad, encrypted);
        }
    }
}
