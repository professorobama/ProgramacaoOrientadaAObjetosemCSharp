namespace ProgramacaoOrientadaAObjetos
{
    internal class ExemploMetodo04
    {
        static void PaisOrigem(string pais = "Brasil")
        {

            Console.WriteLine("Meu país de origem é : " + pais);
            


        }
        public static void Main(string[] args)
        {

            PaisOrigem("Argentina");
            PaisOrigem("Chile");
            PaisOrigem();
            PaisOrigem("Guatemala");

        }
    }
}
