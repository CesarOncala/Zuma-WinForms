using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace Zuma
{
    public class Elemento
    {
        public int Num;
        public Elemento Prox;
        public string Element;
        public Elemento()
        {
            Num = 0;
            Prox = null;
            Element = "";
        }
    }

    public class Lista
    {
        private Elemento Início;
        private Elemento Fim;
        private int Tamanho;
        public int SCORE;
        private bool Start=false;

        public Lista()
        {
            this.InserirFinal();
            for (int i = 0; i < 8; i++)
            {
                this.InserirFinal();
                Thread.Sleep(50);
            }
             
        } // 8 Elementos randômicos

        public void RetirarSeq()
        {
            if (ListaVazia()==false)
            {
                Elemento Aux = this.Início.Prox;
                do
                {
                    if (Aux.Prox.Element == Aux.Element && Aux.Prox.Prox.Element == Aux.Element && Aux.Prox.Prox.Prox.Element == Aux.Element)
                    {
                        SCORE += 3;
                        
                        for (int i = 0; i < 4; i++)
                        {
                            this.RetirarItem(Aux.Num);
                            Aux = Aux.Prox;
                            Tamanho--;
                        }
                    }
                    else if (Aux.Prox.Element == Aux.Element && Aux.Prox.Prox.Element == Aux.Element)
                    {
                        SCORE += 2;
                        for (int i = 0; i < 3; i++)
                        {
                            this.RetirarItem(Aux.Num);
                            Aux = Aux.Prox;
                            Tamanho--;
                        }
                    }
                    Aux = Aux.Prox;
                } while (Aux.Element != "White");
            }
           
        } // Retira sequências de 3 e 4

        public void RetirarItem(int o)
        {
            Elemento aux, anterior;
            anterior = this.Início;
            aux = Início;
            aux = aux.Prox;
            do
            {
                if (aux.Num == o)
                {
                    anterior.Prox = aux.Prox;

                    if (aux == this.Fim)
                    {
                        Fim = anterior;
                    }
                    else if (aux == Início.Prox)
                    {
                        aux = aux.Prox;
                        Início.Prox = aux;
                    }
                    return;
                }
                else
                {
                    anterior = aux;
                    aux = aux.Prox;
                }
            } while (aux.Element != "White");
        } // Retirar elemento da lista

        public void InserirFinal() //Lista  circular encadeada com cabeça
        {

            if (Início == null)
            {
                Elemento Head = new Elemento();
                Head.Element = "White";
                Head.Num = 0;
                Início = Head;
                Fim = Head;
                Head.Prox = Fim;
                return;
            }
            else
            {
                Elemento Novo = this.CriaElemento();
                Fim.Prox = Novo;
                Novo.Prox = Início;
                Fim = Novo;
            }

        }

        public void InserirPos(int pos, Elemento x,Form2 jogo)
        {
            if (ListaVazia()==false)
            {
                Elemento aux = this.Início.Prox, ant = null, novo = x;
                int o = 1;
                if (Tamanho > 20)
                {
                    MessageBox.Show("FIM DO JOGO");
                    this.Tamanho = 0;
                    jogo.Close();
                    Application.Restart();

                }
                if (pos != 1)
                {
                    while (o < pos && aux != null)
                    {
                        ant = aux;
                        aux = aux.Prox;
                        o++;
                    }
                    if (o == pos)
                    {
                        ant.Prox = novo;
                        novo.Prox = aux;
                    }
                }
                else if (pos==1)
                {
                    Elemento oldtrack = this.Início.Prox;
                    x.Prox = oldtrack;
                    this.Início.Prox = x;
                }  
            }
           

           
        } // Insere o elemento na posição indicada

        public Elemento CriaElemento()
        {
            Elemento Novo = new Elemento();
            Random o = new Random();
            Novo.Num = Tamanho++;

            int x = o.Next(0, 100);
         
            if (x < 25)
            {
                Novo.Element = "☾";
            }
            else if (x >= 25 && x < 50)
            {
                Novo.Element = "♞";
            }
            else if (x >= 50 && x < 75)
            {
                Novo.Element = "❤";
            }
            else if (x >= 75)
            {
                Novo.Element = "☯";
            }
            return Novo;
        } // Cria o elemento 

        public void Mostrar_E_Atualizar(ListBox x,TextBox pontuacao,TextBox novoElemt,ref Elemento jogada,string dificult)
        {
            x.Items.Clear();
            if (Start==true)
            {
                if (Início.Element == "White"&& Fim.Element=="White")
                {
                    MessageBox.Show("Você venceu o game !");
                    Application.Restart();
                }
                else
                {
                    Elemento Aux = this.Início.Prox;
                    int pos = 1;
                    while (Aux.Element != "White")
                    {
                        x.Items.Add((pos++) + "\t" + Aux.Element);
                        Aux = Aux.Prox;
                    }

                    pontuacao.Text = SCORE.ToString();
                    Elemento GerarNovoElemento = this.CriaElemento();

                    if (dificult=="facil")
                    {
                        while (ElementExist(GerarNovoElemento.Element) == false)
                        {
                            Tamanho--;
                            GerarNovoElemento = this.CriaElemento();
                        }
                        novoElemt.Text = GerarNovoElemento.Element;
                        jogada = GerarNovoElemento;
                        novoElemt.Text = jogada.Element;
                    }
                    else
                    {
                        novoElemt.Text = GerarNovoElemento.Element;
                        jogada = GerarNovoElemento;
                        novoElemt.Text = jogada.Element;
                    }
                    
                }
            }
            else
            {
                Start = true;
                Elemento Aux = this.Início.Prox;
                int pos = 1;
                while (Aux.Element != "White")
                {
                    x.Items.Add((pos++) + "\t" + Aux.Element);
                    Aux = Aux.Prox;
                }

                pontuacao.Text = SCORE.ToString();
                Elemento GerarNovoElemento = this.CriaElemento();   
                novoElemt.Text = GerarNovoElemento.Element;
                jogada = GerarNovoElemento;
                novoElemt.Text = jogada.Element;
            }
           
        } // Mostra elementos

        public bool ElementExist(string elemento)
        {
            for (Elemento aux = this.Início.Prox; aux.Element != "White";)
            {
                if (elemento==aux.Element)
                    return true;
                aux = aux.Prox;
            }
            return false;
        } // verifica se o elemento existe na lista

        public void EsvaziarLista()
        {
            if (Início == null)
            {
                Console.WriteLine("A lista não possui nenhum elemento!!! \n\n");
            }
            else
            {
                Início = null;
                Fim = null;
                Tamanho = 0;
            }
        } // Esvaziar a lista

        public bool ListaVazia()
        {
            if (this.Início == null && this.Fim == null)
                return true;
            else
                return false;

        } // Verifica se a lista está 
    }
}
