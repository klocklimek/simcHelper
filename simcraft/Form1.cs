using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace simcraft
{
    public partial class Form1 : Form
    {
        menedzerEq menedzer = new menedzerEq();
        string[] slot = { "Head", "Neck", "Shoulder", "Back", "Chest", "Wrist", "Hands", "Waist", "Legs", "Feet", "Ring", "Trinket", "Main hand", "Off hand" };
        string[] sloty = { "head", "neck", "shoulder", "back", "chest", "wrist", "hands", "waist", "legs", "feet", "finger1", "trinket1", "main_hand", "off_hand", "finger2", "trinket2" };

        public Form1()
        {
            InitializeComponent();
            list_doWyboru.DataSource = slot;
        }

        private void btn_importujEq_Click(object sender, EventArgs e)
        {
            import importOkno = new import(ref menedzer);
            importOkno.FormClosed += new FormClosedEventHandler(list_doWyboru_SelectedIndexChanged);
            importOkno.Show();
            btn_Zapisz.Enabled = true;

        }

        private void list_doWyboru_SelectedIndexChanged(object sender, EventArgs e)
        {
            listaPrzedmiotow.Items.Clear();
            foreach (przedmiot przed in menedzer.listaKategorii[this.list_doWyboru.SelectedIndex].listaPrzedmiotow)
            { 
                listaPrzedmiotow.Items.Add(przed.nazwa, przed.czyZaznaczony);
            }
        }

        private void listaPrzedmiotow_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            int indeks = Math.Abs(e.Index - (menedzer.listaKategorii[list_doWyboru.SelectedIndex].listaPrzedmiotow.Count - 1));
            bool wartosc = Convert.ToBoolean(e.NewValue);
            menedzer.listaKategorii[list_doWyboru.SelectedIndex].listaPrzedmiotow[e.Index].czyZaznaczony = wartosc;
        }

        private void btn_generuj_Click(object sender, EventArgs e)
        {
            string doEksportowania = "";
            kategoria[] listaKategorii = new kategoria[14];
            int liczbaLegend = 0;
            for (int kategoria = 0; kategoria < 14; kategoria++)
            {
                listaKategorii[kategoria] = new kategoria();
            }
            for (int indeksListKategorii = 0; indeksListKategorii < 14; indeksListKategorii++)
            {
                foreach (przedmiot przed in menedzer.listaKategorii[indeksListKategorii].listaPrzedmiotow)
                {
                    if (przed.czyZaznaczony)
                    {
                        listaKategorii[indeksListKategorii].listaPrzedmiotow.Add(przed);
                    }
                }
                if (listaKategorii[indeksListKategorii].listaPrzedmiotow.Count == 1)
                {
                    doEksportowania += sloty[indeksListKategorii] + "=" + listaKategorii[indeksListKategorii].listaPrzedmiotow[0].kod + "\n";
                    if (listaKategorii[indeksListKategorii].listaPrzedmiotow[0].czyLegenda)
                    {
                        liczbaLegend++;
                    }
                    listaKategorii[indeksListKategorii].listaPrzedmiotow.Clear();
                }
                else if (listaKategorii[indeksListKategorii].listaPrzedmiotow.Count == 2 && (indeksListKategorii == 10 || indeksListKategorii == 11))
                {
                    doEksportowania += sloty[indeksListKategorii] + "=" + listaKategorii[indeksListKategorii].listaPrzedmiotow[0].kod + "\n";
                    doEksportowania += sloty[indeksListKategorii + 4] + "=" + listaKategorii[indeksListKategorii].listaPrzedmiotow[1].kod + "\n";
                    listaKategorii[indeksListKategorii].listaPrzedmiotow.Clear();
                }
            }
            string nowy = "";
            generujKopie(ref listaKategorii,ref doEksportowania, nowy,ref  doEksportowania, nowy,-1,liczbaLegend);
            doEksportowania = menedzer.apl + "\n\n" + doEksportowania;
            wyjscie okno = new simcraft.wyjscie(doEksportowania);
            okno.Show();

        }
        private void generujKopie(ref kategoria[] listaKategorii, ref string wynikowy, string tmp, ref string wynikowyApl, string tmpApl, int pozycja = -1, int liczbaLegend = 0)
        {
            if (pozycja == -1)
            {
                tmp = "copy=";
                tmpApl = "";
                generujKopie(ref listaKategorii, ref wynikowy, tmp, ref wynikowyApl, tmpApl, pozycja + 1, liczbaLegend);
            }
            else
            {
                int i = 0;
                for (i = pozycja ; i < 14; ++i)
                {
                    if (listaKategorii[i].listaPrzedmiotow.Count > 0)
                    {
                        if (i != 10 && i != 11)
                        {
                            foreach (przedmiot przed in listaKategorii[i].listaPrzedmiotow)
                            {
                                string[] nazwaBezSpacji = przed.nazwa.Split(new string[] { " " }, StringSplitOptions.None);
                                string nazwa = "";
                                foreach (string czesc in nazwaBezSpacji)
                                {
                                    nazwa += czesc;
                                }
                                string tmp2 = tmp + (tmp.Length == 5 ? "": "_") + nazwa;
                                string tmpApl2 = "";
                                tmpApl2 += tmpApl;
                                tmpApl2 += sloty[i] + "=" + przed.kod + "\n";
                                if (przed.czyLegenda)
                                {
                                    generujKopie(ref listaKategorii, ref wynikowy, tmp2, ref wynikowyApl, tmpApl2, i + 1,liczbaLegend+1);
                                }
                                generujKopie(ref listaKategorii, ref wynikowy, tmp2,ref wynikowyApl,tmpApl2, i+1,liczbaLegend);

                            }
                        }else
                        {
                            string tmp2 = tmp + (tmp.Length == 5 ? "" : "_");
                            for (int nrTrinketu = 0; nrTrinketu < listaKategorii[i].listaPrzedmiotow.Count-1; nrTrinketu++)
                            {
                                int tmpLiczbaLegend = liczbaLegend;
                                string[] nazwaBezSpacji = listaKategorii[i].listaPrzedmiotow[nrTrinketu].nazwa.Split(new string[] { " " }, StringSplitOptions.None);
                                string nazwa = "";
                                foreach (string czesc in nazwaBezSpacji)
                                {
                                    nazwa += czesc;
                                }
                                string tmp3 = tmp2 + (tmp2.Length == 5 ? "" : "_") + nazwa;
                                string tmpApl2 = "";
                                tmpApl2 += tmpApl;
                                tmpApl2 += sloty[i] + "=" + listaKategorii[i].listaPrzedmiotow[nrTrinketu].kod + "\n";
                                if (listaKategorii[i].listaPrzedmiotow[nrTrinketu].czyLegenda)
                                {
                                    tmpLiczbaLegend++;
                                }
                                for (int nrTrinketuP = nrTrinketu+1; nrTrinketuP < listaKategorii[i].listaPrzedmiotow.Count; nrTrinketuP++)
                                {
                                    int tmpLiczbaLegend2 = tmpLiczbaLegend;
                                    string[] nazwaBezSpacjiP = listaKategorii[i].listaPrzedmiotow[nrTrinketuP].nazwa.Split(new string[] { " " }, StringSplitOptions.None);
                                    string nazwaP = "";
                                    foreach (string czesc in nazwaBezSpacjiP)
                                    {
                                        nazwaP += czesc;
                                    }
                                    string tmp4 = tmp3 + (tmp3.Length == 6 ? "" :"_") + nazwaP;
                                    string tmpApl3 = tmpApl2;
                                    tmpApl3 += sloty[i+4] + "=" + listaKategorii[i].listaPrzedmiotow[nrTrinketuP].kod + "\n";
                                    if (listaKategorii[i].listaPrzedmiotow[nrTrinketuP].czyLegenda)
                                    {
                                        tmpLiczbaLegend2++;
                                    }

                                    generujKopie(ref listaKategorii, ref wynikowy, tmp4,ref wynikowyApl,tmpApl3, i+1,tmpLiczbaLegend2);
                                }
                            }
                        }
                        break;
                    }
                }
                if (i == 14&& tmp.Length != 5 && liczbaLegend <= 2)
                {
                    wynikowy += tmp;
                    wynikowy += "\n";
                    wynikowy += tmpApl;
                }
            }
        }

        private void listaPrzedmiotow_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btn_Zapisz_Click(object sender, EventArgs e)
        {
            Stream strim = File.Open("dane.bin", FileMode.Create);
            var konwerter = new System.Runtime.Serialization.Formatters.Binary.BinaryFormatter();
            konwerter.Serialize(strim, menedzer);
            strim.Close();
        }

        private void btn_wczytaj_Click(object sender, EventArgs e)
        {
            try
            {
                Stream strim = File.Open("dane.bin", FileMode.Open);
                var konwerter = new System.Runtime.Serialization.Formatters.Binary.BinaryFormatter();
                menedzer = konwerter.Deserialize(strim) as menedzerEq;
                list_doWyboru.SelectedIndex = 1;
                list_doWyboru.SelectedIndex = 0;
                btn_Zapisz.Enabled = true;
                strim.Close();

            }
            catch(FileNotFoundException f)
            {
                return;
            }
          
        }

        private void btn_usunItem_Click(object sender, EventArgs e)
        {
            var indeks = listaPrzedmiotow.SelectedIndex;
            menedzer.listaKategorii[list_doWyboru.SelectedIndex].listaPrzedmiotow.RemoveAt(indeks);
            indeks = list_doWyboru.SelectedIndex;
            list_doWyboru.SelectedIndex = 1;
            list_doWyboru.SelectedIndex = 0;
            list_doWyboru.SelectedIndex = indeks;

        }

        private void btn_modyfApl_Click(object sender, EventArgs e)
        {
            modApl okno = new modApl(ref menedzer);
            okno.Show();
        }
    }
}
