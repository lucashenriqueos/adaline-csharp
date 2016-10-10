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
    public partial class Adaline : Form
    {
        Treino treino = new Treino();

        public Adaline()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            treino.train();
        }
    }
}
