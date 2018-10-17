using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_Objeto_Triangulo
{
    class Triangulo
    {
        private double lado1, lado2, lado3;
        public Triangulo(double lado1, double lado2, double lado3)
        {
            this.lado1 = lado1;
            this.lado2 = lado2;
            this.lado3 = lado3;
        }
        public bool EsIsosceles()
        {
            if (lado1 == lado2 || lado1 == lado3 || lado2 == lado3)
            {
                return true;
            }
            else
            {
                return false;
            } 
        }
        public bool EsEquilatero()
        {
            if (lado1 == lado2 && lado1 == lado3 )
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool EsRectangulo()
        {
            if (lado1 == lado2 || lado1 == lado3 || lado2 == lado3)//TODO: Falta hacer esto
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
//Diseñar una clase llamada Triangulo con tres atributos: lado1, lado2 y lado3, un constructor que me permita declarar
//objetos con tres argumentos y los métodos:
//EsIsosceles que devolverá verdadero si el triángulo es isósceles y falso en caso contrario
//EsEquilatero que devolverá verdadero si el triángulo es isósceles y falso en caso contrario
//EsRectangulo que devolverá verdadero si el triángulo es isósceles y falso en caso contrario
//Perímetro que devolverá el perímetro del triángulo
//Desde el método main() de la clase principal probar su funcionamiento
