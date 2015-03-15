using System;
using System.ComponentModel.Composition;
using System.Threading;
using Process.Core;

namespace SlowTezt
{
    [Export(typeof(IProcess))]
    public class SlowTest: IProcess
    {
      public void Process()
      {
        Configure();
        Console.WriteLine("Starting Slow Test");
        Thread.Sleep(TimeSpan.FromSeconds(5));
        Console.WriteLine("Slow task done");
      }

      public void Configure()
      {
        Console.WriteLine("Configuring Slow Test");
      }
    }
}
