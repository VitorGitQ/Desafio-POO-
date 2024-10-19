namespace DesafioPOO.Models
{
    
    public class Iphone : Smartphone
    {
        public Iphone(string numero, string model, string imei, int memorie) : base(numero, model, imei, memorie)
        {

        }

        public override void downloadingApp(string appName)
        {
            Console.WriteLine($"{appName} is downloading now on your Iphone...");
            Console.WriteLine($"{appName} was downloanded ;)");
        }
    }
}