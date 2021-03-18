using System.Collections.Generic;

namespace E4Progress.BLL.Logic
{
    public interface ILogic<TEntity> where TEntity : class
    {
        bool Create(TEntity entity);
        TEntity FindById(int id);
        bool Delete(int id);
        List<TEntity> GetAll();
        bool Update(TEntity entity);
    }
}
