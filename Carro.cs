using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramacaoOrientadaAObjetos
{
    internal class Carro
    {
        string cor = "vermelho";

        public static void Main(string[] args){
        
        Carro carroSenac = new Carro();
            Carro carroProa = new Carro();

            Console.WriteLine("A cor do carro é : "+carroSenac.cor);
            Console.WriteLine("A cor do carro é : "+carroProa.cor);


        }
    }
}
