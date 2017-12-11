using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace simcraft
{
    [Serializable]
    public class menedzerEq
    {
        public string apl = "";
        public kategoria[] listaKategorii = new kategoria[14];
        /*
         * 1    head
         * 2    neck
         * 3    shoulders
         * 4    cape
         * 5    chest
         * 6    wrist
         * 7    hands
         * 8    waist
         * 9    legs
         * 10   boots
         * 11   ring
         * 12   trinket
         * 13   main hand
         * 14   off hand
         */
        public menedzerEq()
        {
            for(int kategoria = 0; kategoria < 14; kategoria++)
            {
                listaKategorii[kategoria] = new kategoria();
            }
        }
        public void dodajPrzedmiot(string tekstZSimc)
        {
            string[] wynik = tekstZSimc.Split(new string[] { "=" },2,StringSplitOptions.None);
            switch (wynik[0])
            {
                case "head":  listaKategorii[0].dodajPrzedmiot(wynik[1]); break;
                case "neck":  listaKategorii[1].dodajPrzedmiot(wynik[1]); break;
                case "shoulder":  listaKategorii[2].dodajPrzedmiot(wynik[1]); break;
                case "shoulders": listaKategorii[2].dodajPrzedmiot(wynik[1]); break;
                case "back":  listaKategorii[3].dodajPrzedmiot(wynik[1]); break;
                case "chest":  listaKategorii[4].dodajPrzedmiot(wynik[1]); break;
                case "wrist":  listaKategorii[5].dodajPrzedmiot(wynik[1]); break;
                case "wrists": listaKategorii[5].dodajPrzedmiot(wynik[1]); break;
                case "hands":  listaKategorii[6].dodajPrzedmiot(wynik[1]); break;
                case "waist":  listaKategorii[7].dodajPrzedmiot(wynik[1]); break;
                case "legs":  listaKategorii[8].dodajPrzedmiot(wynik[1]); break;
                case "feet":  listaKategorii[9].dodajPrzedmiot(wynik[1]); break;
                case "finger1":  listaKategorii[10].dodajPrzedmiot(wynik[1]); break;
                case "finger2":  listaKategorii[10].dodajPrzedmiot(wynik[1]); break;
                case "trinket1":  listaKategorii[11].dodajPrzedmiot(wynik[1]); break;
                case "trinket2":  listaKategorii[11].dodajPrzedmiot(wynik[1]); break;
                case "main_hand":  listaKategorii[12].dodajPrzedmiot(wynik[1]); break;
                case "off_hand":  listaKategorii[13].dodajPrzedmiot(wynik[1]); break;
                default: break;
            }

        }
    }
}
