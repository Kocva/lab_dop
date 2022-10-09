using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_dop
{
    public enum BikeType { mountain, city, child };
    public class Bike
    {
        public BikeType type = BikeType.mountain; // тип
        public int radius = 0; // радиус колес
    }
    public enum CarType { bus, truck, offroad, passenger };
    public class Car
    {
        public CarType type = CarType.passenger; // тип
        public int volume = 0; // объём двигателя
        public int doors = 0; // кол-во дверей
    }

    public class Plane
    {
        public string engineType = ""; // тип двигателя
        public int height = 0; // максимальная высота полета
    }
}