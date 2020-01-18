using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjemploDecorador
{
    class Program
    {
        static void Main(string[] args)
        {
            IGuardadorCxP guardadorCxP = new GuardadorCxP();

            IDecoradorGuardadorCxP guardarCxPConGuardadorHistorial;
            IDecoradorGuardadorCxP guardarCxPConEnviadorEmail;


            Console.WriteLine("Modalidad 1: ");
            guardarCxPConGuardadorHistorial = new DecoradorGuardadorCxPGuardadorHistorial(guardadorCxP);
            Console.WriteLine($"{guardarCxPConGuardadorHistorial.GuardarCxP()}\n");


            Console.WriteLine("Modalidad 2: ");
            guardarCxPConEnviadorEmail = new DecoradorGuardadorCxPEnviadorEmail(guardadorCxP);
            Console.WriteLine($"{guardarCxPConEnviadorEmail.GuardarCxP()}\n");

            Console.WriteLine("Modalidad 3:");
            guardarCxPConGuardadorHistorial = new DecoradorGuardadorCxPGuardadorHistorial(guardadorCxP);
            guardarCxPConEnviadorEmail = new DecoradorGuardadorCxPEnviadorEmail(guardarCxPConGuardadorHistorial);
            Console.WriteLine($"{guardarCxPConEnviadorEmail.GuardarCxP()}\n");
            Console.ReadKey();
        }
    }
}
