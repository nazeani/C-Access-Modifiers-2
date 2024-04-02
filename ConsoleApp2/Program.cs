using Core;
namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
           Car car1 = new Car();
            car1.Id = 1;
            car1.Name = "Test1";
            car1.Speed = 10;
            car1.CarcCode = "LA1001";
           Car car2 = new Car();
            car2.Id = 2;
            car2.Name = "Test2";
            car2.Speed = 11;
            car2.CarcCode = "LA1002";

           Gallery gallery = new Gallery();
            gallery.AddCar(car1);
            gallery.AddCar(car2);
            string answer;
            do
            {
                Console.WriteLine("choose:1/2/3/4/0 \n 1-ShowAllCars() - Arraydeki butun Carlari gosterir,\r\n2-FindCarById() - verilmis id-e uygun olan car'i tapib qaytarir,\r\n3-FindCarByCarCode() - CarCode uygun olan car'i tapib qaytarir,\r\n4-FindCarsBySpeedInterval() - max ve min speed qebul edib bu suret araligindaki car'lari geri qaytarir.");
                answer = Console.ReadLine();
                if(answer=="1")
                {
                    gallery.ShowAllCars();
                }
                
                else if(answer=="2")
                {
                    Console.WriteLine("Enter Id:");
                    int Id=Convert.ToInt32(Console.ReadLine());
                    gallery.FindCarById(Id);
                }
                else if( answer=="3")
                {
                    Console.WriteLine("Enter Car Code:");
                    string CarCode=Console.ReadLine();
                    gallery.FindCarByCarCode(CarCode);
                }
                else if (answer=="4")
                {
                    Console.WriteLine("Enter Min Salary:");
                    int MinSalary=Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Enter Max Salary:");
                    int MaxSalary = Convert.ToInt32(Console.ReadLine());
                    gallery.FindCarsBySpeedInterval(MinSalary, MaxSalary);
                }
            } 
            while (answer!="0");


        }
    }
}
