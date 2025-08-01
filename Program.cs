using System;

namespace Program
{
    class Notas
    {
        public static void Main(string[] agrs)
        {
            Console.WriteLine("=============== Simulador de Notas Escolares ===============");

            // Inserir nome e série do aluno
            Console.WriteLine($"Qual é o seu nome? ");
            string nome = Console.ReadLine();

            // Limpa o console
            Console.Clear();

            // Entrada de dados
            Console.WriteLine($"{nome}, digite a sua primeira nota: ");
            double nota1 = double.Parse(Console.ReadLine());

            Console.WriteLine($"Digite a segunda nota: ");
            double nota2 = double.Parse(Console.ReadLine());

            Console.WriteLine($"Digite a terceira nota: ");
            double nota3 = double.Parse(Console.ReadLine());

            Console.WriteLine($"Digite a quarta nota: ");
            double nota4 = double.Parse(Console.ReadLine());

            // Limpa o console
            Console.Clear();

            // Processamento dos dados
            double media = (nota1 + nota2 + nota3 + nota4) / 4;

            if (media >= 70 && media <= 100)
            {
                Console.WriteLine($"Parabéns, {nome}! Você foi aprovado!🥳. Sua média foi: {media}");
            }

            else if (media >= 50 && media <= 69)
            {
                Console.WriteLine($"Opa! Você precisa melhorar as suas notas!👀 Está de recuperação. Sua média foi: {media}");
            }
            else
            {
                Console.WriteLine($"Que pena, {nome}! Você foi reprovado.😢 Sua média foi: {media}");
            }

            // Classificação de Desempenho 
            if (media >= 90)
            {
                Console.WriteLine($"Desempenho: Excelente! ⭐️⭐️⭐️⭐️⭐️");
            }
            else if (media >= 70)
            {
                Console.WriteLine("Desempenho: Muito bom!⭐️⭐️⭐️⭐️");
            }
            else if (media >= 50)
            {
                Console.WriteLine("Desempenho: Você precisa estudar mais!⭐️⭐️⭐️");
            }
            else
            {
                Console.WriteLine("Desempenho: Se dedique mais nos seus estudos!⭐️");
            }

        }

        // 
    }
}