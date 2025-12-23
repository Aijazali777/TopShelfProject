using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace TopShelfSampleService
{
    public class TestService
    {
        private Timer _timer;

        public bool Start()
        {
            _timer = new Timer(5000); // 5 seconds
            _timer.Elapsed += (s, e) =>
            {
                Console.WriteLine($"Service running at {DateTime.Now}");
            };
            _timer.Start();

            return true;
        }

        public bool Stop()
        {
            _timer?.Stop();
            _timer?.Dispose();
            return true;
        }
    }
}
