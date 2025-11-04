using System;

class Program
{
    static void Main(string[] args)
    {
        double saldo = 0;
        bool executando = true;
        Console.Title = "Cunsultar dados";

        while (executando)
        {
            Console.Clear();
            Console.WriteLine("=== 💰 Caixa Eletrônico ===");
            Console.WriteLine("1 - Consultar Saldo");
            Console.WriteLine("2 - Depositar");
            Console.WriteLine("3 - Sacar");
            Console.WriteLine("4 - Sair");
            Console.Write("Escolha uma opção: ");
            string? opcao = Console.ReadLine();

            switch (opcao)
            {
                case "1":
                    ConsultarSaldo(saldo);
                    break;

                case "2":
                    saldo = Depositar(saldo);
                    break;

                case "3":
                    saldo = Sacar(saldo);
                    break;

                case "4":
                    executando = false;
                    Console.WriteLine("\nEncerrando o programa!!");
                    break;

                default:
                    Console.WriteLine("Opção invalida");
                    break;
            }

            if (executando)
            {
                Console.WriteLine("\nPrecine qualquer tecla para continar...");
                Console.ReadKey();
            }
        }
        static void ConsultarSaldo(double saldo)
        {
            Console.WriteLine($"\nSeu saldo atual é: R${saldo:F2}");
        }

        static double Depositar(double saldo)
        {
            Console.Write("\nDigite o valor do depósito: ");
            if (double.TryParse(Console.ReadLine(), out double valor) && valor > 0)
            {
                saldo += valor;
                Console.WriteLine($"✅ Depósito de R${valor:F2} realizado com sucesso!");
            }
            else
            {
                Console.WriteLine("❌ Valor inválido!");
            }

            return saldo;
        }

        static double Sacar(double saldo)
        {
            Console.Write("\nDigite o valor do saque: ");
            if (double.TryParse(Console.ReadLine(), out double valor) && valor > 0)
            {
                if (valor <= saldo)
                {
                    saldo -= valor;
                    Console.WriteLine($"💸 Saque de R${valor:F2} realizado com sucesso!");
                }
                else
                {
                    Console.WriteLine("❌ Saldo insuficiente!");
                }
            }
            else
            {
                Console.WriteLine("❌ Valor inválido!");
            }

            return saldo;
        }
    }
}