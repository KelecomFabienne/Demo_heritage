using System;
using System.Collections.Generic;
using System.Text;

namespace Demo_heritage
{
     public abstract class  Reptile :Tetrapode
    {
        protected bool sang_froid;
        protected abstract void Ramper (); //on ne sait pas encore comment les enfants-reptiles vont se déplacer
    }
}
