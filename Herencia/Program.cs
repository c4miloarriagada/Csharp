using System;


namespace Herencia
{
    class Program
    {
        static void Main(string[] args)
        {
            Doctor doctor = new Doctor("Camilo", 40, "cardiologo");
            Console.WriteLine(doctor.GetInfo());
            Console.WriteLine(doctor.GetData());

            Dev dev = new Dev("Camilo", 10, "C#");
            Console.WriteLine(dev.GetInfo());
            Console.WriteLine(dev.GetData());
        }   

        class People
        {
            private string _name;
            private int _age;
            public People(string name, int age)
            {
                _name = name;
                _age = age;
            }

            public string GetInfo()
            {
                return _name + " " + _age;  
            }
        }

        class Doctor: People
        {
            private string _speciality;

            public Doctor(string name, int age, string speciality) : base(name, age)
            {
                _speciality = speciality;   
            }

            public string GetData()
            {
                return GetInfo() + " " + _speciality;
            }
        }

        class Dev : People
        {
            private string _language;
            public Dev(string name, int age, string language) : base(name, age)
            {
                _language = language;   
            }
            public string GetData()
            {
                return GetInfo() + " " + _language;
            }

        }
    }
}