using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramacaoOrientadaAObjetos
{
    internal class ExemploMetodoComParametroeConstrutor
    {
        public string marca;

        public ExemploMetodoComParametroeConstrutor(string nomeMarca)
        {

             marca = nomeMarca;

        }
        public static void Main(string[] args)
        {
            ExemploMetodoComParametroeConstrutor meuCarro = new ExemploMetodoComParametroeConstrutor("Ferrari");
            Console.Write("A marca do meu carro é : " + meuCarro.marca);
        }


    }
}
