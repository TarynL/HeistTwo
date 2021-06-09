using System;

namespace HeistTwo
{
    public class LockSpecialist : IRobber
    {
        public string Name { get; set; }

        public int SkillLevel { get; set; }

        public int PercentageCut { get; set; }

        public void PerformSkill(Bank Bank)
        {
            int BankSecurityScore = Bank.AlarmScore - SkillLevel;

            Console.WriteLine($"{Name} is picking the lock to the vault. Decreased security by {SkillLevel} points.");

            if (BankSecurityScore <= 0)
            {
                Console.WriteLine($"{Name} has cracked the vault!");
            }
        }
    }
}