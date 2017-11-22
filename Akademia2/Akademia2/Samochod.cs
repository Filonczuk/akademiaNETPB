using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Akademia2
{
    public class Samochod
    {
        public string marka;
        public string model;
        public int rok;
        public string kolor;
        public Silnik silnikSamochodu;

        public Samochod()
        {
            this.silnikSamochodu = new Silnik();
        }


        // this() - wywołuje konstruktor bezparametrowy który inicjalizuje obiekt silnika
        // unikniemy wtedy duplikacji kodu i deklaracji obiektu silnika w kazdym w konstruktorów

        public Samochod(string _marka, string _model) : this()
        {
            this.marka = _marka;
            this.model = _model;
        }

        public Samochod(string _marka, string _model, int _rok, string _kolor, string _producent, int _rokProdukcjiSilnika, double _pojSilnika) : this()
        {
            this.silnikSamochodu = new Silnik(_producent, _rokProdukcjiSilnika, _pojSilnika);
            this.marka = _marka;
            this.model = _model;
            this.rok = _rok;
            this.kolor = _kolor;
        }

        public Samochod(string _marka, string _model, int _rok, string _kolor) 
        {
            this.marka = _marka;
            this.model = _model;
            this.rok = _rok;
            this.kolor = _kolor;
        }

        public void Jedz()
        {
            Console.WriteLine(marka + " jedzie");
        }
        public void Hamuj()
        {
            Console.WriteLine(marka + " hamuje");
        }
    }
}
