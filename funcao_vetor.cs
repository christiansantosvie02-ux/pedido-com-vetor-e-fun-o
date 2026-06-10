using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("=== RESTAURANTE SABOR E ARTE ===\n");

        Console.Write("Nome do garçom: ");
        string garcom = Console.ReadLine();

        Console.Write("Quantos pedidos no turno? ");
        int qtdPedidos = int.Parse(Console.ReadLine());

        double[] totais = new double[qtdPedidos];

        Console.WriteLine();

        for (int i = 0; i < qtdPedidos; i++)
        {
            totais[i] = ProcessarPedido(i + 1);
            ExibirComprovante(i + 1, garcom, totais[i]);
        }

        ExibirResumoTurno(totais, garcom);
    }

    static double ProcessarPedido(int numeroPedido)
    {
        Console.Write($"Pedido {numeroPedido} - quantos itens? ");
        int qtdItens = int.Parse(Console.ReadLine());

        double total = 0;

        for (int i = 0; i < qtdItens; i++)
        {
            Console.Write($"  Item {i + 1}: R$ ");
            double valor = double.Parse(Console.ReadLine());

            total += valor;
        }

        Console.WriteLine();

        return total;
    }

    static void ExibirComprovante(int numeroPedido, string garcom, double total)
    {
        Console.WriteLine("---------------------------");
        Console.WriteLine($"   COMPROVANTE - Pedido {numeroPedido}");
        Console.WriteLine("---------------------------");
        Console.WriteLine($"Garçom:  {garcom}");
        Console.WriteLine($"Total:   R$ {total:F2}");
        Console.WriteLine("---------------------------");
        Console.WriteLine();
    }

    static void ExibirResumoTurno(double[] totais, string garcom)
    {
        double totalGeral = 0;

        Console.WriteLine("===========================");
        Console.WriteLine("      RESUMO DO PEDIDO");
        Console.WriteLine("===========================");
        Console.WriteLine($"Garçom: {garcom}");
        Console.WriteLine();

        for (int i = 0; i < totais.Length; i++)
        {
            Console.WriteLine($"  Pedido {i + 1}: R$ {totais[i]:F2}");
            totalGeral += totais[i];
        }

        Console.WriteLine("---------------------------");
        Console.WriteLine($"  TOTAL GERAL: R$ {totalGeral:F2}");
        Console.WriteLine("===========================");
    }
}