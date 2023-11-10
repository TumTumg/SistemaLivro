using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_de_vendas_de_livros
{
    class ControlLivro
    {
        ModelLivro modelo;
        private int opcao;
        public ControlLivro()
        {
            this.modelo = new ModelLivro();//Criando uma chave
            ConsultarOpcao = -1;
        }//Fim do construtor

        public int ConsultarOpcao
        {
            get { return this.opcao; }
            set { this.opcao = value; }
        }//Fim do método

             
        public void Menu()
        {
            Console.WriteLine("-- Bem- Vindo ao nosso site! Escolha um livro --\n\n"              +
                              "0.Sair\n"                                +
                              "1.Harry Potter e a pedra filosofal\n"    +
                              "2.Manual de persuassão do FBI\n"         +
                              "3.Mangá Dragon Ball Vol .1\n"            +
                              "4.O poder do Hábito"                     +
                              "5.Quem pensa enriquece"                
                                                                         );
            ConsultarOpcao = Convert.ToInt32( Console.ReadLine());
        }//Fim do menu

        public void OperacaoLivro()
        {
            do
            {
                Menu();//Mostrar o menu em tela
                switch (ConsultarOpcao)
                {
                    case 0:
                        Console.WriteLine("Obrigado!");
                        break;
                    case 1:
                        Console.WriteLine("Custa 45 R$" + "E atualmente existem 15 unidades disponívros para compra");
                        break;
                    case 2: 
                        Console.WriteLine("Este livro custa 35 R$" + "E atualmente o temos em estoque");
                        break;
                    case 3:
                        Console.WriteLine("Este livro custa 30 R$" + "E atualmente existem 50 unidades disponíveis para compra");
                        break;
                    case 4:
                        Console.WriteLine("Este livro custa 20 R$" + "E atualmente existem 65 unidades disponíveis para compra");
                        break;
                    case 5:
                        Console.WriteLine("Este livro custa 40 R$" + "E atualmente existem 30 unidades disponíveis para compra");
                        break;

                }


            } while (ConsultarOpcao != 0);
        }//Fim do método 



    }//Fim da classe 
}
