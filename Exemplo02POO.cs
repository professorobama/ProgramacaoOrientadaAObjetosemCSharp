using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramacaoOrientadaAObjetos
{
    internal class Exemplo02POO
    {

        string cor = "vermelho";

        public static void Main(string[] args)
        {
            Exemplo02POO hulk = new Exemplo02POO();
            Exemplo02POO superman = new Exemplo02POO();
            Console.WriteLine("A cor do super herói Hulk é : "+hulk.cor);
            Console.WriteLine("A cor do super herói Superman é : "+superman.cor);
        }
    }
}
