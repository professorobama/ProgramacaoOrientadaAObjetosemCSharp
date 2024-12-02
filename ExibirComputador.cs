using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramacaoOrientadaAObjetos
{
    internal class ExibirComputador
    {
        public static void Main(string[] args)
        {
            Computador computadorLuan = new Computador();
            Console.WriteLine("O Id do computador é : "+ computadorLuan.idComputador);
            Console.WriteLine("A marca do computador é : "+ computadorLuan.marcaComputador);
            Console.WriteLine("O fabricante do computador é : "+ computadorLuan.fabricanteComputador);
            Console.WriteLine("O processador do computador é : "+ computadorLuan.processadorComputador);
            Console.WriteLine("A memória RAM do computador é : "+ computadorLuan.memoriaRamComputador);
            Console.WriteLine("O armazenamento do computador é : "+ computadorLuan.armazenamentoComputador);
            Console.WriteLine("O Sistema Operacional do computador é : "+ computadorLuan.sistemaOperacionalComputador);
            Console.WriteLine("O preço do computador é : "+ computadorLuan.precoComputador);
        }
    }
}
