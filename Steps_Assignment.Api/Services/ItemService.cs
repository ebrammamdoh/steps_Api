using AutoMapper;
using Data.Entities;
using Repositories.UnitOfWork;
using Steps_Assignment.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Steps_Assignment.Services
{
    public class ItemService : IItemService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;
        public ItemService(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }
        public ItemDTO Create(CreateItemDTO model)
        {
            var item = _unitOfWork.Items.Create(new Item
            {
               Description = model.Description,
               Title = model.Title,
               StepId = model.StepId
            });
            _unitOfWork.SaveChanges();
            return _mapper.Map<ItemDTO>(item);
        }

        public void Delete(int id)
        {
            var item = _unitOfWork.Items.GetWhere(i => i.Id == id).FirstOrDefault();
            _unitOfWork.Items.Delete(item);
            _unitOfWork.SaveChanges();
        }

        public IEnumerable<ItemDTO> GetAll(int stepId)
        {
            var result = _unitOfWork.Items.GetWhere(i => i.StepId == stepId).ToList();
            return _mapper.Map<IEnumerable<ItemDTO>>(result);
        }

        public void Update(UpdateItemDTO model)
        {
            var item = _unitOfWork.Items.GetWhere(i => i.Id == model.Id).FirstOrDefault();
            item.Description = model.Description;
            item.Title = model.Title;
            _unitOfWork.SaveChanges();
        }
    }
}
