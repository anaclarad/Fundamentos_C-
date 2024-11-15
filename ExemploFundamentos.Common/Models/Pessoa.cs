using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExemplosFundamentos.Common.Models

// uma classe é um molde do que vai ser o objeto no código, por enquanto ela ainda não faz nada pois ainda não foi instanciada. Além disso, posso ter várias cópias da minha classe desde que o namespace(nome acima) seja diferebre
// Nome de classe de classe sempre começa com maiúsculo ou seja fica em PacalCase, além disso, nome de método e propriedades também seguem a mesma linha
{
    public class Pessoa
    {
            public string Nome { get; set; }
            public int Idade { get; set; }


            public void Apresentar(){
                Console.WriteLine($"Olá meu nome é {Nome}, e tenho {Idade} anos");

        }
    }
    
}