using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula08Atividade
{
    class Program
    {
        static List<string> usuarios = new List<string>();
        static void Main(string[] args)
        {
            string opcao;

            Console.WriteLine("Cadastro de usuários");
            Console.WriteLine("1 - Cadastrar");
            Console.WriteLine("2 - Buscar");
            Console.WriteLine("Digite uma opção");
            opcao = Console.ReadLine();

            if (opcao == "1")
            {
                Console.WriteLine("Digite o nomme que deseja cadastrar: ");
                usuarios.Add(Console.ReadLine());
                Console.WriteLine("Nome cadastrado com sucesso");
                Console.Clear();
                Main(null);
                return;
            }
            if(opcao == "2")
            {
                int quantidade = usuarios.Count;
                int posicao;

                Console.WriteLine("Digite a posição que deseja buscar:");
                posicao = int.Parse(Console.ReadLine());


                if(quantidade < posicao)
                {
                    Console.WriteLine("Posição não encontrada.");
                    Console.ReadLine();
                    Console.Clear();
                    return;
                }

                Console.WriteLine($"O nome nesta posição é {usuarios[0]}");
                Console.ReadLine();
                Console.Clear();
                Main(null);
                return;
            }
            Console.ReadKey();
        }
    }
}
