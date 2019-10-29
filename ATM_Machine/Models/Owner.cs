using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace CashMachine.Models.DataBase
{
    public class Owner
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public string AccountNumber { get; set; }
        public bool IsAbleToTransfer { get; set; } 
        public ICollection<Card> Cards { get; set; } 
    }
}