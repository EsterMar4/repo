using WebApplication1_Consist.DAL;

namespace WebApplication1_Consist.BL
{
    public class UserBL
    {
        public User GetUserByID(int id)=>
           UserWrapper.Context.Users.Single(user=>user.UserId == id);
        
        public bool DeleteUserById (int id)
        {
            var user = UserWrapper.Context.Users.First(user => user.UserId == id);
            if(user != null)
            {
                UserWrapper.Context.Remove(user);
                UserWrapper.Context.SaveChanges();
                return true;
            }
            return false;
        }

        public void AddUser(string  name, string password)
        {
            UserWrapper.Context.Users.Add(new User(name, password));
        }

        public bool Validate (string username, string password)
        {
            var user = UserWrapper.Context.Users.First(user => user.UserName.Equals(username) && user.UserPassword.Equals(password));
            if (user != null)
            {
                return true;
            }
            return false;   
        }
    }
}
