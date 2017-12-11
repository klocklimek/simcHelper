using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace simcraft
{
    [Serializable]
    public class kategoria
    {
        public List<przedmiot> listaPrzedmiotow = new List<przedmiot>();
        public void dodajPrzedmiot(string przedmiot)
        {
            listaPrzedmiotow.Add(new przedmiot(przedmiot));
        }
    }
}
