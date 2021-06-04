using System;
using System.Collections.Generic;
using System.Text;

namespace Demo_heritage
{
    public interface IVenimeux
    {
        public string Partie_venimeuse { get; set; }
        public string Degree_poison { get; set; }
        void Empoisonner();
    }
}
