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
        static void Main(string[] args)
        {
            Program aux = new Program();
            while(Console.ReadKey().Key == ConsoleKey.Enter)
            {
                Console.WriteLine("Nueva Visualizacion Del Dado");
                aux.dibujarDado(4,5,6);

            }
            
        }
    }
}
