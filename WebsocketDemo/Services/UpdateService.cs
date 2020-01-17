using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

using WebsocketDemo.Data;
using System.Timers;

namespace WebsocketDemo.Services
{
    public class UpdateService
    {
        public static List<Juna> data = new List<Juna>();
        public Action <Juna,Juna> UpdateAction { get; set; }

        public Juna juna = new Juna();
        public Juna currentJuna = new Juna();
        public void Update(Juna juna, Juna currentJuna)
        {
            
        }

        private static System.Timers.Timer aTimer;

        public void StartTimer()
        {
            SetTimer();
        }

        private void SetTimer()
        {
            aTimer = new System.Timers.Timer(5000);
            aTimer.Elapsed += OnTimedEvent;
            aTimer.AutoReset = true;
            aTimer.Enabled = true;
        }

        static long count = 1;

        private void OnTimedEvent(Object source, ElapsedEventArgs e)
        {
            count++;
            Update(juna,currentJuna);
        }
    }
}
