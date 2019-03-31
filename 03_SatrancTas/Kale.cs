using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_SatrancTas
{
    public class Kale : Tas
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
                        if (i == this.Lokasyon.X)
                        {
                            yerler.Add(new Konum(i, this.Lokasyon.Y + j));
                        }
                        else if (j == this.Lokasyon.Y)
                        {
                            yerler.Add(new Konum(this.Lokasyon.X + i, j));
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
                return "Kale.png";
            }
        }
    }
}
