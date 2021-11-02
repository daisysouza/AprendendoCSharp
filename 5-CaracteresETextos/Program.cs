using System;

namespace _5_CaracteresETextos
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando o projeto 5 - Caracteres e textos");

            //character. A linguagem C# não aceita as aspas duplas,
            //se colocarmos aspas duplas, o conteúdo será interpretado como um texto -> uma string
            
            char primeiraLetra = 'a';
            Console.WriteLine(primeiraLetra);

            primeiraLetra = (char)61;
            Console.WriteLine(primeiraLetra);

            //o C# vai realizar a soma, e depois, fará o casting com o resultado
            //que será um número inteiro
            primeiraLetra = (char)(primeiraLetra + 1);
            Console.WriteLine(primeiraLetra);

            string titulo = "And She's Buying a Stairway to Heaven" + 2007;
            string Mothership = 
                @" -Whole Lotta Love
                -Ramble On
                -Heartbreaker";        
                
                Console.WriteLine(titulo);
                Console.WriteLine(Mothership);




            //instrução que impede que a janela feche até que o usuário tecle enter
            Console.ReadLine();
        }
    }
}
