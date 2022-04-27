using ISS.Models;
using ISS.Repositories.Interfaces;

namespace ISS.Repositories
{
    public class EnterpriseRepository : ICrudRepository<Enterprise>
    {
        private List<Enterprise> _enterprises = new List<Enterprise>();
        public Task Detele(Guid id)
        {
            var enterpriseLocalized = _enterprises.Find(e => e.Id == id);
           _enterprises.Remove(enterpriseLocalized);

           return Task.FromResult(enterpriseLocalized);

        }

        public Task<Enterprise> Insert(Enterprise entity)
        {
            _enterprises.Add(entity);

            return Task.FromResult(entity);
        }

        public Task<List<Enterprise>> SelectAll()
        {
            return Task.FromResult(_enterprises);
        }

        public Task<Enterprise> SelectById(Guid id)
        {
            var enterpriseLocalized = _enterprises.Find(e => e.Id == id);

            return Task.FromResult(enterpriseLocalized);
        }

        public Task<Enterprise> Update(Enterprise entity)
        {
            var enterpriseLocalized = _enterprises.Find(e => e.Id == entity.Id);

            _enterprises.Remove(enterpriseLocalized);

            _enterprises.Add(entity);

            return Task.FromResult(entity);
        }
    }
}