using Project;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Project
{
    #region Aircraft
    public class AbstractAircraft
    {
        protected string name;
        protected int passenger_capacity;

        public int PasCap
        {
            get { return passenger_capacity; }
            set { passenger_capacity = value; }
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
    }

    public class PassengerAirliner : AbstractAircraft
    {
        protected int staff_capacity;

        public int StaffCap
        {
            get { return staff_capacity; }
            set { staff_capacity = value; }
        }
    }

    public class CargoPlane : AbstractAircraft
    {
        double load_capacity;

        public double LoadCap
        {
            get { return load_capacity; }
            set { load_capacity = value; }
        }
    }

    public class Airline
    {
        private List<AbstractAircraft> aircraft_list = new List<AbstractAircraft>();

        public List<AbstractAircraft> AircraftList
        {
            get { return aircraft_list; }
        }

        public void AddPlane(AbstractAircraft aircraft)
        {
            aircraft_list.Add(aircraft);
        }
    }
    #endregion

    #region Logic
    public class AirlineFactory
    {
        public static Airline CreateAirline()
        {
            Airline airline = new Airline();

            PassengerAirliner Boeing737 = new PassengerAirliner();
            Boeing737.Name = "Boeing 737";
            Boeing737.PasCap = 103;
            Boeing737.StaffCap = 6;
            airline.AddPlane(Boeing737);

            PassengerAirliner Boeing777 = new PassengerAirliner();
            Boeing777.Name = "Boeing 777";
            Boeing777.PasCap = 120;
            Boeing777.StaffCap = 7;
            airline.AddPlane(Boeing777);

            CargoPlane AirbusA300 = new CargoPlane();
            AirbusA300.Name = "Airbus A300";
            AirbusA300.LoadCap = 100000;
            AirbusA300.PasCap = 0;
            airline.AddPlane(AirbusA300);

            CargoPlane An124 = new CargoPlane();
            An124.Name = "An124";
            An124.LoadCap = 120000;
            An124.PasCap = 0;
            airline.AddPlane(An124);

            return airline;
        }
    }

    public class TotalPasCapCalculator
    {
        public double GetTotalPasCap(Airline airline)
        {
            int totalPasCap = 0;
            foreach (AbstractAircraft aircraft in airline.AircraftList)
            {
                totalPasCap += aircraft.PasCap;
            }
            return totalPasCap;
        }
    }

    #endregion

    #region Print

    public class AirlinePrint
    {

        public void PrintListOfAircrafts(Airline airline)
        {
            foreach (AbstractAircraft aircraft in airline.AircraftList)
            {
                Console.WriteLine("Название:" + aircraft.Name);
                Console.WriteLine("Вместимость пассажиров:" + aircraft.PasCap);
                Console.WriteLine();
            }
           
        }

    
          public void PrintTotalPasCap(Airline airline)
      {
        TotalPasCapCalculator calculator = new TotalPasCapCalculator();

        Console.WriteLine("Общая вместимость пассажиров = " + calculator.GetTotalPasCap(airline));
        Console.WriteLine();
       }
}
    #endregion

    #region Programm

    class Programm
    {
        static void Main(string[] args)
        {
            Airline airline = AirlineFactory.CreateAirline();

            AirlinePrint printer = new AirlinePrint();
            printer.PrintListOfAircrafts(airline);

            TotalPasCapCalculator calculator = new TotalPasCapCalculator();
            printer.PrintTotalPasCap(airline);

            Console.WriteLine();
        }
    }
    #endregion
}
