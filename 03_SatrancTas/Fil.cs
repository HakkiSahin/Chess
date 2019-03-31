using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_SatrancTas
{
    public class Fil : Tas
    {
        public override List<Konum> GidebilecegiYerler
        {
            get
            {
                List<Konum> yerler = new List<Konum>();
                for (int i = -7; i <= 7; i++)
                {
                    for (int j = -7; j <= 7; j++)
                    {
                        if (Math.Abs(i) == Math.Abs(j) && i != 0 && j != 0)
                        {
                            yerler.Add(new Konum(this.Lokasyon.X + i, this.Lokasyon.Y + j));
                        }
                    }
                }

                return yerler;
            }
        }

        public override string Resim
        {
            get
            {
                return "Fil.png";
            }
        }
    }
}
