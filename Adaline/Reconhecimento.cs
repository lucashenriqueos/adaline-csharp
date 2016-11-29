using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Adaline
{
    public partial class Reconhecimento : Form
    {
        Treino treino = new Treino();

        public Reconhecimento()
        {
            InitializeComponent();
        }

        private void bt_mostrar_Click(object sender, EventArgs e)
        {
            List<Fonte> fontes = treino.Fontes;
            Fonte fonte = null;

            if (rb_tipo_1.Checked)
            {
                fonte = fontes[0];
            } else if (rb_tipo_2.Checked)
            {
                fonte = fontes[1];
            } else if (rb_tipo_3.Checked)
            {
                fonte = fontes[2];
            }

            Letra letra = fonte.Letras.Find(l => l.Simbolo == lb_letra.Text);

            if (letra != null)
            {
                gv_letra.Rows.Clear();
                int k = 0;
                for (int i = 0; i < 9; i++)
                {
                    gv_letra.Rows.Add();
                    for (int j = 0; j < 7; j++)
                    {
                        gv_letra.Rows[i].Cells[j].Value = letra.Neuronios[k++] == 1 ? "#" : ".";
                    }

                }
            }
        }

        private void bt_testar_Click(object sender, EventArgs e)
        {
            int[] neuronios = new int[63];

            int k = 0;
            for(int i = 0; i < 9; i++)
            {
                for(int j = 0; j < 7; j++)
                {
                    int valor;
                    if(gv_letra.Rows[i].Cells[j].Value.Equals("#"))
                    {
                        valor = 1;
                    } else if (gv_letra.Rows[i].Cells[j].Value.Equals("."))
                    {
                        valor = -1;
                    } else
                    {
                        valor = 0;
                    }
                    neuronios[k++] = valor;
                }
            }

            tb_caracter.Text = treino.testar(neuronios);
        }
    }
}
