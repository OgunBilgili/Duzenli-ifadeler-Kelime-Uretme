using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Otomata_Odev_18
{
    class Hesaplama
    {
        private static readonly Random random = new Random();
        private static readonly object syncLock = new object();

        //Eleman Seç
        public int Eleman_Sec(int min, int max)
        {
            lock (syncLock)
            { // synchronize
                return random.Next(min, max);
            }
        }

        public bool YildizArtiDurumu(List<Tuple<List<string>, Boolean, Boolean>> Duzenli_Ifade)
        {
            bool YildizArtiDurumu = false;

            foreach (Tuple<List<string>, Boolean, Boolean> i in Duzenli_Ifade)
            {
                if (i.Item3)
                    return YildizArtiDurumu = true;
            }

            return YildizArtiDurumu;
        }

        public bool GrupSec(List<Tuple<List<string>, Boolean, Boolean>> Duzenli_Ifade)
        {
            bool elemanSec = false;
            int SecilenEleman;

            foreach (Tuple<List<string>, Boolean, Boolean> i in Duzenli_Ifade)
            {
                if (i.Item3)
                {
                    SecilenEleman = Eleman_Sec(0, 2);
                    if (SecilenEleman != 0)
                        return elemanSec = true;
                }
            }

            return elemanSec;
        }



        //Üretilecek Kelime Sayısını Bul
        public int Eleman_Sayisi(int yildiz, List<Tuple<List<string>, Boolean, Boolean>> Duzenli_Ifade)
        {
            bool Topla = false;
            int count = 1;
            foreach (Tuple<List<string>, Boolean, Boolean> i in Duzenli_Ifade)
            {
                //var result = string.Join(",", i.Item1.ToArray());
                if (i.Item2 && i.Item3 == false)
                {
                    count = count * (Int32)Math.Pow(i.Item1.Count, yildiz);
                }
                
                else if (i.Item2 && i.Item3)
                {
                    count = count * (Int32)Math.Pow(i.Item1.Count, yildiz);
                    Topla = true;
                }

                else
                {
                    if (Topla)
                    {
                        count = count + i.Item1.Count;
                    }
                    else
                    {
                        count = count * i.Item1.Count;
                    }
                    
                }
            }
            return count;
        }

    }
}
