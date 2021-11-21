using LifeworthAPI.Interfaces;
using System;
using System.Threading.Tasks;

namespace LifeworthAPI.Interfaces
{
    public interface IUnitOfWork
    {
        void Complete();
        public IProviderRepository Providers { get;}
        public IEmployeeRepository Employees { get;}
        public IDependantRepository Dependants { get;}
        public IFeedBackRepository FeedBack { get; }
        
        public IProductRepository Product { get; }


        //Task Complete();
        Task CompleteAsync();
    }
}
