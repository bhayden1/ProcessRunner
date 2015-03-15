using System;
using System.Linq;
using Process.Core;

namespace ProcessRunner
{
  class Program
  {
    static void Main(string[] args)
    {
      try
      {
        var processor = new Processor();
        Console.WriteLine(processor.Processes.Count());
        processor.Process();

      }
      catch (Exception ex)
      {
        Console.WriteLine(ex.ToString());
      }
      finally
      {
        Console.ReadLine();
      }
    }
  }
}
