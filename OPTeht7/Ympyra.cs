using System;
using System.Collections.Generic;
using System.Text;

namespace OPTeht8A
{
    class Ympyra
    {
        //Muodostin, constructor
        public Ympyra(double sade)
        {
            this.sade = sade;
        }

        //Ominaisuudet, property
        public double sade { get; set; }

        //Luokan metodit, instance method
        public double LaskeAla()
        {
            return Math.PI * sade * sade;

        }
        

    }
}
