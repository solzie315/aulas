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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Exercicio1 ex1 = new Exercicio1();
            ex1.ShowDialog();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Exercicio2 ex2 = new Exercicio2();
            ex2.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Exercicio3 ex3 = new Exercicio3();
            ex3.ShowDialog();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Exercicio4 ex4 = new Exercicio4();
            ex4.ShowDialog();
        }
    }
}
