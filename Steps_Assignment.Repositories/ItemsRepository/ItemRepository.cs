using Data;
using Data.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Repositories.ItemsRepository
{
    public class ItemRepository : RepositoryBase<Item>, IItemRepository
    {
        public ItemRepository(ItemsContext context) : base(context)
        {
        }
    }
}
