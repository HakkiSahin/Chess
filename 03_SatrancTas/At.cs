using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_SatrancTas
{
    public class At : Tas
    {
        public override List<Konum> GidebilecegiYerler
        {
            get
            {
                List<Konum> yerler = new List<Konum>();
                for (int i = -2; i <= 2; i++)
                {
                    for (int j = -2; j <= 2; j++)
                    {
                        if (Math.Abs(i) + Math.Abs(j) == 3)
                        {
                            // X - 2 Y -1, X -2 Y +1, X -1 Y -1 ....
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
                return "At.png";
            }
        }

        public override bool AtlayabilirMi()
        {
            return true;
        }
    }
}
