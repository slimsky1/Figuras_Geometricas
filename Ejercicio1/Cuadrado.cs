using System;
using System.Collections.Generic;
using System.Text;

namespace Ejercicio1
{
    class Cuadrado
    {
        private double lado;
        
        public Cuadrado(double lado)
        {
            this.lado = lado;
        }

        public double getLado() { return this.lado; }

        public void setLado(double lado) { this.lado = lado; }

        public double calcularPerimetro()
        {
            return this.lado * 4;
        }

        public double calcularArea()
        {
            return Math.Pow(this.lado, 2);
        }

        public override string ToString()
        {
            return "El perímetro es [" + this.calcularPerimetro() + "] y el área es [" + this.calcularArea() + "]";
        }
    }
}
