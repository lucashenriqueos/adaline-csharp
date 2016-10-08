using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adaline
{
    class Treino
    {
        List<int[]> pesos;
        List<int[]> saidas;
        List<Fonte> fontes;
        double aprendizado = 0.1;
        double erro = 0;

        public double maiorErroQuadratico { get; private set; }

        public void train()
        {
            maiorErroQuadratico = -1000;
            int ciclos = 0;
            do
            {
                fontes.ForEach(fonte => {
                    saidas.ForEach(saida => {
                        fonte.Letras.ForEach(letra => {
                            for (int i = 0; i < letra.Neuronios.Length; i++) {
                                for (int j = 0; j < saida.Length; j++) {
                                    erro = calcErro(letra.Neuronios[i], letra.Pesos[i], saida[j]);
                                    atualizaPesos(letra.Pesos[i], letra.Neuronios[i], saida[j]);
                                }
                            }
                        });
                    });
                });
                ciclos++;
                double erroQuadratico = Math.Pow(erro, 2) / 2;
                maiorErroQuadratico = maiorErroQuadratico < erro ? erro : maiorErroQuadratico;
            } while (maiorErroQuadratico > erro);
        }

        public int calcErro(int entrada, int peso, int saida)
        {
            double delta = saida * peso;
            return (int) (saida - delta);
        }

        public int atualizaPesos(int peso, int entrada, int saida)
        {
            return (int) (peso + aprendizado * erro * entrada);
        }
    }
}
