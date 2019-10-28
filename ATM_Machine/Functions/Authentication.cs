using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ATM_Machine.Functions
{
    public class Authentication
    {
        public static void CheckPIN(string PIN, int number)
        {
            ATMDbContext db = new ATMDbContext();
            if (db.Card.Where(c => c.Number == number).FirstOrDefault() != null)
            {
                if(db.Card.Where( c => c.Pin == PIN).FirstOrDefault() != null)
                {
                    var id = db.Card.Where(c => c.Number == number).Select(c => c.Id);
                    foreach(var i in id)
                    {
                        ShowPanel.ShowPossibilities(i);
                    }
                    
                }
            }
            else
            {
                Console.WriteLine("Wrong PIN");
                ShowPanel.ShowStart();
            }
               
        }
    }
}
