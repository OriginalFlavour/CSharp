using System;

namespace LR5
{
    class Program
    {
        static void Main(string[] args)
        {

            StudentOfSpeciality Pers1 = new StudentOfSpeciality()
            {
                Name = "Kirill",
                University = Student.Universities.BSUIR,
                AcademicPerformance = StudentOfSpeciality.AcademicPermonances.average,
                Age = 17,
                Sex = Human.Sexs.male
            };
            Console.WriteLine(Pers1.AcademicPerformance);
            Console.WriteLine(Pers1.Age);

            Pers1.Info();
            Console.WriteLine("Is he a Leader? (yes/no)");
            Pers1.IsLeader(Pers1.Answer = Console.ReadLine());
            Pers1.Info();

            Console.WriteLine("--------------------------------------------");

            StudentOfSpeciality Pers2 = new StudentOfSpeciality()
            {
                Name = "Stas",
                Surname = "Kovach",
                University = Student.Universities.BSU,
                AcademicPerformance = StudentOfSpeciality.AcademicPermonances.awful,
                Sex = Human.Sexs.male
            };
            Pers2.Info();

            Console.WriteLine("--------------------------------------------");

            Human hum = new Student();
            hum.Info();
            
        }
    }
}