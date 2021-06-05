using System;

namespace LR6
{
    class Program
    {
        static void Main(string[] args)
        {
            Student Pers1 = new Student()
            {
                Name = "Kirill",
                Age = 17,
                Sex = Sexs.male,
                AveragePoint = 9.8,
                SchoolType = SchoolTypes.Gymnasium,
                University = Universities.BSUIR,
                YearOfEntering = 2020,
                AcademicPerformance = AcademicPermonances.average,
                Degree = Degrees.Bachelor,
                Course = 1,
                PhoneNumber = 3046906,
                NativeCity = "Brest",
                Citizenship = Countries.BY
            };
            Pers1.Info();

            Student Pers2 = new Student()
            {
                Name = "Stas",
                Surname = "Kovach",
                Sex = Sexs.male,
                University = Universities.BSU,
                YearOfEntering = 2018,
                AcademicPerformance = AcademicPermonances.awful
            };
            Pers2.Info();

            Student ideal = new Student()
            {
                Name = "Volodya",
                University = Universities.BSU,
                YearOfEntering = 2017,
                Course = 4,
                AcademicPerformance = AcademicPermonances.excellent,
                Degree = Degrees.Bachelor,
                AveragePoint = 10.0,
                SchoolType = SchoolTypes.Gymnasium
            };
            ideal.UpDegree();
            ideal.Info();



            Human hum = new Student();
            hum.Info();

           ICreator master = Pers1;
            master.UpDegree();

            Human boy = new Schoolguy()
            {
                Name = "Anton",
                Surname = "Golovach",
                SchoolType = SchoolTypes.Gymnasium,
                AveragePoint = 8.5
            };
            boy.Info();


        }
    }
}
