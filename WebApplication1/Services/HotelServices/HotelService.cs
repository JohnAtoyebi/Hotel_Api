using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebApplication1.Data;
using WebApplication1.DTO;
using WebApplication1.Models;

namespace WebApplication1.Services.HotelServices
{
    public class HotelService : IHotelService
    {
        /*private static List<Hotel> listOfHotels = new List<Hotel> {
            new Hotel
            {
               Name = "Prince Hotel",
               Description = "Prince Hotel Making Life Beautiful",
               EmailAddress = "price@gmail.com",
               PhoneNumber = "08012345676",
               AddressId = "4, price way, lagos",
               City = "Lagos state",
               Price = 2000,
               ManagerId = "THY-898-LO"
            }
        };*/
        private readonly DataContext _context;
        private readonly IMapper _mapper;

        public HotelService(DataContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }
        

       

        public async Task<List<Hotel>> AddHotel(Hotel hotel)
        {
            _context.Hotel.Add(hotel);
            await _context.SaveChangesAsync();
            return await _context.Hotel.ToListAsync();
        }

        public async Task<List<Hotel>?> DeleteHotel(int id)
        {
            var hotel = await _context.Hotel.FindAsync(id);
            if (hotel is null)
                return null;

            _context.Hotel.Remove(hotel);
            await _context.SaveChangesAsync();
            return await _context.Hotel.ToListAsync();
        }

        public async Task<List<Hotel>> GetAllHotels()
        {
            var hotel = await _context.Hotel.ToListAsync();
            return hotel;

        }

        public async Task<Hotel?> GetHotelById(int id)
        {
            var getHotelByPrice = await _context.Hotel.FindAsync(id);
            if (getHotelByPrice is null)
                return null;
            return getHotelByPrice;
        }

        public async Task<List<Hotel>?> UpdateHotel(int id, Hotel request)
        {
            var hotel = await _context.Hotel.FindAsync(id);
            if (hotel is null)
                return null;

            hotel.Name = request.Name;
            hotel.Description = request.Description;
            hotel.EmailAddress = request.EmailAddress;
            hotel.AddressId = request.AddressId;
            hotel.City = request.City;
            hotel.Price = request.Price;
            hotel.ManagerId = request.ManagerId;

            await _context.SaveChangesAsync();
            return await _context.Hotel.ToListAsync();
        }
    }
}
