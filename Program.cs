using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp2
{
    class Program
    {
        //criando a variavel static PI
        static double Pi = 3.14;
        static void Main(string[] args)
        {
            //Solicitando o valor do raio
            Console.WriteLine("Entre com valor do raio: ");

            //Verificando o que o utilizador escreveu e armazenando na variavel "raio"
            double raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            //Gerando uma variavel de circulo do tipo double e instanciando-a com o método circuferência da classe Caculadora
            double circ = Circuferencia(raio);
            //Gerando a variavel de volume do tipo double e instanciando-a com o método volume da classe Caculadora
            double volume = Volume(raio);

            //Inserindo o resultado da circunferencia e a convertendo para String
            Console.WriteLine("Circuferência: " + circ.ToString("F2", CultureInfo.InvariantCulture));
            //Escrevendo o resultado do volume e convertendo ela para String
            Console.WriteLine("Volume: " + volume.ToString("F2", CultureInfo.InvariantCulture));
            //Escrevendo o valor de PI e convertendo-o para String
            Console.WriteLine("Valor de PI: " + Pi.ToString("F2", CultureInfo.InvariantCulture));
        }
        //Gerando o método Circuferência e passando como parametro a variavel double r
        static double Circuferencia(double r)
        {
            //Calculando para retornar o valor do comprimento da circunferência
            return 2.0 * Pi * r;
        }
        //Criando o método Volume e passando como parametro a variavel double r
        static double Volume(double r)
        {
            //Fazendo o calculo para retornar o valor do volume da circuferencia
            return 4.0 / 3.0 * Pi * r * r * r;
        }


    }
}