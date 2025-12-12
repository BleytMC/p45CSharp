namespace _32_PingPongEvents
{
    class Pong
    {
        public event EventHandler<CounterEventArgs> EventPong;

        private CounterEventArgs counter;

        public void Start()
        {
            counter = new CounterEventArgs { Count = 0 };
            ReceivePing(this, counter);
        }

        public void ReceivePing(object sender, CounterEventArgs e)
        {
            e.Count++;
            counter = e;
            Console.WriteLine($"Pong received Ping: {e.Count}");
            Thread.Sleep(1000);
            SendPong();
        }

        public void SendPong()
        {
            EventPong?.Invoke(this, counter);
        }
    }
}
