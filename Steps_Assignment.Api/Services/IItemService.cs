using Steps_Assignment.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Steps_Assignment.Services
{
    public interface IItemService
    {
        IEnumerable<ItemDTO> GetAll(int stepNumber);
        ItemDTO Create(CreateItemDTO model);
        void Update(UpdateItemDTO model);
        void Delete(int id);
    }
}
