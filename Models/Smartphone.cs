namespace DesafioPOO.Models
{
    public abstract class Smartphone
    {
        public string Nome { get; set; }
        public string Numero { get; set; }
        public string Modelo { get; set; }
        public string Imei { get; set; }
        public int Memoria { get; set; }
       
        public Smartphone(string nome, string numero, string modelo, string imei, int memoria)
        {
            Nome = nome;
            Numero = numero;
            Modelo = modelo;
            Imei = imei;
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