namespace DesafioPOO.Models
{
    // TODO: Herdar da classe "Smartphone"
    // Implementado
    public class Iphone : Smartphone
    {
        // TODO: Sobrescrever o método "InstalarAplicativo"
        // Implementado
        public Iphone(string numero, string modelo, string imei, int memoria) : base(numero, modelo, imei, memoria)
        {
            
        }
        public override void InstalarAplicativo(string nomeApp)
        {
            System.Console.WriteLine($"O iOS está configurando o ambiente de instalação\nInstalação do {nomeApp} iniciada...\nInstação concluida no {base.Modelo}");
        }
    }
}