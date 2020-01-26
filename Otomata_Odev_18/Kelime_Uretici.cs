using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Otomata_Odev_18
{
    class Kelime_Uretici
    {
        Duzenli_Ifade_Okuyucu Duzenli_Ifade_Okuma = new Duzenli_Ifade_Okuyucu();
        Hesaplama Hesapla = new Hesaplama();

        private List<Tuple<List<string>, Boolean, Boolean>> Duzenli_Ifade;
        private Boolean Izin;

        public Kelime_Uretici(String Alfabe, String Duzenli_Ifade_String)
        {
            foreach (var i in Duzenli_Ifade_String)
            {
                if (i != '*' && i != '+' && i != '(' && i != ')' && !Alfabe.Contains(i.ToString()))
                {
                    Console.WriteLine("Alfabeden düzenli ifade üretilemez !");
                    return;
                }
            }

            Console.WriteLine("Alfabeden düzenli ifade üretilebilir !");
            Izin = true;
            Duzenli_Ifade = Duzenli_Ifade_Okuma.Oku(Duzenli_Ifade_String, Alfabe);

            foreach (Tuple<List<string>, Boolean, Boolean> i in Duzenli_Ifade)
            {
                var result = string.Join(" ", i.Item1.ToArray());
                Console.WriteLine("Item 1: " + result + " // Item 2: " + i.Item2 + " // Item 3: " + i.Item3);
            }
        }


        public List<string> Kelime_Uret(int MaxYildiz)
        {
            int SecilenEleman, yildiz = MaxYildiz, maxSayac = 0;
            Boolean YildizArtiDurumu, elemanSec, elemanSec2 = true;
            StringBuilder geciciString = new StringBuilder();
            List<string> Sonuc = new List<string>();

            if (Izin)
            {
                int kelimeLimiti = Hesapla.Eleman_Sayisi(yildiz, Duzenli_Ifade);
                YildizArtiDurumu = Hesapla.YildizArtiDurumu(Duzenli_Ifade);
                Console.WriteLine("Uretilecek Eleman Sayisi: " + kelimeLimiti);

                for (int count = 0; ;)
                {
                    maxSayac++;

                    if (YildizArtiDurumu)
                    {
                        elemanSec = Hesapla.GrupSec(Duzenli_Ifade);

                        foreach (Tuple<List<string>, Boolean, Boolean> i in Duzenli_Ifade)
                        {
                            if (elemanSec && elemanSec2)
                            {
                                elemanSec = false;
                                elemanSec2 = false;
                                continue;
                            }
                            else
                            {
                                elemanSec = true;
                                if (i.Item2)
                                {
                                    for (int j = 0; j < yildiz; j++)
                                    {
                                        SecilenEleman = Hesapla.Eleman_Sec(0, i.Item1.Count);
                                        geciciString.Append(i.Item1[SecilenEleman]);
                                    }
                                }
                                else
                                {
                                    SecilenEleman = Hesapla.Eleman_Sec(0, i.Item1.Count);
                                    geciciString.Append(i.Item1[SecilenEleman]);
                                }
                            }

                        }
                    }
                    else
                    {
                        foreach (Tuple<List<string>, Boolean, Boolean> i in Duzenli_Ifade)
                        {
                            if (i.Item2)
                            {
                                for (int j = 0; j < yildiz; j++)
                                {
                                    SecilenEleman = Hesapla.Eleman_Sec(0, i.Item1.Count);
                                    geciciString.Append(i.Item1[SecilenEleman]);
                                }
                            }
                            else
                            {
                                SecilenEleman = Hesapla.Eleman_Sec(0, i.Item1.Count);
                                geciciString.Append(i.Item1[SecilenEleman]);
                            }
                        }
                    }

                    if (!Sonuc.Any(str => geciciString.ToString().Contains(str)))
                    {
                        Sonuc.Add(geciciString.ToString());
                        count++;
                    }

                    geciciString.Clear();

                    if (count == kelimeLimiti)
                    {
                        count = 0;
                        yildiz--;
                        kelimeLimiti = Hesapla.Eleman_Sayisi(yildiz, Duzenli_Ifade);
                    }
                    if (yildiz == -1)
                        break;
                    if (maxSayac == 10000)
                        break;
                }
            }

            return Sonuc;
        }
    }
}