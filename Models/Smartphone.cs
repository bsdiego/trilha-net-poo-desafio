namespace DesafioPOO.Models
{
    public abstract class Smartphone
    {
        public string Numero { get; set; }
        // Implementado
        private string Modelo { get; set; }
        private string IME { get; set; }
        private int Memoria { get; set; }

        public Smartphone(string numero, string modelo, string ime, int memoria)
        {
            Numero = numero;
            // Implementado
            Modelo = modelo;
            IME = ime;
            Memoria = memoria;
        
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