namespace DesafioPOO.Models
{
    public class Nokia : Smartphone
    {
        public Nokia(string numero, string modelo, string imei, int memoria) : base(numero, modelo, imei, memoria) 
        {
            Aplicativos.Add("Gmail");
        }

        public override void InstalarAplicativo(string nomeApp)
        {
            Console.WriteLine($"Instalando aplicativo \"{nomeApp}\" neste celular Nokia.");
            RegistrarAplicativoInstalado(nomeApp);
        }

        public override void ExibirAplicativosInstalados()
        {
            Console.WriteLine("Exibindo lista de aplicativos instalados na Google Play Store: ");
            foreach (var aplicativo in Aplicativos)
            {
                Console.WriteLine(aplicativo);
            }
        }
    }
}