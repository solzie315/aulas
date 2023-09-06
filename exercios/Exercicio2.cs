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
    public partial class Exercicio2 : Form
    {
        public Exercicio2()
        {
            InitializeComponent();
        }

        private void buscar(object sender, EventArgs e)
        {
            openFileDialogFoto.ShowDialog();

        }

        private void selecionarFoto(object sender, CancelEventArgs e)
        {
            string caminho = ((System.Windows.Forms.OpenFileDialog)sender).FileName; // Pega a imagem direto do arquivo e transfoma num objeto.

            pictureBoxFoto.Image = Image.FromFile(caminho); // joga a imagem na picturebox

            textBoxCaminho.Text = caminho; // mostra o caminho do arquivo da imagem na textbox



        }

        private void textBoxCaminho_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void salvar(object sender, EventArgs e)
        {
            if (dataGridViewDados.DataSource != null)
            {
                DataTable dt = (DataTable)dataGridViewDados.DataSource;
                DataRow dr = dt.NewRow();
                dr["Nome"] = textBoxNome.Text;
                dr["Foto"] = textBoxCaminho.Text;
                dt.Rows.Add(dr);
            }
            else
            {

                DataTable dt = new DataTable(); // criando tabela de dados.
                dt.Columns.Add("Nome"); // coluna de nome do arquivo
                dt.Columns.Add("Foto"); // coluna da foto

                DataRow dr = dt.NewRow(); // linhas da tabela
                dr["Nome"] = textBoxNome.Text;
                dr["Foto"] = textBoxCaminho.Text;

                dt.Rows.Add(dr);

                dataGridViewDados.DataSource = dt; // mostra a tabela na grid

            }
        }
    }
}
