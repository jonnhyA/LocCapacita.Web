using LocCapacita.Domain.Entities;
using LocCapacita.Domain.Interfaces.Repositories;
using LocCapacita.Domain.Interfaces.Services;
using System.Collections.Generic;


namespace LocCapacita.Domain.Service
{
    public class DetlheCapctService : ServiceBase<DetlheCapct>, IDetlheCapctService
    {
        private readonly IRepositoryDetlheCapct _repositoryDetlheCapct;

        public DetlheCapctService(IRepositoryDetlheCapct repositoryDetlheCapct)
            : base(repositoryDetlheCapct)
        {
            _repositoryDetlheCapct = repositoryDetlheCapct;
        }
    }
}
