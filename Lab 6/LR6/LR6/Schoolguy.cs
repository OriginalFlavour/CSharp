using System;

namespace LR6
{
    enum SchoolTypes
    {
        undefined_school,
        High_School,
        Gymnasium,
        Lyceum
    }

    class Schoolguy : Human
    {
        public SchoolTypes SchoolType { get; set; }
        public double AveragePoint
        {
            get
            {
                return averPoint;
            }
            set
            {
                if (value < 0.0 && value > 10.0)
                {
                    throw new Exception("Average point within 0-10 ");
                }
                averPoint = value;
            }
        }
        public override void Info()
        {
            base.Info();
            Console.WriteLine("--------------------------------------------");
            Console.WriteLine(" School information:");
            Console.WriteLine($"{Name} graduated from {SchoolType}");

            if (AveragePoint == 0)
            {
                Console.WriteLine("Average point: unknown.");
            }
            else
            {
                Console.WriteLine($"Average point: {AveragePoint}");
            }

            if (HasGoldMedal())
            {
                Console.WriteLine("Also has a Gold medal.");
            }
            Console.WriteLine("--------------------------------------------");
        }
        private double averPoint;
        private bool HasGoldMedal()
        {
            return (AveragePoint >= 9.0);
        }
    }
}