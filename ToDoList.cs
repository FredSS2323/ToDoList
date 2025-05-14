using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace ToDoList
{
    class ToDoList
    {
        static List<Tarefa> tarefas = new List<Tarefa>();

        static void Main (string [] args)
        {
            bool executando = true;
            while(executando)
            {
                Menu();
                var opcao = Console.ReadLine();
                
                switch (opcao)
                {
                    case "1":
                    NovaTarefa();
                    break;
                    case "2":
                    ListarTarefa();
                    break;
                    case "3":
                    RemoverTarefa();
                    break;
                    case "4":
                    ConcluirTarefa();
                    break;
                    case "5":
                    ConcluirTodos();
                    break;
                    case "6":
                    ApagarTodos();
                    break;
                    case "7":
                    GerarArquivo();
                    break;
                    case "8":
                    executando = false;
                    break;
                    default:
                    Console.WriteLine("Inválido! Por gentileza escolha uma opção válida");
                    Console.WriteLine("\nPressione qualquer tecla para continuar...");
                    Console.ReadKey();
                    break;

                }
                
            }
        }

        static void Menu() 
        {
            Console.Clear();
            Console.WriteLine("Escolha uma opção: ");
            Console.WriteLine("1-Nova Tarefa");
            Console.WriteLine("2-Listar Tarefas");
            Console.WriteLine("3-Remover uma Tarefa");
            Console.WriteLine("4-Concluir uma Tarefa");
            Console.WriteLine("5-Concluir Todos");
            Console.WriteLine("6-Apagar Todos");
            Console.WriteLine("7-Gerar Arquivo de Tarefas");
            Console.WriteLine("8-Sair");
            Console.WriteLine("-----------------------------------------");
        }

        static void NovaTarefa() 
        {
          
                Console.WriteLine("Digite o nome da tarefa: ");
                var nome = Console.ReadLine();
                
                tarefas.Add(new Tarefa(string.IsNullOrEmpty(nome)? "SEM DESCRIÇÃO" : nome)); 
                Console.WriteLine("Tarefa adicionada com sucesso!");
                Console.WriteLine("Pressione qualquer tecla para continuar...");
                Console.ReadKey();
            
        }


        static void ListarTarefa() 
        {
            Console.WriteLine("\nTarefas:");
            for (int i = 0; i < tarefas.Count; i++)
            {
                string status = tarefas[i].STATUS ? "[Concluída]" : "[Pendente]";
                Console.WriteLine($"{i + 1}. {tarefas[i].NOME} {status}");
            }
            Console.WriteLine("-----------------------------------------");
            Console.WriteLine("Pressione qualquer tecla para continuar...");
            Console.ReadKey();
        }

        static void RemoverTarefa() 
        {
            ListarTarefa();
            Console.Write("Digite o número da tarefa para remover: ");
            int numero = Convert.ToInt32(Console.ReadLine()) - 1;

            if (numero >= 0 && numero < tarefas.Count)
            {
                tarefas.RemoveAt(numero);
                Console.WriteLine("Tarefa removida com sucesso!");
            }
            else
            {
                Console.WriteLine("Número de tarefa inválido.");
            }
            Console.WriteLine("-----------------------------------------");
            Console.WriteLine("Pressione qualquer tecla para continuar...");
            Console.ReadKey();
        }

        static void ConcluirTarefa() 
        {
            ListarTarefa();
            Console.Write("Digite o número da tarefa para marcar como concluída: ");
            int numero = Convert.ToInt32(Console.ReadLine()) - 1;

            if (numero >= 0 && numero < tarefas.Count)
            {
                tarefas[numero].STATUS = true;
                Console.WriteLine("Tarefa marcada como concluída!");
            }
            else
            {
                Console.WriteLine("Número de tarefa inválido.");
            }
            Console.WriteLine("-----------------------------------------");
            Console.WriteLine("Pressione qualquer tecla para continuar...");
            Console.ReadKey();
        }

        static void ConcluirTodos() 
        {
            
            foreach(var tar in tarefas)
            {
                tar.STATUS = true;
            }
            Console.WriteLine("Tarefas concluídas!");
            Console.WriteLine("-----------------------------------------");
            Console.WriteLine("Pressione qualquer tecla para continuar...");
            Console.ReadKey();
        }

        static void ApagarTodos() 
        {
            tarefas.Clear();

            Console.WriteLine("Tarefas removidas com sucesso!");
            Console.WriteLine("-----------------------------------------");
            Console.WriteLine("Pressione qualquer tecla para continuar...");
            Console.ReadKey();
        }

        static void GerarArquivo() 
        {
            List<string> linhas = tarefas.ConvertAll(t => $"{t.NOME} {(t.STATUS == false ? " Pendente" : " Concluída")}");
            string? entrada;
            string caminhoArquivo;
            
            /*Caso a variável entrada seja nula sepre vai gerar o arquivo na pasta do projeto*/
            Console.Write("Insira o caminho .txt para gerar: ");
            entrada = Console.ReadLine();
            caminhoArquivo = string.IsNullOrEmpty(entrada) ? "Relatório.txt" : entrada ; 
 
            File.WriteAllLines(caminhoArquivo, linhas);

            Console.WriteLine("Lista salva com sucesso!");
            Console.WriteLine("Pressione qualquer tecla para continuar...");
            Console.ReadKey();
        }
    }

}