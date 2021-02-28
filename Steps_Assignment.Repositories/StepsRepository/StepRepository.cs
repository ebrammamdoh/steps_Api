using Data;
using Data.Entities;
using Steps_Assignment.Data.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Repositories.StepsRepository
{
    public class StepRepository : RepositoryBase<Step>, IStepRepository
    {
        public StepRepository(ItemsContext context) : base(context)
        {
        }
    }
}
