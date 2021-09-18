using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp2
{
    class Caculadora
    {
        public double Pi = 3.14;

        //Criando o método Circuferencia e passando como parametro a variavel double r
        public double Circuferencia(double r)
        {
            //Fazendo o calculo para retornar o valor do comprimenro da circuferencia
            return 2.0 * Pi * r;
        }
        //Criando o método Volume e passando como parametro a variavel double r
        public double Volume(double r)
        {
            //Fazendo o calculo para retornar o valor do volume da circuferencia
            return 4.0 / 3.0 * Pi * r * r * r;
        }
    }
}