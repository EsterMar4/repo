using Microsoft.AspNetCore.Mvc;
using WebApplication1_Consist.BL;
using WebApplication1_Consist.DAL;

namespace WebApplication1_Consist.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UserController: ControllerBase
    {
        UserBL userBL;
        public UserController()
        {
            userBL= new UserBL();
        }

        //Delete user by userId.
        [HttpDelete]
        public bool Delete(int id) =>
            userBL.DeleteUserById(id);

        //Create user.
        [HttpPost]
        public void post(string name, string password) =>
            userBL.AddUser(name, password);

        //Validate user by name & password.
        [HttpGet]
        public bool validate(string name, string password) =>
            userBL.Validate(name, password);

        //Get user by Id
        [HttpGet]
        [Route("GetUserByID/{id}")]
        public User GetUserByID(int id) =>
            userBL.GetUserByID(id);
    }
}
