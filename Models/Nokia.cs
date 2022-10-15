namespace DesafioPOO.Models
{
    // TODO: Herdar da classe "Smartphone"
    // Implementado
    public class Nokia : Smartphone
    {
        public Nokia(string numero, string modelo, string imei, int memoria) : base(numero, modelo, imei, memoria)
        {
        }

        // TODO: Sobrescrever o método "InstalarAplicativo"
        // Implementado
        public override void InstalarAplicativo(string nomeApp)
        {
           System.Console.WriteLine($"Instalando o aplicativo {nomeApp}...\nInstalação feita com sucesso no {base.Modelo}");
        }
    }
}