namespace DesafioPOO.Models
{
    // TODO: Herdar da classe "Smartphone"
    public class Iphone : Smartphone
    {
        public Iphone(string numero, string modelo, string imei, int memoria) : base(numero, modelo, imei, memoria)
        {

        }
        public override void InstalarAplicativo(string nomeApp)
        {
            Console.WriteLine($"---- Instalação de App no Iphone ----");
            Console.WriteLine("Efetuando a instalação do App " + nomeApp);
            Console.WriteLine($"---- Instalação de App no Iphone ----");
        }
    }
}