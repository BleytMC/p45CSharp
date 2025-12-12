namespace _32_PingPongEvents
{
    class Ping
    {
        public event EventHandler<CounterEventArgs> EventPing;

        private CounterEventArgs counter;

        public void SendPing()
        {
            EventPing?.Invoke(this, counter);
        }

        public void ReceivePong(object sender, CounterEventArgs e)
        {
            e.Count++;
            counter = e;
            Console.WriteLine($"Ping received Pong: {e.Count}");
            Thread.Sleep(1000);
            SendPing();
        }
    }
}
