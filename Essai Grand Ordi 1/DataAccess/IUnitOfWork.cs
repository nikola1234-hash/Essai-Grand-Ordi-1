using Essai_Grand_Ordi_1.DataAccess.Entities;

namespace Essai_Grand_Ordi_1.DataAccess
{
    public interface IUnitOfWork
    {
        IGenericRepository<City> City { get; set; }
        IGenericRepository<Client> Client { get; set; }
        IGenericRepository<Menu> Menu { get; set; }
        IGenericRepository<OrderDetails> OrderDetils { get; set; }
        IGenericRepository<OrderMethod> OrderMethod { get; set; }
        IGenericRepository<Orders> Orders { get; set; }
        IGenericRepository<Payments> Payments { get; set; }
    }
}