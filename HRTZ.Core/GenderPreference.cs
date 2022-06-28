using System.Collections.Generic;
using System.Linq;

namespace HRTZ.Core
{
    public class GenderPreference : IPreference
    {
        private readonly Gender _gender;

        public GenderPreference(Gender gender)
        {
            _gender = gender;
        }

        public List<Candidate> Filter(List<Candidate> candidates)
        {
            return candidates.Where(c => c.Gender == _gender).ToList();
        }
    }
}