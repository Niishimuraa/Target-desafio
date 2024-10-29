using System;

namespace Questoes
{
    public static class Questoes
    {
        public static void Questao1()
        {
            Console.Clear();
            Console.WriteLine("=============================================================");
            Console.WriteLine("                 SEQUÊNCIA DE FIBONACCI");
            Console.WriteLine("=============================================================\n");

            Console.Write("Quantos números do da sequência de Fibonacci você quer: ");

            //TryParse para não permitir letras
            if(!int.TryParse(Console.ReadLine(), out int inputValue))
            {
                Console.Write("Erro retornando ao menu inicial.");
                return;
            }

            //valores para inicialização
            int a = 0, b = 1;
            int temp = 0;

            //if para printar os números iniciais de Fibonacci 0 e 1
            if (inputValue >= 1)
            {
                Console.WriteLine(a);
            }
            if (inputValue >= 2)
            {
                Console.WriteLine(b);
            }

            //caso seja maior que 2 números, printar os demais
            for (int i = 2; i < inputValue; i++)
            {
                temp = a;
                a = b;
                b = temp + b;
                Console.WriteLine(b);
            }

            //Explicação
            //A sequência de Fibonacci, onde se inicia por 0 e 1 e o próximo valor sempre
            //será a soma dos 2 valores anteriores
            //Exemplo (0,1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144, 233, 377, 610, 987, 1597, 2584, ...)

            Console.WriteLine("Retornando para o menu inicial");
        }

        public static void Questao2()
        {
            Console.Clear();
            Console.WriteLine("=============================================================");
            Console.WriteLine("                 CONTADOR DE LETRA A");
            Console.WriteLine("=============================================================\n");

            Console.WriteLine("Informe uma palavra ou frase: ");
            string inputValue = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(inputValue))
            {
                Console.WriteLine("Nenhuma palavra foi informada.");
                return;
            }

            string normalizedValue = inputValue.ToLower();
            int count = 0;

            foreach (char c in normalizedValue)
            {
                if (c == 'a') count++;
            }

            Console.WriteLine($"\nA frase informada tem {count} letras 'a'.");
            Console.WriteLine("Retornando para o menu inicial");
        }

        public static void Questao3()
        {
            Console.Clear();
            Console.WriteLine("=============================================================");
            Console.WriteLine("                 TESTE DE LÓGICA 1");
            Console.WriteLine("=============================================================\n");
            Console.WriteLine("Observe o trecho de código abaixo: \n" +
                "int INDICE = 12, SOMA = 0, K = 1; enquanto K < INDICE faça { K = K + 1; SOMA = SOMA + K; } imprimir(SOMA);\r\n\r\n" +
                "Ao final do processamento, qual será o valor da variável SOMA?");

            int INDICE = 12, SOMA = 0, K = 1;

            do
            {
                K = K + 1;
                SOMA = SOMA + K;
            }
            while (K < INDICE);

            Console.WriteLine($"O valor final da SOMA é: {SOMA}");

            Console.WriteLine("Retornando para o menu inicial");
        }

        public static void Questao4()
        {
            Console.Clear();
            Console.WriteLine("=============================================================");
            Console.WriteLine("                 TESTE DE LÓGICA 2");
            Console.WriteLine("=============================================================\n");

            Console.WriteLine("Descubra a lógica e complete o próximo elemento:\n" +
                "a) 1, 3, 5, 7, ___\n" +
                "b) 2, 4, 8, 16, 32, 64, ____\n" +
                "c) 0, 1, 4, 9, 16, 25, 36, ____\n" +
                "d) 4, 16, 36, 64, ____\n" +
                "e) 1, 1, 2, 3, 5, 8, ____\n" +
                "f) 2, 10, 12, 16, 17, 18, 19, ____\n");

            Console.WriteLine("Respostas:\n" +
                "a) 9\n" +
                "b) 128\n" +
                "c) 49\n" +
                "d) 100\n" +
                "e) 13\n" +
                "f) 20\n");



            Console.WriteLine("Retornando para o menu inicial");
        }

        public static void Questao5()
        {
            Console.Clear();
            Console.WriteLine("=============================================================");
            Console.WriteLine("                 TESTE DE LÓGICA 3");
            Console.WriteLine("=============================================================\n");

            Console.WriteLine("Você está em uma sala com três interruptores, cada um conectado\r\n" +
                "a uma lâmpada em salas diferentes. Você não pode ver as lâmpadas da sala em que está,\r\n" +
                "mas pode ligar e desligar os interruptores quantas vezes quiser. Seu objetivo é descobrir\r\n" +
                "qual interruptor controla qual lâmpada. Como você faria para descobrir, usando apenas duas\r\n" +
                "idas até uma das salas das lâmpadas, qual interruptor controla cada lâmpada?\n");

            Console.WriteLine("Resposta: \n" +
                "Acenderia o interruptor 1 e esperaria alguns segundos, após isso, apagaria o interruptor 1 e\r\n" +
                "acenderia o interruptor 2. Após isso, iria na sala 1, se estivesse apagada e quente, seria o\r\n" +
                "interruptor 1, se estivesse acessa, seria o interruptor 2 e se estivesse apagada e frio, seria o\r\n" +
                "interruptor 3, iria para a próxima sala e repitiria o processo para descobrir qual interruptor\r\n" +
                "acende a lâmpada de cada sala.");

            Console.WriteLine("Retornando para o menu inicial");
        }
    }
}
