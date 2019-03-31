using _03_SatrancTas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_Satranc
{
    public enum Renkler : byte
    {
        Siyah = 1,
        Beyaz = 2
    }
    public class Kare
    {
        public Renkler Renk { get; set; }
        public Konum Lokasyon { get; set; }

        public Kare(Renkler renk, Konum konum)
        {
            Renk = renk;
            Lokasyon = konum;
        }

        public bool UzerindeTasVarMi()
        {
            foreach (Tas item in Taslar.TaslarListesi)
            {
                if (item.Lokasyon.Equals(this.Lokasyon))
                {
                    return true;
                }
            }

            return false;
        }
    }
}
