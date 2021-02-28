using Data;
using Repositories.ItemsRepository;
using Repositories.StepsRepository;

namespace Repositories.UnitOfWork
{
    public class UnitOfWork : IUnitOfWork
    {
        private ItemsContext _context;
        public IStepRepository Steps { get; }
        public IItemRepository Items { get; }
        public UnitOfWork(ItemsContext context)
        {
            _context = context;
            Steps = new StepRepository(_context);
            Items = new ItemRepository(_context);
        }
        public void SaveChanges()
        {
            _context.SaveChanges();
        }
    }
}
