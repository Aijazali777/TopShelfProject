using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Topshelf;

namespace TopShelfSampleService
{
    class Program
    {
        static void Main(string[] args)
        {
            HostFactory.Run(x =>
            {
                x.Service<TestService>(s =>
                {
                    s.ConstructUsing(() => new TestService());
                    s.WhenStarted(tc => tc.Start());
                    s.WhenStopped(tc => tc.Stop());
                });

                x.RunAsLocalSystem();

                x.SetServiceName("TopShelfSampleService");
                x.SetDisplayName("TopShelf Sample Service");
                x.SetDescription("Simple Topshelf test service using .NET Framework");

                x.StartAutomatically();
            });
        }
    }
}
