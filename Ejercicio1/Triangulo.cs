using System;
using System.Collections.Generic;
using System.Text;

namespace Ejercicio1
{
    class Triangulo
    {
        private double baseT;

        public Triangulo(double baseT)
        {
            this.baseT = baseT;
        }

        public double getBaseT() { return this.baseT; }

        public void setBaseT(double baseT) { this.baseT = baseT; }

        public double calcularPerimetro()
        {
            return this.baseT * 3;
        }

        public double calcularArea()
        {
            return (Math.Sqrt(3) / 4) * Math.Pow(this.baseT, 2);
        }

        public override string ToString()
        {
            return "El perímetro es [" + this.calcularPerimetro() + "] y el área es [" + this.calcularArea() + "]";
        }
    }
}
