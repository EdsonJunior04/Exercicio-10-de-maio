using System;

namespace Exercicios_10_de_maio
{
    class Program
    {
        static void Main(string[] args)
        {
                float ano;
                bool check =true;
                string texto = "";
                while(check == true)
        {
            Console.WriteLine("Em qual ano você nasceu ? " + texto);
            ano = float.Parse(Console.ReadLine());

            if (ano <= 2005 )
            {
                Console.WriteLine("Você pode votar !!!");
                check = false;
            }
            else
            {
                Console.WriteLine("Você não pode votar !!!");
                texto = " digite novamente";
            }
        }
        }    
    }
}