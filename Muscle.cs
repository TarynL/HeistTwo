using System;

namespace HeistTwo
{
    public class Muscle : IRobber
    {
        public string Name { get; set; }

        public int SkillLevel { get; set; }

        public int PercentageCut { get; set; }
        public string Speciality { get; set; }

        public void PerformSkill(Bank Bank)
        {
            int BankSecurityScore = Bank.AlarmScore - SkillLevel;

            Console.WriteLine($"{Name} is using their big, strong muscles to take on the guards. Decreased security by {SkillLevel} points.");

            if (BankSecurityScore <= 0)
            {
                Console.WriteLine($"{Name} has disarmed the guards!");
            }
        }
    }
}