using DBAccess.DataModel;

namespace DBAccess.Ropositories
{
    public interface IRoomTypeRepository
    {
        public Task<List<RoomType>> GetRoomTypeListAsync();
        public Task<RoomType> GetRoomTypeByIdAsync(ulong Id);
        public Task<RoomType> AddRoomTypeAsync(RoomType RoomTypes);
        public Task<int> UpdateRoomTypeAsync(RoomType RoomTypes);
        public Task<int> DeleteRoomTypeAsync(ulong Id);
    }
}