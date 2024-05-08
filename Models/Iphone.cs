namespace DesafioPOO.Models
{
    public class Iphone : Smartphone
    {
        public Iphone(string numero, string modelo, string imei, int memoria) : base(numero, modelo, imei, memoria)
        {
        }

        public override void InstalarAplicativo(string nomeApp)
        {
            Console.Clear();
            Console.WriteLine("Acessando o AppStore...");
            Thread.Sleep(2000);

            Random random = new Random();

            for (int i = 0; i <= 100; i++)
            {
                Console.Clear();
                Console.Write($"Instalando o {nomeApp}...");

                Console.WriteLine($"{i}%");

                int tempoEspera = random.Next(25, 200);

                Thread.Sleep(tempoEspera);
            }

            Console.Write($"Foi efetuada a Instalação do {nomeApp} com sucesso!");
        }
    }
}