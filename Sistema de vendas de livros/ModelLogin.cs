using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_de_vendas_de_livros
{
    internal class ModelLogin
    {
        public double login;
        public int i;
        public double senha;
        public double nome;
        public double telefone;
        public double DtNasc;
       


        public void PreencherLogin()
        {
           for(i=0; i< 1; i++)
           {
               

                Console.WriteLine("Informe o seu nome");
                nome = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Infome o seu login");
                login = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Informe a sua senha");
                senha = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Informe o seu telefone");
                telefone = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Informe a sua data de nascimento");
                DtNasc = Convert.ToDouble(Console.ReadLine());
                
        
            }//Fim do for
        }//Fim do método 

     public void MostrarLogin()


    }//Fim da classe
}//Fim do projeto
