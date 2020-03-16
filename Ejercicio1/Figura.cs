using System;
using System.Collections.Generic;
using System.Text;

namespace Ejercicio1
{
    class Figura
    {
        private String nombre;
        private double area;
        private double perimetro;

        public Figura(string nombre)
        {
            this.nombre = nombre;
        }

        public String getNombre()
        {
            return this.nombre;
        }

        public void getNombre(String nombre)
        {
            this.nombre = nombre;
        }


        public double getArea()
        {
            return this.area;
        }

        public void getArea(double area)
        {
            this.area = area;
        }

        public double getPerimetro()
        {
            return this.perimetro;
        }

        public void getPerimetro(double perimetro)
        {
            this.perimetro = perimetro;
        }

        public override string ToString()
        {
            return "Figura " + this.nombre + ": Area - " + this.area + " Perímetro - " + this.perimetro;
        }
    }
}
