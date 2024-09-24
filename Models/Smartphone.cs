namespace DesafioPOO.Models
{
    public abstract class Smartphone
    {
        public string Numero { get; set; }
        private string Modelo { get; set; }
        private string IMEI { get; set; }
        private int Memoria { get; set; }
        protected List<string> Aplicativos { get; set; } = new List<string>();

        public Smartphone(string numero, string modelo, string imei, int memoria)
        {
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

        public abstract void InstalarAplicativo(string nomeApp);

        public abstract void ExibirAplicativosInstalados();
        
        protected void RegistrarAplicativoInstalado(string nomeApp)
        {
            Aplicativos.Add(nomeApp);
        }

        public override string ToString()
        {
            return $"Este é um celular {Modelo} com {Memoria}GB de armazenamento de número {Numero}";
        }
    }
}