using DBAccess.DataModel;
using Microsoft.EntityFrameworkCore;

namespace DBAccess.Ropositories
{
    public class PriceListRepository
    {
        private readonly Context _dbContext;

        public PriceListRepository(Context dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<List<PriceList>> GetPriceListListAsync()
        {
            return await _dbContext.PriceLists.ToListAsync();
        }

        public async Task<PriceList> GetPriceListByIdAsync(ulong Id)
        {
            return await _dbContext.PriceLists.Where(x => x.Id == Id).FirstOrDefaultAsync();
        }

        public async Task<PriceList> AddPriceListAsync(PriceList PriceLists)
        {
            var result = _dbContext.PriceLists.Add(PriceLists);
            await _dbContext.SaveChangesAsync();
            return result.Entity;
        }

        public async Task<int> UpdatePriceListAsync(PriceList PriceLists)
        {
            _dbContext.PriceLists.Update(PriceLists);
            return await _dbContext.SaveChangesAsync();
        }

        public async Task<int> DeletePriceListAsync(ulong Id)
        {
            var filteredData = _dbContext.PriceLists.Where(x => x.Id == Id).FirstOrDefault();
            _dbContext.PriceLists.Remove(filteredData);
            return await _dbContext.SaveChangesAsync();
        }
    }
}