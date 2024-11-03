using MySite.BL.Abstract;
using MySite.DataAccess.GenericRepos.Concrete;
using MySite.Entities.Entities.Abstract;

namespace MySite.BL.Concrete
{
    public class Manager<T> : Repository<T>, IManager<T> where T : BaseEntity
    {
    }
}
