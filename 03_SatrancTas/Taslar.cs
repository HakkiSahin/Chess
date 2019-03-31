using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_SatrancTas
{
    public static class Taslar
    {
        private static List<Tas> _tasListesi = new List<Tas>();
        public static List<Tas> TaslarListesi
        {
            get
            {
                return _tasListesi;
            }
        }

        public static void TasEkle(Tas t)
        {
            _tasListesi.Add(t);
        }
    }
}
