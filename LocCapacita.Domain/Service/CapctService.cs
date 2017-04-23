using LocCapacita.Domain.Entities;
using LocCapacita.Domain.Interfaces.Repositories;
using LocCapacita.Domain.Interfaces.Services;
using System.Collections.Generic;


namespace LocCapacita.Domain.Service
{
    public class CapctService : ServiceBase<Capct>, ICapctService
    {
        private readonly IRepositoryCapct _repositoryCapct;

        public CapctService(IRepositoryCapct repositoryCapct)
            : base(repositoryCapct)
        {
            _repositoryCapct = repositoryCapct;
        }
    }
}
