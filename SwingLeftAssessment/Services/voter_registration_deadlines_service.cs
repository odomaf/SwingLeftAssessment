using Microsoft.Extensions.Caching.Memory;
using SwingLeftAssessment.Models;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

namespace SwingLeftAssessment.Services
{
  public interface Ivoter_registration_deadlines_service
  {
    List<voter_registration_deadlines> ReadAll();
    //void Create(voter_registration_deadlines deadline);
    //voter_registration_deadlines Read(int id);
    //void Update(voter_registration_deadlines deadlineModofied);
    //void Delete(int id);
  }

  public class voter_registration_deadlines_service(IMemoryCache cache) : Ivoter_registration_deadlines_service {
    private IMemoryCache _cache = cache;
    private SRDContext Context { get; }

    public List<voter_registration_deadlines> ReadAll()
    {
      Debug.WriteLine("In the service, reading all");
      if (_cache.Get("DeadlineList") == null)
      {
        List<voter_registration_deadlines> deadlines = Context.voter_registration_deadlines.ToList();
        foreach (voter_registration_deadlines deadline in deadlines) { 
          Debug.WriteLine(deadline.ToString());
        }
        _cache.Set("DeadlineList", deadlines);
      }
      return _cache.Get<List<voter_registration_deadlines>>("DeadlineList");
    }
  }
}
