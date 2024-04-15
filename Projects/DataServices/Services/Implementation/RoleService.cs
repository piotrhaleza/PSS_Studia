
using Models.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Data.Services
{
    public class RoleService : SaveReuqimentService<Role,V_Role>, IRoleService
    {
        public RoleService(BaseContext context) : base(context)
        {

        }

        public override List<V_Role> GetAllItems()
        {
            return Context.V_Roles.ToList();
        }

        public override Role GetItem(int id)
        {
            return Context.Roles.FirstOrDefault(x => x.Id == id);
        }

        public override void UpdateItem(Role saveItem)
        {
            
        }
    }
}