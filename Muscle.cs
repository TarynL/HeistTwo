using System;

namespace HeistTwo
{
    public class Muscle : IRobber
    {
        public string Name { get; set; }

        public int SkillLevel { get; set; }

        public int PercentageCut { get; set; }

        public void PerformSkill(Bank Bank)
        {
            int BankSecurityScore = Bank.AlarmScore - SkillLevel;

            Console.WriteLine($"{Name} is using their muscle to break into the building. Decreased security by {SkillLevel} points.");

            if (BankSecurityScore <= 0)
            {
                Console.WriteLine($"{Name} has disabled the alarm system!");
            }
        }
    }
}