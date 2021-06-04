using System;
using System.Collections.Generic;
using System.Text;

namespace Demo_heritage
{
    public class Ornithorinque :Mammifere, IVenimeux
    {
        public string bec = "bec de canard";

        public string Partie_venimeuse { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string Degree_poison { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public void Empoisonner()
        {
            throw new NotImplementedException();
        }

        public int Pondre() 
        {
            return 8;
        }
    }
}
