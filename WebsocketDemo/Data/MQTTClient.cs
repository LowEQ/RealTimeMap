using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using MQTTnet;
using MQTTnet.Client;
using MQTTnet.Client.Options;

namespace WebsocketDemo.Data
{
    public class MQTTClient
    {
 

        public async Task GetMQTTDataAsync()
        {
            Juna data = new Juna();
            Parser parser = new Parser();
            // Create a new MQTT client.
            var factory = new MqttFactory();
            var mqttClient = factory.CreateMqttClient();
            var options = new MqttClientOptionsBuilder()
                .WithTcpServer("rata-mqtt.digitraffic.fi",1883)
                //.WithTls()//secure web socket connection from ws:// to wss://
                .Build();


            mqttClient.UseConnectedHandler(async e =>
            {
                Console.WriteLine("### CONNECTED FROM SERVER ###");

                await mqttClient.SubscribeAsync(new TopicFilterBuilder().WithTopic("train-locations/#").Build());
            });
            //establishing connection 
            await mqttClient.ConnectAsync(options, CancellationToken.None);
            
            mqttClient.UseApplicationMessageReceivedHandler(async e =>
            {
                //Console.WriteLine($"{Encoding.UTF8.GetString(e.ApplicationMessage.Payload)}");
                string strdata = Encoding.UTF8.GetString(e.ApplicationMessage.Payload);
                Console.WriteLine(strdata);
                data = parser.ParserPayload(strdata);
                await TrainData.UpdateList(data);
                Console.WriteLine(data);
            });

            

            
            //Console.ReadKey();
        }
    }
}
