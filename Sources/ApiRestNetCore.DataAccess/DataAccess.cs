namespace Credipaz.CPClub.Dal
{
    public class DataAccess
    {
        private readonly EFDBContext context;

        public DataAccess(EFDBContext context)
        {
            this.context = context;
        }

        public string GetHelloWorld(string param)
        {
            // Call to BDContext
            return "Hello " + param;
        }
    }
}
