using System;

namespace ConsoleApp17
{
    class Program
    {
        static void Main(string[] args)
        {
            University obj1 = new University();
            obj1.Former = "Azerbaijan State Oil Academy";
            obj1.Type = "Public";
            obj1.Established = "1920";
            obj1.Rector = "Mustafa Babanli";
            obj1.Academic = "850";
            obj1.Administrative = "900";
            obj1.Students = "10200";
            obj1.Adress = "Baku,Azerbaijan";
            obj1.Campus = "Urban";



            University obj2 = new University();
            obj2.Former = "Azerbaijan Technical University";
            obj2.Type = "Public";
            obj2.Established = "1950";
            obj2.Rector = "Vilayet Veliyev";
            obj2.Academic = "884";
            obj2.Administrative = "1099";
            obj2.Students = "7565";
            obj2.Adress = "Baku,Azerbaijan";
            obj2.Campus = "Urban";
            Console.WriteLine(obj1.Fullname());
            Console.WriteLine();
            Console.WriteLine(obj2.Fullname());
        }
    }
    class University
    {

        public string Former;
        public string Type;
        public string Established;
        public string Rector;
        public string Academic;
        public string Administrative;
        public string Students;
        public string Adress;
        public string Campus;


        public string Fullname()
        {
            return $"{ Former}- {Type}- {Established}- {Rector}- {Academic}-  {Administrative}-  {Students}-  {Adress}-  {Campus}";
        }
    }
    }

