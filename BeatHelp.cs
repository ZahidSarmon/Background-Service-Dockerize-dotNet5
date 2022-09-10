using System;
using System.Collections.Generic;
using System.Linq;
using System.Timers;
using System.IO;
namespace BeatService
{
    public class BeatHelp
    {
        private readonly System.Timers.Timer _timer;
        public BeatHelp()
        {
            _timer=new System.Timers.Timer(1000){AutoReset=true};
            _timer.Elapsed+=TimerElapsed;
        }
        private void TimerElapsed(object sender, ElapsedEventArgs args)
        {
            Console.WriteLine(DateTime.Now.ToString());
        }   
        public void Start()
        {
            _timer.Start();
        }
        public void Stop()
        {
            _timer.Stop();
        }
    }
}