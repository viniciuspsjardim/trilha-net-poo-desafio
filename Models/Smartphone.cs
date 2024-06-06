namespace DesafioPOO.Models
{
    public abstract class Smartphone
    {
        public string Numero { get; set; }
        public string Modelo { get; set; }
        public int IMEI { get; set; }
        public int Armazenamento { get; set; }

        // TODO: Implementar as propriedades faltantes de acordo com o diagrama

        public Smartphone(string numero, string modelo, int imei , int armazenamento)
        {
            Numero = numero;
            Modelo = modelo;
            IMEI = imei;
            Armazenamento = armazenamento;
        }

        public void Ligar()
        {
            Console.WriteLine("Ligando...");
        }

        public void ReceberLigacao()
        {
            Console.WriteLine("Recebendo ligação...");
        }

        public abstract void InstalarAplicativo(string nomeApp);
    }
}