using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adaline
{
    class Fonte
    {
        List<Letra> letras;

        public Fonte()
        {
            Letras = new List<Letra>();
        }

        public Fonte(List<Letra> letra)
        {
            Letras = letra;
        }

        internal List<Letra> Letras
        {
            get
            {
                return letras;
            }

            set
            {
                letras = value;
            }
        }
    }
}
