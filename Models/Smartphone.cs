using System;

namespace DesafioPOO.Models
{
    public abstract class Smartphone
    {
        // Propriedade pública
        public string Numero { get; set; }
        
        // Propriedades privadas (Encapsulamento) conforme costuma ser pedido neste desafio
        private string Modelo;
        private string IMEI;
        private int Memoria;

        public Smartphone(string numero, string modelo, string imei, int memoria)
        {
            // TODO: Passar os parâmetros do construtor para as propriedades
            Numero = numero;
            Modelo = modelo;
            IMEI = imei;
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

        // TODO: Declarar o método abstrato InstalarAplicativo
        public abstract void InstalarAplicativo(string nomeApp);
    }
}