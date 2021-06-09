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
                    if (speciality != 1 && speciality != 2 && speciality != 3)
                    {
                        Console.WriteLine("Speciality was not needed. Crew member denied.");

                    }
                    else if (speciality == 1)
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

                    CrewSelection();
                }

            }

            Random r = new Random();
            Bank bank = new Bank()
            {
                AlarmScore = r.Next(0, 100),
                VaultScore = r.Next(0, 100),
                SecurityGuardScore = r.Next(0, 100),
                CashOnHand = r.Next(50000, 1000000)
            };

            Console.WriteLine("");
            Console.WriteLine("REACON REPORT");
            Console.WriteLine("");

            if (bank.AlarmScore > bank.VaultScore && bank.VaultScore > bank.SecurityGuardScore)
            {
                Console.WriteLine("\nMost Secure: Alarm \nLeast Secure: Guard");
            }
            else if (bank.AlarmScore > bank.SecurityGuardScore && bank.SecurityGuardScore > bank.VaultScore)
            {
                Console.WriteLine("\nMost Secure: Alarm \nLeast Secure: Vault");
            }
            else if (bank.VaultScore > bank.AlarmScore && bank.AlarmScore > bank.SecurityGuardScore)
            {
                Console.WriteLine("\nMost Secure: Vault \nLeast Secure: Guard");
            }
            else if (bank.VaultScore > bank.SecurityGuardScore && bank.SecurityGuardScore > bank.AlarmScore)
            {
                Console.WriteLine("\nMost Secure: Vault \nLeast Secure: Alarm");
            }
            else if (bank.SecurityGuardScore > bank.VaultScore && bank.VaultScore > bank.AlarmScore)
            {
                Console.WriteLine("\nMost Secure: Guard  \nLeast Secure: Alarm");

            }
            else
            {
                Console.WriteLine("\nMost Secure: Guard  \nLeast Secure: Vault");
            }

            Console.WriteLine("");
            Console.WriteLine("CREW MEMBERS REPORT");
            Console.WriteLine("");
            List<IRobber> crew = new List<IRobber>();

            foreach (IRobber criminal in crew)
            {
                Console.WriteLine($@"
            Name: {criminal.Name}
            Speciality: {criminal.Speciality}
            Skill Level: {criminal.SkillLevel}
            Cut: {criminal.PercentageCut}
             ");
            }



        }
    }
}
