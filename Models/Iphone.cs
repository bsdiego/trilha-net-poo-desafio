namespace DesafioPOO.Models
{
    // Implementado
    public class Iphone : Smartphone
    {
        public Iphone (string numero, string modelo, string ime, int memoria) : base(numero, modelo, ime, memoria)
        {
        }


        // Implementado
        public override void InstalarAplicativo(string nomeApp)
        {
            Console.WriteLine($"Instalado o aplicativo \"{nomeApp}\" no Iphone");
        }
    }
}