using Repositories.ItemsRepository;
using Repositories.StepsRepository;

namespace Repositories.UnitOfWork
{
    public interface IUnitOfWork
    {
        IStepRepository Steps { get; }
        IItemRepository Items { get; }
        void SaveChanges();
    }
}
