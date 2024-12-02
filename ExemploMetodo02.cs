using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramacaoOrientadaAObjetos
{
    internal class ExemploMetodo02
    {
        public static void NomeCompleto(string nome)
        {

            Console.WriteLine("Meu nome completo é : " + nome + " Costa dos Santos");

        }
        public static void Main(String[] args)
        {

            NomeCompleto("Jailson");
            NomeCompleto("Cristina");

        }
    }
}
