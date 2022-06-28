using System.Collections.Generic;
using System.IO;
using System.Text.Json;

namespace HRTZ.Core
{
    public class CandidateRepository
    {
        private readonly List<Candidate> _candidates;

        public CandidateRepository()
        {
            var file = File.ReadAllText("candidates.json");
            _candidates = JsonSerializer.Deserialize<List<Candidate>>(file)!;
        }

        public List<Candidate> GetAll() => _candidates;

        public void SaveChanges()
        {
            var serialized = JsonSerializer.Serialize(_candidates);
            File.WriteAllText("candidates.json", serialized);
        }
    }
}