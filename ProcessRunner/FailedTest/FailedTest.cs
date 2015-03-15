using System;
using System.ComponentModel.Composition;
using System.Configuration;
using Process.Core;

namespace FailedTest
{
  [Export(typeof (IProcess))]
  public class FailedTest : IProcess
  {
    public void Process()
    {
      Console.WriteLine("Starting failed test");
      Configure();
      Console.WriteLine("Ending failed test");
    }

    public void Configure()
    {
      throw new ConfigurationErrorsException("Some value is missing");
    }
  }
}
