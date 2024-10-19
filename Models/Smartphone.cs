namespace DesafioPOO.Models
{
    public abstract class Smartphone
    {
        public string Number { get; set; }

        private string Model { get; set; }

        private string Imei { get; set; }

        private int Memorie { get; set;}

        public Smartphone(string number, string model, string imei, int memorie)
        {
            Number = number;
            Model = model;
            Imei = imei;
            Memorie = memorie;
        }

        public void TurnOn()
        {
            Console.WriteLine("Turning on...");
        }

        public void ReceivingCall()
        {
            Console.WriteLine("Receiving  Call...");
        }

        public abstract void downloadingApp(string nomeApp);
    }
}