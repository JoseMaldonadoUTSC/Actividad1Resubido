using System;

namespace Actividad1
{
    class Captura
    {

        public Captura() { }
        public Captura(Animal perro, Usuario usuario, Dinero cantidad) { realizarAdopcion(perro, usuario, cantidad); }
        public void realizarAdopcion(Animal perro, Usuario usuario, Dinero pesos)
        {
            Console.WriteLine("Buen día: " + usuario.nombre + "\nSe realizó la adopción de: " + perro.nombre + "\nSe donó la cantidad de: " + pesos.cantidad + " a nuestra fundación");
            Console.Write("Gracias!");
            Console.ReadLine();
        }
    }
}