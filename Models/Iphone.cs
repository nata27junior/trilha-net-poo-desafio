using System;

namespace DesafioPOO.Models
{
    // TODO: Herdar da classe "Smartphone"
    public class Iphone : Smartphone
    {
        // TODO: Sobrescrever o método "InstalarAplicativo"
        public Iphone(string numero, string modelo, string imei, int memoria) 
            : base(numero, modelo, imei, memoria)
        {
             // O construtor da classe filha deve chamar o construtor da base
        }

        public override void InstalarAplicativo(string nomeApp)
        {
            Console.WriteLine($"Instalando o aplicativo \"{nomeApp}\" no iPhone.");
        }
    }
}