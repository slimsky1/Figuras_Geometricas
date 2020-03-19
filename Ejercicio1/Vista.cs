using System;
using System.Collections.Generic;
using System.Text;

namespace Ejercicio1
{
    class Vista
    {
        public void getVistaGeneral()
        {
            Console.WriteLine("Elija la figura geométrica para calcular perímetro y área");
            Console.WriteLine("---------------------------------------------------------");
            Console.WriteLine("1. Triángulo");
            Console.WriteLine("2. Cuadrado");
            Console.WriteLine("3. Rectángulo");
            Console.WriteLine(Environment.NewLine);
            Console.Write("Elija la opción: ");
            int opcion = int.Parse(Console.ReadLine());

            while (opcion != 1 && opcion != 2 && opcion != 3)
            {
                Console.Clear();
                this.getVistaGeneral();
            }

            Console.Clear();

            switch (opcion)
            {
                case 1:
                    this.getVistaTriangulo();
                    break;
                case 2:
                    this.getVistaCuadrado();
                    break;
                case 3:
                    this.getVistaRectangulo();
                    break;
            }
            this.getVistaGeneral();
        }
        public void getVistaTriangulo()
        {
            Console.WriteLine("Se necesitan lo siguientes datos para realizar el cálculo de área y perímetro de un triángulo");
            Console.WriteLine("---------------------------------------------------------------------------------------------");
            Console.Write("Ingrese la base: ");
            double baseT = double.Parse(Console.ReadLine());

            Triangulo triangulo1 = new Triangulo(baseT);
            Console.Write(triangulo1);
            Console.ReadLine();
            Console.Clear();
        }

        public void getVistaCuadrado()
        {
            Console.WriteLine("Se necesitan lo siguientes datos para realizar el cálculo de área y perímetro de un cuadrado");
            Console.WriteLine("---------------------------------------------------------------------------------------------");
            Console.Write("Ingrese la longitud de los lados: ");
            double lado = double.Parse(Console.ReadLine());

            Cuadrado cuadrado1 = new Cuadrado(lado);
            Console.Write(cuadrado1);
            Console.ReadLine();
            Console.Clear();
        }

        public void getVistaRectangulo()
        {
            Console.WriteLine("Se necesitan lo siguientes datos para realizar el cálculo de área y perímetro de un rectangulo");
            Console.WriteLine("---------------------------------------------------------------------------------------------");
            Console.Write("Ingrese la base: ");
            double baseR = double.Parse(Console.ReadLine());
            Console.Write("Ingrese la altura: ");
            double altura = double.Parse(Console.ReadLine());

            Rectangulo rectangulo1 = new Rectangulo(baseR, altura);
            Console.Write(rectangulo1);
            Console.ReadLine();
            Console.Clear();
        }
    }
}
