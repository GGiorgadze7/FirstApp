using static System.Runtime.InteropServices.JavaScript.JSType;

namespace FirstApp.Model
{
    public class CarModel
    {
        public string Model { get; set; }
        public int Releasedate { get; set; }
        public string Color { get; set; }

        public string GetFullInfo()
        {
            return Model + " " + Releasedate + " " + Color;
        }

    }
}
