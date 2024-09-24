namespace DesafioPOO.Models
{
    public class Iphone : Smartphone
    {
        public Iphone(string numero, string modelo, string imei, int memoria) : base(numero, modelo, imei, memoria)
        {
            Aplicativos.Add("iMessage");
        }

        public override void InstalarAplicativo(string nomeApp)
        {
            Console.WriteLine($"Instalando aplicativo \"{nomeApp}\" direto da App Store.");
            RegistrarAplicativoInstalado(nomeApp);
        }

        public override void ExibirAplicativosInstalados()
        {
            Console.WriteLine("Exibindo lista de aplicativos instalados na App Store: ");
            foreach (var aplicativo in Aplicativos)
            {
                Console.WriteLine(aplicativo);
            }
        }
    }
}