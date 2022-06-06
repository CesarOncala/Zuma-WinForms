using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Zuma
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            SoundPlayer soundtrack = new SoundPlayer(@"soundtrack.wav");
            soundtrack.PlayLooping();
        }

        private void Iniciar_Click(object sender, EventArgs e)
        {
           
            string dificuldade = "";
            if (Fácil.Checked == true)
                dificuldade = "facil";
            else
                dificuldade = "dificil";
            Form2 Abrir = new Form2(dificuldade);
            Abrir.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Trabalho na discíplina: ALGORITMOS E ESTRUTURAS DE DADOS \n\nDesenvolvedores: \n\nCésar Henrique Alves Oncala \nGabriel Jorge Soalheiro Só\nLeonardo Aleixo Lopes \n\nProfessora: Joyce");
        }
    }
}
