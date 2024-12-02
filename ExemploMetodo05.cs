using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramacaoOrientadaAObjetos
{

    internal class ExemploMetodo05
    {
        public static int Soma(int numero, int numero1) {

            return numero + numero1;
        }

        public static void Main(string[] args) {

            Console.WriteLine("A soma dos valores é : " + Soma(10,20));
        }
    }
}
