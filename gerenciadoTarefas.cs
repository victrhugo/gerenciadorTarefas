using System;
using System.Collections.Generic;

namespace gerenciadorTarefas
{
    class Program
    {
        static List<string> tarefas = new List<string>();

        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("== Gerenciador de Tarefas - VH ==");
                Console.WriteLine("1 - Adicionar Tarefa");
                Console.WriteLine("2 - Listar Tarefas");
                Console.WriteLine("3 - Remover Tarefa");
                Console.WriteLine("4 - Sair do sistema");
                Console.Write("Escolha uma opção: ");

                string opcao = Console.ReadLine();

                switch (opcao)
                {
                    case "1":
                        AdicionarTarefa();
                        break;
                    case "2":
                        ListarTarefas();
                        break;
                    case "3":
                        RemoverTarefa();
                        break;
                    case "4":
                        Console.WriteLine("Saindo do sistema...");
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Opção inválida!");
                        break;
                }
            }
        }

        static void AdicionarTarefa()
        {
            Console.WriteLine("Digite a nova tarefa: ");
            string tarefa = Console.ReadLine();

            if (!string.IsNullOrWhiteSpace(tarefa))
            {
                tarefas.Add(tarefa);
                Console.WriteLine("Tarefa adicionada!");
            }
            else
            {
                Console.WriteLine("A tarefa não pode ser vazia.");
            }
        }

        static void ListarTarefas()
        {
            if (tarefas.Count == 0)
            {
                Console.WriteLine("Nenhuma tarefa cadastrada.");
            }
            else
            {
                Console.WriteLine("== Lista de Tarefas - VH ==");
                for (int i = 0; i < tarefas.Count; i++)
                {
                    Console.WriteLine($"{i + 1} - {tarefas[i]}");
                }
            }
        }

        static void RemoverTarefa()
        {
            ListarTarefas();

            if (tarefas.Count > 0)
            {
                Console.WriteLine("Digite o número da tarefa que deseja remover: ");
                if (int.TryParse(Console.ReadLine(), out int numero) && numero > 0 && numero <= tarefas.Count)
                {
                    tarefas.RemoveAt(numero - 1);
                    Console.WriteLine("Tarefa removida!");
                }
                else
                {
                    Console.WriteLine("Número inválido.");
                }
            }
        }
    }
}
