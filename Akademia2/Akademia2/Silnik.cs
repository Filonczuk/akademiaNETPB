using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Akademia2
{
    public class Silnik
    {
        public string producent;
        public int rokProdukcji;
        public double pojSilnika;

        public Silnik()
        {

        }

        public Silnik(string _producent, int _rokProdukcji, double _pojSilnika)
        {
            this.producent = _producent;
            this.rokProdukcji = _rokProdukcji;
            this.pojSilnika = _pojSilnika;
        }

    }
}