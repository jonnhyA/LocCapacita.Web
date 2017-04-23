using LocCapacita.Domain.Entities;
using LocCapacita.Domain.Interfaces.Repositories;
using LocCapacita.Domain.Interfaces.Services;
using System.Collections.Generic;


namespace LocCapacita.Domain.Service
{
    public class AgndCapctService : ServiceBase<AgndCapct>, IAgndCapctService
    {
        private readonly IRepositoryAgndCapct _repositoryAgndCapct;

        public AgndCapctService(IRepositoryAgndCapct repositoryAgndCapct)
            : base(repositoryAgndCapct)
        {
            _repositoryAgndCapct = repositoryAgndCapct;
        }
    }
}
