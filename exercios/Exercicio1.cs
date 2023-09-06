using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace exercios
{
    public partial class Exercicio1 : Form
    {
        public Exercicio1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void comboBoxTipo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void converter(object sender, EventArgs e)
        {
            double valorConverter = Convert.ToDouble(textBoxValor.Text);
            double cotacao = Convert.ToDouble(textBoxValorConverter.Text);

            int index = comboBoxTipo.SelectedIndex;

            if (index == 0)
            {
                double resultado = valorConverter * cotacao;
                textBoxResultado.Text = resultado.ToString();
            }
            else if (index == 1) {
                double resultado = valorConverter / cotacao;
                textBoxResultado.Text = resultado.ToString();
            }
        }

        private void textBoxResultado_TextChanged(object sender, EventArgs e)
        {

        }
    }
}  
