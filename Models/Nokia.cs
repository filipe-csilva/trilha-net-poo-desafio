namespace DesafioPOO.Models
{
    public class Nokia : Smartphone
    {
        public Nokia(string numero, string modelo, string imei, int memoria) : base(numero, modelo, imei, memoria)
        {
        }

        public override void InstalarAplicativo(string nomeApp)
        {
            Console.Clear();
            Console.WriteLine("Acessando o PlayStore...");
            Thread.Sleep(2000);


            Random random = new Random();

            for (int i = 0; i <= 100; i++)
            {
                Console.Clear();
                Console.Write($"Instalando o {nomeApp}...");

                Console.WriteLine($"{i}%");

                int tempoEspera = random.Next(50, 300);

                Thread.Sleep(tempoEspera);
            }

            Console.Write($"Foi efetuada a Instalação do {nomeApp} com sucesso!");
        }
    }
}