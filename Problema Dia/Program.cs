using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Queue<string> filaDeTarefas = new Queue<string>();
        Stack<string> pilhaDeTarefasConcluidas = new Stack<string>();

        while (true)
        {
            Console.WriteLine("Escolha uma opção:");
            Console.WriteLine("1. Adicionar tarefa");
            Console.WriteLine("2. Concluir tarefa");
            Console.WriteLine("3. Mostrar fila e pilha");
            Console.WriteLine("4. Sair");

            string escolha = Console.ReadLine();

            switch (escolha)
            {
                case "1":
                    Console.WriteLine("Digite uma tarefa:");
                    string novaTarefa = Console.ReadLine();
                    AdicionarTarefa(filaDeTarefas, novaTarefa);
                    break;

                case "2":
                    ConcluirTarefa(filaDeTarefas, pilhaDeTarefasConcluidas);
                    break;

                case "3":
                    MostrarFilaEPilha(filaDeTarefas, pilhaDeTarefasConcluidas);
                    break;

                case "4":
                    Console.WriteLine("Saindo do programa.");
                    // Aguarda uma tecla antes de encerrar o programa
                    Console.ReadKey();
                    return;

                default:
                    Console.WriteLine("Opção inválida. Tente novamente.");
                    break;
            }
        }
    }

    static void AdicionarTarefa(Queue<string> fila, string tarefa)
    {
        fila.Enqueue(tarefa);
        Console.WriteLine($"Tarefa adicionada: {tarefa}");
    }

    static void ConcluirTarefa(Queue<string> fila, Stack<string> pilha)
    {
        if (fila.Count > 0)
        {
            string tarefaConcluida = fila.Dequeue();
            pilha.Push(tarefaConcluida);
            Console.WriteLine($"Tarefa concluída: {tarefaConcluida}");
        }
        else
        {
            Console.WriteLine("Erro: Não há tarefas para concluir.");
        }
    }

    static void MostrarFilaEPilha(Queue<string> fila, Stack<string> pilha)
    {
        Console.WriteLine("\nFila de Tarefas:");
        foreach (var tarefa in fila)
        {
            Console.WriteLine(tarefa);
        }

        Console.WriteLine("\nPilha de Tarefas Concluídas:");
        foreach (var tarefa in pilha)
        {
            Console.WriteLine(tarefa);
        }
    }
}
