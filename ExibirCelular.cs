using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramacaoOrientadaAObjetos
{
    internal class ExibirCelular
    {
        public static void Main(string[] args)
        {
            Celular iPhone = new Celular();
            Console.WriteLine("O Id do celular é : "+iPhone.id);
            Console.WriteLine("O nome do celular é : "+iPhone.nome);
            Console.WriteLine("A marca do celular é : "+iPhone.marca);
            Console.WriteLine("O modelo do celular é : "+iPhone.modelo);
            Console.WriteLine("A descrição do celular é : "+iPhone.descricao);
            Console.WriteLine("O preço do celular é : "+iPhone.preco);
        }
    }
}
