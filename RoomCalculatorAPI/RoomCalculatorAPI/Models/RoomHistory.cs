using System.ComponentModel.DataAnnotations;

namespace RoomCalculatorAPI.Models
{
    public class RoomHistory
    {
        [Key]
        public int Id { get; set; }
        public double Length { get; set; }
        public double Width { get; set; }
        public double Height { get; set; }
        public double Perimeter { get; set; }
        public double Volume { get; set; }
        public double SurfaceArea { get; set; }
        public double Size { get; set; }
    }
}
