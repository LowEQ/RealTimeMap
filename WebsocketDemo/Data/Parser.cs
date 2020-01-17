using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace WebsocketDemo.Data
{
    public class Parser
    {
        public List<Juna> ParseJson(string json)
        {
            List<Juna> trainData = new List<Juna>();
            var data = JsonConvert.DeserializeObject<Train[]>(json);

            foreach (var item in data)
            {
                Juna junaItem = new Juna();
                junaItem.trainId = item.trainNumber;
                junaItem.speed = item.speed;
                junaItem.longitude = item.location.coordinates[0];
                junaItem.latitude = item.location.coordinates[1];
                trainData.Add(junaItem);
            }
            return trainData;
        }

        public Juna ParserPayload(string json)
        {
            
            var data = JsonConvert.DeserializeObject<Train>(json);


            Juna junaItem = new Juna
            {
                trainId = data.trainNumber,
                speed = data.speed,
                longitude = data.location.coordinates[0],
                latitude = data.location.coordinates[1]
            };


            return junaItem;
        }
    }
}
