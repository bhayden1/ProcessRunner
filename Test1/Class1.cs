using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test1
{
  public interface IProcess
  {
    Task<bool> Process();
    void Configure();
  }
  public class Class1 : IProcess
  {
    public Task<bool> Process()
    {
      return Task.FromResult(true);
    }

    public void Configure()
    {
    }
  }
}
