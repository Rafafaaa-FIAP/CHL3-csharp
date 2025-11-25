using System;

namespace CHL3_csharp
{
    internal class Program
    {
        // Arrays internos que armazenam os registros
        // Eles começam com tamanho 100, mas podem crescer conforme necessário
        static string[] tipos = new string[100];
        static DateTime[] datas = new DateTime[100];
        static double[] valores = new double[100];

        // Quantidade total de registros armazenados
        static int totalRegistros = 0;

        static void Main(string[] args)
        {
            Console.WriteLine("=== REGISTRO DE ATIVIDADES DE SAÚDE ===\n");

            int opcao = 0;

            // Loop principal do programa (menu)
            do
            {
                MostrarMenu();

                // Valida a opção digitada
                if (!int.TryParse(Console.ReadLine(), out opcao))
                {
                    Console.WriteLine("Opção inválida! Pressione ENTER para continuar.");
                    Console.ReadLine();
                    continue;
                }

                // Executa a opção escolhida
                switch (opcao)
                {
                    case 1:
                        AdicionarRegistro();
                        MostrarFinalizacaoOpcao();
                        break;

                    case 2:
                        ListarRegistros();
                        MostrarFinalizacaoOpcao();
                        break;

                    case 3:
                        ExibirEstatisticas();
                        MostrarFinalizacaoOpcao();
                        break;

                    case 4:
                        Console.WriteLine("Encerrando...");
                        break;

                    default:
                        Console.WriteLine("Opção inválida! Pressione ENTER para continuar.");
                        Console.ReadLine();
                        break;
                }

            } while (opcao != 4);

            Console.WriteLine("\nPrograma finalizado!");
        }

        // Exibe o menu principal
        static void MostrarMenu()
        {
            Console.Clear();
            Console.WriteLine("\n╔════════════════════════════════════╗");
            Console.WriteLine("║                MENU                ║");
            Console.WriteLine("╠════════════════════════════════════╣");
            Console.WriteLine("║  1  - Adicionar registro           ║");
            Console.WriteLine("║  2  - Listar registros             ║");
            Console.WriteLine("║  3  - Exibir estatísticas          ║");
            Console.WriteLine("║  4  - Sair                         ║");
            Console.WriteLine("╚════════════════════════════════════╝");
            Console.Write("\nEscolha uma opção: ");
        }

        // Pausa antes de voltar ao menu
        static void MostrarFinalizacaoOpcao()
        {
            Console.WriteLine("\nPressione ENTER para voltar ao menu.");
            Console.ReadLine();
        }

        // ---------------- MÉTODO: Adicionar Registro ----------------
        static void AdicionarRegistro()
        {
            // Se o array estiver cheio, aumentamos automaticamente
            if (totalRegistros >= tipos.Length)
            {
                AumentarCapacidade();
            }

            Console.Clear();
            Console.WriteLine("=== ADICIONAR REGISTRO ===");

            Console.Write("Tipo de atividade (ex: exercício, água, sono): ");
            string tipo = Console.ReadLine();

            Console.Write("Data (formato DD/MM/AAAA): ");
            string dataStr = Console.ReadLine();

            // Validação do formato de data
            if (!DateTime.TryParseExact(
                dataStr,
                "dd/MM/yyyy",
                System.Globalization.CultureInfo.InvariantCulture,
                System.Globalization.DateTimeStyles.None,
                out DateTime data))
            {
                Console.WriteLine("Data inválida! Use o formato DD/MM/YYYY.");
                return;
            }

            Console.Write("Valor numérico (minutos, litros ou horas): ");
            if (!double.TryParse(Console.ReadLine(), out double valor) || valor < 0)
            {
                Console.WriteLine("Valor inválido! Não pode ser negativo.");
                return;
            }

            // Armazena o registro nos arrays
            tipos[totalRegistros] = tipo;
            datas[totalRegistros] = data;
            valores[totalRegistros] = valor;

            totalRegistros++;

            Console.WriteLine("Registro adicionado com sucesso!");
        }

        // ---------------- MÉTODO: Listar Registros ----------------
        static void ListarRegistros()
        {
            Console.Clear();
            Console.WriteLine("=== LISTA DE REGISTROS ===");

            if (totalRegistros == 0)
            {
                Console.WriteLine("Nenhum registro cadastrado.");
            }
            else
            {
                // Exibe cada registro formatado
                for (int i = 0; i < totalRegistros; i++)
                {
                    Console.WriteLine($"{i + 1}. Tipo: {tipos[i]} | Data: {datas[i]:dd/MM/yyyy} | Valor: {valores[i]}");
                }
            }
        }

        // ---------------- MÉTODO: Exibir Estatísticas ----------------
        static void ExibirEstatisticas()
        {
            Console.Clear();
            Console.WriteLine("=== ESTATÍSTICAS POR ATIVIDADE ===");

            if (totalRegistros == 0)
            {
                Console.WriteLine("Nenhum registro disponível.");
                return;
            }

            // Array temporário contendo os tipos únicos de atividades
            string[] tiposUnicos = new string[totalRegistros];
            int countTipos = 0;

            // Identifica tipos únicos
            for (int i = 0; i < totalRegistros; i++)
            {
                bool existe = false;

                for (int j = 0; j < countTipos; j++)
                {
                    if (tiposUnicos[j] == tipos[i])
                    {
                        existe = true;
                        break;
                    }
                }

                if (!existe)
                {
                    tiposUnicos[countTipos] = tipos[i];
                    countTipos++;
                }
            }

            // Calcula estatísticas por tipo
            for (int t = 0; t < countTipos; t++)
            {
                string tipoAtual = tiposUnicos[t];
                double soma = 0;
                int qtd = 0;

                // Soma todos os valores do tipo atual
                for (int i = 0; i < totalRegistros; i++)
                {
                    if (tipos[i] == tipoAtual)
                    {
                        soma += valores[i];
                        qtd++;
                    }
                }

                double media = soma / qtd;

                // Exibe o resultado
                Console.WriteLine($"\nAtividade: {tipoAtual}");
                Console.WriteLine($" - Total: {soma}");
                Console.WriteLine($" - Média: {media:F2}");
            }
        }

        // ---------------- MÉTODO: Aumentar Capacidade ----------------
        static void AumentarCapacidade()
        {
            // Aumenta o tamanho dos arrays em +50 cada vez que ficam cheios
            int novoTamanho = tipos.Length + 50;

            Array.Resize(ref tipos, novoTamanho);
            Array.Resize(ref datas, novoTamanho);
            Array.Resize(ref valores, novoTamanho);
        }
    }
}
