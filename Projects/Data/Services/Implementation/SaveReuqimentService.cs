using Models;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Data.Services
{
    public abstract class SaveReuqimentService<T,V_T> : ISaveService<T,V_T>
        where T : BaseModel<int>
    {
        public SaveReuqimentService(BaseContext baseContext)
        {
            Context = baseContext;
        }

        public BaseContext Context { get; set; }

        public virtual bool CanSave(T saveItem)
        {
            bool result = true;

            var properties = saveItem.GetType().GetProperties();

         

            return result;
        }

        public abstract List<V_T> GetAllItems();
        public abstract T GetItem(int id);
       
        public virtual async Task<bool> Save(T saveItem)
        {
            var canSave = CanSave(saveItem);
            if (canSave)
            {
                if (saveItem.Id == 0)
                    await Context.AddAsync(saveItem);
                else
                    UpdateItem(saveItem);

                await Context.SaveChangesAsync();
            }

            return canSave;
        }
        public abstract void UpdateItem(T saveItem);

    }
}
