using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora_Compleja
{
    //CLASS/CLASE
    public class Calculo
    {
        public double num1 {  get; set; }
        public double num2 { get; set; }
        public double result { get; set; }
        //SUBSTRACTION METHOD
        public void Substraction(double num1, double num2)
        {
            result = 0;
            result = num1 - num2;
        }
        //PLUS METHOD
        public void Plus(double num1, double num2)
        {
            result = 0;
            result = num1 + num2;
        }
        //MULTIPLICATION METHOD
        public void Multiplication(double num1, double num2)
        {
            result = 0;
            result = num1 * num2;
        }

        //DIVISON METHOD
        public void Division(double num1, double num2)
        {
            result = 0;
            result = num1 / num2;
        }
        //tan method
        public void CalcularTangente(double v)
        {
            double radianes = num1 * (Math.PI / 180);
            result = Math.Tan(radianes);
        }

    }
}
