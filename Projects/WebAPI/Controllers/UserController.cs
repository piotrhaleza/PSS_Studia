using Autofac;
using Data;
using Data.Services;
using Microsoft.AspNetCore.Mvc;
using Models.Models;

namespace WebAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UserController : ControllerBase
    {

        private readonly ILogger<UserController> _logger;

        public UserController(ILogger<UserController> logger)
        {
            _logger = logger;
        }

        [Microsoft.AspNetCore.Mvc.HttpPost("AddUser")]
        public async Task<JsonResult> Get([FromForm] string login, [FromForm] string password)
        {
           
            try
            {
                using (var scope = Startups.Container.BeginLifetimeScope())
                {
                    var servicesFactory = scope.Resolve<IUserService>();
                    var canSave = servicesFactory.CanSaveItem(login);
                    if(!canSave)
                        return new JsonResult( new UserWebResult() { Succes = false,Message ="Istnieje ju¿ taki login" } );
                    var newUser = new User() {Name = login,Password=password,RoleId=1 };
                    await servicesFactory.Save(newUser);
                    
                }
            }
            catch(Exception e)
            {

            }

            return new JsonResult(new UserWebResult() { Succes = true} );

        }
    }
}