using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core
{
    public class Car
    {
        public int Id;
        public string Name;
        public int Speed;
        private string _carCode;
        public string CarcCode
        {
            get
            {
                return _carCode;        
            }
            set
            {
                string first = value.Substring(0, 2);
                string secondstr = value.Substring(2);
                int second;
                if (value.Length == 6)
                {
                    if (!int.TryParse(secondstr, out second))
                    {
                        Console.WriteLine("NOT A NUMBER!");
                    }

                    if (first.ToUpper() == first && second >= 1000 && second < 2000)
                    {
                        _carCode = value;
                    }
                    else
                    {
                        Console.WriteLine("False");
                    }
                }
            }
        }
        public Car() { }
        public Car(int id, string name)
        {
            Id = id;
            Name = name;
        }
        public Car(int id, string name, int speed, string carcCode):this(id,name)
        {
            Speed = speed;
            CarcCode = carcCode;
        }
    }
}
