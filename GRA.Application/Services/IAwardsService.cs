using GRA.Domain.Entities;

namespace GRA.Application.Services
{
    public interface IAwardsService
    {
        void ImportCsvFile(string csv);
        AwardResponse GetAwardsInterval();
    }
}
