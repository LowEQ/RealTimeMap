using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebsocketDemo.Data
{
    public class TrainData
    {
        public static List<Juna> data = new List<Juna>();

        public static async Task<List<Juna>> GetList()
        {
            return data;
        }

        public static async Task UpdateList(Juna juna)
        {
            if(!data.Contains(juna))
            {
                data.Add(juna);
            }
            else
            {
                data.Where<Juna>(s => s.trainId == juna.trainId)
                    .Select(s => {
                        s.latitude = juna.latitude;
                        s.longitude = juna.longitude;
                        s.speed = juna.speed;
                        return s;
                });
                
            }
        }
        public static async Task InsertList(Juna juna)
        {
            data.Add(juna);
        }
    }
}
