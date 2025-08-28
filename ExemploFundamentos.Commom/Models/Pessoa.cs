using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace ExemploFundamentos.Commom.Models
{
    // classe pessoa
    public class Pessoa
    {
        //atributos dessa pessoa, ela tera texto e numero, nome e idade
        public string Nome { get; set; }
        public int Idade { get; set; }

        // método o que essa pessoa poderá fazer, pensando num the sims ela pode se apresentar
        public void Apresentar()
        {
            Console.WriteLine($" Olá, meu nome é {Nome} \n e tenho {Idade} anos ");
        }


    }
}
