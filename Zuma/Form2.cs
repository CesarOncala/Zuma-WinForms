using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Zuma
{
    public partial class Form2 : Form
    {
        Lista Game;
        Elemento jogada;
        string dificult;
        public Form2(string dificuldade)
        {
            InitializeComponent();
            this.Indíce.Focus();
            Game = new Lista();
            dificult = dificuldade;
            Game.Mostrar_E_Atualizar(this.Tela,this.Score,this.Elemento,ref jogada,dificult);
           
        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            try
            {
                if (int.Parse(Indíce.Text)!=0)
                {
                    Game.InserirPos(int.Parse(Indíce.Text), jogada, this);
                    Game.RetirarSeq();
                    Game.Mostrar_E_Atualizar(this.Tela, this.Score, this.Elemento, ref jogada, dificult);
                    if (Game.ListaVazia() == true)
                    {
                        MessageBox.Show("Você venceu !!!");
                        Application.Restart();
                    }
                }
                else
                {
                    MessageBox.Show("Não tem índice 0");
                }
                
            }
            catch (Exception)
            {

                MessageBox.Show("Digite um índice para realizar a jogada!");
            }
            this.Indíce.Focus();
            this.Indíce.Text = "";
         
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Indíce_KeyPress(object sender, KeyPressEventArgs e)
        {
                if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != ','))
                {
                    e.Handled = true;
                    MessageBox.Show("Este campo aceita somente numeros");
                }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void button1_KeyPress(object sender, KeyPressEventArgs e)
        {
            this.BotãoInserir.PerformClick();
        }

        private void Indíce_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                BotãoInserir.PerformClick();
            }
        }
    }
}
