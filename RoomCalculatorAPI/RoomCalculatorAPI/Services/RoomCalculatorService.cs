using RoomCalculatorAPI.DbModel;
using RoomCalculatorAPI.Models;

namespace RoomCalculatorAPI.Services
{

    public interface IRoomCalculatorService
    {
        double CalculateRoomSize(double length, double width, double height);
        IEnumerable<RoomHistory> GetRoomSize();
    }

    public class RoomCalculatorService : IRoomCalculatorService
    {
        private readonly RoomCalculatorDbContext _context;

        public RoomCalculatorService(RoomCalculatorDbContext context)
        {
            _context = context;
        }

        public double CalculateRoomSize(double length, double width, double height)
        {
            double size = length * width;
            double perimeter = 2 * (length + width);
            double surfaceArea = 2 * (length * width + length * height + width * height);
            double volume = length * width * height;
            RoomHistory roomHistory = new()
            {
                Length = length,
                Width = width,
                Height = height,
                Perimeter = perimeter,
                SurfaceArea = surfaceArea,
                Volume = volume,
                Size = size
            };

            _context.RoomHistories.Add(roomHistory);
            _context.SaveChanges();

            return size;
        }

        public IEnumerable<RoomHistory> GetRoomSize()
        {
            return _context.RoomHistories.ToList();
        }
    }
}
