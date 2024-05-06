namespace DesafioPOO.Models
{
    // TODO: Herdar da classe "Smartphone"
    public class Nokia : Smartphone
    {
        public Nokia(string nome, string numero, string modelo, string imei, int memoria) : base(nome, numero, modelo, imei, memoria)
        {

        }
        
        // TODO: Sobrescrever o método "InstalarAplicativo"   IMPLEMENTADO
        public override void InstalarAplicativo(string nomeApp)
        {
            Console.WriteLine($"O app {nomeApp} foi instalado com sucesso");
        }

    }
}