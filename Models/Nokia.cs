namespace DesafioPOO.Models
{
    public class Nokia : Smartphone
    {

        public Nokia(string numero, string modelo, string imei, int memoria) : base(numero, modelo, imei, memoria)
        {
                
        }

        // TODO: Sobrescrever o método "InstalarAplicativo"
        public override void InstalarAplicativo(string nomeApp)
        {
            Console.WriteLine($"---- Instalação de App no Nokia ----");
            Console.WriteLine("Efetuando a instalação do App " + nomeApp);
            Console.WriteLine($"---- Instalação de App no Nokia ----");
        }
    }
}