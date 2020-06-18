using System;

namespace Aula19Fixação
{
    class Program
    {
        static void Main(string[] args)
        {
            Vip hariel = new Vip();

            hariel.Valor = 300;
            hariel.Valoradicional = 200;
            

            Console.WriteLine("Digite Comum para adquirir ingresso comum e Vip para adquirir o ingresso VIP.");
            string resposta = Console.ReadLine();


            switch (resposta)
            {
                case "Comum": hariel.ImprimirIngressocomum();
                break;
                
                case "Vip": hariel.ImprimirVip();
                break;

                default:System.Console.WriteLine("DIGITE UMA OÇÃO VALIDA!");
                break;
            }

        }
    }
}
