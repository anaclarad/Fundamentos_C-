using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExemplosFundamentos.Common.Models
{
    public class Calculadora
    {
        public void Somar(int x, int y){
            Console.WriteLine($"{x} + {y} = {x + y}");
        }
        public void Subtrair(int x, int y){
            Console.WriteLine($"{x} - {y} = {x - y}");
        }

        public void Multiplicar(int x, int y){
            Console.WriteLine($"{x} x {y} = {x * y}");
        }
        
        public void Dividir(int x, int y){
            Console.WriteLine($"{x} / {y} = {x / y}");
        }

         public void Potenvia(int x, int y){
            double pot = Math.Pow(x,y);
            Console.WriteLine($"{x} ^ {y} = {pot}");
        }
    }
}