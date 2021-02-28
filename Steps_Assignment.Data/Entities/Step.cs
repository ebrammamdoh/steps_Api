using Data.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Steps_Assignment.Data.Entities
{
    public class Step
    {
        public int Id { get; set; }
        public int StepNumber { get; set; }
        public ICollection<Item> Items { get; set; }
    }
}
