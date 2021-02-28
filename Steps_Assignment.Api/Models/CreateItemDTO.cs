using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Steps_Assignment.Models
{
    public class CreateItemDTO
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public int StepId { get; set; }
    }
}
