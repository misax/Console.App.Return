using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class.Library.Return
{

        public abstract class Account
        {
        }

        public class Student : Account { }

        public class Individual : Account
        {
            public double PersentageDiscount { get; set; }
        }

        public class Businness : Account
        {
            public int Employees { get; set; }
        }

    public class Test
    {
        public static double ApplyDiscount(Account ac, double discount)
        {
            if (ac is null)
            {
                throw new ArgumentNullException(nameof(ac));
            }
            if (ac is Student)
            {
                return 0;
            }
            if (ac is Individual individual)
            {
                return discount * (1 - individual.PersentageDiscount / 100);
            }
            if (ac is Businness bussiAccount)
            {
                if (bussiAccount.Employees <= 50)
                {
                    return discount * 0.9;
                }
            }
            throw new InvalidOperationException();
        }
    }
} 


