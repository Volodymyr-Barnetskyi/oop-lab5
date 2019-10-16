using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace ConsoleApp2
{
    class Date
    {
        public int Year { set; get; }
        public int Month { set; get; }
        public int Day { set; get; }
        public int Hours { set; get; }
        public int Minutes { set; get; }

        public Date() { }

        public Date(Date prevDate)
        {
            this.Year = prevDate.Year;
            this.Month = prevDate.Month;
            this.Day = prevDate.Day;
            this.Hours = prevDate.Hours;
            this.Minutes = prevDate.Minutes;
        }

        public Date(int year, int month, int day, int hours, int minutes)
        {
            Year = year;
            Month = month;
            Day = day;
            Hours = hours;
            Minutes = minutes;
        }
    }
    class Airplane
    {
        public string StartCity { set; get; }
        public string FinishCity { set; get; }
        public Date StartDate { set; get; }
        public Date FinishDate { set; get; }

        public Airplane() { }
        public Airplane(string startCity, string finishCity, Date startDate, Date finishDate)
        {
            StartCity = startCity;
            FinishCity = finishCity;
            StartDate = startDate;
            FinishDate = finishDate;
        }

        public int GetTotalTime()
        {
            int totalTime = 0;



            return totalTime;
        }

        public bool IsArrivingToday()
        {
            if (FinishDate.Day == StartDate.Day) return true;
            else return false;
        }
    }


    namespace ConsoleApp2
    {
        class Date
        {
            public int Year { set; get; }
            public int Month { set; get; }
            public int Day { set; get; }
            public int Hours { set; get; }
            public int Minutes { set; get; }

            public Date() { }

            public Date(Date prevDate)
            {
                this.Year = prevDate.Year;
                this.Month = prevDate.Month;
                this.Day = prevDate.Day;
                this.Hours = prevDate.Hours;
                this.Minutes = prevDate.Minutes;
            }

            public Date(int year, int month, int day, int hours, int minutes)
            {
                Year = year;
                Month = month;
                Day = day;
                Hours = hours;
                Minutes = minutes;
            }
        }

        class Airplane
        {
            public string StartCity { set; get; }
            public string FinishCity { set; get; }
            public Date StartDate { set; get; }
            public Date FinishDate { set; get; }

            public Airplane() { }
            public Airplane(string startCity, string finishCity, Date startDate, Date finishDate)
            {
                StartCity = startCity;
                FinishCity = finishCity;
                StartDate = startDate;
                FinishDate = finishDate;
            }

            public int GetTotalTime()
            {
                int totalTime = (int)(new DateTime(FinishDate.Year, FinishDate.Month, FinishDate.Day, FinishDate.Hours, FinishDate.Minutes, 0) - new DateTime(StartDate.Year, StartDate.Month, StartDate.Day, StartDate.Hours, StartDate.Minutes, 0)).TotalSeconds;
                return totalTime / 60;
            }

            public bool IsArrivingToday()
            {
                if (FinishDate.Day == StartDate.Day) return true;
                else return false;
            }
        }

        class Program
        {
            static Airplane[] ReadAirplaneArray()
            {
                Console.WriteLine("Кiлькiсть рейсiв: ");
                int n = Convert.ToInt32(Console.ReadLine());
                Airplane[] airplane = new Airplane[n];

                string startCity, finishCity;
                int year_1, month_1, day_1, hours_1, minutes_1;
                int year_2, month_2, day_2, hours_2, minutes_2;

                for (int i = 0; i < n; i++)
                {
                    Console.WriteLine($"Рейс № {i + 1}");
                    Console.WriteLine("Мiсто вiдправлення: ");
                    startCity = Console.ReadLine();
                    Console.WriteLine("Мiсто прибуття: ");
                    finishCity = Console.ReadLine();

                    Console.WriteLine("Рiк, мiсяць, день, година, хвилина вiдправлення");
                    year_1 = Convert.ToInt32(Console.ReadLine());
                    month_1 = Convert.ToInt32(Console.ReadLine());
                    day_1 = Convert.ToInt32(Console.ReadLine());
                    hours_1 = Convert.ToInt32(Console.ReadLine());
                    minutes_1 = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("Рiк, мiсяць, день, година, хвилина прибуття");
                    year_2 = Convert.ToInt32(Console.ReadLine());
                    month_2 = Convert.ToInt32(Console.ReadLine());
                    day_2 = Convert.ToInt32(Console.ReadLine());
                    hours_2 = Convert.ToInt32(Console.ReadLine());
                    minutes_2 = Convert.ToInt32(Console.ReadLine());

                    Date startDate = new Date(year_1, month_1, day_1, hours_1, minutes_1);
                    Date finishDate = new Date(year_2, month_2, day_2, hours_2, minutes_2);
                    airplane[i] = new Airplane(startCity, finishCity, startDate, finishDate);
                }

                return airplane;
            }
            static void PrintAirplane(Airplane airplane)
            {
                Console.WriteLine($"Мiсто вiдправлення: {airplane.StartCity}");
                Console.WriteLine($"Мiсто прибуття: {airplane.FinishCity}");
                Console.Write("Рiк, мiсяць, день, година, хвилина вiдправлення: ");
                Console.Write($"{airplane.StartDate.Year}/{airplane.StartDate.Month}/{airplane.StartDate.Day} ");
                Console.Write($"{airplane.StartDate.Hours}:{airplane.StartDate.Minutes}\n");
                Console.Write("Рiк, мiсяць, день, година, хвилина прибуття: ");
                Console.Write($"{airplane.FinishDate.Year}/{airplane.FinishDate.Month}/{airplane.FinishDate.Day} ");
                Console.Write($"{airplane.FinishDate.Hours}:{airplane.FinishDate.Minutes}\n");
                Console.WriteLine($"Час польоту: {airplane.GetTotalTime()}хв");
                Console.WriteLine($"Чи прибуває в той же день: {airplane.IsArrivingToday()}");
            }
            static void PrintAirplanes(Airplane[] plane)
            {
                foreach (Airplane airplane in plane)
                {
                    Console.WriteLine($"\nМiсто вiдправлення: {airplane.StartCity}");
                    Console.WriteLine($"Мiсто прибуття: {airplane.FinishCity}");
                    Console.Write("Рiк, мiсяць, день, година, хвилина вiдправлення: ");
                    Console.Write($"{airplane.StartDate.Year}/{airplane.StartDate.Month}/{airplane.StartDate.Day} ");
                    Console.Write($"{airplane.StartDate.Hours}:{airplane.StartDate.Minutes}\n");
                    Console.Write("Рiк, мiсяць, день, година, хвилина прибуття: ");
                    Console.Write($"{airplane.FinishDate.Year}/{airplane.FinishDate.Month}/{airplane.FinishDate.Day} ");
                    Console.Write($"{airplane.FinishDate.Hours}:{airplane.FinishDate.Minutes}\n");
                    Console.WriteLine($"Час польоту: {airplane.GetTotalTime()}хв");
                    Console.WriteLine($"Чи прибуває в той же день: {airplane.IsArrivingToday()}");
                }
            }

            static void GetAirplaneInfo(Airplane[] airplane, out int maxTime, out int minTime)
            {
                maxTime = 0;
                minTime = 9999;

                for (int i = 0; i < airplane.Length; i++)
                {
                    if (airplane[i].GetTotalTime() > maxTime)
                    {
                        maxTime = airplane[i].GetTotalTime();
                    }
                    if (airplane[i].GetTotalTime() < minTime)
                    {
                        minTime = airplane[i].GetTotalTime();
                    }
                }
            }

            static void SortAirplanesByDate(Airplane[] airplane)
            {
                Array.Sort(airplane, (a1, a2) => new DateTime(a1.StartDate.Year, a1.StartDate.Month, a1.StartDate.Day, a1.StartDate.Hours, a1.StartDate.Minutes, 0).CompareTo(new DateTime(a2.StartDate.Year, a2.StartDate.Month, a2.StartDate.Day, a2.StartDate.Hours, a2.StartDate.Minutes, 0)));
            }

            static void SortAirplanesByTotalTime(Airplane[] airplane)
            {
                Array.Sort(airplane, (a1, a2) => a1.GetTotalTime().CompareTo(a2.GetTotalTime()));
            }

            static void Main(string[] args)
            {
                Airplane[] airplane = ReadAirplaneArray();

                int n;

                bool stop = false;
                int MinReis, MaxReis;
                int s;

                while (!stop)
                {
                    Console.WriteLine();
                    Console.WriteLine("1. Вивести iнформацiю про один рейс.");
                    Console.WriteLine("2. Вивести iнформацiю про всi рейси.");
                    Console.WriteLine("3. Вивести найкоротший та найдовший час польоту.");
                    Console.WriteLine("4. Посортувати рейси за датою.");
                    Console.WriteLine("5. Посортувати рейси за часом польоту.");
                    Console.WriteLine("6. Вихiд.");

                    n = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine();
                    switch (n)
                    {
                        case 1:
                            Console.WriteLine($"Введiть порядковий номер рейсу: 0-{airplane.Length - 1} : ");
                            s = Convert.ToInt32(Console.ReadLine());
                            PrintAirplane(airplane[s]);
                            break;
                        case 2:
                            PrintAirplanes(airplane);
                            break;
                        case 3:
                            GetAirplaneInfo(airplane, out MaxReis, out MinReis);
                            Console.WriteLine($"Мiнiмальний час польоту: {MinReis}хв");
                            Console.WriteLine($"Максимальний час польоту: {MaxReis}хв");
                            break;
                        case 4:
                            SortAirplanesByDate(airplane);
                            break;
                        case 5:
                            SortAirplanesByTotalTime(airplane);
                            break;
                        case 6:
                            stop = true;
                            break;
                        default:
                            Console.WriteLine("Такого варiанту не iснує!");
                            break;
                    }
                    Console.WriteLine();
                }

            }
        }
    }
}
