namespace DesafioPOO.Models
{
   
    public class Nokia : Smartphone
    {
        public Nokia(string numero, string model, string imei, int memorie) : base(numero, model, imei, memorie)
        {

        }

        public override void downloadingApp(string appName)
        {
            Console.WriteLine($"{appName} is downloading now on your Nokia...");
            Console.WriteLine($"{appName} was downloanded ;)");
        }
    }
}