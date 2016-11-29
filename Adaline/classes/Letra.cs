using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adaline
{
    class Letra
    {
        double[] neuronios;
        double[] pesos;
        string simbolo;

        public Letra()
        {
            Neuronios = new double[64];
        }

        public Letra(double[] neuronios, string simbolo)
        {
            Simbolo = simbolo;
            Neuronios = new double[64];

            neuronios.CopyTo(Neuronios, 0);
            Neuronios[Neuronios.Length-1] = 1;

        }

        public Letra(string simbolo)
        {
            Simbolo = simbolo;
            Pesos = new double[64];
            for(int i = 0; i < Pesos.Length; i++)
            {
                Pesos[i] = 0;
            }
        }

        public double[] Neuronios
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

        public double[] Pesos
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

        public string Simbolo
        {
            get
            {
                return simbolo;
            }

            set
            {
                simbolo = value;
            }
        }
    }
}
