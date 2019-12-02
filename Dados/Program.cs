using System;

namespace Dados
{
    class Program
    {

        public void dibujarDado(int caraSuperior, int caraInferior, int caraLaterales)//40 13
        {
            Console.WriteLine("                    ###########          ");
            Console.WriteLine("                    #         #          ");
            Console.WriteLine("                    #    {0}    #          ", caraSuperior);
            Console.WriteLine("                    #         #          ");
            Console.WriteLine("#########################################");
            Console.WriteLine("#         #         #         #         #");
            Console.WriteLine("#    {0}    #    {1}    #    {2}    #    {3}    #", caraInferior, caraLaterales, 7-caraInferior, 7-caraLaterales);
            Console.WriteLine("#         #         #         #         #");
            Console.WriteLine("#########################################");
            Console.WriteLine("                    #         #          ");
            Console.WriteLine("                    #    {0}    #         ",7-caraSuperior);
            Console.WriteLine("                    #         #          ");
            Console.WriteLine("                    ###########          ");
        }

        public int[] asigancionDeValores()
        {
            Random random = new Random();
            int[] valoresDescartados = new int[3];
            int[] valores = new int[3];
            int x = 0;
            do
            {
                int numeroRandom = random.Next(1, 7);
                int numeroDescartado = 7 - numeroRandom;
                Boolean condicion = true; 
                for(int y = 0; y < 3; y++)
                {
                    if(valores[y] == numeroRandom || valoresDescartados[y] == numeroRandom)
                    {
                        condicion = false;
                    }
                }
                for(int y = 0; y < 3; y++)
                {
                    if (valoresDescartados[y] == numeroDescartado || valores[y] == numeroDescartado)
                    {
                        condicion = false;
                    }
                }
                if(condicion)
                {
                    valores[x] = numeroRandom;
                    valoresDescartados[x] = numeroDescartado;
                    x++;
                }
            }
            while (x<3);

            return valores;
        }
        static void Main(string[] args)
        {
            bool condicion = true;
            while (condicion)
            {
                if (Console.ReadKey().Key == ConsoleKey.Enter)
                {
                    Program aux = new Program();
                    int[] valores = aux.asigancionDeValores();
                    Console.WriteLine("Nueva Visualizacion Del Dado");
                    aux.dibujarDado(valores[0], valores[1], valores[2]);
                }
                else if (Console.ReadKey().Key == ConsoleKey.Escape)
                {
                    condicion = false;
                }
            }
        }
    }
}
