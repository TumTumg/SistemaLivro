using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_de_vendas_de_livros
{
    class ControlLogin
    {
        ModelLogin LoginSenha;
        private int opcao;

        public ControlLogin()
        {
            LoginSenha = new ModelLogin();//Conectar classe model e control
            ConsultarOpcao = -1;
        }//Fim do construtort

        public int ConsultarOpcao
        {
            get { return opcao; }
            set { opcao = value; }
        }


        public void MenuLogin()
        {
            Console.WriteLine("\n\n - Cadastro - \n\n" +
                              "0.Sair\n" +
                              "1.Cadastro\n" +
                              "3.Login\n");
            ConsultarOpcao = Convert.ToInt32(Console.ReadLine());
        }

        public void OperacaoLogin()
        {
            do
            {
                MenuLogin();
                switch (ConsultarOpcao)
                {
                    case 0:
                        Console.WriteLine("Obrigado!");
                        break;
                    case 1:
                        this.modelo.PreencherLogin();
                        this.modelo.MostrarLogin();
                        break;
                }


            } while (ConsultarOpcao != 0);//Fim do while
        }//Fim do método

    }

}
