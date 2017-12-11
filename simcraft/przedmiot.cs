using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace simcraft
{
    [Serializable]
    public class przedmiot
    {
        public bool czyZaznaczony;
        public bool czyLegenda;
        public string nazwa;
        public string kod;
        public przedmiot(string kod, bool czyZaznaczyc = true)
        {
            this.kod = kod;
            nazwa = znajdzNazwe();
            czyZaznaczony = czyZaznaczyc;
        }
        public string znajdzNazwe()
        {
            string[] idx = kod.Split(new string[] { "," }, StringSplitOptions.None);
            string id = idx[1];
            idx = id.Split(new string[] { "=" }, StringSplitOptions.None);
            id = idx[1];
            string url = "http://www.wowhead.com/item=" + id + "&xml";
            XmlDocument itemXml = new XmlDocument();
            itemXml.Load(url);
            if (itemXml.SelectSingleNode("/wowhead/item/quality").Attributes["id"].Value == "5")
            {
                czyLegenda = true;
            }
            else czyLegenda = false;
            return itemXml.SelectSingleNode("/wowhead/item/name").InnerText;
        }
    }

}
