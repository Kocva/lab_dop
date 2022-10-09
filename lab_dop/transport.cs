using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_dop
{
    public class Transport
    {
        public int wheels = 0;
        public static Random rnd = new Random();
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
            str += String.Format("\nкол-во колес: {0}", this.wheels);
            return str;
        }
        public static Bike Generate()
        {

            return new Bike
            {
                type = (BikeType)rnd.Next(2),
                radius = 15 + rnd.Next() % 6,
                wheels = 2 + rnd.Next() % 2
            };
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
            str += String.Format("\nкол-во колес: {0}", this.wheels);
            return str;
        }
        public static Car Generate()
        {
            
            return new Car
            {
                type = (CarType)rnd.Next(4),
                volume = 1 + rnd.Next() % 5,
                doors = 3 + rnd.Next() % 2,
                wheels = 4 + rnd.Next() % 2
            };
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
            str += String.Format("\nкол-во колес: {0}", this.wheels);
            return str;
        }
        public static Plane Generate()
        {
            
            return new Plane
            {
                engineType = (EngineType)rnd.Next(2),
                height = 1000 + rnd.Next() % 9000,
                wheels = 3 + rnd.Next() % 1
            };
        }
    }
}