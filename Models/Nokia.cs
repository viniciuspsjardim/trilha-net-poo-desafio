namespace DesafioPOO.Models
{
    // TODO: Herdar da classe "Smartphone"
    public class Nokia : Smartphone
    {
        public Nokia(string numero, string modelo, int imei, int armazenamento) : base(numero, modelo, imei, armazenamento)
        {
        }


        public override void InstalarAplicativo(string nomeApp)
        {
            Console.WriteLine("Acessando a PlayStore");
            Console.WriteLine($"Procurando por {nomeApp}");
            Console.WriteLine("Programa encontrado, instalando....");
            Console.WriteLine($"{nomeApp} instalado com sucesso.");;
        }
    }
}