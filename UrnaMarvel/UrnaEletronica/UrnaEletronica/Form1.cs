using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace UrnaEletronica
{
    public partial class Form1 : Form
    {
        string[] imagens = Directory.GetFiles(@"C:\Users\Aluno\Downloads\UrnaEletronica\vingadores");
        string[] candidato = new string[5] { "Hulk", "Homem de Ferro", "Thor", "Viúva Negra", "Capitão América" };
        string[] numero = new string[5] { "25", "35", "45", "55", "65" };
        string aux;

        //int cont1, cont2, cont3, cont4, cont5;
        int[] cont = new int[5];

        Timer tempo = new Timer();

        public Form1()
        {
            InitializeComponent();
            telaFoto.Image = Image.FromFile(imagens[imagens.Length - 2]);
        }

        private void CliqueBotao(object sender, EventArgs e)
        {
            Button btn = sender as Button;

            aux += btn.Text;

            if (aux.Length == 2)
            {
                for (int i = 0; i < numero.Length; i++)
                {
                    if (aux == numero[i])
                    {
                        telaFoto.Image = Image.FromFile(imagens[i]);
                        txtNumero.Text = numero[i];
                        txtNome.Text = candidato[i];
                    }
                }
                aux = null;
            }

        }

        private void btnBranco_Click(object sender, EventArgs e)
        {
            txtNumero.Text = "";
            txtNome.Text = "";
            telaFoto.Image = Image.FromFile(imagens[imagens.Length - 5]);
        }

        private void btnCorrige_Click(object sender, EventArgs e)
        {
            txtNumero.Text = "";
            txtNome.Text = "";
            telaFoto.Image = Image.FromFile(imagens[imagens.Length - 2]);
        }

        private void btnConfirma_Click(object sender, EventArgs e)
        {
            if (txtNumero.Text == numero[0])
            {
                cont[0]++;
            }

            if (txtNumero.Text == numero[1])
            {
                cont[1]++;
            }

            if (txtNumero.Text == numero[2])
            {
                cont[2]++;
            }

            if (txtNumero.Text == numero[3])
            {
                cont[3]++;
            }

            if (txtNumero.Text == numero[4])
            {
                cont[4]++;
            }

            if (txtNumero.Text != "")
            {
                txtNumero.Text = "";
                txtNome.Text = "";
                telaFoto.Image = Image.FromFile(imagens[imagens.Length - 3]);

                tempo.Start();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            tempo.Interval = 2000;
            tempo.Tick += Tempo_Tick;
        }

        private void Tempo_Tick(object sender, EventArgs e)
        {
            tempo.Stop();
            telaFoto.Image = Image.FromFile(imagens[imagens.Length - 2]);
        }

        private void bntH_Click(object sender, EventArgs e)
        {

            int qtdVotos = 0;
            string nomeVencedor = "";

            for (int i = 0; i < candidato.Length; i++)
            {
                if (cont[i] > qtdVotos)
                {
                    qtdVotos = cont[i];
                    nomeVencedor = candidato[i];
                }
            }

            MessageBox.Show($"{candidato[0]} - {cont[0]}" + "\n" +
                            $"{candidato[1]} - {cont[1]}" + "\n" +
                            $"{candidato[2]} - {cont[2]}" + "\n" +
                            $"{candidato[3]} - {cont[3]}" + "\n" +
                            $"{candidato[4]} - {cont[4]}" + "\n\n" +
                            $"{nomeVencedor} está vencendo com {qtdVotos} votos !","Histórico Votação");
        }
    }
}
