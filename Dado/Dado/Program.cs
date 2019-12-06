using System;

namespace Dado
{
    class Program
    {
        int sup1 = 0;
        int front1 = 0;
        int izq1 = 0;
        int infe1 = 0;
        int back1 = 0;
        int derecha1 = 0;

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
            int sup = random.Next(1,3);
            int front = 2;
            int izq = 3;
            if(sup == 2)
            {
                front = 3;
                izq = 1;

            }
            if (sup == 3)
            {
                front = 1;
                izq = 2;

            }
            if (random.Next() % 2 == 0)
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


            sup1 = sup1 + sup;
            front1 = front1 + front;
            izq1 = izq1 + izq;
            infe1 = infe1 + (7 - sup);
            back1 = back1 + (7 - front);
            derecha1 = derecha1 + (7 - izq);
            
            

        }

        public void girarDados()
        {
            sup1 = 0;
            front1 = 0;
            izq1 = 0;
            infe1 = 0;
            back1 = 0;
            derecha1 = 0;
            girarDado();
            girarDado();
            Console.WriteLine("-----------------------------------------------");
        }

        public void sumar()
        {
            Console.WriteLine("Las caras superiores suman: " + sup1);
            Console.WriteLine("Las caras frontales suman: " + front1);
            Console.WriteLine("Las caras de la izquierda suman: " + izq1);
            Console.WriteLine("Las caras inferiores suman: " + infe1);
            Console.WriteLine("Las caras de atras suman: " + back1);
            Console.WriteLine("Las caras de la derecha suman: " + derecha1);

        }



        static void Main(string[] args)
        {

            Program variable = new Program();
            variable.dibujarDado(4, 5, 6);
            variable.dibujarDado(4, 5, 6);
            while (Console.ReadKey().Key == ConsoleKey.Enter)
            {
                Console.WriteLine("Nueva Visualizacion");
                //variable.girarDado();
                variable.girarDados();
                variable.sumar();
            }


            Console.ReadLine();
        }
    }
}
