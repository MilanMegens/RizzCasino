using System;
using System.Collections.Generic;

namespace RizzCasino.Models
{
    public class BlackjackModel
    {
        public List<string> SpelerKaarten { get; private set; }
        public List<string> DealerKaarten { get; private set; }
        public List<string> Deck { get; private set; }
        public int Inzet { get; private set; }

        private Random random = new Random();

        // Start een nieuw blackjackspel met een bepaalde inzet.
        public void NieuwSpel(int inzet)
        {
            Inzet = inzet;
            SpelerKaarten = new List<string>();
            DealerKaarten = new List<string>();
            Deck = GenereerDeck();
            SchudDeck();

            TrekKaart(SpelerKaarten);
            TrekKaart(SpelerKaarten);
            TrekKaart(DealerKaarten);
            TrekKaart(DealerKaarten);
        }

        // Genereert een standaard kaartendeck met 52 kaarten.
        private List<string> GenereerDeck()
        {
            var deck = new List<string>();
            string[] soorten = { "Harten", "Ruiten", "Klaveren", "Schoppen" };
            string[] waarden = { "2", "3", "4", "5", "6", "7", "8", "9", "10", "Boer", "Vrouw", "Heer", "Aas" };

            foreach (var soort in soorten)
            {
                foreach (var waarde in waarden)
                {
                    deck.Add($"{waarde} van {soort}");
                }
            }

            return deck;
        }

        // Schudt het kaartendeck met Fisher-Yates algoritme.
        private void SchudDeck()
        {
            for (int i = Deck.Count - 1; i > 0; i--)
            {
                int j = random.Next(i + 1);
                var temp = Deck[i];
                Deck[i] = Deck[j];
                Deck[j] = temp;
            }
        }

        // Trekt de bovenste kaart van het deck en voegt deze toe aan de opgegeven hand.
        public void TrekKaart(List<string> hand)
        {
            if (Deck.Count > 0)
            {
                hand.Add(Deck[0]);
                Deck.RemoveAt(0);
            }
        }

        // Berekent de totale score van een hand, met juiste behandeling van azen.
        public int BerekenScore(List<string> hand)
        {
            int score = 0;
            int azen = 0;

            foreach (var kaart in hand)
            {
                string waarde = kaart.Split(' ')[0];
                if (int.TryParse(waarde, out int num))
                {
                    score += num;
                }
                else if (waarde == "Boer" || waarde == "Vrouw" || waarde == "Heer")
                {
                    score += 10;
                }
                else if (waarde == "Aas")
                {
                    azen++;
                    score += 11;
                }
            }

            // Verlaag score voor azen als score > 21
            while (score > 21 && azen > 0)
            {
                score -= 10;
                azen--;
            }

            return score;
        }

        // Controleert of een hand bust is (score > 21).
        public bool IsBusted(List<string> hand)
        {
            return BerekenScore(hand) > 21;
        }
    }
}
