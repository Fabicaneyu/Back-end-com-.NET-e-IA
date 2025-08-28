using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;


namespace ExemploFundamentos.Commom.Models

// inicio da classe calculadora
{
    public class Calculadora
    // inicio do metodo, metodo é tudo que faz uma ação, neste caso tem 2 parametros
    // parametro é o argumento que vc vai passar para realizar alguma ação
    // aqui no caso, quem for chamar o somar, vai ter que passar 2 inteiros
    {
        public void Somar(int x, int y)
        {
            Console.WriteLine($"{x} + {y} = {x + y}");
        }
        public void Subtrair(int x, int y)
        {
            Console.WriteLine($"{x} - {y} = {x - y}");
        }
        public void Multiplicar(int x, int y)
        {
            Console.WriteLine($"{x} x {y} = {x * y}");
        }
        public void Dividir(int x, int y)
        {
            Console.WriteLine($"{x} /  {y} = {x / y}");
        }

        // calculos mais complexos use a classe Math
        public void Potencia(int x, int y)
        {
            double pot = Math.Pow(x, y);
            Console.WriteLine($"{x} ^ {y} = {pot}");
        }
        public void Seno(double angulo)
        {
            double radiano = angulo * Math.PI / 180;
            double seno = Math.Sin(radiano);
            Console.WriteLine($"Seno de {angulo} = {Math.Round(seno, 4)}"); //math round aredonda
        }
        public void Coseno(double angulo)
        {
            double radiano = angulo * Math.PI / 180;
            double coseno = Math.Cos(radiano);
            Console.WriteLine($"Seno de {angulo} = {Math.Round(coseno, 4)}");
        }
        public void Tangente(double angulo)
        {
            double radiano = angulo * Math.PI / 180;
            double tangente = Math.Tan(radiano);
            Console.WriteLine($"Seno de {angulo} = {Math.Round(tangente, 4)}");
        }
          public void RaizQuadrada (double x)
        {
            double raiz = Math.Sqrt(x);
            Console.WriteLine($"Raíz quadrada de {x} = {raiz}");
        }
    }
    // fim do metodo
}
// fim da classe calculadora