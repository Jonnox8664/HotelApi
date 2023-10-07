using DBAccess.DataModel;

namespace DBAccess.Ropositories
{
    public interface IAccommodationRopository
    {
        public Task<List<Accommodation>> GetAccommodationListAsync();
        public Task<Accommodation> GetAccommodationByIdAsync(ulong Id);
        public Task<Accommodation> AddAccommodationAsync(Accommodation Accommodations);
        public Task<int> UpdateAccommodationAsync(Accommodation Accommodations);
        public Task<int> DeleteAccommodationAsync(ulong Id);
    }
}