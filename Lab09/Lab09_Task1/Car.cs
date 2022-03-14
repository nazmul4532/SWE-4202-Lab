using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab09
{
    internal class Car
    {
        public Seat seats = new Seat();
        public Door doors = new Door();
        public Engine engine = new Engine();
        public Wheel wheels = new Wheel();
        private int maximum_accelaration = 25;
        public int getMaxAccelaration()
        {
            return this.maximum_accelaration;
        }
        public void setMaxAccelaration(int max)
        {
            this.maximum_accelaration = max;
        }
        private int fuel_capacity = 5000;
        public int getFuelCapacity()
        {
            return this.fuel_capacity;
        }
        public void setFuelCapacity(int fuel)
        {
            this.fuel_capacity = fuel;
        }
        public string DisplayInfo()
        {
            string info = Convert.ToString(getFuelCapacity()) +" "+ Convert.ToString(getMaxAccelaration())+" " + seats.getSeatComfortability()+" " + Convert.ToString(seats.getSeatWarmerStatus())+" "+ Convert.ToString(wheels.getWheelCircumference())+" "+doors.getDoorOpeningMode()+" "+Convert.ToString(engine.getEnergyProduction())+ " " + Convert.ToString(engine.getFuelConsumption())+ " " + Convert.ToString(engine.getRPM());
            return info;
        }
    }
}
