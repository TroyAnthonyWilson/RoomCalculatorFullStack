using Microsoft.AspNetCore.Mvc;
using RoomCalculatorAPI.Models;
using RoomCalculatorAPI.Services;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace RoomCalculatorAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RoomCalculatorController : ControllerBase
    {
        private readonly IRoomCalculatorService _roomCalculatorService;

        public RoomCalculatorController(IRoomCalculatorService roomCalculatorService)
        {
            _roomCalculatorService = roomCalculatorService;
        }

        [HttpGet("roomsizecalculator")]
        public double Get(double length, double width, double height)
        {
            return _roomCalculatorService.CalculateRoomSize(length, width, height);
        }

        [HttpGet("roomhistory")]
        public IEnumerable<RoomHistory> Get()
        {
            return _roomCalculatorService.GetRoomSize();
        }
    }
}
