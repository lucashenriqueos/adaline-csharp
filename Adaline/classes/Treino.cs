using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adaline
{
    class Treino
    {
        //List<int[]> saidas = new List<int[]>();
        List<Fonte> fontes = new List<Fonte>();
        List<Letra> saidas = new List<Letra>();
        double aprendizagem = 0.01;
        double erroMinimo = 0.1;
        private double erroQuadratico;

        public double maiorErroQuadratico { get; private set; }
        public double result { get; private set; }


        public Treino()
        {
            maiorErroQuadratico = 10000;
            saidasLetras();
            fonte01();
            fonte02();
            fonte03();
            train();
        }

        public void train()
        {
            int ciclos = 0;
            while (maiorErroQuadratico > erroMinimo)
            {
                maiorErroQuadratico = -10000;
                double erro = 0;
                Fontes.ForEach(fonte => {
                    fonte.Letras.ForEach(letra => {
                        saidas.ForEach(saida => {
                            int saidaDesejada = letra.Simbolo == saida.Simbolo ? 1 : -1;
                            erro = calcErro(letra.Neuronios, saida.Pesos, saidaDesejada);
                            for (int i = 0; i < letra.Neuronios.Length; i++) {                                
                                    saida.Pesos[i] = atualizaPesos(saida.Pesos[i], letra.Neuronios[i], erro);
                            }
                            erroQuadratico = Math.Pow(erro, 2) / 2;
                            maiorErroQuadratico = erroQuadratico > maiorErroQuadratico ? erroQuadratico : maiorErroQuadratico;
                        });
                    });
                });
                ciclos++;
            }

            Console.WriteLine(ciclos);
        }

        internal String testar(int[] entrada)
        {
            string res = "";
            saidas.ForEach(saida =>
            {
                double result = 0;
                for (int i = 0; i < entrada.Length; i ++)
                {
                    result += entrada[i] * saida.Pesos[i];
                }
                result += saida.Pesos[entrada.Length];

                if (result >= 0)
                {
                    res += saida.Simbolo + " ";
                }
            });
            return res;
        }

        void printPesos(double[] pesos)
        {
            foreach (int peso in pesos)
            {
                Console.Write(peso + " - ");
            }
            Console.WriteLine();
        }

        public double calcErro(double[] entrada, double[] peso, int saida)
        {
            double soma = 0;
            for (int i = 0; i < entrada.Length; i++)
            {
                soma += entrada[i] * peso[i];
            }

            return (saida - soma);
        }

        public double atualizaPesos(double peso, double entrada, double erro)
        {
            return (peso + (aprendizagem * erro * entrada));
        }

        private void fonte01()
        {
            Fonte fonte = new Fonte();
            fonte.Letras.Add(new Letra(new double[63] {
               -1,-1, 1, 1,-1,-1,-1 ,
               -1,-1,-1, 1,-1,-1,-1 ,
               -1,-1,-1, 1,-1,-1,-1 ,
               -1,-1, 1,-1, 1,-1,-1 ,
               -1,-1, 1,-1, 1,-1,-1 ,
               -1, 1, 1, 1, 1, 1,-1 ,
               -1, 1,-1,-1,-1, 1,-1 ,
               -1, 1,-1,-1,-1, 1,-1 ,
                1,  1, 1,-1, 1, 1,1 }, "A"));



            fonte.Letras.Add(new Letra(new double[63] {
              1, 1, 1, 1, 1, 1,-1 ,
             -1, 1,-1,-1,-1,-1, 1 ,
            - 1, 1,-1,-1,-1,-1, 1 ,
            - 1, 1,-1,-1,-1,-1, 1 ,
            - 1, 1, 1, 1, 1, 1,-1 ,
            - 1, 1,-1,-1,-1,-1, 1 ,
            - 1, 1,-1,-1,-1,-1, 1 ,
            - 1, 1,-1,-1,-1,-1, 1 ,
              1, 1, 1, 1, 1, 1,-1 }, "B"));



            fonte.Letras.Add(new Letra(new double[63] {
              -1,-1, 1, 1, 1, 1, 1 ,
              -1, 1,-1,-1,-1,-1, 1 ,
               1,-1,-1,-1,-1,-1,-1 ,
               1,-1,-1,-1,-1,-1,-1 ,
               1,-1,-1,-1,-1,-1,-1 ,
               1,-1,-1,-1,-1,-1,-1 ,
               1,-1,-1,-1,-1,-1,-1 ,
              -1, 1,-1,-1,-1,-1, 1 ,
              -1,-1, 1, 1, 1, 1,-1 }, "C"));



            fonte.Letras.Add(new Letra(new double[63] {
               1, 1, 1, 1, 1,-1,-1 ,
              -1, 1,-1,-1,-1, 1,-1 ,
              -1, 1,-1,-1,-1,-1, 1 ,
              -1, 1,-1,-1,-1,-1, 1 ,
              -1, 1,-1,-1,-1,-1, 1 ,
              -1, 1,-1,-1,-1,-1, 1 ,
              -1, 1,-1,-1,-1,-1, 1 ,
              -1, 1,-1,-1,-1, 1,-1 ,
               1, 1, 1, 1, 1,-1,-1 }, "D"));



            fonte.Letras.Add(new Letra(new double[63] {
               1, 1, 1, 1, 1, 1, 1 ,
              -1, 1,-1,-1,-1,-1, 1 ,
              -1, 1,-1,-1,-1,-1,-1 ,
              -1, 1,-1, 1,-1,-1,-1 ,
              -1, 1, 1, 1,-1,-1,-1 ,
              -1, 1,-1, 1,-1,-1,-1 ,
              -1, 1,-1,-1,-1,-1,-1 ,
              -1, 1,-1,-1,-1,-1, 1 ,
               1, 1, 1, 1, 1, 1, 1 }, "E"));



            fonte.Letras.Add(new Letra(new double[63] {
              -1,-1,-1, 1, 1, 1, 1 ,
              -1,-1,-1,-1,-1, 1,-1 ,
              -1,-1,-1,-1,-1, 1,-1 ,
              -1,-1,-1,-1,-1, 1,-1 ,
              -1,-1,-1,-1,-1, 1,-1 ,
              -1,-1,-1,-1,-1, 1,-1 ,
              -1, 1,-1,-1,-1, 1,-1 ,
              -1, 1,-1,-1,-1, 1,-1 ,
              -1,-1, 1, 1, 1,-1,-1 }, "J"));



            fonte.Letras.Add(new Letra(new double[63] {
               1, 1, 1,-1,-1, 1, 1 ,
              -1, 1,-1,-1, 1,-1,-1 ,
              -1, 1,-1, 1,-1,-1,-1 ,
              -1, 1, 1,-1,-1,-1,-1 ,
              -1, 1, 1,-1,-1,-1,-1 ,
              -1, 1,-1, 1,-1,-1,-1 ,
              -1, 1,-1,-1, 1,-1,-1 ,
              -1, 1,-1,-1,-1, 1,-1 ,
              1, 1, 1,-1,-1, 1, 1 }, "K"));


            Fontes.Add(fonte);
        }

        private void fonte02()
        {
            Fonte fonte = new Fonte();
            fonte.Letras.Add(new Letra(
                    new double[63] { -1,-1,-1, 1,-1,-1,-1 ,
                                -1,-1,-1, 1,-1,-1,-1 ,
                                -1,-1,-1, 1,-1,-1,-1 ,
                                -1,-1, 1,-1, 1,-1,-1 ,
                                -1,-1, 1,-1, 1,-1,-1 ,
                                -1, 1,-1,-1,-1, 1,-1 ,
                                -1, 1, 1, 1, 1, 1,-1 ,
                                -1, 1,-1,-1,-1, 1,-1 ,
                                -1, 1,-1,-1,-1, 1,-1 }, "A"));

            fonte.Letras.Add(new Letra(
                    new double[63] {  1, 1, 1, 1, 1, 1,-1 ,
                                 1,-1,-1,-1,-1,-1, 1 ,
                                 1,-1,-1,-1,-1,-1, 1 ,
                                 1,-1,-1,-1,-1,-1, 1 ,
                                 1, 1, 1, 1, 1, 1,-1 ,
                                 1,-1,-1,-1,-1,-1, 1 ,
                                 1,-1,-1,-1,-1,-1, 1 ,
                                 1,-1,-1,-1,-1,-1, 1 ,
                                 1, 1, 1, 1, 1, 1,-1 }, "B"));

            fonte.Letras.Add(new Letra(
                    new double[] { -1,-1, 1, 1, 1,-1,-1 ,
                                 1, 1,-1,-1,-1, 1,-1 ,
                                 1,-1,-1,-1,-1,-1, 1 ,
                                 1,-1,-1,-1,-1,-1,-1 ,
                                 1,-1,-1,-1,-1,-1,-1 ,
                                 1,-1,-1,-1,-1,-1,-1 ,
                                 1,-1,-1,-1,-1,-1, 1 ,
                                -1, 1,-1,-1,-1, 1,-1 ,
                                -1,-1, 1, 1, 1,-1,-1 }, "C"));

            fonte.Letras.Add(new Letra(
                    new double[63] {  1, 1, 1, 1, 1,-1,-1,
                                 1,-1,-1,-1,-1, 1,-1 ,
                                 1,-1,-1,-1,-1,-1, 1 ,
                                 1,-1,-1,-1,-1,-1, 1 ,
                                 1,-1,-1,-1,-1,-1, 1 ,
                                 1,-1,-1,-1,-1,-1, 1 ,
                                 1,-1,-1,-1,-1,-1, 1 ,
                                 1,-1,-1,-1,-1, 1,-1 ,
                                 1, 1, 1, 1, 1,-1,-1 }, "D"));

            fonte.Letras.Add(new Letra(
                    new double[63] {  1, 1, 1, 1, 1, 1, 1 ,
                                 1,-1,-1,-1,-1,-1,-1 ,
                                 1,-1,-1,-1,-1,-1,-1 ,
                                 1,-1,-1,-1,-1,-1,-1 ,
                                 1, 1, 1, 1, 1,-1,-1 ,
                                 1,-1,-1,-1,-1,-1,-1 ,
                                 1,-1,-1,-1,-1,-1,-1 ,
                                 1,-1,-1,-1,-1,-1,-1 ,
                                 1, 1, 1, 1, 1, 1, 1 }, "E"));

            fonte.Letras.Add(new Letra(
                    new double[63] { -1,-1,-1,-1,-1, 1,-1,
                                 1,-1,-1,-1,-1, 1,-1 ,
                                -1,-1,-1,-1,-1, 1,-1 ,
                                -1,-1,-1,-1,-1, 1,-1 ,
                                -1,-1,-1,-1,-1, 1,-1 ,
                                -1,-1,-1,-1,-1, 1,-1 ,
                                -1, 1,-1,-1,-1, 1,-1 ,
                                -1, 1,-1,-1,-1, 1,-1 ,
                                -1,-1, 1, 1, 1,-1,-1 }, "J"));

            fonte.Letras.Add(new Letra(
                    new double[63] {  1,-1,-1,-1,-1, 1,-1 ,
                                 1,-1,-1,-1, 1,-1,-1 ,
                                 1,-1,-1, 1,-1,-1,-1 ,
                                 1,-1, 1,-1,-1,-1,-1 ,
                                 1, 1,-1,-1,-1,-1,-1 ,
                                 1,-1, 1,-1,-1,-1,-1 ,
                                 1,-1,-1, 1,-1,-1,-1 ,
                                 1,-1,-1,-1, 1,-1,-1 ,
                                 1,-1,-1,-1,-1, 1,-1 }, "K"));

            Fontes.Add(fonte);
        }

        private void fonte03()
        {
            Fonte fonte = new Fonte();

            fonte.Letras.Add(new Letra(
                    new double[63] {-1,-1,-1, 1,-1,-1,-1 ,
                                 -1,-1,-1, 1,-1,-1,-1 ,
                                 -1,-1, 1,-1, 1,-1,-1 ,
                                 -1,-1, 1,-1, 1,-1,-1 ,
                                 -1, 1,-1,-1,-1, 1,-1 ,
                                 -1, 1, 1, 1, 1, 1,-1 ,
                                  1,-1,-1,-1,-1,-1, 1 ,
                                  1,-1,-1,-1,-1,-1, 1 ,
                                  1, 1,-1,-1,-1, 1, 1 }, "A"));

            fonte.Letras.Add(new Letra(
                    new double[63] { 1, 1, 1, 1, 1, 1,-1 ,
                                 -1, 1,-1,-1,-1,-1, 1 ,
                                 -1, 1,-1,-1,-1,-1, 1 ,
                                 -1, 1, 1, 1, 1, 1,-1 ,
                                 -1, 1,-1,-1,-1,-1, 1 ,
                                 -1, 1,-1,-1,-1,-1, 1 ,
                                 -1, 1,-1,-1,-1,-1, 1 ,
                                 -1, 1,-1,-1,-1,-1, 1 ,
                                  1, 1, 1, 1, 1, 1,-1 }, "B"));

            fonte.Letras.Add(new Letra(
                    new double[63] {-1,-1, 1, 1, 1,-1, 1,
                                 -1, 1,-1,-1,-1, 1, 1 ,
                                  1,-1,-1,-1,-1,-1, 1 ,
                                  1,-1,-1,-1,-1,-1,-1 ,
                                  1,-1,-1,-1,-1,-1,-1 ,
                                  1,-1,-1,-1,-1,-1,-1 ,
                                  1,-1,-1,-1,-1,-1, 1 ,
                                 -1, 1,-1,-1,-1, 1,-1 ,
                                 -1,-1, 1, 1, 1,-1,-1 }, "C"));

            fonte.Letras.Add(new Letra(
                    new double[63] { 1, 1, 1, 1, 1,-1,-1 ,
                                 -1, 1,-1,-1,-1, 1,-1 ,
                                 -1, 1,-1,-1,-1,-1, 1 ,
                                 -1, 1,-1,-1,-1,-1, 1 ,
                                 -1, 1,-1,-1,-1,-1, 1 ,
                                 -1, 1,-1,-1,-1,-1, 1 ,
                                 -1, 1,-1,-1,-1,-1, 1 ,
                                 -1, 1,-1,-1,-1, 1,-1 ,
                                  1, 1, 1, 1, 1,-1,-1 }, "D"));

            fonte.Letras.Add(new Letra(
                    new double[63] { 1, 1, 1, 1, 1, 1, 1 ,
                                 -1, 1,-1,-1,-1,-1, 1 ,
                                 -1, 1,-1,-1, 1,-1,-1 ,
                                 -1, 1, 1, 1, 1,-1,-1 ,
                                 -1, 1,-1,-1, 1,-1,-1 ,
                                 -1, 1,-1,-1,-1,-1,-1 ,
                                 -1, 1,-1,-1,-1,-1,-1 ,
                                 -1, 1,-1,-1,-1,-1, 1 ,
                                  1, 1, 1, 1, 1, 1, 1 }, "E"));

            fonte.Letras.Add(new Letra(
                    new double[63] {-1,-1,-1,-1, 1, 1, 1 ,
                                 -1,-1,-1,-1,-1, 1,-1 ,
                                 -1,-1,-1,-1,-1, 1,-1 ,
                                 -1,-1,-1,-1,-1, 1,-1 ,
                                 -1,-1,-1,-1,-1, 1,-1 ,
                                 -1,-1,-1,-1,-1, 1,-1 ,
                                 -1,-1,-1,-1,-1, 1,-1 ,
                                 -1, 1,-1,-1,-1, 1,-1 ,
                                 -1,-1, 1, 1, 1,-1,-1 }, "J"));

            fonte.Letras.Add(new Letra(
                    new double[63] { 1, 1, 1,-1,-1, 1, 1 ,
                                 -1, 1,-1,-1,-1, 1,-1 ,
                                 -1, 1,-1,-1, 1,-1,-1 ,
                                 -1, 1,-1, 1,-1,-1,-1 ,
                                 -1, 1, 1,-1,-1,-1,-1 ,
                                 -1, 1,-1, 1,-1,-1,-1 ,
                                 -1, 1,-1,-1, 1,-1,-1 ,
                                 -1, 1,-1,-1,-1, 1,-1 ,
                                  1, 1, 1,-1,-1, 1, 1 }, "K"));
            Fontes.Add(fonte);
        }

        private void saidasLetras()
        {
            saidas.Add(new Letra("A"));
            saidas.Add(new Letra("B"));
            saidas.Add(new Letra("C"));
            saidas.Add(new Letra("D"));
            saidas.Add(new Letra("E"));
            saidas.Add(new Letra("J"));
            saidas.Add(new Letra("K"));
        }


        internal List<Fonte> Fontes
        {
            get
            {
                return fontes;
            }

            set
            {
                fontes = value;
            }
        }
    }
}
