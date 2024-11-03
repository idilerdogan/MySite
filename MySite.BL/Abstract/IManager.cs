using MySite.DataAccess.GenericRepos.Abstract;
using MySite.Entities.Entities.Abstract;

namespace MySite.BL.Abstract
{
    public interface IManager<T> : IRepository<T> where T : BaseEntity
    {
    }
}
