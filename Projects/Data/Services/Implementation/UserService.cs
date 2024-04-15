
using Models.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Data.Services
{
    public class UserService : SaveReuqimentService<User,V_User>, IUserService
    {
        public UserService(BaseContext context) : base(context)
        {

        }

        public override List<V_User> GetAllItems()
        {
            return Context.V_Users.ToList();
        }

        public override User GetItem(int id)
        {
            return Context.Users.FirstOrDefault(x => x.Id == id);
        }

        public bool CanSaveItem(string login)
        {
            return !Context.Users.Any(x => x.Name.Equals(login));
        }

        public override void UpdateItem(User saveItem)
        {
            
        }
    }
}