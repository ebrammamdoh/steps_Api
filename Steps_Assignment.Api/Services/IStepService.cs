using Steps_Assignment.Api.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Steps_Assignment.Api.Services
{
    public interface IStepService
    {
        IEnumerable<StepDTO> GetAll();
        StepDTO Create();
        void Delete(int stepNumber);
    }
}
