/*Desenvolva um programa que solicite o multiplicador ao usuário e apresente o resultado da multiplicação de 0 a 10*/

using System;

namespace ExercicioTabuadaComUmMutiplicador
{
    class Program
    {
        static void Main(string[] args)
        {
            int multiplicador;
            int multiplicando = 0;
            int resultado; 

            Console.WriteLine("Digite o multiplicador: ");
            multiplicador = Convert.ToInt32(Console.ReadLine());

           
            
            while(multiplicando <= 10)
            {
                resultado = multiplicando * multiplicador;
                Console.WriteLine($"{multiplicador} x {multiplicando} = {resultado}");
                multiplicando = multiplicando + 1;
            }
        }
    }
}
