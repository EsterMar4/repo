namespace WebApplication1_Consist.DAL
{
    public class UserWrapper : IDisposable
    {
        public static UserContext Context { get; set; }

        static UserWrapper()
        {
            Context = new UserContext();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }
    }
}
