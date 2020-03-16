using System;
using System.Collections.Generic;
using System.Text;

namespace Ejercicio1
{
    class Rectangulo
    {
        private double baseR;
        private double altura;

        public Rectangulo(double baseR, double altura)
        {
            this.baseR = baseR;
            this.altura = altura;
        }

        public double getBaseR() { return this.baseR; }

        public void setBaseR(double baseR) { this.baseR = baseR; }

        public double getAltura() { return this.altura; }

        public void setAltura(double altura) { this.altura = altura; }

        public double calcularPerimetro()
        {
            return this.baseR * this.altura;
        }

        public double calcularArea()
        { 
            return ((this.baseR * 2) + (this.altura * 2));
        }

        public override string ToString()
        {
            return "El perímetro es [" + this.calcularPerimetro() + "] y el área es [" + this.calcularArea() + "]";
        }
    }
}
