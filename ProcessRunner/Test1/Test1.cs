using System;
using System.ComponentModel.Composition;
using System.Configuration;
using Process.Core;

namespace Test1
{
    [Export(typeof(IProcess))]
    public class Test1: IProcess
    {
      public void Process()
      {
        Configure();
        Console.WriteLine("test 1");
      }

      public void Configure()
      {
        Console.WriteLine("configuring test 1");
        throw new ConfigurationErrorsException("Some value is missing");
      }
    }
}
