using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_de_vendas_de_livros
{
     class Program
    {
        static void Main(string[] args)
        {
            ControlLivro controle = new ControlLivro();
            controle.OperacaoLivro();

            ControlLogin controleLogin = new ControlLogin();
            controle.OperacaoLogin();
           

            Console.ReadLine();
        }//Fim do método
    }//Fim da classe
}//Fim  do projeto
