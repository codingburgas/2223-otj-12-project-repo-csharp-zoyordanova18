using GreenhouseManagmentSystem.Enums;

namespace GreenhouseManagmentSystem.Models
{
    public class GreenHouse
    {
        public int Id { get; set; }
        public TypeOfGreenHouse Type { get; set; }
        public double Size { get; set; }
        public int NumberOfPlants { get; set; }
    }
}
