using LocCapacita.Domain.Entities;
using LocCapacita.Domain.Interfaces.Repositories;
using LocCapacita.Domain.Interfaces.Services;
using System.Collections.Generic;


namespace LocCapacita.Domain.Service
{
    public class EmpresaService : ServiceBase<Empresa>, IEmpresaService
    {
        private readonly IRepositoryEmpresa _repositoryEmpresa;

        public EmpresaService(IRepositoryEmpresa repositoryEmpresa)
            : base(repositoryEmpresa)
        {
            _repositoryEmpresa = repositoryEmpresa;
        }
    }
}
