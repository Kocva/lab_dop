using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_dop
{
    public class Transport
    {
        public virtual String GetInfo()
        {
            return "я транспорт";
        }
    }
    public enum BikeType { mountain, city, child };
    public class Bike : Transport
    {
        public BikeType type = BikeType.mountain; // тип
        public int radius = 0; // радиус колес
        public override String GetInfo()
        {
            return "Я велосипед";
        }
    }
    public enum CarType { bus, truck, offroad, passenger };
    public class Car : Transport
    {
        public CarType type = CarType.passenger; // тип
        public int volume = 0; // объём двигателя
        public int doors = 0; // кол-во дверей
        public override String GetInfo()
        {
            return "Я автомобиль";
        }
    }

    public class Plane : Transport
    {
        public string engineType = ""; // тип двигателя
        public int height = 0; // максимальная высота полета
        public override String GetInfo()
        {
            return "Я самолет";
        }
    }
}