using SimpleInjector;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocCapacita.Infra.CrossCutting
{
    public class IoC
    {
        public static void InitializeContainer(Container container)
        {
            //container.Register<ICorAppService, CorAppService>(Lifestyle.Scoped);
            //container.Register<IAplicacaoAppService, AplicacaoAppService>(Lifestyle.Scoped);
            //container.Register<ICodinomeAppService, CodinomeAppService>(Lifestyle.Scoped);
            //container.Register<IDelegacaoAppService, DelegacaoAppService>(Lifestyle.Scoped);
            //container.Register<IGrupoEtwAppService, GrupoEtwAppService>(Lifestyle.Scoped);
            //container.Register<IAssociarCodinomeAppService, AssociarCodinomeAppService>(Lifestyle.Scoped);
            //container.Register<IFuncionarioAppService, FuncionarioAppService>(Lifestyle.Scoped);
            //container.Register<ISiteAppService, SiteAppService>(Lifestyle.Scoped);
            //container.Register<IPerfilAppService, PerfilAppService>(Lifestyle.Scoped);
            //container.Register<INivelAcessoAppService, NivelAcessoAppService>(Lifestyle.Scoped);
            //container.Register<ISecaoAppService, SecaoAppService>(Lifestyle.Scoped);
            //container.Register<ISkillAppService, SkillAppService>(Lifestyle.Scoped);
            //container.Register<IDepartamentoAppService, DepartamentoAppService>(Lifestyle.Scoped);
            //container.Register<IAssociarMuAppService, AssociarMuAppService>(Lifestyle.Scoped);
            //container.Register<IListarPerfilGestorAppService, ListarPerfilGestorAppService>(Lifestyle.Scoped);
            //container.Register<IAssociarPerfilAppService, AssociarPerfilAppService>(Lifestyle.Scoped);
            //container.Register<IRevisaoAppService, RevisaoAppService>(Lifestyle.Scoped);
            //container.Register<ITerceiroAppService, TerceiroAppService>(Lifestyle.Scoped);
            //container.Register<IRelatorioHistoricoFuncionarioPerfilAppService, RelatorioHistoricoFuncionarioPerfilAppService>(Lifestyle.Scoped);
            //container.Register<IRelatorioGeralAppService, RelatorioGeralAppService>(Lifestyle.Scoped);
            //container.Register<IRelatorioRevisaoAppService, RelatorioRevisaoAppService>(Lifestyle.Scoped);
            //container.Register<IRelatorioHistoricoFuncionarioCodinomeAppService, RelatorioHistoricoFuncionarioCodinomeAppService>(Lifestyle.Scoped);
            //container.Register<IRelatorioHistoricoFuncionarioSkillAppService, RelatorioHistoricoFuncionarioSkillAppService>(Lifestyle.Scoped);

            //container.Register<ICorService, CorService>(Lifestyle.Scoped);
            //container.Register<IAplicacaoService, AplicacaoService>(Lifestyle.Scoped);
            //container.Register<ICodinomeService, CodinomeService>(Lifestyle.Scoped);
            //container.Register<IDelegacaoService, DelegacaoService>(Lifestyle.Scoped);
            //container.Register<IGrupoEtwService, GrupoEtwService>(Lifestyle.Scoped);
            //container.Register<IAssociarCodinomeService, AssociarCodinomeService>(Lifestyle.Scoped);
            //container.Register<IFuncionarioService, FuncionarioService>(Lifestyle.Scoped);
            //container.Register<ISiteService, SiteService>(Lifestyle.Scoped);
            //container.Register<IPerfilService, PerfilService>(Lifestyle.Scoped);
            //container.Register<INivelAcessoService, NivelAcessoService>(Lifestyle.Scoped);
            //container.Register<ISecaoService, SecaoService>(Lifestyle.Scoped);
            //container.Register<ISkillService, SkillService>(Lifestyle.Scoped);
            //container.Register<IDepartamentoService, DepartamentoService>(Lifestyle.Scoped);
            //container.Register<IAssociarMuService, AssociarMuService>(Lifestyle.Scoped);
            //container.Register<IAssociarPerfilService, AssociarPerfilService>(Lifestyle.Scoped);
            //container.Register<IRevisaoService, RevisaoService>(Lifestyle.Scoped);
            //container.Register<ITerceiroService, TerceiroService>(Lifestyle.Scoped);
            //container.Register<IEmpresaService, EmpresaService>(Lifestyle.Scoped);
            //container.Register<IRelatorioHistoricoFuncionarioPerfilService, RelatorioHistoricoFuncionarioPerfilService>(Lifestyle.Scoped);
            //container.Register<IRelatorioGeralService, RelatorioGeralService>(Lifestyle.Scoped);
            //container.Register<IRelatorioRevisaoService, RelatorioRevisaoService>(Lifestyle.Scoped);
            //container.Register<IRelatorioHistoricoFuncionarioCodinomeService, RelatorioHistoricoFuncionarioCodinomeService>(Lifestyle.Scoped);
            //container.Register<IRelatorioHistoricoFuncionarioSkillService, RelatorioHistoricoFuncionarioSkillService>(Lifestyle.Scoped);

            //container.Register<IRepositoryCor, RepositoryCor>(Lifestyle.Scoped);
            //container.Register<IRepositoryAplicacao, RepositoryAplicacao>(Lifestyle.Scoped);
            //container.Register<IRepositoryCodinome, RepositoryCodinome>(Lifestyle.Scoped);
            //container.Register<IRepositoryDelegacao, RepositoryDelegacao>(Lifestyle.Scoped);
            //container.Register<IRepositoryGrupoEtw, RepositoryGrupoEtw>(Lifestyle.Scoped);
            //container.Register<IRepositoryAssociarCodinome, RepositoryAssociarCodinome>(Lifestyle.Scoped);
            //container.Register<IRepositoryPerfil, RepositoryPerfil>(Lifestyle.Scoped);
            //container.Register<IRepositoryNivelAcesso, RepositoryNivelAcesso>(Lifestyle.Scoped);
            //container.Register<IRepositoryAssociarMu, RepositoryAssociarMu>(Lifestyle.Scoped);
            //container.Register<IRepositoryCallHandling, RepositoryCallHandling>(Lifestyle.Scoped);
            //container.Register<IRepositoryPerfilAplicacao, RepositoryPerfilAplicacao>(Lifestyle.Scoped);
            //container.Register<IRepositoryPerfilSkill, RepositoryPerfilSkill>(Lifestyle.Scoped);
            //container.Register<IRepositoryViewPerfil, RepositoryViewPerfil>(Lifestyle.Scoped);
            //container.Register<IRepositoryAssociarPerfil, RepositoryAssociarPerfil>(Lifestyle.Scoped);
            //container.Register<IRepositoryViewPerfilAplicacao, RepositoryViewPerfilAplicacao>(Lifestyle.Scoped);
            //container.Register<IRepositoryViewPerfilSkill, RepositoryViewPerfilSkill>(Lifestyle.Scoped);
            //container.Register<IRepositoryViewAssociarPerfil, RepositoryViewAssociarPerfil>(Lifestyle.Scoped);
            //container.Register<IRepositoryRevisao, RepositoryRevisao>(Lifestyle.Scoped);
            //container.Register<IRepositoryNotificacaoRevisao, RepositoryNotificacaoRevisao>(Lifestyle.Scoped);
            //container.Register<IRepositoryTerceiro, RepositoryTerceiro>(Lifestyle.Scoped);
            //container.Register<IRepositoryEmpresa, RepositoryEmpresa>(Lifestyle.Scoped);
            //container.Register<IRepositoryViewDelegacao, RepositoryViewDelegacao>(Lifestyle.Scoped);
            //container.Register<IRepositoryAssociarPerfilMassa, RepositoryAssociarPerfilMassa>(Lifestyle.Scoped);
            //container.Register<IRepositoryViewRelatorioHistoricoFuncionarioPerfil, RepositoryViewRelatorioHistoricoFuncionarioPerfil>(Lifestyle.Scoped);
            //container.Register<IRepositoryViewRelatorioGeral, RepositoryViewRelatorioGeral>(Lifestyle.Scoped);
            //container.Register<IRepositoryViewRelatorioRevisao, RepositoryViewRelatorioRevisao>(Lifestyle.Scoped);
            //container.Register<IRepositoryViewAssociarPerfilMassa, RepositoryViewAssociarPerfilMassa>(Lifestyle.Scoped);
            //container.Register<IRepositoryRevisaoAssociacaoPerfil, RepositoryRevisaoAssociacaoPerfil>(Lifestyle.Scoped);
            //container.Register<IRepositoryLoginFuncionario, RepositoryLoginFuncionario>(Lifestyle.Scoped);
            //container.Register<IRepositoryLoginColaborador, RepositoryLoginColaborador>(Lifestyle.Scoped);
            //container.Register<IRepositoryViewRelatorioHistoricoFuncionarioCodinome, RepositoryViewRelatorioHistoricoFuncionarioCodinome>(Lifestyle.Scoped);
            //container.Register<IRepositoryViewRelatorioHistoricoFuncionarioSkill, RepositoryViewRelatorioHistoricoFuncionarioSkill>(Lifestyle.Scoped);
            //container.Register<IRepositoryViewFuncionarioColaboradorLogin, RepositoryViewFuncionarioColaboradorLogin>(Lifestyle.Scoped);
        }
    }
}
