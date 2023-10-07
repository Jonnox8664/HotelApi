using DBAccess.DataModel;
using Microsoft.EntityFrameworkCore;

namespace DBAccess.Ropositories
{
    public class AccommodationRopository : IAccommodationRopository
    {
        private readonly Context _dbContext;

        public AccommodationRopository(Context dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<List<Accommodation>> GetAccommodationListAsync()
        {
            return await _dbContext.Accommodations.ToListAsync();
        }

        public async Task<Accommodation> GetAccommodationByIdAsync(ulong Id)
        {
            return await _dbContext.Accommodations.Where(x => x.Id == Id).FirstOrDefaultAsync();
        }

        public async Task<Accommodation> AddAccommodationAsync(Accommodation Accommodations)
        {
            var result = _dbContext.Accommodations.Add(Accommodations);
            await _dbContext.SaveChangesAsync();
            return result.Entity;
        }

        public async Task<int> UpdateAccommodationAsync(Accommodation Accommodations)
        {
            _dbContext.Accommodations.Update(Accommodations);
            return await _dbContext.SaveChangesAsync();
        }

        public async Task<int> DeleteAccommodationAsync(ulong Id)
        {
            var filteredData = _dbContext.Accommodations.Where(x => x.Id == Id).FirstOrDefault();
            _dbContext.Accommodations.Remove(filteredData);
            return await _dbContext.SaveChangesAsync();
        }
    }
}