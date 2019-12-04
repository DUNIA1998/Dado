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

        public void girarDado()
        {
            Random random = new Random();
            int sup = 1;
            int front = 2;
            int izq = 3;
            if(random.Next() % 2 == 0)
            {
                sup = 7 - sup;
            }
            if (random.Next() % 2 == 0)
            {
                front = 7 - front;
            }
            if (random.Next() % 2 == 0)
            {
                izq = 7 - izq;
            }
            dibujarDado(sup, front, izq);   
            
            

        }



        static void Main(string[] args)
        {

            Program variable = new Program();
            variable.dibujarDado(4, 5, 6);
            while (Console.ReadKey().Key == ConsoleKey.Enter)
            {
                Console.WriteLine("Nueva Visualizacion");
                variable.girarDado();

            }


            Console.ReadLine();
        }
    }
}
