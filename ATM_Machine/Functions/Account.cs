using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ATM_Machine.Functions
{
    public static class Account
    {
        public static ATMDbContext db = new ATMDbContext();
        public static void ShowStatus(Guid cardId)
        {
            List<int> money = db.Card.Where(c => c.Id == cardId).Select(c => c.Money).ToList();
            money.ForEach(m => Console.WriteLine(m + "zl"));
        }

        public static void WithdrawMoney(Guid cardId)
        {
            Console.WriteLine("Enter value which you want to withdraw: ");
            int value = Convert.ToInt32(Console.ReadLine());
            var card = db.Card.First(c => c.Id == cardId);
            if (card.Money >= value)
            {
                card.Money =  card.Money - value;
                db.SaveChanges();
            }
            else
            {
                Console.WriteLine("You don't have enough money. Please enter another value");
                WithdrawMoney(cardId);
            }

        }

        public static void GenerateCode(Guid cardId)
        {
            Console.WriteLine("Choose value: ");
            Console.WriteLine("1. 10");
            Console.WriteLine("2. 50");
            Console.WriteLine("3. 100");
            int number = Convert.ToInt32(Console.ReadLine());
            int value = 0;
            if (number == 1)
            {
                value = 10;
            }
            else if (number == 2)
            {
                value = 50;
            }
            else if (number == 3)
            {
                value = 100;
            }
            else
            {
                Console.WriteLine("Incorrect value");
                GenerateCode(cardId);
            }
            var card = db.Card.First(c => c.Id == cardId);
            if (card.Money >= value)
            {
                Random random = new Random();
                card.Money = card.Money - value;
                List<int> nums = Enumerable.Range(0, 10).ToList();
                Console.WriteLine("Your code: ");
                for (int i = 0; i < 10; i++)
                {
                    Console.Write(random.Next(10));
                }
                Console.WriteLine();
                db.SaveChanges();
            }
            else
            {
                Console.WriteLine("You don't have enough money");
            }
        }       
    }
}

