using BulkyWeb.Data;
using SD7501Bulky.DataAccess.Repository;
using SD7501Bulky.DataAccess.Repository.IRepository;
using SD7501Bulky.Models;

namespace SD7501Bulky.DataAccess.Repository.IRepository
{
    public interface ICompanyRepository:IRepository<Company>
    {
        void Update(Company obj);
        void Save();
    }
}