using System;
// tudo orientado a obj

namespace MyApp //separa completamente um bloco de codigo, precisa de chave, como se fosse uma ilha 
{
    internal class Program //
    {
        // Main -- primeira coisa que ira executar no código (main), tem que ter
        static void Main(string[] args) 
        {
            Console.BackgroundColor = ConsoleColor.White; // muda as cores somente das linhas afetadas
            Console.ForegroundColor = ConsoleColor.Magenta; // muda a cor somente das letras do codigo
            Console.Clear(); // limpa as cores do fundo-
            Console.WriteLine("Hello World!");
            Console.WriteLine("ola, meu eu futuro");

            Console.Write("teste teste");
            Console.Write("teste teste");
            Console.Write("teste teste");

            //Console.Beep(4000, 1);    faz um som de beep no compuador, faz o som de 1000Hz por 4 ms
        }
    }
}