namespace DesafioPOO.Models
{
    public abstract class Smartphone
    {
        public string Numero { get; set; }
        public string Modelo { get; }
        public string IMEI { get; }
        public int Memoria { get; }

        protected Smartphone(string numero, string modelo, string imei, int memoria)
        {
            Numero = numero;
            Modelo = modelo;
            IMEI = imei;
            Memoria = memoria;
        }

        public void Ligar()
        {
            Console.Clear();
            Console.WriteLine("Ligando...");
            Thread.Sleep(2000);
        }

        public void ReceberLigacao()
        {
            Console.Clear();
            Console.WriteLine("Recebendo ligação...");
            Thread.Sleep(2000);
        }

        public abstract void InstalarAplicativo(string nomeApp);
    }
}