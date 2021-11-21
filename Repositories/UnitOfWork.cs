using System;
using LifeworthAPI.Models;
using LifeworthAPI.Interfaces;
using Microsoft.Extensions.Logging;
using LifeworthAPI.Interfaces;
using LifeworthAPI.Repositories;
using System.Threading.Tasks;

namespace LifeworthAPI.Repositories
{
    public class UnitOfWork : IUnitOfWork
    {
        private  ILogger<UnitOfWork> logger;
        private  DB9198_lifeworthContext dbContext;
        
        public UnitOfWork(ILogger<UnitOfWork> logger, DB9198_lifeworthContext dbContext,
            ILogger<DependantRepository> dependantLogger,
            ILogger<ProviderRepository> providerLogger, ILogger<EmployeeRepository> employeeLoger, ILogger<FeedBackRepository> feedbackLogger, ILogger<ProductRepository> ProductLogger)
        {
            this.logger = logger;
            this.dbContext = dbContext;
            Providers = new ProviderRepository(dbContext, providerLogger);
            Employees = new EmployeeRepository(dbContext, employeeLoger);
            Dependants = new DependantRepository(dbContext, dependantLogger);
            FeedBack = new FeedBackRepository(dbContext, feedbackLogger );
            Product = new ProductRepository(dbContext, ProductLogger);
        }

        public IProviderRepository Providers { get; private set; }
        public IEmployeeRepository Employees { get; private set; }
        public IDependantRepository Dependants { get; private set; }
        public IFeedBackRepository FeedBack { get; private set; }
        public IProductRepository Product { get; private set; }
        public async Task CompleteAsync()
        {
            await dbContext.SaveChangesAsync();
        }
        public void Complete()
        {
            try
            {
                dbContext.SaveChanges();
            }catch(Exception e)
            {
                throw;
            }
        }
    }
}
