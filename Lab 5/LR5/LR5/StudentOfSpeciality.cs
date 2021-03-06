using System;
using System.Collections.Generic;
using System.Text;

namespace LR5
{
    sealed class StudentOfSpeciality : Student
    {
        public enum AcademicPermonances
        {
            undefined,
            awful,
            bad,
            average,
            good,
            excellent
        }
        public string Speciality { get; set; }
        public int Group { get; set; }
        public AcademicPermonances AcademicPerformance { get; set; }

        public bool WillBeDeducted()
        {
            return AcademicPerformance == AcademicPermonances.awful;
        }

        public bool IsLeader(string answer)
        {
            return (answer == "yes");
        }
        public override void Info()
        {
            base.Info();
            if (AcademicPerformance == AcademicPermonances.undefined)
            {
                Console.WriteLine("A student without marks");
            }
            if (IsLeader(Answer))
            {
                Console.WriteLine("Also he(she) is a Leader of the group!");
            }
            if (WillBeDeducted())
            {
                Console.Write("Unfortunately ");
                Console.Write(value: Name);
                Console.WriteLine(" will be deducted because of awful academic perfomance.");
            }
        }
        public string Answer { get; set; }
    }
}