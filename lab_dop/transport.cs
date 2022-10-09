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
            var str = "Я велосипед";
            str += String.Format("\nтип: {0}", this.type);
            str += String.Format("\nРадиус колес: {0}", this.radius);
            return str;
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
            var str = "Я автомобиль";
            str += String.Format("\nтип: {0}", this.type);
            str += String.Format("\nОбъём двигателя: {0}", this.volume);
            str += String.Format("\nкол-во дверей: {0}", this.doors);
            return str;
        }
    }

    public enum EngineType {reactive, piston}
    public class Plane : Transport
    {
        public EngineType engineType = EngineType.reactive; // тип двигателя
        public int height = 0; // максимальная высота полета
        public override String GetInfo()
        {
            var str = "Я самолет";
            str += String.Format("\nтип двигателя: {0}", this.engineType);
            str += String.Format("\nмакс. высота: {0}", this.height);
            return str;
        }
    }
}