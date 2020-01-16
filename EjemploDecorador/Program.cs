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

            IDecoradorGuardadorCxP guardarCxPConGuardadorHistorial = new DecoradorGuardadorCxPGuardadorHistorial(guardadorCxP);
            IDecoradorGuardadorCxP guardarCxPConEnviadorEmail = new DecoradorGuardadorCxPEnviadorEmail(guardarCxPConGuardadorHistorial);

            Console.WriteLine($"{guardarCxPConEnviadorEmail.GuardarCxP()}");
            Console.ReadKey();
        }
    }
}
