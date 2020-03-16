using System;
using System.Collections.Generic;
using System.Text;

namespace Ejercicio1
{
    class Triangulo
    {
        private double baseT;
        private double altura;

        public Triangulo(double baseT, double altura)
        {
            this.baseT = baseT;
            this.altura = altura;
        }

        public double getBaseT() { return this.baseT; }

        public void setBaseT(double baseT) { this.baseT = baseT; }

        public double getAltura() { return this.altura; }

        public void setAltura(double altura) { this.altura = altura; }

        public double calcularPerimetro()
        {
            return this.baseT * 3;
        }

        public double calcularArea()
        {
            return (this.baseT * this.altura) / 2;
        }

        public override string ToString()
        {
            return "El perímetro es [" + this.calcularPerimetro() + "] y el área es [" + this.calcularArea() + "]";
        }
    }
}
