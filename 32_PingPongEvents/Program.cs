using _32_PingPongEvents;

Ping ping = new Ping();
Pong pong = new Pong();

ping.EventPing += pong.ReceivePing;
pong.EventPong += ping.ReceivePong;

pong.Start();