using System.Collections.Generic;

namespace GRA.Domain.Entities
{
    public class AwardResponse
    {
        public AwardResponse(IEnumerable<AwardsInterval> min, IEnumerable<AwardsInterval> max)
        {
            Min = min;
            Max = max;
        }

        public IEnumerable<AwardsInterval> Min { get; }
        public IEnumerable<AwardsInterval> Max { get; }
    }
}
