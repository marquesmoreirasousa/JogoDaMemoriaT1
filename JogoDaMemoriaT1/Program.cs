using System;

namespace JogoDaMemoriaT1
{
    public class Program
    {
        public static void PrintMatrix(int[,] telaMain)
        {
            Console.Write("   ");
            for (int j = 0; j < 4; j++)
            {
                Console.Write(" {0}  ", j + 1);
            }
            Console.WriteLine("\n  -----------------");
            for (int i = 0; i < 4; i++)
            {
                Console.Write("{0} |", i + 1);
                for (int j = 0; j < 4; j++)
                {
                    Console.Write(" {0} |", telaMain[i, j]);
                }
                Console.WriteLine("\n  -----------------");
            }
            Console.WriteLine();
        }
        public static void Main(String[] Args)
        {

            int[,] jogo = new int[4, 4];
            int[,] tela = new int[4, 4];
            Player p1 = new Player("Marques");

            Console.WriteLine(p1.Name);

            //Para criar números aleatórios
            Random gerador = new Random();

            for (int i = 1; i <= 8; i++) //Atribui os pares de números às posições
            {
                //Escolhe a posição do primeiro número do par
                int lin, col;
                for (int j = 0; j < 2; j++)
                {
                    do
                    {
                        lin = gerador.Next(0, 4);
                        col = gerador.Next(0, 4);

                    } while (jogo[lin, col] != 0);
                    jogo[lin, col] = i;
                }
            }

            int acertos = 0;
            do
            {
                //Chamar método de impressão
                Program.PrintMatrix(tela);

                //Pedir as posições do primeiro número
                int lin1;
                do
                {
                    Console.WriteLine("Escolha uma linha para jogar [1, 4]: ");
                    lin1 = int.Parse(Console.ReadLine());
                } while (lin1 < 1 || lin1 > 4);

                int col1;
                do
                {
                    Console.WriteLine("Escolha uma coluna para jogar [1, 4]: ");
                    col1 = int.Parse(Console.ReadLine());
                } while (col1 < 1 || col1 > 4);

                lin1--;
                col1--;

                tela[lin1, col1] = jogo[lin1, col1];

                //Chamar método de impressão
                Program.PrintMatrix(tela);

                //Pedir as posições do segundo número
                int lin2;
                do
                {
                    Console.WriteLine("Escolha uma linha para jogar [1, 4]: ");
                    lin2 = int.Parse(Console.ReadLine());
                } while (lin2 < 1 || lin2 > 4);

                int col2;
                do
                {
                    Console.WriteLine("Escolha uma coluna para jogar [1, 4]: ");
                    col2 = int.Parse(Console.ReadLine());
                } while (col2 < 1 || col2 > 4);

                lin2--;
                col2--;

                tela[lin2, col2] = jogo[lin2, col2];

                //Chamar método de impressão
                Program.PrintMatrix(tela);

                //Em caso de acerto, a matriz tela permanece como está.
                //Em caso de erro, precisamos voltar as posições para zero.
                if (jogo[lin1, col1] != jogo[lin2, col2])
                {
                    tela[lin1, col1] = 0;
                    tela[lin2, col2] = 0;
                }
                else
                {
                    acertos++;
                }

            } while (acertos < 8);
        }
    }
}