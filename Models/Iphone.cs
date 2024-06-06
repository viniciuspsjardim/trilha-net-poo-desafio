namespace DesafioPOO.Models
{
    // TODO: Herdar da classe "Smartphone"
    public class Iphone : Smartphone
    {
        public Iphone(string numero, string modelo, int imei, int armazenamento) : base(numero, modelo, imei, armazenamento)
        {
        }

        public override void InstalarAplicativo(string nomeApp)
        {
            Console.WriteLine("Acessando a Apple Store");
            Console.WriteLine($"Procurando por {nomeApp}");
            Console.WriteLine("Programa encontrado, instalando....");
            Console.WriteLine($"{nomeApp} instalado com sucesso.");
        }
    }
}