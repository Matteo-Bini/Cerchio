using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cerchio
{
    internal class Cerchio
    {
        public int Raggio { get; set; }
        public int Perimetro()
        {
            return (int)(Raggio*2*Math.PI);
        }
        public int Area()
        {
            return (int)(Raggio*Raggio*Math.PI);
        }
        public override string ToString()
        {
            return string.Format("Cerchio R = {0}", Raggio);
        }
    }
}
