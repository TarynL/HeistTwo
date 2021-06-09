using System;
using System.Collections.Generic;
using System.Linq;

namespace HeistTwo
{
    class Program
    {
        static void Main(string[] args)
        {
            LockSpecialist Taryn = new LockSpecialist()
            {
                Name = "Taryn",
                SkillLevel = 50,
                PercentageCut = 30

            };

            Hacker Laurel = new Hacker()
            {
                Name = "Laurel",
                SkillLevel = 50,
                PercentageCut = 30

            };

            Hacker Preston = new Hacker()
            {
                Name = "Preston",
                SkillLevel = 5,
                PercentageCut = 10

            };

            Muscle Gus = new Muscle()
            {
                Name = "Gus",
                SkillLevel = 30,
                PercentageCut = 15

            };

            Muscle Loretta = new Muscle()
            {
                Name = "Loretta",
                SkillLevel = 30,
                PercentageCut = 15

            };

            List<IRobber> rolodex = new List<IRobber>()
            {
                Taryn, Laurel, Preston, Gus, Loretta
            };

            CrewSelection();

            void CrewSelection()
            {
                Console.WriteLine("---------------");
                Console.WriteLine($"There are {rolodex.Count()} members in the crew.");
                Console.WriteLine("---------------");

                Console.Write("Please enter a new crew members name? ");
                string name = Console.ReadLine();
                Console.WriteLine("---------------");

                if (name == "")
                {
                    Console.WriteLine("Thats fine. Keep moving");
                }
                else
                {
                    Console.WriteLine("Please choose a specialty: \n1.Hacker \n2.Muscle \n3.Lock Specialist");
                    int speciality = Int32.Parse(Console.ReadLine());
                    Console.WriteLine("---------------");

                    Console.Write("What is their skill level? (1-100) ");
                    int skillLevel = Int32.Parse(Console.ReadLine());
                    Console.WriteLine("---------------");

                    Console.Write("What is their cut? (1-100) ");
                    int cut = Int32.Parse(Console.ReadLine());
                    Console.WriteLine("---------------");

                    if (speciality == 1)
                    {
                        Hacker hacker = new Hacker()
                        {
                            Name = name,
                            SkillLevel = skillLevel,
                            PercentageCut = cut
                        };
                        rolodex.Add(hacker);
                    }
                    else if (speciality == 2)
                    {
                        Muscle muscle = new Muscle()
                        {
                            Name = name,
                            SkillLevel = skillLevel,
                            PercentageCut = cut
                        };
                        rolodex.Add(muscle);
                    }
                    else if (speciality == 3)
                    {
                        LockSpecialist lockSpecialist = new LockSpecialist()
                        {
                            Name = name,
                            SkillLevel = skillLevel,
                            PercentageCut = cut
                        };
                        rolodex.Add(lockSpecialist);
                    }
                    else
                    {
                        Console.WriteLine("The crew member is not accepted.");
                        return;
                    }
                    CrewSelection();
                }

            }


        }
    }
}
