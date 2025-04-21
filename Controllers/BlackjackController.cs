//███╗░░░███╗██╗██╗░░░░░░█████╗░███╗░░██╗░█████╗░░██████╗░██████╗
//████╗░████║██║██║░░░░░██╔══██╗████╗░██║██╔══██╗██╔════╝██╔════╝
//██╔████╔██║██║██║░░░░░███████║██╔██╗██║██║░░██║╚█████╗░╚█████╗░
//██║╚██╔╝██║██║██║░░░░░██╔══██║██║╚████║██║░░██║░╚═══██╗░╚═══██╗
//██║░╚═╝░██║██║███████╗██║░░██║██║░╚███║╚█████╔╝██████╔╝██████╔╝
//╚═╝░░░░░╚═╝╚═╝╚══════╝╚═╝░░╚═╝╚═╝░░╚══╝░╚════╝░╚═════╝░╚═════╝░

using RizzCasino.Models;
using System.Collections.Generic;

namespace RizzCasino.Controllers
{
    public class BlackjackController
    {
        private BlackjackModel model;
        private StartController startController;

        // Haalt het balans van de speler op via de StartController.
        public int GetBalans()
        {
            return startController.HaalBalansOp();
        }

        // Controleert of de opgegeven kaartencombinatie een bust is (boven de 21).
        public bool IsBusted(List<string> kaarten)
        {
            return model.IsBusted(kaarten);
        }

        // Constructor
        public BlackjackController()
        {
            model = new BlackjackModel();
            startController = new StartController();
        }

        // Start een nieuw spel met een bepaalde inzet en trekt dit van het balans af.
        public void StartNieuwSpel(int inzet)
        {
            int huidig = startController.HaalBalansOp();
            if (inzet > huidig) return;

            model.NieuwSpel(inzet);
            startController.UpdateBalans(huidig - inzet);
        }

        // Laat de speler een extra kaart trekken.
        public void SpelerHit()
        {
            model.TrekKaart(model.SpelerKaarten);
        }

        // Laat de dealer kaarten trekken totdat hij minimaal 17 heeft. 
        public void DealerSpeelt()
        {
            while (model.BerekenScore(model.DealerKaarten) < 17)
            {
                model.TrekKaart(model.DealerKaarten);
            }
        }

        // Bepaalt wie de winnaar is en past het balans aan op basis van de uitkomst.
        public string BepaalWinnaar()
        {
            int speler = model.BerekenScore(model.SpelerKaarten);
            int dealer = model.BerekenScore(model.DealerKaarten);

            if (model.IsBusted(model.SpelerKaarten))
                return "Dealer wint";

            if (model.IsBusted(model.DealerKaarten))
            {
                startController.UpdateBalans(startController.HaalBalansOp() + (model.Inzet * 2));
                return "Speler wint";
            }

            if (speler > dealer)
            {
                startController.UpdateBalans(startController.HaalBalansOp() + (model.Inzet * 2));
                return "Speler wint";
            }

            if (speler == dealer)
            {
                startController.UpdateBalans(startController.HaalBalansOp() + model.Inzet);
                return "Gelijkspel";
            }

            return "Dealer wint";
        }

        // Geeft de huidige kaarten van de speler terug.
        public List<string> GetSpelerKaarten() => model.SpelerKaarten;

        // Geeft de huidige kaarten van de dealer terug.
        public List<string> GetDealerKaarten() => model.DealerKaarten;

        // Geeft de huidige score van de speler terug.
        public int GetSpelerScore() => model.BerekenScore(model.SpelerKaarten);

        // Geeft de huidige score van de dealer terug.
        public int GetDealerScore() => model.BerekenScore(model.DealerKaarten);

        // Geeft de huidige inzet van het spel terug.
        public int HaalInzet() => model.Inzet;
    }
}
