using System;
using System.Collections.Generic;
using System.ComponentModel.Composition;
using System.ComponentModel.Composition.Hosting;
using System.Linq;
using System.Threading.Tasks;

namespace Process.Core
{
  public class Processor
  {
    [ImportMany(typeof(IProcess))]
    public IEnumerable<IProcess> Processes;

    public Processor()
    {
      var catalog = new AggregateCatalog();
      catalog.Catalogs.Add(new DirectoryCatalog("process"));
      var container = new CompositionContainer(catalog);
      container.ComposeParts(this);
    }

    public void Process()
    {
      try
      {
        var tasks = Processes
          .Select(process1 => Task.Factory.StartNew(process1.Process))
          .ToArray();
        Task.WaitAll(tasks);
      }
      catch (AggregateException ae)
      {
        foreach (var e in ae.Flatten().InnerExceptions)
        {
          Console.WriteLine("Error: {0}", e);
        }
      }
      finally
      {
        Console.WriteLine("All done");
      }
    }
  }
}
