using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NetP.Base
{
    public class Clientes
    {   private List<string> listaDeClientes = new List<string>();

        public Clientes listaClientes()
        {
            Console.WriteLine("Clientes Encontrados na Lista:");
            foreach (string item in listaDeClientes)
            {
                Console.WriteLine($"Nome - {item}");
            }
            return null;
        }

        public Clientes adicionaClientes()
        {
            Console.WriteLine("Digite o nome a ser adicionado:");
            string nome = Console.ReadLine();
            listaDeClientes.Add(nome);
            return null;
        }

        public Clientes removeCliente()
        {
            Console.WriteLine("Digite o nome a ser adicionado:");
            string nome = Console.ReadLine();
            listaDeClientes.Remove(nome);

            return null;
        }
    }


    public class Menu: Clientes
    {
        public Clientes operation = new Clientes();
        public Clientes Tasks()
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
                        return adicionaClientes();
                    case "2":
                        return listaClientes();
                    case "3":
                        return removeCliente();
                    case "4":
                        break;

                    default:
                        Console.WriteLine("Tipo inválido");
                        break;

                } 
            }
                return null;
        }        
    }
}