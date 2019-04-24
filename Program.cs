using System;


class Program
{
    static void Main(string[] args)
    {
        metodo();

    }

    static void metodo()
    {
        Console.WriteLine("Metodo padre");
        metodoUno();

        void metodoUno() {
            Console.WriteLine("Metodo privado");
        }
    }
}
