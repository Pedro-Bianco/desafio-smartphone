using System;

namespace DesafioPOO.Models
{
    public abstract class Smartphone
    {
        public string Numero { get; set; }
        public string Modelo { get; set; }
        public string Marca { get; set; }

        public Smartphone(string numero, string modelo, string marca)
        {
            Numero = numero;
            Modelo = modelo;
            Marca = marca;
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

    public class Nokia : Smartphone
    {
        public Nokia(string numero, string modelo) : base(numero, modelo, "Nokia")
        {
            
        }

        public override void InstalarAplicativo(string nomeApp)
        {
            Console.WriteLine($"Instalando {nomeApp} na plataforma Nokia...");
           
        }
    }

    public class Iphone : Smartphone
    {
        public Iphone(string numero, string modelo) : base(numero, modelo, "iPhone")
        {
            
        }

        public override void InstalarAplicativo(string nomeApp)
        {
            Console.WriteLine($"Instalando {nomeApp} na plataforma iPhone...");
            
        }
    }

    public class Program
    {
        static void Main(string[] args)
        {
            
            Nokia nokiaPhone = new Nokia("913424368", "Nokia");
            Iphone iphone = new Iphone("987654321", "iPhone");

       
            nokiaPhone.Ligar();
            nokiaPhone.InstalarAplicativo("WhatsApp");

            iphone.Ligar();
            iphone.InstalarAplicativo("Instagram");

            
            Console.ReadLine();
        }
    }
}
