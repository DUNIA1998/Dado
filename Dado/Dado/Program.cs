using System;

namespace Dado
{
    class Program
    {
        public void dibujarDado(int caraSuperior, int caraFrontal, int caraIzquierda)
        {
            //Cara Superior
            Console.WriteLine("                     ##########          ");
            Console.WriteLine("                     #        #          ");
            Console.WriteLine("                     #    {0}   #          ", caraSuperior);
            Console.WriteLine("                     #        #          ");

            //Caras Frontales
            Console.WriteLine("#########################################");
            Console.WriteLine("#         #         #         #         #");
            Console.WriteLine("#   {0}     #    {1}    #     {2}   #     {3}   #", 7-caraFrontal, 7-caraIzquierda, caraFrontal, caraIzquierda);
            Console.WriteLine("#         #         #         #         #");
            Console.WriteLine("#########################################");

            //Cara Inferior
            Console.WriteLine("                     #        #          ");
            Console.WriteLine("                     #    {0}   #          ", 7-caraSuperior);
            Console.WriteLine("                     #        #          ");
            Console.WriteLine("                     ##########          ");


        }

        static void Main(string[] args)
        {

            Program variable = new Program();

            while (Console.ReadKey().Key == ConsoleKey.Enter)
            {
                Console.WriteLine("Nueva Visualizacion");
                variable.dibujarDado(4,5,6);

            }


            Console.ReadLine();
        }
    }
}
