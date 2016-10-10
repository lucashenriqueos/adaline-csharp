using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adaline
{
    class Letra
    {
        int[] neuronios;
        int[] pesos;

        public Letra()
        {
            Neuronios = new int[64];
            Pesos = new int[64];
        }

        public int[] Neuronios
        {
            get
            {
                return neuronios;
            }

            set
            {
                neuronios = value;
            }
        }

        public int[] Pesos
        {
            get
            {
                return pesos;
            }

            set
            {
                pesos = value;
            }
        }
    }
}
