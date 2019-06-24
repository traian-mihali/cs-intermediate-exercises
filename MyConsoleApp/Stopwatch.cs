using System;
using System.Net.Configuration;

namespace MyConsoleApp
{
    public class Stopwatch
    {
        private bool _running;
        private DateTime _startTime;
        private DateTime _stopTime;

        public void Start()
        {
            if (_running)
                throw new InvalidOperationException("Stopwatch is already running..");

            _startTime = DateTime.Now;
            _running = true;
        }

        public void Stop()
        {
            if (!_running)
                throw new InvalidOperationException("Stopwatch is not running..");

            _stopTime = DateTime.Now;
            _running = false;
            
        }

        public TimeSpan Duration()
        {
            return _stopTime - _startTime;
        }
    }
}