using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Net.Mail;
using System.Xml.Linq;
using WebApplication1.Services.HotelServices;

namespace WebApplication1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HotelController : ControllerBase
    {
        private readonly IHotelService _hotelService;

        public HotelController(IHotelService hotelService)
        {
            _hotelService = hotelService;
        }

        [HttpGet]
        public async Task<ActionResult<List<Hotel>>> GetAllHotels()
        {
            return await _hotelService.GetAllHotels();
        }

        [HttpGet("id")]
        public async Task<ActionResult<Hotel>> GetHotelById(int id)
        {
            var result = await _hotelService.GetHotelById(id);
            if (result is null)
                return NotFound("Hotel can't be found! Kindly, try again!");

            return Ok(result);
        }

        [HttpPut("id")]
        public async Task<ActionResult<List<Hotel>>> UpdateHotel(int id, Hotel request)
        {
            var result = await _hotelService.UpdateHotel(id, request);
            if (result is null)
                return NotFound("Hotel can't be found! Kindly, try again!");

            return Ok(result);
        }

        [HttpPost]
        public async Task<ActionResult<List<Hotel>>> AddHotel(Hotel hotel)
        {
            var result = await _hotelService.AddHotel(hotel);
            return Ok(result);
        }

        [HttpDelete("id")]
        public async Task<ActionResult<List<Hotel>>> DeleteHotel(int id)
        {
            var result = await _hotelService.DeleteHotel(id);
            if (result is null)
                return NotFound("Hotel Id can't be found! Kindly, try again!");

            return Ok(result);
        }
    }
}
