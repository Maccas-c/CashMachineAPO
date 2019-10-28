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

        }

        public static void MakeTransfer(Guid cardId)
        {

        }
    }
}
