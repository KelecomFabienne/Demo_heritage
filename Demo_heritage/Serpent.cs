using System;
using System.Collections.Generic;
using System.Text;

namespace Demo_heritage
{
    public class Serpent : Reptile, IVenimeux
    {
        public bool machoire_déboitable = true;

        public string Partie_venimeuse { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string Degree_poison { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public void Empoisonner()
        {
            throw new NotImplementedException();
        }

        protected override void Ramper()
        {
            // déplacement du serpent
            throw new NotImplementedException();
        }
    }
}
