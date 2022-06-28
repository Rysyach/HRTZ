using System.Collections.Generic;

namespace HRTZ.Core
{
    public interface IPreference
    {
        List<Candidate> Filter(List<Candidate> candidates);
    }
}
