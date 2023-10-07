using DBAccess.DataModel;

namespace DBAccess.Ropositories
{
    internal interface IPriceListRepository
    {
        public Task<List<PriceList>> GetPriceListAsync();
        public Task<PriceList> GetPriceListByIdAsync(ulong Id);
        public Task<PriceList> AddPriceListAsync(PriceList PriceLists);
        public Task<int> UpdatePriceListAsync(PriceList PriceLists);
        public Task<int> DeletePriceListAsync(ulong Id);
    }
}