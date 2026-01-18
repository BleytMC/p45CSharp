namespace _47_ClassLib
{
    public class PC
    {
        private string company;
        private string model;
        private string serialNumber;

        public string Company { get; set; }
        public string Model { get; set; }
        public string SerialNumber { get; set; }

        public PC()
        {
            company = string.Empty;
            model = string.Empty;
            serialNumber = string.Empty;
        }

        public PC(string company, string model, string serialNumber)
        {
            this.company = company;
            this.model = model;
            this.serialNumber = serialNumber;
        }

        public void TurnOn()
        {
            Console.WriteLine("You have turned on your PC!");
        }

        public void TurnOff()
        {
            Console.WriteLine("You have turned off your PC!");
        }

        public void Reboot()
        {
            Console.WriteLine("You have rebooted your PC!");
        }

        public override string ToString()
        {
            return $"Company: {company}\nModel: {model}\nSerial Number: {serialNumber}";
        }
    }
}
