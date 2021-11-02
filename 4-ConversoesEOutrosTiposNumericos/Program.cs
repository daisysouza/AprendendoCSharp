using System;

namespace _4_ConversoesEOutrosTiposNumericos
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando o projeto 4");

            double salario = 1200.50;

            // o int é um tipo de variavel que suporta valores até 32 bits

            int salarioEmInteiro;
            salarioEmInteiro = (int) salario;

            Console.WriteLine(salarioEmInteiro);

            // o long é uma variável de 64 bits

            long idade = 130000000000000;
            Console.WriteLine(idade);

            // o short é um tipo de variável que suporta 16 bits

            short quantidadeProdutos;
            quantidadeProdutos = 15000;
            Console.WriteLine(quantidadeProdutos);

            float altura = 1.80f;
            Console.WriteLine(altura);




            Console.ReadLine();
        }
    }
}
