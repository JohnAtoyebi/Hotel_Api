using WebApplication1.Models;

namespace WebApplication1.Services.HotelServices
{
    public interface IHotelService
    {
        Task<List<Hotel>> GetAllHotels();
        Task<Hotel?> GetHotelById(int id);
        Task<List<Hotel>> AddHotel(Hotel hotel);
        Task<List<Hotel>?> UpdateHotel(int id, Hotel request);
        Task<List<Hotel>?> DeleteHotel(int id);
    }
}
