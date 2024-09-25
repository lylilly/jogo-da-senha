
using System;

using System;

class JogoDaSenha
{
    static void Main(string[] args)
    {
        Console.WriteLine("BEM VINDO AO JOGO DA SENHA :) ");

        Console.WriteLine("Jogador 1 digite a senha de 0 a 100:");
       
        int senha = int.Parse(Console.ReadLine());

        Console.Clear();

        for (int i = 0; i < 100; i++)
        {
            Console.WriteLine("Jogador 2 qual sua  tentativa? " + (i + 1) + ":");
            int tentativa = int.Parse(Console.ReadLine());

            if (tentativa == senha)
            {
                Console.WriteLine("Parabéns! Você acertou a senha :).");
                return;
            }

            if (tentativa < senha)
            {
                Console.WriteLine("A senha é maior.");
            }
            else
            {
                Console.WriteLine("A senha é menor.");
            }
        }

        Console.WriteLine("Você não acertou :( . A senha era " + senha + ".");
    }
}

