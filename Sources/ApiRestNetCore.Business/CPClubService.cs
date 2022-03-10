using Credipaz.CPClub.Business.Data;
using Credipaz.CPClub.Dal;
using Credipaz.CPClub.Shared.Interfaces;

namespace Credipaz.CPClub.Business
{
    public class CPClubService : ICPClubService
    {

        private readonly DataContext dataContext;

        public CPClubService(EFDBContext ctx)
        {
            this.dataContext = new DataContext(ctx);
        }

        public string GetHelloWorld(string param)
        {
            return this.dataContext.GetHelloWorld(param);
        }
    }
}
