using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebsocketDemo.Data
{
    public class Train
    {
        public int trainNumber { get; set; }
        public string departureDate { get; set; }
        public string timestamp { get; set; }
        public Location location { get; set; }
        public int speed { get; set; }
    }
}
/*{
 * "trainNumber":1,
 * "departureDate":"2020-01-03",
 * "timestamp":"2020-01-03T08:56:47.000Z",
 * "location":{
 * "type":"Point"
 * "coordinates":[29.849961,61.937198]
 * },
 * "speed":137
 * }
 */
