using AutoMapper;
using Repositories.UnitOfWork;
using Steps_Assignment.Api.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Steps_Assignment.Api.Services
{
    public class StepService : IStepService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;
        public StepService(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }
        public IEnumerable<StepDTO> GetAll()
        {
            var steps = _unitOfWork.Steps.GetAll().ToList();
            return _mapper.Map<IEnumerable<StepDTO>>(steps);
        }
        public void Delete(int stepId)
        {
            var items = _unitOfWork.Items.GetWhere(i => i.StepId == stepId).ToList();
            var step = _unitOfWork.Steps.GetWhere(i => i.Id == stepId).FirstOrDefault();
            _unitOfWork.Items.DeleteRange(items);
            _unitOfWork.Steps.Delete(step);
            _unitOfWork.SaveChanges();
        }

        public StepDTO Create()
        {
            var maxStep = _unitOfWork.Steps.GetAll().Max(s => s.StepNumber);
            var step = _unitOfWork.Steps.Create(new Data.Entities.Step
            {
                StepNumber = maxStep+1
            });
            _unitOfWork.SaveChanges();
            return _mapper.Map<StepDTO>(step);
        }
    }
}
