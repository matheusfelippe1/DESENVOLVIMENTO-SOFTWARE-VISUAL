using System;

namespace aula2_1
{
    class SwitchCase
    {
        public static void Main(string[] args)
        {
            string menu "--- Projeto -------\n" +
                "1 - Fatorial: \n" +
                "2 - Ver valores de 1 até N \n" +
                "3 - Sair:";
            int option = 3;
            do
            {
                Console.WriteLine(menu);
                option = int.Parse(Console.ReadLine());
            } while (option != 3);
        }
    }
}