using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NetP.Base
{
    public class Clientes
    {   private List<string> listaDeClientes = new List<string>();

        public void listaClientes()
        {
            Console.WriteLine("Clientes Encontrados na Lista:");
            foreach (string item in listaDeClientes)
            {
                Console.WriteLine(item);
            }
            
        }

        public void adicionaClientes()
        {
            Console.WriteLine("Digite o nome a ser adicionado:");
            string nome = Console.ReadLine();
            listaDeClientes.Add(nome);
            
        }

        public void removeCliente()
        {
            Console.WriteLine("Digite o nome a ser adicionado:");
            string nome = Console.ReadLine();
            listaDeClientes.Remove(nome);

            
        }
    }


    public class Menu: Clientes
    {
        public Clientes operation = new Clientes();
        public void Tasks()
        {
            bool exibirMenu = true;
            while (!exibirMenu == false)
            {
                Console.WriteLine("Digite uma Operação: ");
                Console.WriteLine("1 - Cadastrar Clientes");
                Console.WriteLine("2 - Excluir Clientes");
                Console.WriteLine("3 - Listar Clientes");
                Console.WriteLine("4 - Encerrar");
                string option = Console.ReadLine();

                switch (option)
                {
                    case "1":
                         adicionaClientes();
                         break;
                    case "2":
                         listaClientes();
                         break;
                    case "3":
                         removeCliente();
                         break;
                    case "4":
                        break;

                    default:
                        Console.WriteLine("Tipo inválido");
                        break;

                } 
            }
                
        }        
    }
}