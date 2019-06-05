using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Actividad1
{
    class Program
    {
        static void Main(string[] args)
        {
            Usuario usuario = new Usuario();
            Animal perro = new Animal();
            Dinero pesos = new Dinero();
            Console.Write("Bienvenid@\n");
            Console.WriteLine("¿Cúal es su nombre?");
            usuario.nombre = Console.ReadLine();
            Console.WriteLine("¿Cual es el nombre de la mascota que adoptará?");
            perro.nombre = Console.ReadLine();
            Console.WriteLine("¿Cantidad a donar a la fundación <1$ al monto que desee>?");
            pesos.cantidad = Console.Read();
            Captura captura = new Captura(perro, usuario, pesos);
            Console.ReadLine();
        }
    }
}
