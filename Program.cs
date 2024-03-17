using System.Net.WebSockets;
using WatsonWebsocket;
String message = string.Join(" ", args).Substring(args[0].Length + 1);
WatsonWsClient wsClient = new WatsonWsClient(new Uri(args[0]));
System.Threading.CancellationToken CT = new System.Threading.CancellationToken();
wsClient.KeepAliveInterval = 1000;
wsClient.Start();
wsClient.SendAsync(message, WebSocketMessageType.Text, CT);
wsClient.Stop();