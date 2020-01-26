using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Otomata_Odev_18
{
    class Duzenli_Ifade_Okuyucu
    {
       public List<Tuple<List<string>, Boolean, Boolean>> Oku(string Ifade, string Alfabe)
        {
            Boolean YildizVar, ArtiVar, YildizArtiVar;
            var  Duzenli_Ifade = new List<Tuple<List<string>, bool, bool>>();
            int ilkIndis = 0, sonIndis = 0;

            while (!String.IsNullOrEmpty(Ifade))
            { 
                ilkIndis = Ifade.IndexOf('(');
                sonIndis = Ifade.IndexOf(')');

                //Console.WriteLine("Indisler: " + Ifade[ilkIndis] + " " + Ifade[sonIndis]);
                Console.WriteLine("Indisler: " + ilkIndis + " " + sonIndis);
                //

                YildizVar = sonIndis + 1 < Ifade.Length && Ifade[sonIndis + 1] == '*';
                ArtiVar = sonIndis + 1 < Ifade.Length && Ifade[sonIndis + 1] == '+';
                YildizArtiVar = sonIndis + 1 < Ifade.Length && Ifade[sonIndis + 2] == '+';

                if (ilkIndis == -1)
                    break;

                string[] temp = Ifade.Substring(1, sonIndis - 1).Split('+');

                List<string> list = new List<string>();

                foreach (var i in temp)
                {
                    Console.WriteLine(Alfabe + " <<<>>> " + i.ToString());
                    if (Alfabe.Contains(i.ToString()))
                        list.Add(i);
                }   

                Duzenli_Ifade.Add(new Tuple<List<string>, bool, bool>(list, YildizVar, YildizArtiVar));
                Ifade = Ifade.Remove(ilkIndis, sonIndis - ilkIndis + 1);

                if (YildizVar == true && YildizArtiVar == false)
                {
                    Ifade = Ifade.Remove(Ifade.IndexOf('*'), 1);
                }

                if (YildizVar == true && YildizArtiVar == true)
                {
                    Console.WriteLine("FOUND ONE");
                    Ifade = Ifade.Remove(Ifade.IndexOf('*'), 1);
                    Ifade = Ifade.Remove(Ifade.IndexOf('+'), 1);
                }

                if (ArtiVar == true && YildizVar == false)
                {
                    Ifade = Ifade.Remove(Ifade.IndexOf('+'), 1);
                }

            }

            return Duzenli_Ifade;
        }
    }
}
