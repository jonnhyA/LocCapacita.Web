using LocCapacita.Domain.Entities;
using LocCapacita.Domain.Interfaces.Repositories;
using LocCapacita.Domain.Interfaces.Services;
using System.Collections.Generic;


namespace LocCapacita.Domain.Service
{
    public class AcssoSiteService : ServiceBase<AcssoSite>, IAcssoSiteService
    {
        private readonly IRepositoryAcssoSite _repositoryAcssoSite;

        public AcssoSiteService(IRepositoryAcssoSite repositoryAcssoSite)
            : base(repositoryAcssoSite)
        {
            _repositoryAcssoSite = repositoryAcssoSite;
        }
    }
}
