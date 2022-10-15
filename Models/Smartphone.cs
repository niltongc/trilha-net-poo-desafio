namespace DesafioPOO.Models
{
    public abstract class Smartphone
    {
        private string _numero;
        public string Numero
        { 
            get
            {
                return _numero;
            } 
            set
            {
                if (value.Length == 9)
                {
                    _numero = value;
                }
                else
                {
                    throw new ArgumentException("O numero de telefone deve conter 9 digitos");
                }
            } 
        }
        // TODO: Implementar as propriedades faltantes de acordo com o diagrama
        // Implementado
        protected string Modelo { get; set; }
        protected string IMEI {get; set;}
        protected int Memoria { get; set; }


        public Smartphone(string numero, string modelo, string imei, int memoria)
        {
            Numero = numero;
            Modelo = modelo;
            IMEI = imei;
            Memoria = memoria;
            // TODO: Passar os parâmetros do construtor para as propriedades
            // Implementado
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