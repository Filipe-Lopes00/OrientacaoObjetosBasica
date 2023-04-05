using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VolumeDeUmaEsfera
{
    internal class VolumeEsfera
    {
        public int raio;

        public double VolumeDaEsfera()
        { return (Math.PI * 4) * (raio * raio* raio) / 3; }
    }
}
