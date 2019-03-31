using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_SatrancTas
{
    public abstract class Tas
    {
        public Konum Lokasyon { get; set; }
        public abstract List<Konum> GidebilecegiYerler { get; }
        public abstract string Resim { get; }

        public virtual bool AtlayabilirMi()
        {
            return false;
        }
    }
}
