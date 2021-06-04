using System;
using Demo_heritage;

namespace Demo_heritage_program
{
    class Program
    {
        static void Main(string[] args)
        {
            IVenimeux venimeux = new Ornithorinque();
            venimeux = new Serpent();
            switch (venimeux)
            {
                case Ornithorinque Pol:
                    Pol.Pondre();
                    break;
                default:
                    break;
            }
        }
    }
}
